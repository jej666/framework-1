﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThreeBytes.User.DashBoard.LoginStatisticsMonthly.Frontend.Views.LoginStatisticsMonthly
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
    using System.Web.Script.Serialization;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using ThreeBytes.Core.Extensions.Mvc;
    using ThreeBytes.User.DashBoard.LoginStatisticsMonthly.Frontend.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/LoginStatisticsMonthly/MonthlyStatistic.cshtml")]
    public class MonthlyStatistic : System.Web.Mvc.WebViewPage<LoginStatisticViewModel>
    {
        public MonthlyStatistic()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n<div id=\"monthly-login-statistic-container\" class=\"stat\">\t\t\t\t\t\t\t\t\r\n    <h4>Uniq" +
"ue <span data-bind=\"text: plural\"></span> This Month</h4>\r\n    <span class=\"valu" +
"e\">");


            
            #line 5 "..\..\Views\LoginStatisticsMonthly\MonthlyStatistic.cshtml"
                   Write(Model.CurrentStatistic);

            
            #line default
            #line hidden
WriteLiteral("</span>\t\t\t\t\t\t\t\t\r\n</div>\r\n\r\n");


            
            #line 8 "..\..\Views\LoginStatisticsMonthly\MonthlyStatistic.cshtml"
   
  using (Html.BeginScriptContext())
  {
    Html.AddScriptBlock(@"
        var monthly_login_statistic  = {};
    
        (function (index) {
        
            monthly_login_statistic = index = ko.mapping.fromJS(" + @Html.Raw(new JavaScriptSerializer().Serialize(Model)) + @");

            index.plural = ko.dependentObservable(function () {
                return index.CurrentStatistic() == 1 ? 'Login' : 'Logins';
            }, index);

            jQuery(function() {
                ko.applyBindings(index, jQuery('#monthly-login-statistic-container')[0]);
            });     

        } (monthly_login_statistic));");
  }

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591