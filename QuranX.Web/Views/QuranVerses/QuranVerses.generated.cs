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
  
	ViewBag.Title = "The Qur'an";

            
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
		if (Model.AutoScrollToSelectedVerse
			&& verse.ChapterNumber == Model.SelectChapterAndVerse.SelectedChapterNumber
			&& verse.VerseNumber == Model.SelectChapterAndVerse.SelectedVerseNumber)
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<a");

WriteLiteral(" name=\"focal-point\"");

WriteLiteral("></a>\r\n");

            
            #line 37 "..\..\Views\QuranVerses\QuranVerses.cshtml"
		}

            
            #line default
            #line hidden
WriteLiteral("\t\t<div");

WriteLiteral(" class=\"row verse__statistics\"");

WriteLiteral(">\r\n\t\t\t<span");

WriteLiteral(" class=\"verse__reference\"");

WriteLiteral(">");

            
            #line 39 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                                      Write(verse.ChapterNumber);

            
            #line default
            #line hidden
WriteLiteral(".");

            
            #line 39 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                                                           Write(verse.VerseNumber);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 1319), Tuple.Create("\"", 1374)
, Tuple.Create(Tuple.Create("", 1326), Tuple.Create("analysis/", 1326), true)
            
            #line 40 "..\..\Views\QuranVerses\QuranVerses.cshtml"
, Tuple.Create(Tuple.Create("", 1335), Tuple.Create<System.Object, System.Int32>(verse.ChapterNumber
            
            #line default
            #line hidden
, 1335), false)
, Tuple.Create(Tuple.Create("", 1355), Tuple.Create(".", 1355), true)
            
            #line 40 "..\..\Views\QuranVerses\QuranVerses.cshtml"
, Tuple.Create(Tuple.Create("", 1356), Tuple.Create<System.Object, System.Int32>(verse.VerseNumber
            
            #line default
            #line hidden
, 1356), false)
);

WriteLiteral(">\r\n\t\t\t\t<dl");

WriteLiteral(" class=\"count-and-label\"");

WriteLiteral(">\r\n\t\t\t\t\t<dd>");

            
            #line 42 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                   Write(verse.RootWordCount);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\t\t\t\t\t<dt>Roots</dt>\r\n\t\t\t\t</dl>\r\n\t\t\t</a>\r\n");

            
            #line 46 "..\..\Views\QuranVerses\QuranVerses.cshtml"
			
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\QuranVerses\QuranVerses.cshtml"
             if (verse.CommentaryCount > 0)
			{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 1537), Tuple.Create("\"", 1591)
, Tuple.Create(Tuple.Create("", 1544), Tuple.Create("tafsirs/", 1544), true)
            
            #line 48 "..\..\Views\QuranVerses\QuranVerses.cshtml"
, Tuple.Create(Tuple.Create("", 1552), Tuple.Create<System.Object, System.Int32>(verse.ChapterNumber
            
            #line default
            #line hidden
, 1552), false)
, Tuple.Create(Tuple.Create("", 1572), Tuple.Create(".", 1572), true)
            
            #line 48 "..\..\Views\QuranVerses\QuranVerses.cshtml"
, Tuple.Create(Tuple.Create("", 1573), Tuple.Create<System.Object, System.Int32>(verse.VerseNumber
            
            #line default
            #line hidden
, 1573), false)
);

WriteLiteral(">\r\n\t\t\t\t\t<dl");

WriteLiteral(" class=\"count-and-label\"");

WriteLiteral(">\r\n\t\t\t\t\t\t<dd>");

            
            #line 50 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                       Write(verse.CommentaryCount);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\t\t\t\t\t\t<dt>Tafirs</dt>\r\n\t\t\t\t\t</dl>\r\n\t\t\t\t</a>\r\n");

            
            #line 54 "..\..\Views\QuranVerses\QuranVerses.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t");

            
            #line 55 "..\..\Views\QuranVerses\QuranVerses.cshtml"
             if (verse.HadithCount > 0)
			{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 1764), Tuple.Create("\"", 1818)
, Tuple.Create(Tuple.Create("", 1771), Tuple.Create("hadiths/", 1771), true)
            
            #line 57 "..\..\Views\QuranVerses\QuranVerses.cshtml"
, Tuple.Create(Tuple.Create("", 1779), Tuple.Create<System.Object, System.Int32>(verse.ChapterNumber
            
            #line default
            #line hidden
, 1779), false)
, Tuple.Create(Tuple.Create("", 1799), Tuple.Create(".", 1799), true)
            
            #line 57 "..\..\Views\QuranVerses\QuranVerses.cshtml"
, Tuple.Create(Tuple.Create("", 1800), Tuple.Create<System.Object, System.Int32>(verse.VerseNumber
            
            #line default
            #line hidden
, 1800), false)
);

WriteLiteral(">\r\n\t\t\t\t\t<dl");

WriteLiteral(" class=\"count-and-label\"");

WriteLiteral(">\r\n\t\t\t\t\t\t<dd>");

            
            #line 59 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                       Write(verse.HadithCount);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\t\t\t\t\t\t<dt>Hadiths</dt>\r\n\t\t\t\t\t</dl>\r\n\t\t\t\t</a>\r\n");

            
            #line 63 "..\..\Views\QuranVerses\QuranVerses.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\t\t</div>\r\n");

            
            #line 65 "..\..\Views\QuranVerses\QuranVerses.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t\t<div");

WriteLiteral(" class=\"verse__translations boxed\"");

WriteLiteral(">\r\n");

            
            #line 67 "..\..\Views\QuranVerses\QuranVerses.cshtml"
			
            
            #line default
            #line hidden
            
            #line 67 "..\..\Views\QuranVerses\QuranVerses.cshtml"
             foreach (VerseText translation in verse.VerseTexts)
			{
				string arabicCss = translation.TranslatorCode == "AR" ? "arabic" : "";
				string containerPaddingCss = arabicCss != "" ? "arabic-container" : "";

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<dl");

WriteAttribute("class", Tuple.Create(" class=\"", 2222), Tuple.Create("\"", 2269)
, Tuple.Create(Tuple.Create("", 2230), Tuple.Create("verse__translation", 2230), true)
            
            #line 71 "..\..\Views\QuranVerses\QuranVerses.cshtml"
, Tuple.Create(Tuple.Create(" ", 2248), Tuple.Create<System.Object, System.Int32>(containerPaddingCss
            
            #line default
            #line hidden
, 2249), false)
);

WriteLiteral(" data-translator-code=\"");

            
            #line 71 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                                                                                     Write(translation.TranslatorCode);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n\t\t\t\t\t<dt>");

            
            #line 72 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                   Write(translation.TranslatorName);

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n\t\t\t\t\t<dd");

WriteAttribute("class", Tuple.Create(" class=\"", 2375), Tuple.Create("\"", 2407)
            
            #line 73 "..\..\Views\QuranVerses\QuranVerses.cshtml"
, Tuple.Create(Tuple.Create("", 2383), Tuple.Create<System.Object, System.Int32>(arabicCss
            
            #line default
            #line hidden
, 2383), false)
, Tuple.Create(Tuple.Create(" ", 2393), Tuple.Create("highlightable", 2394), true)
);

WriteLiteral(">");

            
            #line 73 "..\..\Views\QuranVerses\QuranVerses.cshtml"
                                                    Write(translation.Text);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\t\t\t\t</dl>\r\n");

            
            #line 75 "..\..\Views\QuranVerses\QuranVerses.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\t\t</div>\r\n");

            
            #line 77 "..\..\Views\QuranVerses\QuranVerses.cshtml"
	}
}

            
            #line default
            #line hidden
DefineSection("scripts", () => {

WriteLiteral("\r\n\t<script>\r\n\r\n\t\tfunction toggleTranslation(translatorCode, immediateHide) {\r\n\t\t\t" +
"var verseElem = $(`.verse__translation[data-translator-code=\"${translatorCode}\"`" +
");\r\n\t\t\tvar hiddenCodeElem = $(`.verse__translation-hidden-item[data-translator-c" +
"ode=\"${translatorCode}\"`);\r\n\r\n\t\t\tif (!immediateHide) {\r\n\t\t\t\tverseElem.toggle(\"co" +
"llapse\");\r\n\t\t\t\thiddenCodeElem.toggle(\"collapse\");\r\n\t\t\t} else {\r\n\t\t\t\tverseElem.hi" +
"de();\r\n\t\t\t\thiddenCodeElem.show();\r\n\t\t\t}\r\n\t\t}\r\n\t\t// Buttons to show translations\r" +
"\n\t\t$(\".verse__translation-hidden-item\")\r\n\t\t\t.each(function (index, elem) {\r\n\t\t\t\t" +
"elem = $(elem);\r\n\t\t\t\tconst translatorCode = elem.data(\"translator-code\");\r\n\t\t\t\ti" +
"f (window.localStorage.getItem(translatorCode)) {\r\n\t\t\t\t\telem.show();\r\n\t\t\t\t} else" +
" {\r\n\t\t\t\t\telem.hide();\r\n\t\t\t\t}\r\n\t\t\t})\r\n\t\t\t.on(\"click\", function (ev) {\r\n\t\t\t\tconst " +
"elem = $(ev.target);\r\n\t\t\t\tconst translatorCode = elem.data(\"translator-code\");\r\n" +
"\t\t\t\twindow.localStorage.removeItem(\"hide-\" + translatorCode);\r\n\r\n\t\t\t\ttoggleTrans" +
"lation(translatorCode);\r\n\t\t\t});\r\n\t\t// Translations\r\n\t\t$(\".verse__translation>dt\"" +
")\r\n\t\t\t.each(function (index, elem) {\r\n\t\t\t\telem = $(elem.parentElement);\r\n\t\t\t\tcon" +
"st translatorCode = elem.data(\"translator-code\");\r\n\t\t\t\t// If this is the first v" +
"isit\r\n\t\t\t\tif (!window.localStorage.getItem(\"returnVisit\")) {\r\n\t\t\t\t\t// Hide the t" +
"ranslation if not one of the defaults to show\r\n\t\t\t\t\tif ([\"AR\", \"Pickthall\", \"Sah" +
"ihIntl\", \"YusufAli\"].indexOf(translatorCode) < 0) {\r\n\t\t\t\t\t\twindow.localStorage.s" +
"etItem(\"hide-\" + translatorCode, true);\r\n\t\t\t\t\t}\r\n\t\t\t\t}\r\n\t\t\t\tif (window.localStor" +
"age.getItem(\"hide-\" + translatorCode)) {\r\n\t\t\t\t\ttoggleTranslation(translatorCode," +
" true);\r\n\t\t\t\t};\r\n\t\t\t})\r\n\t\t\t.on(\"click\", function (ev) {\r\n\t\t\t\tconst elem = $(ev.t" +
"arget.parentElement);\r\n\t\t\t\tconst translatorCode = elem.data(\"translator-code\");\r" +
"\n\t\t\t\twindow.localStorage.setItem(\"hide-\" + translatorCode, true);\r\n\r\n\t\t\t\ttoggleT" +
"ranslation(translatorCode);\r\n\t\t\t});\r\n\t\t$(document).ready(function () {\r\n\t\t\twindo" +
"w.localStorage.setItem(\"returnVisit\", true);\r\n\t\t});\r\n\t</script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
