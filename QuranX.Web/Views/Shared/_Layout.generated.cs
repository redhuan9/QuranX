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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Layout.cshtml")]
    public partial class _Views_Shared__Layout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Layout_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n\t<meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n\t<meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0\"");

WriteLiteral(">\r\n\t<title>");

            
            #line 6 "..\..\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(" - My ASP.NET Application</title>\r\n");

WriteLiteral("\t");

            
            #line 7 "..\..\Views\Shared\_Layout.cshtml"
Write(Styles.Render("~/Content/css"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\t");

            
            #line 8 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/jquery"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\t");

            
            #line 9 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/modernizr"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\t");

            
            #line 10 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/site"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</head>\r\n<body>\r\n\t<div");

WriteLiteral(" class=\"navbar navbar-inverse navbar-fixed-top\"");

WriteLiteral(">\r\n\t\t<div>\r\n\t\t\t<div");

WriteLiteral(" class=\"navbar-header\"");

WriteLiteral(">\r\n\t\t\t\t<button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"navbar-toggle\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-target=\".navbar-collapse\"");

WriteLiteral(">\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n\t\t\t\t</button>\r\n\t\t\t\t<a");

WriteLiteral(" href=\"/1.1\"");

WriteLiteral(" class=\"navbar-brand\"");

WriteLiteral(">QuranX</a>\r\n\t\t\t</div>\r\n\t\t\t<div");

WriteLiteral(" class=\"navbar-collapse collapse\"");

WriteLiteral(">\r\n\t\t\t\t<ul");

WriteLiteral(" class=\"nav navbar-nav\"");

WriteLiteral(">\r\n\t\t\t\t\t<li><a");

WriteLiteral(" href=\"/1.1\"");

WriteLiteral(">Quran</a></li>\r\n\t\t\t\t\t<li>");

            
            #line 26 "..\..\Views\Shared\_Layout.cshtml"
                   Write(Html.RouteLink("Commentaries", "Commentators"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n\t\t\t\t\t<li>");

            
            #line 27 "..\..\Views\Shared\_Layout.cshtml"
                   Write(Html.RouteLink("Hadiths", "HadithCollections"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n\t\t\t\t</ul>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\t<div");

WriteLiteral(" class=\"container-fluid body-content\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t");

            
            #line 33 "..\..\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n\t</div>\r\n\r\n");

WriteLiteral("\t");

            
            #line 36 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/jquery"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\t");

            
            #line 37 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/bootstrap"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\t");

            
            #line 38 "..\..\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
