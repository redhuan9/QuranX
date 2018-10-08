﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using QuranX.Persistence.Models;
using QuranX.Persistence.Services.Repositories;
using QuranX.Web.Views.HadithIndex;

namespace QuranX.Web.Controllers
{
	public class HadithIndexController : Controller
	{
		private readonly IHadithRepository HadithRepository;
		private readonly IHadithCollectionRepository HadithCollectionRepository;

		public HadithIndexController(
			IHadithRepository hadithRepository,
			IHadithCollectionRepository hadithCollectionRepository)
		{
			HadithRepository = hadithRepository;
			HadithCollectionRepository = hadithCollectionRepository;
		}

		// GET: HadithReferences
		public ActionResult Index(string collectionCode, string referenceCode,
			string referenceValue1, string referenceValue2, string referenceValue3)
		{
			HadithCollection collection = HadithCollectionRepository.Get(collectionCode);
			if (collection == null)
				return HttpNotFound();

			HadithReferenceDefinition referenceDefinition = collection.GetReferenceDefinition(referenceCode);
			if (referenceDefinition == null)
				return HttpNotFound();

			var referencePartNamesAndValues = new List<(string referencePartName, int value, string suffix)>();
			if (!string.IsNullOrWhiteSpace(referenceValue1))
				referencePartNamesAndValues.Add(HadithReference.SplitNameAndValue(referenceValue1));
			if (!string.IsNullOrWhiteSpace(referenceValue2))
				referencePartNamesAndValues.Add(HadithReference.SplitNameAndValue(referenceValue2));
			if (!string.IsNullOrWhiteSpace(referenceValue3))
				referencePartNamesAndValues.Add(HadithReference.SplitNameAndValue(referenceValue3));

			IEnumerable<string> referencePartNames = referencePartNamesAndValues
				.Select(x => x.referencePartName);
			if (!referenceDefinition.PatternMatch(referencePartNames))
				return HttpNotFound();

			IEnumerable<(int value, string suffix)> referenceValues =
				referencePartNamesAndValues.Select(x => (x.value, x.suffix));
			IEnumerable<HadithReference> hadithReferences =
				HadithRepository.GetReferences(
					collectionCode: collectionCode,
					referenceCode: referenceCode,
					values: referenceValues);

			IEnumerable<string> urlReferenceParts = referencePartNamesAndValues
				.Select(x => x.value + x.suffix)
				.Select((value, i) => referenceDefinition.PartNames[i] + "-" + value);
			string partsAsUrl = string.Join("/", urlReferenceParts);
			var headerViewModel = new HadithIndexHeaderViewModel(
				selectedReferenceCode: referenceCode,
				urlSoFar: $"/hadith/{collectionCode}/{referenceCode}/{partsAsUrl}",
				collection: collection, 
				referencePartNamesAndValues: urlReferenceParts);
			if (referencePartNames.Count() == referenceDefinition.PartNames.Count)
			{
				IEnumerable<int> hadithIds = hadithReferences.Select(x => x.HadithId);
				IEnumerable<Hadith> hadiths = HadithRepository.GetHadiths(hadithIds);
				var viewModel = new HadithsViewModel(headerViewModel, hadiths);
				return View("Hadiths", viewModel);
			}
			else
			{
				string nextReferencePartName = referenceDefinition.PartNames[referencePartNames.Count()];
				Func<HadithReference, string> getNextValue;
				switch (referencePartNames.Count())
				{
					case 0:
						getNextValue = x => x.ReferenceValue1 + x.ReferenceValue1Suffix;
						break;
					case 1:
						getNextValue = x => x.ReferenceValue2 + x.ReferenceValue2Suffix;
						break;
					case 2:
						getNextValue = x => x.ReferenceValue3 + x.ReferenceValue3Suffix;
						break;
					default:
						throw new NotImplementedException();
				}
				// If the next level is the final level (the hadith itself) then remove the suffix
				// from the final part so that all hadiths with the same reference but different
				// suffixes are shown on screen at once.
				hadithReferences = hadithReferences
					.Select(x => x.ExcludingFinalSuffix())
					.Distinct();
				// Get the next available values
				IEnumerable<string> nextReferencePartValues =
					hadithReferences.Select(getNextValue)
					.Distinct();
				var viewModel = new BrowseHadithIndexViewModel(
					hadithIndexHeaderViewModel: headerViewModel,
					nextReferencePartName: nextReferencePartName,
					nextReferencePartValueSelection: nextReferencePartValues);
				return View("BrowseHadithIndex", viewModel);
			}
		}

	}
}