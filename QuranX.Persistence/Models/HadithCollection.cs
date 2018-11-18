﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace QuranX.Persistence.Models
{
	public class HadithCollection
	{
		public string Code { get; }
		public string Name { get; }
		public IReadOnlyList<HadithReferenceDefinition> ReferenceDefinitions { get; }
		public int HadithCount { get; }

		public HadithCollection(
			string code,
			string name,
			IEnumerable<HadithReferenceDefinition> referenceDefinitions,
			int hadithCount)
		{
			Code = code;
			Name = name;
			ReferenceDefinitions = referenceDefinitions.ToList().AsReadOnly();
			HadithCount = hadithCount;
		}

		public string PrimaryReferenceCode => ReferenceDefinitions.Single(x => x.IsPrimary).Code;
		public HadithReferenceDefinition GetReferenceDefinition(string referenceCode) => ReferenceDefinitions
			.SingleOrDefault(x => string.Compare(x.Code, referenceCode, true) == 0);
		public HadithReferenceDefinition GetPrimaryReferenceDefinition() =>
			GetReferenceDefinition(PrimaryReferenceCode);

		public HadithReferenceDefinition GetReferenceDefinitionByPartNames(IEnumerable<string> referencePartNames)
		{
			string requiredValues = string.Join(":", referencePartNames).ToLowerInvariant();
			Dictionary<string, HadithReferenceDefinition> availableDefinitions =
				ReferenceDefinitions
				.ToDictionary(x => string.Join(":", x.PartNames), StringComparer.InvariantCultureIgnoreCase);
			HadithReferenceDefinition result;
			if (availableDefinitions.TryGetValue(requiredValues, out result))
				return result;
			return null;
		}
	}
}
