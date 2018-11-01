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
    
    #line 2 "..\..\Views\VerseHadiths\VerseHadiths.cshtml"
    using QuranX.Web.Views.Shared;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/VerseHadiths/VerseHadiths.cshtml")]
    public partial class _Views_VerseHadiths_VerseHadiths_cshtml : System.Web.Mvc.WebViewPage<QuranX.Web.Views.VerseHadiths.ViewModel>
    {
        public _Views_VerseHadiths_VerseHadiths_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\VerseHadiths\VerseHadiths.cshtml"
  
	ViewBag.Title = $"Hadiths for {Model.Chapter.ChapterNumber}.{Model.VerseNumber}";
	string hadithsTitle = Model.Hadiths.Count() == 1 ? "hadith" : "hadiths";

            
            #line default
            #line hidden
WriteLiteral("\r\n<h1>The Quran</h1>\r\n<h2>\r\n\tHadiths for <a");

WriteAttribute("href", Tuple.Create(" href=\"", 289), Tuple.Create("\"", 344)
, Tuple.Create(Tuple.Create("", 296), Tuple.Create("/", 296), true)
            
            #line 10 "..\..\Views\VerseHadiths\VerseHadiths.cshtml"
, Tuple.Create(Tuple.Create("", 297), Tuple.Create<System.Object, System.Int32>(Model.Chapter.ChapterNumber
            
            #line default
            #line hidden
, 297), false)
, Tuple.Create(Tuple.Create("", 325), Tuple.Create(".", 325), true)
            
            #line 10 "..\..\Views\VerseHadiths\VerseHadiths.cshtml"
, Tuple.Create(Tuple.Create("", 326), Tuple.Create<System.Object, System.Int32>(Model.VerseNumber
            
            #line default
            #line hidden
, 326), false)
);

WriteLiteral(">\r\n");

WriteLiteral("\t\t");

            
            #line 11 "..\..\Views\VerseHadiths\VerseHadiths.cshtml"
   Write(Model.Chapter.ChapterNumber);

            
            #line default
            #line hidden
WriteLiteral(".");

            
            #line 11 "..\..\Views\VerseHadiths\VerseHadiths.cshtml"
                                Write(Model.VerseNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t</a>\r\n</h2>\r\n<h3>");

            
            #line 14 "..\..\Views\VerseHadiths\VerseHadiths.cshtml"
Write(Model.Chapter.EnglishName);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 14 "..\..\Views\VerseHadiths\VerseHadiths.cshtml"
                            Write(Model.Chapter.ArabicName);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 15 "..\..\Views\VerseHadiths\VerseHadiths.cshtml"
 if (Model.Hadiths.Count() != 1)
{

            
            #line default
            #line hidden
WriteLiteral("\t<h4>");

            
            #line 17 "..\..\Views\VerseHadiths\VerseHadiths.cshtml"
   Write(Model.Hadiths.Count());

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 17 "..\..\Views\VerseHadiths\VerseHadiths.cshtml"
                          Write(hadithsTitle);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n");

            
            #line 18 "..\..\Views\VerseHadiths\VerseHadiths.cshtml"
}

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\VerseHadiths\VerseHadiths.cshtml"
 foreach (HadithViewModel hadithVM in Model.Hadiths)
{
	
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\VerseHadiths\VerseHadiths.cshtml"
Write(Html.Partial("HadithView", hadithVM));

            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\VerseHadiths\VerseHadiths.cshtml"
                                         
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
