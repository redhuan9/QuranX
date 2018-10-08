﻿using System;
using System.Text.RegularExpressions;

namespace QuranX.Persistence.Models
{
	public class HadithReference : IComparable<HadithReference>
	{
		public string CollectionCode { get; }
		public string ReferenceCode { get; }
		public int ReferenceValue1 { get; }
		public string ReferenceValue1Suffix { get; }
		public int? ReferenceValue2 { get; }
		public string ReferenceValue2Suffix { get; }
		public int? ReferenceValue3 { get; }
		public string ReferenceValue3Suffix { get; }
		public int HadithId { get; }

		public HadithReference(
			string collectionCode,
			string referenceCode,
			int referenceValue1,
			string referenceValue1Suffix,
			int? referenceValue2,
			string referenceValue2Suffix,
			int? referenceValue3,
			string referenceValue3Suffix,
			int hadithId)
		{
			CollectionCode = collectionCode;
			ReferenceCode = referenceCode;
			ReferenceValue1 = referenceValue1;
			ReferenceValue1Suffix = referenceValue1Suffix;
			ReferenceValue2 = referenceValue2;
			ReferenceValue2Suffix = referenceValue2Suffix;
			ReferenceValue3 = referenceValue3;
			ReferenceValue3Suffix = referenceValue3Suffix;
			HadithId = hadithId;
		}

		public static (int value, string suffix) SplitValue(string value)
		{
			var regex = new Regex(@"^(\d+)(\w+)?$");
			Match match = regex.Match(value);
			if (!match.Success)
				throw new ArgumentException("Must be digits alone or digits + letters", nameof(value));
			int val = int.Parse(match.Groups[1].Value);
			string suffix = match.Groups[2].Value;
			return (value:val, suffix);
		}

		public static (string referencePartName, int value, string suffix) SplitNameAndValue(string value)
		{
			var regex = new Regex(@"^([a-zA-Z]+)-(\d+)(\w+)?$");
			Match match = regex.Match(value);
			if (!match.Success)
				throw new ArgumentException("Must be Name, a dash, and then digits alone or digits + letters", nameof(value));
			string referencePartName = match.Groups[1].Value;
			int val = int.Parse(match.Groups[2].Value);
			string suffix = match.Groups[3].Value;
			return (referencePartName, value:val, suffix);
		}

		public override int GetHashCode()
		{
			string hashString =
				$"{CollectionCode}/{ReferenceCode}"
				+ $"/{ReferenceValue1}/{ReferenceValue1Suffix}"
				+ $"/{ReferenceValue2}/{ReferenceValue2Suffix}"
				+ $"/{ReferenceValue3}/{ReferenceValue3Suffix}";
			return hashString.GetHashCode();

		}

		public override bool Equals(object obj)
		{
			HadithReference other = obj as HadithReference;
			if (other == null)
				return false;

			return
				string.Compare(CollectionCode, other.CollectionCode, true) == 0
				&& string.Compare(ReferenceCode, other.ReferenceCode, true) == 0
				&& ReferenceValue1 == other.ReferenceValue1
				&& string.Compare(ReferenceValue1Suffix, other.ReferenceValue1Suffix, true) == 0
				&& ReferenceValue2 == other.ReferenceValue2
				&& string.Compare(ReferenceValue2Suffix, other.ReferenceValue2Suffix, true) == 0
				&& ReferenceValue1 == other.ReferenceValue3
				&& string.Compare(ReferenceValue3Suffix, other.ReferenceValue3Suffix, true) == 0;
		}

		public int CompareTo(HadithReference other)
		{
			if (other == null)
				throw new ArgumentNullException(nameof(other));
			int result;
			if ((result = string.Compare(CollectionCode, other.CollectionCode, true)) != 0)
				return result;
			if ((result = string.Compare(ReferenceCode, other.ReferenceCode, true)) != 0)
				return result;
			if ((result = other.ReferenceValue1 - ReferenceValue1) != 0)
				return result;
			if ((result = string.Compare(ReferenceValue1Suffix, other.ReferenceValue1Suffix, true)) != 0)
				return result;
			if ((result = other.ReferenceValue2 ?? 0 - ReferenceValue2 ?? 0) != 0)
				return result;
			if ((result = string.Compare(ReferenceValue2Suffix, other.ReferenceValue2Suffix, true)) != 0)
				return result;
			if ((result = other.ReferenceValue3 ?? 0 - ReferenceValue3 ?? 0) != 0)
				return result;
			if ((result = string.Compare(ReferenceValue3Suffix, other.ReferenceValue3Suffix, true)) != 0)
				return result;
			return 0;
		}

		public HadithReference ExcludingFinalSuffix()
		{
			int value1 = ReferenceValue1;
			string value1Suffix = ReferenceValue2.HasValue ? ReferenceValue1Suffix : null;
			int? value2 = ReferenceValue2;
			string value2Suffix = ReferenceValue2.HasValue ? ReferenceValue2Suffix : null;
			int? value3 = ReferenceValue3;
			string value3Suffix = null; // This can never be anything other than null
			return new HadithReference(
				collectionCode: CollectionCode,
				referenceCode: ReferenceCode,
				referenceValue1: value1,
				referenceValue1Suffix: value1Suffix,
				referenceValue2: value2,
				referenceValue2Suffix: value2Suffix,
				referenceValue3: value3,
				referenceValue3Suffix: value3Suffix,
				hadithId: -1);
		}

		public static bool operator ==(HadithReference a, HadithReference b)
		{
			if (Object.ReferenceEquals(a, null) && Object.ReferenceEquals(b, null))
				return true;
			return a.Equals(b);
		}

		public static bool operator !=(HadithReference a, HadithReference b)
		{
			return !(a == b);
		}
	}
}
