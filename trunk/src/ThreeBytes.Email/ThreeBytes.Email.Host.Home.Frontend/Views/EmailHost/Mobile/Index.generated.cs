﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThreeBytes.Email.Host.Home.Frontend.Views.EmailHost.Mobile
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using ThreeBytes.Core.Extensions.Mvc;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EmailHost/Mobile/Index.cshtml")]
    public class Index : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Index()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div id=\"home\" data-role=\"page\">\r\n    <div data-role=\"header\">\r\n        <h1>Three" +
" Bytes Email</h1> \r\n    </div>\r\n    <div data-role=\"content\">\r\n        <div clas" +
"s=\"span8 columns\">\r\n");


            
            #line 7 "..\..\Views\EmailHost\Mobile\Index.cshtml"
               Html.RenderAction("MostRecent", "EmailDispatchWidget"); 

            
            #line default
            #line hidden

            
            #line 8 "..\..\Views\EmailHost\Mobile\Index.cshtml"
               Html.RenderAction("MostRecent", "EmailTemplateWidget"); 

            
            #line default
            #line hidden
WriteLiteral(@"        </div>   

	    <a href=""Template"" rel=""external"" data-role=""button"" data-icon=""grid"" data-theme=""a"">Templates</a>
		<a href=""Dispatch"" rel=""external"" data-role=""button"" data-icon=""grid"" data-theme=""a"">Dispatched</a>
        <a href=""Home/About"" rel=""external"" data-role=""button"" data-icon=""info"" data-theme=""a"">About</a>
    </div>
    <div data-role=""footer"">
        <h4>Designed and built by <a href=""http://www.threebytes.co.uk"" target=""_blank"">Three Bytes</a>.</h4>
    </div>
</div>

");


            
            #line 20 "..\..\Views\EmailHost\Mobile\Index.cshtml"
   Html.RenderAction("Details", "EmailDispatchView"); 

            
            #line default
            #line hidden

            
            #line 21 "..\..\Views\EmailHost\Mobile\Index.cshtml"
   Html.RenderAction("Details", "EmailTemplateView"); 

            
            #line default
            #line hidden

            
            #line 22 "..\..\Views\EmailHost\Mobile\Index.cshtml"
   Html.RenderAction("Edit", "EmailTemplateManagement");

            
            #line default
            #line hidden

            
            #line 23 "..\..\Views\EmailHost\Mobile\Index.cshtml"
   Html.RenderAction("Delete", "EmailTemplateManagement");

            
            #line default
            #line hidden
WriteLiteral(@"
<script type=""text/javascript"">

    var home = {};

    (function (index) {

        home = index;

        jQuery(document).bind('home', function () {
            jQuery.mobile.changePage(""#home"", ""flip"", true, false);
        });
    } (home));
</script>");


        }
    }
}
#pragma warning restore 1591