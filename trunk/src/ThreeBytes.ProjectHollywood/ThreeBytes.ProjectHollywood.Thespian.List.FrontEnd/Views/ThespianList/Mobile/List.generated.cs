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

namespace ThreeBytes.ProjectHollywood.Thespian.List.Frontend.Views.ThespianList.Mobile
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
    using MvcContrib;
    using ThreeBytes.Core.Extensions.Mvc;
    using ThreeBytes.Core.Security.Concrete;
    using ThreeBytes.ProjectHollywood.Thespian.List.Frontend.Models;
    using ThreeBytes.ProjectHollywood.Thespian.List.Resources;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ThespianList/Mobile/List.cshtml")]
    public class List : System.Web.Mvc.WebViewPage<dynamic>
    {
        public List()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div id=\"thespian-list-container\">\r\n    <div class=\"row\">\r\n        <div class=\"sp" +
"an12\">\r\n            <div id=\"thespian-options-container\" data-role=\"collapsible\"" +
" data-theme=\"a\" data-content-theme=\"a\">\r\n                <h3>Filter</h3>\r\n      " +
"          <div data-role=\"controlgroup\">\r\n                    <a href=\"#\" data-r" +
"ole=\"button\" data-bind=\"click: function() { setThespianTypeFilter(\'Artist\') }, c" +
"ss: { \'ui-btn-active\': ThespianTypeFilter() == \'Artist\' }\">Artists</a>\r\n        " +
"            <a href=\"#\" data-role=\"button\" data-bind=\"click: function() { setThe" +
"spianTypeFilter(\'Creative\') }, css: { \'ui-btn-active\': ThespianTypeFilter() == \'" +
"Creative\' }\">Creatives</a>\r\n                </div>\r\n                <div data-ro" +
"le=\"controlgroup\">\r\n                    <a href=\"#\" data-role=\"button\" data-bind" +
"=\"click: function() { setGenderFilter(\'Male\') }, css: { \'ui-btn-active\': GenderF" +
"ilter() == \'Male\' }\">Male</a>\r\n                    <a href=\"#\" data-role=\"button" +
"\" data-bind=\"click: function() { setGenderFilter(\'Female\') }, css: { \'ui-btn-act" +
"ive\': GenderFilter() == \'Female\' }\">Female</a>\r\n                </div>\r\n        " +
"        <div data-role=\"controlgroup\">\r\n                    <a href=\"#\" data-rol" +
"e=\"button\" data-bind=\"click: setAKFilter, css: { \'ui-btn-active\': AToKFilter }\">" +
"A-K</a>\r\n                    <a href=\"#\" data-role=\"button\" data-bind=\"click: se" +
"tLZFilter, css: { \'ui-btn-active\': LToKFilter }\">L-Z</a>\r\n                </div>" +
"\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n       " +
" <div class=\"span12\">\r\n            <div id=\"thespian-filtered-list-container\" da" +
"ta-bind=\"visible: Items().length > 0\">\r\n                <div id=\"thespian-list\" " +
"data-bind=\"foreach: Items\">\r\n                    <a href=\"#\" data-role=\"button\" " +
"data-bind=\"click: $parent.raiseDetails\" data-icon=\"arrow-r\" data-iconpos=\"right\"" +
"><span data-bind=\"fadeInText: FirstName\"></span>&nbsp;<span data-bind=\"fadeInTex" +
"t: LastName\"></span></a>\r\n                </div>\r\n            </div>\r\n        </" +
"div>\r\n    </div>\r\n</div>\r\n");


            
            #line 31 "..\..\Views\ThespianList\Mobile\List.cshtml"
   
    using (Html.BeginScriptContext())
    {
        Html.AddScriptBlock(@"

        var thespian_list  = {};

        (function (index) {

            var hub = jQuery.connection.thespianListHub;
        
            thespian_list = index;

            index.ThespianTypeFilter = ko.observable('Artist');
            index.GenderFilter = ko.observable('Male');
            index.AToKFilter = ko.observable(true);
            index.LToKFilter = ko.observable(false);
            index.Items = ko.observableArray();
            index.GetItems = ko.computed(function() {  
                jQuery.ajax({
                    url: '/OurClients/GetArtists',
                    type: 'GET',
                    data: { 'type': index.ThespianTypeFilter(), 'gender': index.GenderFilter(), 'aToKFilter': index.AToKFilter(), 'lToKFilter': index.LToKFilter() },
                    dataType: 'json',
                    beforeSend: function () { jQuery.mobile.showPageLoadingMsg(); },
                    success: function(data) {
                        index.Items.removeAll();

                        jQuery.each(data.Thespians, function() {
                            index.Items.push(ko.mapping.fromJS(this));
                        });
                    },
                    complete: function() { jQuery.mobile.hidePageLoadingMsg(); }
                });
            }, index);

            index.setGenderFilter = function(gender) {
                index.GenderFilter(gender);
            };

            index.setThespianTypeFilter = function(type) {
                index.ThespianTypeFilter(type);
            };

            index.setAKFilter = function() {
                index.AToKFilter(true);
                index.LToKFilter(false);
            };

            index.setLZFilter = function() {
                index.AToKFilter(false);
                index.LToKFilter(true);
            };
        
            index.raiseDetails = function (obj) {
                jQuery(document).trigger('thespianDetails', [obj]);
            };

            hub.handleCreatedThespianEventMessage = function(message) {
                var exists = ko.utils.arrayFirst(index.Items(), function(item) {
                    return item.Id() == message.Id;
                });

                if (exists != null)
                    return;

                jQuery.getJSON('/OurClients/GetArtists', { 'type': index.ThespianTypeFilter(), 'gender': index.GenderFilter(), 'aToKFilter': index.AToKFilter(), 'lToKFilter': index.LToKFilter() }, function(data) {
                    
                    index.Items.removeAll();

                    jQuery.each(data.Thespians, function() {
                        index.Items.push(ko.mapping.fromJS(this));
                    });
                });
            };

            hub.handleRenamedThespianEventMessage = function(id, newFirstName, newLastName) {
                var update = ko.utils.arrayFirst(index.Items(), function(item) {
                    return item.Id() == id;
                });

                if (update == null)
                    return;

                ko.bindingHandlers.fadeInText.highlight = true;

                if (update.FirstName() != newFirstName)
                    update.FirstName(newFirstName);

                if (update.LastName() != newLastName)
                    update.LastName(newLastName);

                ko.bindingHandlers.fadeInText.highlight = false;
            };

            hub.handleDeletedThespianEventMessage = function(id) {
                var toDelete = ko.utils.arrayFirst(index.Items(), function(item) {
                    return item.Id() == id;
                });

                if (toDelete == null)
                    return;

                index.Items.remove(toDelete);
            };

            jQuery(function() {
                ko.applyBindings(index, jQuery('#thespian-list-container')[0]);
            });

        } (thespian_list));");
    }


            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591