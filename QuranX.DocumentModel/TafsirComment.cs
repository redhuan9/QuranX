﻿using System.Collections.Generic;
using System.Linq;

namespace QuranX.DocumentModel
{
	public class TafsirComment
	{
		public readonly VerseRangeReference VerseReference;
		public readonly string[] Text;

		public TafsirComment(VerseRangeReference verseReference, IEnumerable<string> text)
		{
			this.VerseReference = verseReference;
			this.Text = text.ToArray();
		}
	}
}
