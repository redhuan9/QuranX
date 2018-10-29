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
    
    #line 2 "..\..\Views\VerseHadiths\Index.cshtml"
    using QuranX.Web.Views.Shared;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/VerseHadiths/Index.cshtml")]
    public partial class _Views_VerseHadiths_Index_cshtml : System.Web.Mvc.WebViewPage<QuranX.Web.Views.VerseHadiths.ViewModel>
    {
        public _Views_VerseHadiths_Index_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\VerseHadiths\Index.cshtml"
  
	ViewBag.Title = $"Hadiths for {Model.Chapter.ChapterNumber}.{Model.VerseNumber}";

            
            #line default
            #line hidden
WriteLiteral("\r\n<h1>The Quran</h1>\r\n<h2>\r\n\tHadiths for <a");

WriteAttribute("href", Tuple.Create(" href=\"", 214), Tuple.Create("\"", 271)
, Tuple.Create(Tuple.Create("", 221), Tuple.Create("/", 221), true)
            
            #line 9 "..\..\Views\VerseHadiths\Index.cshtml"
, Tuple.Create(Tuple.Create("", 222), Tuple.Create<System.Object, System.Int32>(Model.Chapter.ChapterNumber
            
            #line default
            #line hidden
, 222), false)
, Tuple.Create(Tuple.Create("", 252), Tuple.Create(".", 252), true)
            
            #line 9 "..\..\Views\VerseHadiths\Index.cshtml"
, Tuple.Create(Tuple.Create("", 253), Tuple.Create<System.Object, System.Int32>(Model.VerseNumber
            
            #line default
            #line hidden
, 253), false)
);

WriteLiteral(">\r\n");

WriteLiteral("\t\t");

            
            #line 10 "..\..\Views\VerseHadiths\Index.cshtml"
    Write(Model.Chapter.ChapterNumber);

            
            #line default
            #line hidden
WriteLiteral(".");

            
            #line 10 "..\..\Views\VerseHadiths\Index.cshtml"
                                  Write(Model.VerseNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t</a>\r\n</h2>\r\n<h3>");

            
            #line 13 "..\..\Views\VerseHadiths\Index.cshtml"
Write(Model.Chapter.EnglishName);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 13 "..\..\Views\VerseHadiths\Index.cshtml"
                            Write(Model.Chapter.ArabicName);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 14 "..\..\Views\VerseHadiths\Index.cshtml"
 foreach (HadithViewModel hadithVM in Model.Hadiths)
{
	
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\VerseHadiths\Index.cshtml"
Write(Html.Partial("HadithView", hadithVM));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\VerseHadiths\Index.cshtml"
                                         
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
