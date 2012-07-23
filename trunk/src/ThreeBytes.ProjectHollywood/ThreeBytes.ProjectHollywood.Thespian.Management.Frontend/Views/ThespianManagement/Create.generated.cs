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

namespace ThreeBytes.ProjectHollywood.Thespian.Management.Frontend.Views.ThespianManagement
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
    using MvcContrib;
    using ThreeBytes.Core.Extensions.Mvc;
    using ThreeBytes.Core.Security.Concrete;
    using ThreeBytes.ProjectHollywood.Thespian.Management.Resources;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ThespianManagement/Create.cshtml")]
    public class Create : System.Web.Mvc.WebViewPage<ThreeBytes.ProjectHollywood.Thespian.Management.Entities.ThespianManagementThespian>
    {
        public Create()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n");


            
            #line 3 "..\..\Views\ThespianManagement\Create.cshtml"
 if (Context.User.Identity.IsAuthenticated && ((ThreeBytesPrincipal)Context.User).IsInAnyRoles(new[] { "Creator", "Admin", "ThespianManager" }))
{

            
            #line default
            #line hidden
WriteLiteral("    <div id=\"create-thespian-container\">\r\n        <p>\r\n            <button class=" +
"\"btn btn-primary\" data-bind=\"click: raiseCreate\" rel = \"popover\" data_content =\"" +
"");


            
            #line 7 "..\..\Views\ThespianManagement\Create.cshtml"
                                                                                                     Write(Resources.CreatePopoverContent);

            
            #line default
            #line hidden
WriteLiteral("\" data_original_title =\"");


            
            #line 7 "..\..\Views\ThespianManagement\Create.cshtml"
                                                                                                                                                            Write(Resources.CreatePopoverTitle);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 7 "..\..\Views\ThespianManagement\Create.cshtml"
                                                                                                                                                                                           Write(Resources.Create);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n        </p>\r\n        <div id=\"create-thespian-modal\" class=\"modal mod" +
"al-medium-wide hide fade\">\r\n            <div class=\"modal-header\">\r\n            " +
"    <a href=\"#\" class=\"close\" data-bind=\"click: raiseClose\">×</a>\r\n             " +
"   <h3>");


            
            #line 12 "..\..\Views\ThespianManagement\Create.cshtml"
               Write(Resources.CreateTemplate);

            
            #line default
            #line hidden
WriteLiteral(@"</h3>
            </div>
            <div class=""modal-body modal-body-scrollable"">
                <div data-bind=""error: GeneralErrors""></div>
                <form id=""create-thespian-form"" enctype=""multipart/form-data"" method=""post"">
                    <fieldset>
                        <div class=""row"">
                            <div class=""span3 columns"">
                                <div class=""clearfix""> 
                                    ");


            
            #line 21 "..\..\Views\ThespianManagement\Create.cshtml"
                               Write(Html.LabelFor(model => model.FirstName, Resources.FirstName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        \r\n                                    <div class=\"input input-small-mar" +
"gin\">\r\n                                        ");


            
            #line 24 "..\..\Views\ThespianManagement\Create.cshtml"
                                   Write(Html.TextBoxFor(model => model.FirstName, new { @data_val = "true", @data_val_required = "'First Name' should not be empty.", @data_val_length = "'First Name' must be a string with a maximum length of 35.", @data_val_length_max = "35", @data_bind = "value: FirstName" }));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""FirstName"" data-valmsg-replace=""true"" data-bind=""error: FirstNameErrors""></div>
                                    </div>
                                </div>

                                <div class=""clearfix"">
                                    ");


            
            #line 30 "..\..\Views\ThespianManagement\Create.cshtml"
                               Write(Html.LabelFor(model => model.LastName, Resources.LastName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        \r\n                                    <div class=\"input input-small-mar" +
"gin\">\r\n                                        ");


            
            #line 33 "..\..\Views\ThespianManagement\Create.cshtml"
                                   Write(Html.TextBoxFor(model => model.LastName, new { @data_val = "true", @data_val_required = "'Last Name' should not be empty.", @data_val_length = "'Last Name' must be a string with a maximum length of 35.", @data_val_length_max = "35", @data_bind = "value: LastName" }));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""LastName"" data-valmsg-replace=""true"" data-bind=""error: LastNameErrors""></div>
                                    </div>
                                </div>

                                <div class=""clearfix image"">
                                    <label for=""thespian-profile-image"">Profile Image <input type=""file"" id=""thespian-profile-image"" name=""thespian-profile-image"" /></label>
                                    <div data-bind=""error: ProfileImageLocationErrors""></div>
                                    <span class=""label label-success"" data-bind=""visible: HasImageBeenUploaded"">Upload Success</span>

                                    <div data-valmsg-for=""ProfileImageLocation"" data-valmsg-replace=""true"" data-bind=""error: ProfileImageLocationErrors""></div>
                                    <input type=""hidden"" id=""ProfileImageLocation"" name=""ProfileImageLocation"" data-bind = ""value: ProfileImageLocation"" />
                                    <input type=""hidden"" id=""ProfileThumbnailImageLocation"" name=""ProfileThumbnailImageLocation"" data-bind = ""value: ProfileThumbnailImageLocation"" />
                                </div>

                                <div class=""clearfix"">
                                    ");


            
            #line 49 "..\..\Views\ThespianManagement\Create.cshtml"
                               Write(Html.LabelFor(model => model.Email, "Email"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        \r\n                                    <div class=\"input input-small-mar" +
"gin\">\r\n                                        ");


            
            #line 52 "..\..\Views\ThespianManagement\Create.cshtml"
                                   Write(Html.TextBoxFor(model => model.Email, new { @data_val = "true", @data_val_required = "'Email' should not be empty.", @data_val_email = "'Email' is not a valid email address.", @data_val_length = "'Email' must be a string with a maximum length of 320.", @data_val_length_max = "320", @data_bind = "value: Email" }));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""Email"" data-valmsg-replace=""true"" data-bind=""error: EmailErrors""></div>
                                    </div>
                                </div>
                            </div>
                            <div class=""span3 columns"">
                                <div id=""thespian-profile-image-container"">
                                    <ul class=""thumbnails"">
                                        <li class=""span3"">
                                            <div class=""thumbnail"">
                                                <img data-bind=""attr: { src: ProfileImageUrl() }"" />
                                                <div class=""caption""></div>
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div>
                            <div class=""columns"">
                                <div class=""clearfix"">
                                    ");


            
            #line 73 "..\..\Views\ThespianManagement\Create.cshtml"
                               Write(Html.LabelFor(model => model.LastName, Resources.DateOfBirth));

            
            #line default
            #line hidden
WriteLiteral("\r\n        \r\n                                    <div class=\"input input-small-mar" +
"gin\">\r\n                                        ");


            
            #line 76 "..\..\Views\ThespianManagement\Create.cshtml"
                                   Write(Html.TextBoxFor(model => model.DateOfBirth, new { @data_bind = "value: DateOfBirth" }));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""DateOfBirth"" data-valmsg-replace=""true"" data-bind=""error: DateOfBirthErrors""></div>
                                    </div>
                                </div>  

                                <div class=""clearfix"">
                                    ");


            
            #line 82 "..\..\Views\ThespianManagement\Create.cshtml"
                               Write(Html.LabelFor(model => model.Gender, Resources.Gender));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    <div class=\"input input-small-margin\">\r\n   " +
"                                     ");


            
            #line 84 "..\..\Views\ThespianManagement\Create.cshtml"
                                   Write(Html.EnumDropDownListFor(model => model.Gender));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""Gender"" data-valmsg-replace=""true"" data-bind=""error: GenderErrors""></div>
                                    </div>
                                </div>

                                <div class=""clearfix"">
                                    ");


            
            #line 90 "..\..\Views\ThespianManagement\Create.cshtml"
                               Write(Html.LabelFor(model => model.Location, Resources.Location));

            
            #line default
            #line hidden
WriteLiteral("\r\n        \r\n                                    <div class=\"input input-small-mar" +
"gin\">\r\n                                        ");


            
            #line 93 "..\..\Views\ThespianManagement\Create.cshtml"
                                   Write(Html.TextBoxFor(model => model.Location, new { @data_val_length = "'Location' must be a string with a maximum length of 200.", @data_val_length_max = "200", @data_bind = "value: Location" }));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""Location"" data-valmsg-replace=""true"" data-bind=""error: LocationErrors""></div>
                                    </div>
                                </div>

                                <div class=""clearfix"">
                                    ");


            
            #line 99 "..\..\Views\ThespianManagement\Create.cshtml"
                               Write(Html.LabelFor(model => model.Height, Resources.Height));

            
            #line default
            #line hidden
WriteLiteral("\r\n        \r\n                                    <div class=\"input input-small-mar" +
"gin\">\r\n                                        ");


            
            #line 102 "..\..\Views\ThespianManagement\Create.cshtml"
                                   Write(Html.TextBoxFor(model => model.Height, new { @data_bind = "value: Height" }));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""Height"" data-valmsg-replace=""true"" data-bind=""error: HeightErrors""></div>
                                    </div>
                                </div>

                                <div class=""clearfix"">
                                    ");


            
            #line 108 "..\..\Views\ThespianManagement\Create.cshtml"
                               Write(Html.LabelFor(model => model.Weight, Resources.Weight));

            
            #line default
            #line hidden
WriteLiteral("\r\n        \r\n                                    <div class=\"input input-small-mar" +
"gin\">\r\n                                        ");


            
            #line 111 "..\..\Views\ThespianManagement\Create.cshtml"
                                   Write(Html.TextBoxFor(model => model.Weight, new { @data_bind = "value: Weight" }));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""Weight"" data-valmsg-replace=""true"" data-bind=""error: WeightErrors""></div>
                                    </div>
                                </div>

                                <div class=""clearfix"">
                                    ");


            
            #line 117 "..\..\Views\ThespianManagement\Create.cshtml"
                               Write(Html.LabelFor(model => model.PlayingAge, Resources.PlayingAge));

            
            #line default
            #line hidden
WriteLiteral("\r\n        \r\n                                    <div class=\"input input-small-mar" +
"gin\">\r\n                                        ");


            
            #line 120 "..\..\Views\ThespianManagement\Create.cshtml"
                                   Write(Html.TextBoxFor(model => model.PlayingAge, new { @data_bind = "value: PlayingAge" }));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""PlayingAge"" data-valmsg-replace=""true"" data-bind=""error: PlayingAgeErrors""></div>
                                    </div>
                                </div>

                                <div class=""clearfix"">
                                    ");


            
            #line 126 "..\..\Views\ThespianManagement\Create.cshtml"
                               Write(Html.LabelFor(model => model.EyeColour, Resources.EyeColour));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    <div class=\"input input-small-margin\">\r\n   " +
"                                     ");


            
            #line 128 "..\..\Views\ThespianManagement\Create.cshtml"
                                   Write(Html.EnumDropDownListFor(model => model.EyeColour));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""EyeColour"" data-valmsg-replace=""true"" data-bind=""error: EyeColourErrors""></div>
                                    </div>
                                </div>

                                <div class=""clearfix"">
                                    ");


            
            #line 134 "..\..\Views\ThespianManagement\Create.cshtml"
                               Write(Html.LabelFor(model => model.HairLength, Resources.HairLength));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    <div class=\"input input-small-margin\">\r\n   " +
"                                     ");


            
            #line 136 "..\..\Views\ThespianManagement\Create.cshtml"
                                   Write(Html.EnumDropDownListFor(model => model.HairLength));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""HairLength"" data-valmsg-replace=""true"" data-bind=""error: HairLengthErrors""></div>
                                    </div>
                                </div>

                                <div class=""clearfix"">
                                    ");


            
            #line 142 "..\..\Views\ThespianManagement\Create.cshtml"
                               Write(Html.LabelFor(model => model.Summary, Resources.Summary));

            
            #line default
            #line hidden
WriteLiteral("\r\n        \r\n                                    <div class=\"input input-small-mar" +
"gin\">\r\n                                        ");


            
            #line 145 "..\..\Views\ThespianManagement\Create.cshtml"
                                   Write(Html.TextAreaFor(model => model.Summary, new { @data_bind = "value: Summary" }));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""Summary"" data-valmsg-replace=""true"" data-bind=""error: SummaryErrors""></div>
                                    </div>
                                </div>

                                <div class=""clearfix"">
                                    ");


            
            #line 151 "..\..\Views\ThespianManagement\Create.cshtml"
                               Write(Html.LabelFor(model => model.Twitter, Resources.Twitter));

            
            #line default
            #line hidden
WriteLiteral("\r\n        \r\n                                    <div class=\"input input-small-mar" +
"gin\">\r\n                                        ");


            
            #line 154 "..\..\Views\ThespianManagement\Create.cshtml"
                                   Write(Html.TextBoxFor(model => model.Twitter, new { data_val_length = "'Twitter' must be a string with a maximum length of 20.", @data_val_length_max = "20", @data_bind = "value: Twitter" }));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""Twitter"" data-valmsg-replace=""true"" data-bind=""error: TwitterErrors""></div>
                                    </div>
                                </div>

                                <div class=""clearfix"">
                                    ");


            
            #line 160 "..\..\Views\ThespianManagement\Create.cshtml"
                               Write(Html.LabelFor(model => model.Facebook, Resources.Facebook));

            
            #line default
            #line hidden
WriteLiteral("\r\n        \r\n                                    <div class=\"input input-small-mar" +
"gin\">\r\n                                        ");


            
            #line 163 "..\..\Views\ThespianManagement\Create.cshtml"
                                   Write(Html.TextBoxFor(model => model.Facebook, new { data_val_length = "'Facebook' must be a string with a maximum length of 255.", @data_val_length_max = "255", @data_bind = "value: Facebook" }));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""Facebook"" data-valmsg-replace=""true"" data-bind=""error: FacebookErrors""></div>
                                    </div>
                                </div>

                                <div class=""clearfix"">
                                    ");


            
            #line 169 "..\..\Views\ThespianManagement\Create.cshtml"
                               Write(Html.LabelFor(model => model.Spotlight, Resources.Spotlight));

            
            #line default
            #line hidden
WriteLiteral("\r\n        \r\n                                    <div class=\"input input-small-mar" +
"gin\">\r\n                                        ");


            
            #line 172 "..\..\Views\ThespianManagement\Create.cshtml"
                                   Write(Html.TextBoxFor(model => model.Spotlight, new { data_val_length = "'Spotlight' must be a string with a maximum length of 255.", @data_val_length_max = "255", @data_bind = "value: Spotlight" }));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""Spotlight"" data-valmsg-replace=""true"" data-bind=""error: SpotlightErrors""></div>
                                    </div>
                                </div>

                                <div class=""clearfix"">
                                    ");


            
            #line 178 "..\..\Views\ThespianManagement\Create.cshtml"
                               Write(Html.LabelFor(model => model.Imdb, Resources.Imdb));

            
            #line default
            #line hidden
WriteLiteral("\r\n        \r\n                                    <div class=\"input input-small-mar" +
"gin\">\r\n                                        ");


            
            #line 181 "..\..\Views\ThespianManagement\Create.cshtml"
                                   Write(Html.TextBoxFor(model => model.Imdb, new { data_val_length = "'Imdb' must be a string with a maximum length of 255.", @data_val_length_max = "255", @data_bind = "value: Imdb" }));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""Imdb"" data-valmsg-replace=""true"" data-bind=""error: ImdbErrors""></div>
                                    </div>
                                </div>

                                <div class=""clearfix"">
                                    ");


            
            #line 187 "..\..\Views\ThespianManagement\Create.cshtml"
                               Write(Html.LabelFor(model => model.ThespianType, Resources.ThespianType));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    <div class=\"input input-small-margin\">\r\n   " +
"                                     ");


            
            #line 189 "..\..\Views\ThespianManagement\Create.cshtml"
                                   Write(Html.EnumDropDownListFor(model => model.ThespianType));

            
            #line default
            #line hidden
WriteLiteral(@"
                                        <div data-valmsg-for=""ThespianType"" data-valmsg-replace=""true"" data-bind=""error: ThespianTypeErrors""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </fieldset>
                </form>
            </div>
            <div class=""modal-footer"">
                <button type=""submit"" class=""btn btn-primary"" data-bind=""click: save"">");


            
            #line 199 "..\..\Views\ThespianManagement\Create.cshtml"
                                                                                 Write(Resources.SaveChanges);

            
            #line default
            #line hidden
WriteLiteral("</button>&nbsp;\r\n                <button type=\"submit\" class=\"btn btn-danger\" dat" +
"a-bind=\"click: raiseClose\">");


            
            #line 200 "..\..\Views\ThespianManagement\Create.cshtml"
                                                                                      Write(Resources.Cancel);

            
            #line default
            #line hidden
WriteLiteral("</button>&nbsp;\r\n            </div>\r\n        </div>\r\n    </div>\r\n");


            
            #line 204 "..\..\Views\ThespianManagement\Create.cshtml"

    using (Html.BeginScriptContext())
    {
        Html.AddScriptBlock(@"
        var thespian_create = {};

        (function (index) {

            thespian_create = index;

            index.FirstName = ko.observable();
            index.LastName = ko.observable();
            index.ProfileImageLocation = ko.observable();
            index.ProfileThumbnailImageLocation = ko.observable();
            index.Email = ko.observable();
            index.DateOfBirth = ko.observable();
            index.Gender = ko.observable();
            index.Location = ko.observable();
            index.Height = ko.observable();
            index.Weight = ko.observable();
            index.PlayingAge = ko.observable();
            index.EyeColour = ko.observable();
            index.HairLength = ko.observable();
            index.Summary = ko.observable();
            index.Twitter = ko.observable();
            index.Facebook = ko.observable();
            index.Spotlight = ko.observable();
            index.Imdb = ko.observable();
            index.ThespianType = ko.observable();

            index.HasImageBeenUploaded = ko.observable(false);

            index.ProfileImageUrl = ko.computed(function() {
                return index.HasImageBeenUploaded() ? '" + @Url.Action("GetProfileImage", "OurClients") + @"' + '/' + index.ProfileThumbnailImageLocation() : '" + @Url.Content("img/placeholder260x180.gif") + @"';;
            });

            var val = ko.setupValidation([], []);
            val.createErrorCollections({
                            FirstName: 0, 
                            LastName: 0,
                            ProfileImageLocation: 0,
                            Email: 0, 
                            DateOfBirth: 0, 
                            Gender: 0, 
                            Location: 0, 
                            Height: 0, 
                            Weight: 0,
                            PlayingAge: 0, 
                            EyeColour: 0, 
                            HairLength: 0, 
                            Summary: 0, 
                            Twitter: 0, 
                            Facebook: 0, 
                            Spotlight: 0, 
                            Imdb: 0, 
                            ThespianType: 0,
                            General: 0
                        }, index, 'create-thespian-form');

            index.toJS = function() {
                return {
                        FirstName: index.FirstName() == null ? '' : index.FirstName(), 
                        LastName: index.LastName() == null ? '' : index.LastName(), 
                        ProfileImageLocation: index.ProfileImageLocation() == null ? '' : index.ProfileImageLocation(),
                        ProfileThumbnailImageLocation: index.ProfileThumbnailImageLocation() == null ? '' : index.ProfileThumbnailImageLocation(), 
                        Email: index.Email() == null ? '' : index.Email(), 
                        DateOfBirth: index.DateOfBirth() == null ? '' : index.DateOfBirth(), 
                        Gender: index.Gender() == null ? '' : index.Gender(),
                        Location: index.Location() == null ? '' : index.Location(), 
                        Height: index.Height() == null ? '' : index.Height(), 
                        Weight: index.Weight() == null ? '' : index.Weight(),
                        PlayingAge: index.PlayingAge() == null ? '' : index.PlayingAge(), 
                        EyeColour: index.EyeColour() == null ? '' : index.EyeColour(), 
                        HairLength: index.HairLength() == null ? '' : index.HairLength(), 
                        Summary: index.Summary() == null ? '' : index.Summary(), 
                        Twitter: index.Twitter() == null ? '' : index.Twitter(), 
                        Facebook: index.Facebook() == null ? '' : index.Facebook(), 
                        Spotlight: index.Spotlight() == null ? '' : index.Spotlight(), 
                        Imdb: index.Imdb() == null ? '' : index.Imdb(), 
                        ThespianType: index.ThespianType() == null ? '' : index.ThespianType()
                }
            }

            index.raiseCreate = function () {
                index.clear();
                index.createModal.modal('show');
            };

            index.raiseClose = function () {
                index.createModal.modal('hide');
            };

            index.save = function (form) {
                if(!jQuery('#create-thespian-form').valid())
                    return;

                jQuery.post('" + @Url.Action("Create", "OurClients") + @"', index.toJS(), function (dataReturned) {
                    if (dataReturned.IsValid) {
                        jQuery(document).trigger('actorCreated');
                        jQuery(document).trigger('publishProcessingNotification', ['Processing client creation.', 'We are currently processing your request to create ' + index.FirstName() + ' ' + index.LastName() + '.']);
                        index.createModal.modal('hide');
                    }
                    else {
                        val.rebindValidations({
                            FirstName: 0, 
                            LastName: 0, 
                            ProfileImageLocation: 0,
                            Email: 0, 
                            DateOfBirth: 0, 
                            Gender: 0, 
                            Location: 0, 
                            Height: 0, 
                            Weight: 0,
                            PlayingAge: 0, 
                            EyeColour: 0, 
                            HairLength: 0, 
                            Summary: 0, 
                            Twitter: 0, 
                            Facebook: 0, 
                            Spotlight: 0, 
                            Imdb: 0, 
                            ThespianType: 0,
                            General: 0
                        }, index, dataReturned.Errors);
                    }
                });
            };

            index.clear = function() {
                index.FirstName(null);
                index.LastName(null);
                index.ProfileImageLocation(null);
                index.ProfileThumbnailImageLocation(null);
                index.Email(null);
                index.DateOfBirth(null);
                index.Gender(null);
                index.Location(null);
                index.Height(null);
                index.Weight(null);
                index.PlayingAge(null);
                index.EyeColour(null);
                index.HairLength(null);
                index.Summary(null);
                index.Twitter(null);
                index.Facebook(null);
                index.Spotlight(null);
                index.Imdb(null);
                index.ThespianType(null);
                
                index.HasImageBeenUploaded(false);

                val.clearValidations({
                            FirstName: 0, 
                            LastName: 0,
                            ProfileImageLocation: 0,
                            Email: 0, 
                            DateOfBirth: 0, 
                            Gender: 0, 
                            Location: 0, 
                            Height: 0, 
                            Weight: 0,
                            PlayingAge: 0, 
                            EyeColour: 0, 
                            HairLength: 0, 
                            Summary: 0, 
                            Twitter: 0, 
                            Facebook: 0, 
                            Spotlight: 0, 
                            Imdb: 0, 
                            ThespianType: 0,
                            General: 0
                        }, index);
            };

            jQuery(function () {
                jQuery('#thespian-profile-image').makeAsyncUploader({
                    upload_url: '" + @Url.Action("ImageUpload", "Home") + @"',
                    flash_url: '" + @Url.Content("~/js/libs/swfupload.swf") + @"',
                    button_image_url: '" + @Url.Content("~/img/blankButton.png") + @"',
	                file_types : '*.jpg;*.jpeg;*.png;*.bmp;*.gif',
                    upload_success_handler: function(file, data, response) {
                        var item = jQuery.parseJSON(data);                        

                        if (item.Result.IsValid) {
                            index.ProfileImageLocation(item.Filename);
                            index.ProfileThumbnailImageLocation(item.ThumbnailName);
                            index.HasImageBeenUploaded(true);
                        }
                        else {
                            val.rebindValidations({
                                ProfileImageLocation: 0,
                                General: 0
                            }, index, item.Result.Errors);
                        }
                    }
                });

                ko.applyBindings(index, jQuery('#create-thespian-container')[0]);
                index.createModal = jQuery('#create-thespian-modal').modal({ backdrop: true, closeOnEscape: true, modal: true, show: false });
            });

        } (thespian_create));
    ");
    }
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591