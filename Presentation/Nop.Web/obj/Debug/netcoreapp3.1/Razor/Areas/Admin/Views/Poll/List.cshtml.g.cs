#pragma checksum "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\Poll\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c475ada5de9dfed73c8b2397b53fa8bdbb447d4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Poll_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Poll/List.cshtml")]
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
#line 7 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Services.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Affiliates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ExternalAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Forums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins.Marketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Reports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Shipping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Templates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c475ada5de9dfed73c8b2397b53fa8bdbb447d4d", @"/Areas/Admin/Views/Poll/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9afeeb77ddd3a4a2e0698ab1d31f0fa32cb5e81", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Poll_List : Nop.Web.Framework.Mvc.Razor.NopRazorPage<PollSearchModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-blue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopSelectTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\Poll\List.cshtml"
  
    //page title
    ViewBag.PageTitle = T("Admin.ContentManagement.Polls").Text;
    //active menu item (system name)
    Html.SetActiveMenuItemSystemName("Polls");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\Poll\List.cshtml"
  
    const string hideSearchBlockAttributeName = "PollsPage.HideSearchBlock";
    var hideSearchBlock = genericAttributeService.GetAttribute<bool>(workContext.CurrentCustomer, hideSearchBlockAttributeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-header clearfix\">\r\n    <h1 class=\"pull-left\">\r\n        ");
#nullable restore
#line 17 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\Poll\List.cshtml"
   Write(T("Admin.ContentManagement.Polls"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    <div class=\"pull-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c475ada5de9dfed73c8b2397b53fa8bdbb447d4d14781", async() => {
                WriteLiteral("\r\n            <i class=\"fa fa-plus-square\"></i>\r\n            ");
#nullable restore
#line 22 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\Poll\List.cshtml"
       Write(T("Admin.Common.AddNew"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
#nullable restore
#line 24 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\Poll\List.cshtml"
   Write(await Component.InvokeAsync("AdminWidget", new { widgetZone = AdminWidgetZones.PollListButtons }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"content\">\r\n    <div class=\"form-horizontal\">\r\n        <div class=\"panel-group\">\r\n\r\n");
            WriteLiteral("            <div class=\"panel panel-default panel-search\" ");
#nullable restore
#line 33 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\Poll\List.cshtml"
                                                      Write(Model.HideStoresList ? Html.Raw("style=\"display:none\"") : null);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                <div class=\"panel-body\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 1222, "\"", 1280, 3);
            WriteAttributeValue("", 1230, "row", 1230, 3, true);
            WriteAttributeValue(" ", 1233, "search-row", 1234, 11, true);
#nullable restore
#line 35 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\Poll\List.cshtml"
WriteAttributeValue(" ", 1244, !hideSearchBlock ? "opened" : "", 1245, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-hideAttribute=\"");
#nullable restore
#line 35 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\Poll\List.cshtml"
                                                                                                   Write(hideSearchBlockAttributeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <div class=\"search-text\">");
#nullable restore
#line 36 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\Poll\List.cshtml"
                                            Write(T("Admin.Common.Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        <div class=""icon-search""><i class=""fa fa-search"" aria-hidden=""true""></i></div>
                        <div class=""icon-collapse""><i class=""fa fa-angle-down"" aria-hidden=""true""></i></div>
                    </div>

                    <div");
            BeginWriteAttribute("class", " class=\"", 1685, "\"", 1739, 2);
            WriteAttributeValue("", 1693, "search-body", 1693, 11, true);
#nullable restore
#line 41 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\Poll\List.cshtml"
WriteAttributeValue(" ", 1704, hideSearchBlock ? "closed" : "", 1705, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <div class=""col-md-4"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c475ada5de9dfed73c8b2397b53fa8bdbb447d4d19461", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 46 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\Poll\List.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchStoreId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c475ada5de9dfed73c8b2397b53fa8bdbb447d4d21058", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopSelectTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper);
#nullable restore
#line 49 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\Poll\List.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchStoreId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 49 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\Poll\List.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.Items = Model.AvailableStores;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""col-md-8 col-md-offset-4"">
                                        <button type=""button"" id=""search-poll"" class=""btn btn-primary btn-search"">
                                            <i class=""fa fa-search""></i>
                                            ");
#nullable restore
#line 56 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\Poll\List.cshtml"
                                       Write(T("Admin.Common.Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""panel panel-default"">
                <div class=""panel-body"">
                    ");
#nullable restore
#line 68 "D:\ASP\nopEcommerce\Presentation\Nop.Web\Areas\Admin\Views\Poll\List.cshtml"
               Write(await Html.PartialAsync("Table", new DataTablesModel
                    {
                        Name = "polls-grid",
                        UrlRead = new DataUrl("List", "Poll", null),
                        SearchButtonId = "search-poll",
                        Length = Model.PageSize,
                        LengthMenu = Model.AvailablePageSizes,
                        Filters = new List<FilterParameter>
                        {
                            new FilterParameter(nameof(Model.SearchStoreId))
                        },
                        ColumnCollection = new List<ColumnProperty>
                        {
                            new ColumnProperty(nameof(PollModel.Name))
                            {
                                Title = T("Admin.ContentManagement.Polls.Fields.Name").Text
                            },
                            new ColumnProperty(nameof(PollModel.LanguageName))
                            {
                                Title = T("Admin.ContentManagement.Polls.Fields.Language").Text,
                                Width = "100"
                            },
                            new ColumnProperty(nameof(PollModel.DisplayOrder))
                            {
                                Title = T("Admin.ContentManagement.Polls.Fields.DisplayOrder").Text,
                                Width = "100",
                                ClassName =  NopColumnClassDefaults.CenterAll
                            },
                            new ColumnProperty(nameof(PollModel.Published))
                            {
                                Title = T("Admin.ContentManagement.Polls.Fields.Published").Text,
                                Width = "100",
                                ClassName =  NopColumnClassDefaults.CenterAll,
                                Render = new RenderBoolean()
                            },
                            new ColumnProperty(nameof(PollModel.ShowOnHomepage))
                            {
                                Title = T("Admin.ContentManagement.Polls.Fields.ShowOnHomepage").Text,
                                Width = "100",
                                ClassName =  NopColumnClassDefaults.CenterAll,
                                Render = new RenderBoolean()
                            },
                            new ColumnProperty(nameof(PollModel.StartDateUtc))
                            {
                                Title = T("Admin.ContentManagement.Polls.Fields.StartDate").Text,
                                Width = "150",
                                Render = new RenderDate()
                            },
                            new ColumnProperty(nameof(PollModel.EndDateUtc))
                            {
                                Title = T("Admin.ContentManagement.Polls.Fields.EndDate").Text,
                                Width = "150",
                                Render = new RenderDate()
                            },
                            new ColumnProperty(nameof(PollModel.Id))
                            {
                                Title = T("Admin.Common.Edit").Text,
                                Width = "100",
                                ClassName =  NopColumnClassDefaults.Button,
                                Render = new RenderButtonEdit(new DataUrl("Edit"))
                            }
                        }
                    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Nop.Services.Common.IGenericAttributeService genericAttributeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PollSearchModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
