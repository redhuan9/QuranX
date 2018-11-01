﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Views\QuranVerses\QuranVerses.cshtml"
    using QuranX.Persistence.Models;
    
    #line default
    #line hidden
    using QuranX.Web;
    
    #line 1 "..\..\Views\QuranVerses\QuranVerses.cshtml"
    using QuranX.Web.Models;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\QuranVerses\QuranVerses.cshtml"
    using QuranX.Web.Views.QuranVerses;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/QuranVerses/QuranVerses.cshtml")]
    public partial class _Views_QuranVerses_QuranVerses_cshtml : System.Web.Mvc.WebViewPage<ViewModel>
    {
        public _Views_QuranVerses_QuranVerses_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Views\QuranVerses\QuranVerses.cshtml"
  
	ViewBag.Title = "The Noble Qur'an";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h1>");

            
            #line 10 "..\..\Views\QuranVerses\QuranVerses.cshtml"
Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n");

            
            #line 11 "..\..\Views\QuranVerses\QuranVerses.cshtml"
   Html.RenderPartial("SelectChapterAndVerse", Model.SelectChapterAndVerse); 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n\t<button");

WriteLiteral(" class=\"btn dropdown-toggle\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" id=\"dropdownMenuButton\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" aria-haspopup=\"true\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(">\r\n\t\tTranslations\r\n\t</button>\r\n\t<div");

WriteLiteral(" class=\"dropdown-menu verse__translation-hidden-items\"");

WriteLiteral(" aria-labelledby=\"dropdownMenuButton\"");

WriteLiteral(">\r\n");

            
            #line 18 "..\..\Views\QuranVerses\QuranVerses.cshtml"
		
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\QuranVerses\QuranVerses.cshtml"
         foreach (Translator translator in Model.Translators)
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<button");

WriteLiteral(" class=\"verse__translation-hidden-item btn\"");

WriteLiteral(" data-translator-code=\"");

            
            #line 20 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                                                                                Write(translator.Code);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 21 "..\..\Views\QuranVerses\QuranVerses.cshtml"
           Write(translator.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t</button>\r\n");

            
            #line 23 "..\..\Views\QuranVerses\QuranVerses.cshtml"
		}

            
            #line default
            #line hidden
WriteLiteral("\t</div>\r\n</div>\r\n\r\n");

            
            #line 27 "..\..\Views\QuranVerses\QuranVerses.cshtml"
 foreach (ChapterAndVerseSelection group in Model.DisplayVerses)
{

            
            #line default
            #line hidden
WriteLiteral("\t<h2>");

            
            #line 29 "..\..\Views\QuranVerses\QuranVerses.cshtml"
   Write(group.Chapter.EnglishName);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 29 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                                Write(group.Chapter.ArabicName);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n");

            
            #line 30 "..\..\Views\QuranVerses\QuranVerses.cshtml"
	foreach (Verse verse in group.Verses)
	{

            
            #line default
            #line hidden
WriteLiteral("\t\t<div");

WriteLiteral(" class=\"row verse__statistics\"");

WriteLiteral(">\r\n\t\t\t<span");

WriteLiteral(" class=\"verse__reference\"");

WriteLiteral(">");

            
            #line 33 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                                      Write(verse.ChapterNumber);

            
            #line default
            #line hidden
WriteLiteral(".");

            
            #line 33 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                                                           Write(verse.VerseNumber);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 1088), Tuple.Create("\"", 1143)
, Tuple.Create(Tuple.Create("", 1095), Tuple.Create("analysis/", 1095), true)
            
            #line 34 "..\..\Views\QuranVerses\QuranVerses.cshtml"
, Tuple.Create(Tuple.Create("", 1104), Tuple.Create<System.Object, System.Int32>(verse.ChapterNumber
            
            #line default
            #line hidden
, 1104), false)
, Tuple.Create(Tuple.Create("", 1124), Tuple.Create(".", 1124), true)
            
            #line 34 "..\..\Views\QuranVerses\QuranVerses.cshtml"
, Tuple.Create(Tuple.Create("", 1125), Tuple.Create<System.Object, System.Int32>(verse.VerseNumber
            
            #line default
            #line hidden
, 1125), false)
);

WriteLiteral(">\r\n\t\t\t\t<dl");

WriteLiteral(" class=\"count-and-label\"");

WriteLiteral(">\r\n\t\t\t\t\t<dd>");

            
            #line 36 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                   Write(verse.RootWordCount);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\t\t\t\t\t<dt>Roots</dt>\r\n\t\t\t\t</dl>\r\n\t\t\t</a>\r\n");

            
            #line 40 "..\..\Views\QuranVerses\QuranVerses.cshtml"
			
            
            #line default
            #line hidden
            
            #line 40 "..\..\Views\QuranVerses\QuranVerses.cshtml"
             if (verse.CommentaryCount > 0)
			{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 1306), Tuple.Create("\"", 1360)
, Tuple.Create(Tuple.Create("", 1313), Tuple.Create("tafsirs/", 1313), true)
            
            #line 42 "..\..\Views\QuranVerses\QuranVerses.cshtml"
, Tuple.Create(Tuple.Create("", 1321), Tuple.Create<System.Object, System.Int32>(verse.ChapterNumber
            
            #line default
            #line hidden
, 1321), false)
, Tuple.Create(Tuple.Create("", 1341), Tuple.Create(".", 1341), true)
            
            #line 42 "..\..\Views\QuranVerses\QuranVerses.cshtml"
, Tuple.Create(Tuple.Create("", 1342), Tuple.Create<System.Object, System.Int32>(verse.VerseNumber
            
            #line default
            #line hidden
, 1342), false)
);

WriteLiteral(">\r\n\t\t\t\t\t<dl");

WriteLiteral(" class=\"count-and-label\"");

WriteLiteral(">\r\n\t\t\t\t\t\t<dd>");

            
            #line 44 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                       Write(verse.CommentaryCount);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\t\t\t\t\t\t<dt>Tafirs</dt>\r\n\t\t\t\t\t</dl>\r\n\t\t\t\t</a>\r\n");

            
            #line 48 "..\..\Views\QuranVerses\QuranVerses.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t");

            
            #line 49 "..\..\Views\QuranVerses\QuranVerses.cshtml"
             if (verse.HadithCount > 0)
			{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 1533), Tuple.Create("\"", 1587)
, Tuple.Create(Tuple.Create("", 1540), Tuple.Create("hadiths/", 1540), true)
            
            #line 51 "..\..\Views\QuranVerses\QuranVerses.cshtml"
, Tuple.Create(Tuple.Create("", 1548), Tuple.Create<System.Object, System.Int32>(verse.ChapterNumber
            
            #line default
            #line hidden
, 1548), false)
, Tuple.Create(Tuple.Create("", 1568), Tuple.Create(".", 1568), true)
            
            #line 51 "..\..\Views\QuranVerses\QuranVerses.cshtml"
, Tuple.Create(Tuple.Create("", 1569), Tuple.Create<System.Object, System.Int32>(verse.VerseNumber
            
            #line default
            #line hidden
, 1569), false)
);

WriteLiteral(">\r\n\t\t\t\t\t<dl");

WriteLiteral(" class=\"count-and-label\"");

WriteLiteral(">\r\n\t\t\t\t\t\t<dd>");

            
            #line 53 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                       Write(verse.HadithCount);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\t\t\t\t\t\t<dt>Hadiths</dt>\r\n\t\t\t\t\t</dl>\r\n\t\t\t\t</a>\r\n");

            
            #line 57 "..\..\Views\QuranVerses\QuranVerses.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\t\t</div>\r\n");

            
            #line 59 "..\..\Views\QuranVerses\QuranVerses.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t\t<div");

WriteLiteral(" class=\"verse__translations boxed\"");

WriteLiteral(">\r\n");

            
            #line 61 "..\..\Views\QuranVerses\QuranVerses.cshtml"
			
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\QuranVerses\QuranVerses.cshtml"
             foreach (VerseText translation in verse.VerseTexts)
			{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<dl");

WriteLiteral(" class=\"verse__translation\"");

WriteLiteral(" data-translator-code=\"");

            
            #line 63 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                                                                Write(translation.TranslatorCode);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n\t\t\t\t\t<dt>");

            
            #line 64 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                   Write(translation.TranslatorName);

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n\t\t\t\t\t<dd>");

            
            #line 65 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                   Write(translation.Text);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\t\t\t\t</dl>\r\n");

            
            #line 67 "..\..\Views\QuranVerses\QuranVerses.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\t\t</div>\r\n");

            
            #line 69 "..\..\Views\QuranVerses\QuranVerses.cshtml"
	}
}

            
            #line default
            #line hidden
DefineSection("scripts", () => {

WriteLiteral(@"
	<script>
		function toggleTranslation(translatorCode) {
			$(`.verse__translation[data-translator-code=""${translatorCode}""`).toggle(""collapse"");
			$(`.verse__translation-hidden-item[data-translator-code=""${translatorCode}""`).toggle(""collapse"");
		}
		// Buttons to show translations
		$("".verse__translation-hidden-item"")
			.each(function (index, elem) {
				elem = $(elem);
				const translatorCode = elem.data(""translator-code"");
				if (window.localStorage.getItem(translatorCode)) {
					elem.show();
				} else {
					elem.hide();
				}
			})
			.on(""click"", function (ev) {
				const elem = $(ev.target);
				const translatorCode = elem.data(""translator-code"");
				window.localStorage.removeItem(translatorCode);

				toggleTranslation(translatorCode);
			});
		// Translations
		$("".verse__translation>dt"")
			.each(function (index, elem) {
				elem = $(elem.parentElement);
				const translatorCode = elem.data(""translator-code"");
				if (window.localStorage.getItem(translatorCode)) {
					elem.hide();
				};
			})
			.on(""click"", function (ev) {
				const elem = $(ev.target.parentElement);
				const translatorCode = elem.data(""translator-code"");
				window.localStorage.setItem(translatorCode, true);

				toggleTranslation(translatorCode);
			});
	</script>
");

});

        }
    }
}
#pragma warning restore 1591
