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

namespace ThreeBytes.User.Profile.Management.Frontend.Views.ProfileManagement
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ProfileManagement/Edit.cshtml")]
    public class Edit : System.Web.Mvc.WebViewPage<ThreeBytes.User.Profile.Management.Entities.UserProfileManagementProfile>
    {
        public Edit()
        {
        }
        public override void Execute()
        {

WriteLiteral(@"
<div id=""user-profile-edit-container"">
    <div id=""user-profile-edit-modal"" class=""modal hide fade"">
        <div class=""modal-header"">
            <a href=""#"" class=""close"" data-bind=""click: raiseClose"">×</a>
            <h3>
                <span data-bind=""text:DisplayName""></span> Details
            </h3>
        </div>
        <div class=""modal-body modal-body-scrollable"">
            <div class=""row"">
                <div class=""span12 columns"">
                    <div id=""user-profile-edit-forms-container"">
                        <div data-bind=""error: GeneralErrors""></div>
                        <form id=""update-email-user-profile-form"">
                            <div class=""clearfix"">
                                ");


            
            #line 18 "..\..\Views\ProfileManagement\Edit.cshtml"
                           Write(Html.LabelFor(model => model.Username, "Username"));

            
            #line default
            #line hidden
WriteLiteral(@"
                                <div class=""input""><span data-bind=""text:Username""></span></div>
                                <br />
                            </div>

                            <fieldset>
                                <div class=""clearfix"">
                                    ");


            
            #line 25 "..\..\Views\ProfileManagement\Edit.cshtml"
                               Write(Html.LabelFor(model => model.Email, "Email"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    <div class=\"input\">\r\n                      " +
"                  ");


            
            #line 27 "..\..\Views\ProfileManagement\Edit.cshtml"
                                   Write(Html.TextBoxFor(model => model.Email, new { @data_val = "true", @data_val_required = "'Email' should not be empty.", @data_val_email = "'Email' is not a valid email address.", @data_val_length = "'Email' must be a string with a maximum length of 320.", @data_val_length_max = "320", @data_bind = "value: Email" }));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <button type=""submit"" class=""btn btn-primary"" data-bind=""click: updateEmail"">Update</button> 
                                        <div data-valmsg-for=""Email"" data-valmsg-replace=""true"" data-bind=""error: EmailErrors""></div>
                                    </div>
                                </div>
                            </fieldset>
                        </form>

                        <form id=""rename-user-profile-form"">
                            <fieldset>
                                <div class=""clearfix"">
                                    ");


            
            #line 38 "..\..\Views\ProfileManagement\Edit.cshtml"
                               Write(Html.LabelFor(model => model.Forename, "Forename"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    <div class=\"input\">\r\n                      " +
"                  ");


            
            #line 40 "..\..\Views\ProfileManagement\Edit.cshtml"
                                   Write(Html.TextBoxFor(model => model.Forename, new { @data_val = "true", @data_val_required = "'Forename' should not be empty.", @data_val_length = "'Forename' must be a string with a maximum length of 35.", @data_val_length_max = "35", @data_bind = "value: Forename" }));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""Forename"" data-valmsg-replace=""true"" data-bind=""error: ForenameErrors""></div>
                                    </div>
                                </div>
                                <div class=""clearfix"">
                                    ");


            
            #line 45 "..\..\Views\ProfileManagement\Edit.cshtml"
                               Write(Html.LabelFor(model => model.Surname, "Surname"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    <div class=\"input\">\r\n                      " +
"                  ");


            
            #line 47 "..\..\Views\ProfileManagement\Edit.cshtml"
                                   Write(Html.TextBoxFor(model => model.Surname, new { @data_val = "true", @data_val_required = "'Surname' should not be empty.", @data_val_length = "'Surname' must be a string with a maximum length of 35.", @data_val_length_max = "35", @data_bind = "value: Surname" }));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <button type=""submit"" class=""btn btn-primary"" data-bind=""click: rename"">Update</button> 
                                        <div data-valmsg-for=""Surname"" data-valmsg-replace=""true"" data-bind=""error: SurnameErrors""></div>
                                    </div>
                                </div>
                            </fieldset>
                        </form>
                    </div>
                </div>
            </div>
        </div>
        <div class=""modal-footer"">
            <button class=""btn btn-danger"" data-bind=""click: raiseClose"">Close</button>
        </div>
    </div>
</div>

");


            
            #line 64 "..\..\Views\ProfileManagement\Edit.cshtml"
   
  using (Html.BeginScriptContext())
  {
    Html.AddScriptBlock(@"
        var user_profile_edit = {};

        (function (index) {

            user_profile_edit = index;

            var val = ko.setupValidation([], []);
            val.createErrorCollections({Email: 0, Forename: 0, Surname: 0, General: 0}, index, 'user-profile-edit-forms-container');

            index.Id = ko.observable();
            index.Username = ko.observable();
            index.Email = ko.observable();
            index.Forename = ko.observable(null);
            index.Surname = ko.observable(null);
            index.DisplayName = ko.computed(function(){
                if (isNullOrEmpty(index.Forename())) {
                    return index.Username();
                }

                return index.Forename() + ' ' + index.Surname();
            });

            index.rename = function () {
                if(!jQuery('#rename-user-profile-form').valid())
                    return;

                jQuery.post('" + @Url.Action("Rename", "ProfileManagement") + @"', { 'id': ko.utils.unwrapObservable(index.Id), 'forename': ko.utils.unwrapObservable(index.Forename), 'Surname': ko.utils.unwrapObservable(index.Surname) }, function (dataReturned) {                    
                    if (dataReturned.IsValid) {
                        jQuery(document).trigger('userProfileUpdated', index);
                        index.editModal.modal('hide');
                    }
                    else
                    {
                        val.rebindValidations({Email: 0, Forename: 0, Surname: 0, General: 0}, index, dataReturned.Errors);
                    }
                });
            };

            index.updateEmail = function () {
                if(!jQuery('#update-email-user-profile-form').valid())
                    return;

                jQuery.post('" + @Url.Action("UpdateEmailAddress", "ProfileManagement") + @"', { 'id': index.Id(), 'email': index.Email() }, function (dataReturned) {                    
                    if (dataReturned.IsValid) {
                        jQuery(document).trigger('userProfileUpdated', index);
                        index.editModal.modal('hide');
                    }
                    else
                    {
                        val.rebindValidations({Email: 0, Forename: 0, Surname: 0, General: 0}, index, dataReturned.Errors);
                    }
                });
            };

            index.raiseClose = function () {
                index.editModal.modal('hide');
            };

            jQuery(document).bind('userProfileEdit', function (event) {

                jQuery.getJSON('" + @Url.Action("GetCurrentUserProfile", "ProfileManagement") + @"', function (data) {

                    index.Id(data.Id);
                    index.Username(data.Username);
                    index.Email(data.Email);
                    index.Forename(data.Forename);
                    index.Surname(data.Surname);

                    val.clearValidations({Email: 0, Forename: 0, Surname: 0, General: 0}, index);
                    index.editModal.modal('show');
                });
            });

            jQuery(function () {
                ko.applyBindings(index, jQuery('#user-profile-edit-container')[0]);
                index.editModal = jQuery('#user-profile-edit-modal').modal({ backdrop: true, closeOnEscape: true, modal: true, show: false });
            });
        } (user_profile_edit));");
  }

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591