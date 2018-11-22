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
    
    #line 2 "..\..\Views\SiteSearch\SiteSearch.cshtml"
    using QuranX.Web.Views.Search;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SiteSearch/SiteSearch.cshtml")]
    public partial class _Views_SiteSearch_SiteSearch_cshtml : System.Web.Mvc.WebViewPage<QuranX.Web.Views.Search.ViewModel>
    {
        public _Views_SiteSearch_SiteSearch_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\SiteSearch\SiteSearch.cshtml"
  
	ViewBag.Title = "Search";

            
            #line default
            #line hidden
WriteLiteral("\r\n<h1>Search</h1>\r\n");

            
            #line 8 "..\..\Views\SiteSearch\SiteSearch.cshtml"
 using (Html.BeginForm(actionName: "index", controllerName: "SiteSearch", method: FormMethod.Get))
{

            
            #line default
            #line hidden
WriteLiteral("\t<div");

WriteLiteral(" class=\"search__criteria\"");

WriteLiteral(">\r\n\t\t<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t");

            
            #line 12 "..\..\Views\SiteSearch\SiteSearch.cshtml"
       Write(Html.TextBoxFor(x => x.Q, new { @class = "form-control search__criteria-text center", placeholder = "Search..." }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t</div>\r\n\t\t<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t");

            
            #line 15 "..\..\Views\SiteSearch\SiteSearch.cshtml"
       Write(Html.DropDownListFor(x => x.Context, Model.Context, new { @class = "form-control col-xs-12 center" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t</div>\r\n\t\t<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n\t\t\t<input");

WriteLiteral(" class=\"btn btn-primary center\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Search\"");

WriteLiteral(" />\r\n\t\t</div>\r\n\t</div>\r\n");

            
            #line 21 "..\..\Views\SiteSearch\SiteSearch.cshtml"
}

            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\SiteSearch\SiteSearch.cshtml"
 if (Model.SearchResults != null)
{
	int resultNumber = 0;
	if (Model.TotalResults == 0)
	{

            
            #line default
            #line hidden
WriteLiteral("\t\t<h2>No results</h2>\r\n");

            
            #line 28 "..\..\Views\SiteSearch\SiteSearch.cshtml"
	}
	else
	{
		int numberOfResultsToShow = Model.SearchResults.Count();
		string resultsCaption = Model.TotalResults == 1 ? "result" : "results";
		if (numberOfResultsToShow == Model.TotalResults)
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<h2>Showing ");

            
            #line 35 "..\..\Views\SiteSearch\SiteSearch.cshtml"
                   Write(numberOfResultsToShow);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 35 "..\..\Views\SiteSearch\SiteSearch.cshtml"
                                          Write(resultsCaption);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n");

            
            #line 36 "..\..\Views\SiteSearch\SiteSearch.cshtml"
		}
		else
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<h2>Showing ");

            
            #line 39 "..\..\Views\SiteSearch\SiteSearch.cshtml"
                   Write(numberOfResultsToShow);

            
            #line default
            #line hidden
WriteLiteral(" of ");

            
            #line 39 "..\..\Views\SiteSearch\SiteSearch.cshtml"
                                             Write(Model.TotalResults);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 39 "..\..\Views\SiteSearch\SiteSearch.cshtml"
                                                                 Write(resultsCaption);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n");

            
            #line 40 "..\..\Views\SiteSearch\SiteSearch.cshtml"
		}

            
            #line default
            #line hidden
WriteLiteral("\t\t<div");

WriteLiteral(" class=\"search__results\"");

WriteLiteral(">\r\n");

            
            #line 42 "..\..\Views\SiteSearch\SiteSearch.cshtml"
			
            
            #line default
            #line hidden
            
            #line 42 "..\..\Views\SiteSearch\SiteSearch.cshtml"
             foreach (SearchResultWithLink searchResult in Model.SearchResults)
			{
				resultNumber++;

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<dl");

WriteLiteral(" class=\"search__result\"");

WriteLiteral(">\r\n\t\t\t\t\t<dt>\r\n\t\t\t\t\t\t<span");

WriteLiteral(" class=\"search__result-number\"");

WriteLiteral(">");

            
            #line 47 "..\..\Views\SiteSearch\SiteSearch.cshtml"
                                                       Write(resultNumber);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t\t\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 1411), Tuple.Create("\"", 1435)
            
            #line 48 "..\..\Views\SiteSearch\SiteSearch.cshtml"
, Tuple.Create(Tuple.Create("", 1418), Tuple.Create<System.Object, System.Int32>(searchResult.Url
            
            #line default
            #line hidden
, 1418), false)
);

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t\t\t");

            
            #line 49 "..\..\Views\SiteSearch\SiteSearch.cshtml"
                       Write(searchResult.Caption);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</dt>\r\n\t\t\t\t\t<dd>\r\n\t\t\t\t\t\t<ul>\r\n");

            
            #line 54 "..\..\Views\SiteSearch\SiteSearch.cshtml"
							
            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\SiteSearch\SiteSearch.cshtml"
                             foreach (var snippet in searchResult.Snippets)
							{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t\t<li>");

            
            #line 56 "..\..\Views\SiteSearch\SiteSearch.cshtml"
                               Write(Html.Highlight(snippet));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 57 "..\..\Views\SiteSearch\SiteSearch.cshtml"
							}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t</dd>\r\n\t\t\t\t</dl>\r\n");

            
            #line 61 "..\..\Views\SiteSearch\SiteSearch.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\t\t</div>\r\n");

            
            #line 63 "..\..\Views\SiteSearch\SiteSearch.cshtml"
	}
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591