#pragma checksum "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b4bcf2fa4070a37f1f830cc26e0f12b4bcd1284"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 8 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Boards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Checkout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Newsletter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.PrivateMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Vendors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b4bcf2fa4070a37f1f830cc26e0f12b4bcd1284", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7654b745a4afa95f40d704ba2b1e9f7718148f30", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopMenu_Default : Nop.Web.Framework.Mvc.Razor.NopRazorPage<TopMenuModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Nop.Web.Framework.TagHelpers.Public.ScriptTagHelper __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul class=\"top-menu notmobile\">\r\n    ");
#nullable restore
#line 3 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.HeaderMenuBefore }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
     if (Model.DisplayHomepageMenuItem)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a");
            BeginWriteAttribute("href", " href=\"", 217, "\"", 249, 1);
#nullable restore
#line 6 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 224, Url.RouteUrl("Homepage"), 224, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 6 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                           Write(T("Homepage"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 7 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
     if (!Model.UseAjaxMenu)
    {
        var rootCategories = Model.Categories.Where(x => x.IncludeInTopMenu).ToList();
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
         foreach (var category in rootCategories)
        {
            var categoryLineModel = new TopMenuModel.CategoryLineModel
            {
                Category = category
            };
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
       Write(await Html.PartialAsync("_CategoryLine.TopMenu", categoryLineModel));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                                                                
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
         


    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
     foreach (var topic in Model.Topics)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a");
            BeginWriteAttribute("href", " href=\"", 777, "\"", 837, 1);
#nullable restore
#line 24 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 784, Url.RouteUrl("Topic", new { SeName = topic.SeName }), 784, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                                                       Write(topic.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 25 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
     if (Model.NewProductsEnabled && Model.DisplayNewProductsMenuItem)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a");
            BeginWriteAttribute("href", " href=\"", 961, "\"", 996, 1);
#nullable restore
#line 28 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 968, Url.RouteUrl("NewProducts"), 968, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                              Write(T("Products.NewProducts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 29 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
     if (Model.DisplayProductSearchMenuItem)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a");
            BeginWriteAttribute("href", " href=\"", 1109, "\"", 1146, 1);
#nullable restore
#line 32 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 1116, Url.RouteUrl("ProductSearch"), 1116, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                                Write(T("Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 33 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
     if (Model.DisplayCustomerInfoMenuItem)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a");
            BeginWriteAttribute("href", " href=\"", 1244, "\"", 1280, 1);
#nullable restore
#line 36 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 1251, Url.RouteUrl("CustomerInfo"), 1251, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                               Write(T("Account.MyAccount"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 37 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
     if (Model.BlogEnabled && Model.DisplayBlogMenuItem)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a");
            BeginWriteAttribute("href", " href=\"", 1402, "\"", 1430, 1);
#nullable restore
#line 40 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 1409, Url.RouteUrl("Blog"), 1409, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                       Write(T("Blog"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 41 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
     if (Model.ForumEnabled && Model.DisplayForumsMenuItem)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a");
            BeginWriteAttribute("href", " href=\"", 1542, "\"", 1572, 1);
#nullable restore
#line 44 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 1549, Url.RouteUrl("Boards"), 1549, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 44 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                         Write(T("Forum.Forums"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 45 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
     if (Model.DisplayContactUsMenuItem)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a");
            BeginWriteAttribute("href", " href=\"", 1673, "\"", 1706, 1);
#nullable restore
#line 48 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 1680, Url.RouteUrl("ContactUs"), 1680, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 48 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                            Write(T("ContactUs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 49 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
#nullable restore
#line 50 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.HeaderMenuAfter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>\r\n");
#nullable restore
#line 52 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
  
    var rootCategoriesResponsive = Model.Categories.ToList();
    //name it "Categories" if we have only categories. Otherwise, "Menu"
    var responsiveMenuTitle = Model.HasOnlyCategories ? T("Categories") : T("Menu");

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"menu-toggle\">");
#nullable restore
#line 56 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                        Write(responsiveMenuTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <ul class=\"top-menu mobile\">\r\n        ");
#nullable restore
#line 58 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
   Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.MobHeaderMenuBefore }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 59 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
         if (Model.DisplayHomepageMenuItem)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 2348, "\"", 2380, 1);
#nullable restore
#line 61 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 2355, Url.RouteUrl("Homepage"), 2355, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                               Write(T("Homepage"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 62 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
         if (!Model.UseAjaxMenu)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
             foreach (var category in rootCategoriesResponsive)
            {
                var categoryLineModel = new TopMenuModel.CategoryLineModel
                {
                    Category = category,
                    ResponsiveMobileMenu = true
                };
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
           Write(await Html.PartialAsync("_CategoryLine.TopMenu", categoryLineModel));

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                                                                    
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
             

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
         foreach (var topic in Model.Topics)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 2938, "\"", 2998, 1);
#nullable restore
#line 78 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 2945, Url.RouteUrl("Topic", new { SeName = topic.SeName }), 2945, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 78 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                                                           Write(topic.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 79 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
         if (Model.NewProductsEnabled && Model.DisplayNewProductsMenuItem)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 3138, "\"", 3173, 1);
#nullable restore
#line 82 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 3145, Url.RouteUrl("NewProducts"), 3145, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 82 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                                  Write(T("Products.NewProducts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 83 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
         if (Model.DisplayProductSearchMenuItem)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 3302, "\"", 3339, 1);
#nullable restore
#line 86 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 3309, Url.RouteUrl("ProductSearch"), 3309, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 86 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                                    Write(T("Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 87 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
         if (Model.DisplayCustomerInfoMenuItem)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 3453, "\"", 3489, 1);
#nullable restore
#line 90 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 3460, Url.RouteUrl("CustomerInfo"), 3460, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 90 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                                   Write(T("Account.MyAccount"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 91 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
         if (Model.BlogEnabled && Model.DisplayBlogMenuItem)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 3627, "\"", 3655, 1);
#nullable restore
#line 94 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 3634, Url.RouteUrl("Blog"), 3634, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 94 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                           Write(T("Blog"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 95 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
         if (Model.ForumEnabled && Model.DisplayForumsMenuItem)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 3783, "\"", 3813, 1);
#nullable restore
#line 98 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 3790, Url.RouteUrl("Boards"), 3790, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 98 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                             Write(T("Forum.Forums"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 99 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
         if (Model.DisplayContactUsMenuItem)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 3930, "\"", 3963, 1);
#nullable restore
#line 102 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 3937, Url.RouteUrl("ContactUs"), 3937, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 102 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                                Write(T("ContactUs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 103 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
#nullable restore
#line 104 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
   Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.MobHeaderMenuAfter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n");
#nullable restore
#line 107 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
     if (Model.UseAjaxMenu)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b4bcf2fa4070a37f1f830cc26e0f12b4bcd128431313", async() => {
                WriteLiteral(@"
        $(document).ready(function () {
            $('.menu-toggle').on('click', function () {
                $(this).siblings('.top-menu.mobile').slideToggle('slow');
            });
            var localized_data = {
                AjaxFailure: """);
#nullable restore
#line 115 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                         Write(T("MainMenu.AjaxFailure"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n            };\r\n            mainMenu.init(\'");
#nullable restore
#line 117 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                      Write(Url.RouteUrl("GetCatalogRoot"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\', \'");
#nullable restore
#line 117 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                                         Write(Url.RouteUrl("GetCatalogSubCategories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\', \'ul.top-menu.notmobile\', \'ul.top-menu.mobile\', localized_data);\r\n        });\r\n        ");
            }
            );
            __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper);
#nullable restore
#line 109 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
__Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper.Location = global::Nop.Web.Framework.UI.ResourceLocation.Footer;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-location", __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper.Location, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 120 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"

        Html.AppendScriptParts(ResourceLocation.Footer, "~/js/public.menu.js");

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b4bcf2fa4070a37f1f830cc26e0f12b4bcd128434361", async() => {
                WriteLiteral(@"
            $(document).ready(function () {
                $('.menu-toggle').on('click', function () {
                    $(this).siblings('.top-menu.mobile').slideToggle('slow');
                });
                $('.top-menu.mobile .sublist-toggle').on('click', function () {
                    $(this).siblings('.sublist').slideToggle('slow');
                });
            });
        ");
            }
            );
            __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper);
#nullable restore
#line 126 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"
__Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper.Location = global::Nop.Web.Framework.UI.ResourceLocation.Footer;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-location", __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper.Location, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 136 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Views\Shared\Components\TopMenu\Default.cshtml"

    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopMenuModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
