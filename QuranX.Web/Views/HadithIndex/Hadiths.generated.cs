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
    
    #line 2 "..\..\Views\HadithIndex\Hadiths.cshtml"
    using QuranX.Persistence.Models;
    
    #line default
    #line hidden
    using QuranX.Web;
    
    #line 1 "..\..\Views\HadithIndex\Hadiths.cshtml"
    using QuranX.Web.Views.HadithIndex;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/HadithIndex/Hadiths.cshtml")]
    public partial class _Views_HadithIndex_Hadiths_cshtml : System.Web.Mvc.WebViewPage<HadithsViewModel>
    {
        public _Views_HadithIndex_Hadiths_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\HadithIndex\Hadiths.cshtml"
  
	ViewBag.Title = $"{Model.HadithIndexHeaderViewModel.Collection.Name} Hadiths";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 9 "..\..\Views\HadithIndex\Hadiths.cshtml"
Write(Html.Partial("HadithIndexHeader", Model.HadithIndexHeaderViewModel));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\Views\HadithIndex\Hadiths.cshtml"
 foreach(Hadith hadith in Model.Hadiths)
{

            
            #line default
            #line hidden
WriteLiteral("\t<div>\r\n");

            
            #line 13 "..\..\Views\HadithIndex\Hadiths.cshtml"
		
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\HadithIndex\Hadiths.cshtml"
         foreach(string text in hadith.EnglishText)
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<p>");

            
            #line 15 "..\..\Views\HadithIndex\Hadiths.cshtml"
          Write(text);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 16 "..\..\Views\HadithIndex\Hadiths.cshtml"
		}

            
            #line default
            #line hidden
WriteLiteral("\t\t");

            
            #line 17 "..\..\Views\HadithIndex\Hadiths.cshtml"
         foreach(string text in hadith.ArabicText)
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<p>");

            
            #line 19 "..\..\Views\HadithIndex\Hadiths.cshtml"
          Write(text);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 20 "..\..\Views\HadithIndex\Hadiths.cshtml"
		}

            
            #line default
            #line hidden
WriteLiteral("\t</div>\r\n");

            
            #line 22 "..\..\Views\HadithIndex\Hadiths.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
