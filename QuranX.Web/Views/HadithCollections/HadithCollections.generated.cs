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
    
    #line 1 "..\..\Views\HadithCollections\HadithCollections.cshtml"
    using QuranX.Persistence.Models;
    
    #line default
    #line hidden
    using QuranX.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/HadithCollections/HadithCollections.cshtml")]
    public partial class _Views_HadithCollections_HadithCollections_cshtml : System.Web.Mvc.WebViewPage<IEnumerable<HadithCollection>>
    {
        public _Views_HadithCollections_HadithCollections_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\HadithCollections\HadithCollections.cshtml"
  
	ViewBag.Title = "Hadith collections";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h1>");

            
            #line 8 "..\..\Views\HadithCollections\HadithCollections.cshtml"
Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n<ol");

WriteLiteral(" class=\"hadithcollection__collection-list striped\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\HadithCollections\HadithCollections.cshtml"
	
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\HadithCollections\HadithCollections.cshtml"
     foreach (HadithCollection collection in Model)
	{

            
            #line default
            #line hidden
WriteLiteral("\t\t<li>\r\n\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 271), Tuple.Create("\"", 336)
, Tuple.Create(Tuple.Create("", 278), Tuple.Create("/Hadith/", 278), true)
            
            #line 13 "..\..\Views\HadithCollections\HadithCollections.cshtml"
, Tuple.Create(Tuple.Create("", 286), Tuple.Create<System.Object, System.Int32>(collection.Code
            
            #line default
            #line hidden
, 286), false)
, Tuple.Create(Tuple.Create("", 302), Tuple.Create("/", 302), true)
            
            #line 13 "..\..\Views\HadithCollections\HadithCollections.cshtml"
, Tuple.Create(Tuple.Create("", 303), Tuple.Create<System.Object, System.Int32>(collection.PrimaryReferenceCode
            
            #line default
            #line hidden
, 303), false)
, Tuple.Create(Tuple.Create("", 335), Tuple.Create("/", 335), true)
);

WriteLiteral(">\r\n\t\t\t\t<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"col-xs-4 col-sm-3 col-md-2\"");

WriteLiteral(">");

            
            #line 15 "..\..\Views\HadithCollections\HadithCollections.cshtml"
                                                        Write(collection.Code);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"col-xs-8 col-sm-9 col-md-10\"");

WriteLiteral(">");

            
            #line 16 "..\..\Views\HadithCollections\HadithCollections.cshtml"
                                                         Write(collection.Name);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t\t\t</div>\r\n\t\t\t</a>\r\n\t\t</li>\r\n");

            
            #line 20 "..\..\Views\HadithCollections\HadithCollections.cshtml"
	}

            
            #line default
            #line hidden
WriteLiteral("</ol>");

        }
    }
}
#pragma warning restore 1591