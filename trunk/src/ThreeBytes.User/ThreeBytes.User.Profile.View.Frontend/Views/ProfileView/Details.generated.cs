﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThreeBytes.User.Profile.View.Frontend.Views.ProfileView
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ProfileView/Details.cshtml")]
    public class Details : System.Web.Mvc.WebViewPage<ThreeBytes.User.Profile.View.Entities.UserProfileViewProfile>
    {
        public Details()
        {
        }
        public override void Execute()
        {

WriteLiteral(@"
<div id=""user-profile-details-container"">
    <div id=""user-profile-details-modal"" class=""modal hide fade"">
        <div class=""modal-header"">
            <a href=""#"" class=""close"" data-bind=""click: raiseClose"">×</a>
            <h3>
                <span data-bind=""text:DisplayName""></span> Details
            </h3>
        </div>
        <div class=""modal-body modal-body-scrollable"">
            <div class=""row"">
                <div class=""span12 columns"">
                    <div class=""display-label"">Username</div>
                    <div class=""display-field""><span data-bind=""text:Username""></span></div>

                    <div class=""display-label"">Email</div>
                    <div class=""display-field""><span data-bind=""text:Email""></span></div>
                </div>
            </div>
        </div>
        <div class=""modal-footer"">
            <button class=""btn"" data-bind=""click: raiseEdit"">Edit</button>
        </div>
    </div>
</div>

");


            
            #line 28 "..\..\Views\ProfileView\Details.cshtml"
   
  using (Html.BeginScriptContext())
  {
    Html.AddScriptBlock(@"
        var user_profile_details = {};

        (function (index) {

            user_profile_details = index;

            index.Id = ko.observable();
            index.ItemId = ko.observable();
            index.Username = ko.observable();
            index.ApplicationName = ko.observable();

            index.raiseClose = function () {
                index.detailModal.modal('hide');
            };

            index.raiseEdit = function (obj) {
                index.detailModal.modal('hide');
                jQuery(document).trigger('userProfileEdit', index.ItemId());
            };

            jQuery(document).bind('userProfileDetails', function (event, template) {

                jQuery.getJSON('" + @Url.Action("GetProfile", "Profile") + @"', { id: template.Id() }, function (data) {

                    index.Id(data.Id);
                    index.ItemId(data.ItemId);
                    index.Username(data.Username);
                    index.ApplicationName(data.ApplicationName);

                    index.detailModal.modal('show');
                });
            });

            jQuery(function () {
                ko.applyBindings(index, jQuery('#user-profile-details-container')[0]);
                index.detailModal = jQuery('#user-profile-details-modal').modal({ backdrop: true, closeOnEscape: true, modal: true, show: false });
            });
        } (user_profile_details));");
  }

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591