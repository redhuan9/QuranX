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
    using QuranX.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/VerseAnalysis/Index.cshtml")]
    public partial class _Views_VerseAnalysis_Index_cshtml : System.Web.Mvc.WebViewPage<QuranX.Web.Views.VerseAnalysis.ViewModel>
    {
        public _Views_VerseAnalysis_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\VerseAnalysis\Index.cshtml"
  
	ViewBag.Title = $"Analysis for Quran verse {Model.Chapter.ChapterNumber}.{Model.VerseNumber}";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h1>The Quran</h1>\r\n<h2>\r\n\tAnalysis of <a");

WriteAttribute("href", Tuple.Create(" href=\"", 198), Tuple.Create("\"", 253)
, Tuple.Create(Tuple.Create("", 205), Tuple.Create("/", 205), true)
            
            #line 9 "..\..\Views\VerseAnalysis\Index.cshtml"
, Tuple.Create(Tuple.Create("", 206), Tuple.Create<System.Object, System.Int32>(Model.Chapter.ChapterNumber
            
            #line default
            #line hidden
, 206), false)
, Tuple.Create(Tuple.Create("", 234), Tuple.Create(".", 234), true)
            
            #line 9 "..\..\Views\VerseAnalysis\Index.cshtml"
, Tuple.Create(Tuple.Create("", 235), Tuple.Create<System.Object, System.Int32>(Model.VerseNumber
            
            #line default
            #line hidden
, 235), false)
);

WriteLiteral(">\r\n");

WriteLiteral("\t\t");

            
            #line 10 "..\..\Views\VerseAnalysis\Index.cshtml"
   Write(Model.Chapter.ChapterNumber);

            
            #line default
            #line hidden
WriteLiteral(".");

            
            #line 10 "..\..\Views\VerseAnalysis\Index.cshtml"
                                Write(Model.VerseNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t</a>\r\n</h2>\r\n<h3>\r\n");

WriteLiteral("\t");

            
            #line 14 "..\..\Views\VerseAnalysis\Index.cshtml"
Write(Model.Chapter.EnglishName);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 14 "..\..\Views\VerseAnalysis\Index.cshtml"
                            Write(Model.Chapter.ArabicName);

            
            #line default
            #line hidden
WriteLiteral("\r\n</h3>\r\n");

            
            #line 16 "..\..\Views\VerseAnalysis\Index.cshtml"
   Html.RenderPartial("SelectChapterAndVerse", Model.SelectChapterAndVerse); 
            
            #line default
            #line hidden
WriteLiteral("\r\n<ul");

WriteLiteral(" class=\"verse-analysis__word-list\"");

WriteLiteral(">\r\n");

            
            #line 18 "..\..\Views\VerseAnalysis\Index.cshtml"
	
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\VerseAnalysis\Index.cshtml"
     foreach (var word in Model.Words)
	{
		string wordUrl = Url.RouteUrl("WordAnalysis", new { Word = QuranX.Web.ArabicHelper.Standardize(word.Arabic) });

            
            #line default
            #line hidden
WriteLiteral("\t\t<li");

WriteLiteral(" class=\"verse-analysis__word row\"");

WriteLiteral(">\r\n\t\t\t<a");

WriteAttribute("name", Tuple.Create(" name=\"", 714), Tuple.Create("\"", 796)
, Tuple.Create(Tuple.Create("", 721), Tuple.Create("Word_", 721), true)
            
            #line 22 "..\..\Views\VerseAnalysis\Index.cshtml"
, Tuple.Create(Tuple.Create("", 726), Tuple.Create<System.Object, System.Int32>(Model.Chapter.ChapterNumber
            
            #line default
            #line hidden
, 726), false)
, Tuple.Create(Tuple.Create("", 756), Tuple.Create("_", 756), true)
            
            #line 22 "..\..\Views\VerseAnalysis\Index.cshtml"
, Tuple.Create(Tuple.Create("", 757), Tuple.Create<System.Object, System.Int32>(Model.VerseNumber
            
            #line default
            #line hidden
, 757), false)
, Tuple.Create(Tuple.Create("", 777), Tuple.Create("_(", 777), true)
            
            #line 22 "..\..\Views\VerseAnalysis\Index.cshtml"
, Tuple.Create(Tuple.Create("", 779), Tuple.Create<System.Object, System.Int32>(word.WordNumber
            
            #line default
            #line hidden
, 779), false)
, Tuple.Create(Tuple.Create("", 795), Tuple.Create(")", 795), true)
);

WriteLiteral("></a>\r\n\t\t\t<div");

WriteLiteral(" class=\"col-xs-6 verse-analysis__word-reference\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 24 "..\..\Views\VerseAnalysis\Index.cshtml"
           Write(Model.Chapter.ChapterNumber);

            
            #line default
            #line hidden
WriteLiteral(".");

            
            #line 24 "..\..\Views\VerseAnalysis\Index.cshtml"
                                        Write(Model.VerseNumber);

            
            #line default
            #line hidden
WriteLiteral(".");

            
            #line 24 "..\..\Views\VerseAnalysis\Index.cshtml"
                                                           Write(word.WordNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t<div");

WriteLiteral(" class=\"col-xs-6 verse-analysis__word-image\"");

WriteLiteral(">\r\n\t\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 1003), Tuple.Create("\"", 1019)
            
            #line 27 "..\..\Views\VerseAnalysis\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1010), Tuple.Create<System.Object, System.Int32>(wordUrl
            
            #line default
            #line hidden
, 1010), false)
, Tuple.Create(Tuple.Create("\t", 1018), Tuple.Create("", 1018), true)
);

WriteLiteral(">\r\n\t\t\t\t\t<img");

WriteAttribute("src", Tuple.Create(" src=\"", 1032), Tuple.Create("\"", 1108)
, Tuple.Create(Tuple.Create("", 1038), Tuple.Create<System.Object, System.Int32>(Href("~/Content/Images/ArabicWords/")
, 1038), false)
            
            #line 28 "..\..\Views\VerseAnalysis\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1067), Tuple.Create<System.Object, System.Int32>(Html.GetHexValues(word.Buckwalter)
            
            #line default
            #line hidden
, 1067), false)
, Tuple.Create(Tuple.Create("", 1104), Tuple.Create(".png", 1104), true)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 1109), Tuple.Create("\"", 1131)
            
            #line 28 "..\..\Views\VerseAnalysis\Index.cshtml"
                           , Tuple.Create(Tuple.Create("", 1115), Tuple.Create<System.Object, System.Int32>(word.Buckwalter
            
            #line default
            #line hidden
, 1115), false)
);

WriteLiteral(" />\r\n\t\t\t\t</a>\r\n\t\t\t</div>\r\n\t\t\t<div");

WriteLiteral(" class=\"col-xs-6 verse-analysis__word-text\"");

WriteLiteral(">\r\n\t\t\t\t<div");

WriteLiteral(" class=\"verse-analysis__word-text-buckwalter\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t");

            
            #line 33 "..\..\Views\VerseAnalysis\Index.cshtml"
               Write(word.Buckwalter);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<div");

WriteLiteral(" class=\"verse-analysis__word-text-english\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t");

            
            #line 36 "..\..\Views\VerseAnalysis\Index.cshtml"
               Write(word.English);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<ol");

WriteLiteral(" class=\"col-xs-6 verse-analysis__word-parts\"");

WriteLiteral(">\r\n");

            
            #line 40 "..\..\Views\VerseAnalysis\Index.cshtml"
				
            
            #line default
            #line hidden
            
            #line 40 "..\..\Views\VerseAnalysis\Index.cshtml"
                 foreach (var wordPart in word.WordParts)
				{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t<li");

WriteLiteral(" class=\"verse-analysis__word-part\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 43 "..\..\Views\VerseAnalysis\Index.cshtml"
                   Write(wordPart.Type);

            
            #line default
            #line hidden
WriteLiteral(" -\r\n");

            
            #line 44 "..\..\Views\VerseAnalysis\Index.cshtml"
						
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\VerseAnalysis\Index.cshtml"
                         foreach (string decorator in @wordPart.Decorators)
						{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t<span>");

            
            #line 46 "..\..\Views\VerseAnalysis\Index.cshtml"
                             Write(decorator);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 47 "..\..\Views\VerseAnalysis\Index.cshtml"
						}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t");

            
            #line 48 "..\..\Views\VerseAnalysis\Index.cshtml"
                   Write(wordPart.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 49 "..\..\Views\VerseAnalysis\Index.cshtml"
						
            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\VerseAnalysis\Index.cshtml"
                         if (!string.IsNullOrEmpty(wordPart.Root))
						{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t<span");

WriteLiteral(" class=\"arabicText\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t\t\t\t");

            
            #line 52 "..\..\Views\VerseAnalysis\Index.cshtml"
                           Write(Html.RouteLink(
									linkText: wordPart.Root,
									routeName: "RootAnalysis",
									routeValues: new
									{
										Root = QuranX.Web.ArabicHelper
											.ArabicToLetterNames(wordPart.Root)
									}
								));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t</span>\r\n");

WriteLiteral("\t\t\t\t\t\t\t<span>(");

            
            #line 62 "..\..\Views\VerseAnalysis\Index.cshtml"
                              Write(QuranX.Web.ArabicHelper.ArabicToLetterNames(wordPart.Root));

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n");

            
            #line 63 "..\..\Views\VerseAnalysis\Index.cshtml"
						}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t</li>\r\n");

            
            #line 65 "..\..\Views\VerseAnalysis\Index.cshtml"
				}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t</ol>\r\n\t\t</li>\r\n");

            
            #line 68 "..\..\Views\VerseAnalysis\Index.cshtml"
	}

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
