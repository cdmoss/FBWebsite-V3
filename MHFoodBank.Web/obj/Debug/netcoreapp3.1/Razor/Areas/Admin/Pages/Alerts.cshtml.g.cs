#pragma checksum "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28565787659756d5c7b2037e09d22f039b459b80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MHFoodBank.Web.Areas.Admin.Pages.Areas_Admin_Pages_Alerts), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/Alerts.cshtml")]
namespace MHFoodBank.Web.Areas.Admin.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
using MHFoodBank.Web.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28565787659756d5c7b2037e09d22f039b459b80", @"/Areas/Admin/Pages/Alerts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"473d4c5dc71302ebe799cb510ee6d4e5d4f55c35", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_Alerts : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AdminStatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "ViewApplicant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "DeleteAlert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "ViewRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
  
    ViewData["Title"] = "Alerts";
    Layout = "~/Areas/Admin/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"ml-5 mr-5\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28565787659756d5c7b2037e09d22f039b459b806004", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 10 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StatusMessage);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <!--<br />
        <form class=""row w-50 mb-3 ml-1"" method=""post"">
            if (String.IsNullOrWhiteSpace(Model.SearchedName))
            {
            <input class=""form-control col-md-4 mr-1"" placeholder=""Search by name..."" asp-for=""Model.SearchedName"" />
            }
            else
            {
            <input class=""form-control col-md-4 mr-1"" value=""Model.SearchedName"" asp-for=""Model.SearchedName"" />
            }
            <div class=""col-md-3"" method=""post"">
                <button class=""btn btn-sm btn-primary w-50 h-100"" asp-page-handler=""Search""><i class=""fas fa-search""></i></button>
            </div>
        </form>-->
        <h3>New Applicants</h3>
");
#nullable restore
#line 26 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
         if (Model.ApplicationAlerts.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <hr />\r\n            <p><strong>No new applicants</strong></p>\r\n");
#nullable restore
#line 30 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table\">\r\n                <tr>\r\n                    <th>Date</th>\r\n                    <th>From</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n");
#nullable restore
#line 39 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                 foreach (Alert alert in @Model.ApplicationAlerts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 42 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                         if (!alert.HasBeenRead)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td><strong>");
#nullable restore
#line 44 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                                   Write(alert.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                            <td><strong>");
#nullable restore
#line 45 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                                   Write(alert.Volunteer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 45 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                                                              Write(alert.Volunteer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n");
#nullable restore
#line 46 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 49 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                           Write(alert.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><span>");
#nullable restore
#line 50 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                                 Write(alert.Volunteer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>&nbsp;<span>");
#nullable restore
#line 50 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                                                                              Write(alert.Volunteer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n");
#nullable restore
#line 51 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28565787659756d5c7b2037e09d22f039b459b8012274", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28565787659756d5c7b2037e09d22f039b459b8012565", async() => {
                    WriteLiteral("See Applicant Information");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                                                                                                          WriteLiteral(alert.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28565787659756d5c7b2037e09d22f039b459b8015072", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                                                                                                       WriteLiteral(alert.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 59 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                </tr>\r\n            </table>\r\n");
#nullable restore
#line 63 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <br />\r\n        <h3>Shift Requests</h3>\r\n        <br />\r\n        <h5>Pending Requests</h5>\r\n");
#nullable restore
#line 69 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
         if (Model.PendingRequests.Count < 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <hr />\r\n            <p><strong>No pending requests</strong></p>\r\n");
#nullable restore
#line 73 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table\">\r\n                <tr>\r\n                    <th>Date</th>\r\n                    <th>From</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n");
#nullable restore
#line 82 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                 foreach (Alert alert in @Model.PendingRequests)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 85 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                         if (!alert.HasBeenRead)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td><strong>");
#nullable restore
#line 87 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                                   Write(alert.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                            <td><strong>");
#nullable restore
#line 88 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                                   Write(alert.Volunteer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 88 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                                                              Write(alert.Volunteer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n");
#nullable restore
#line 89 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 92 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                           Write(alert.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><span>");
#nullable restore
#line 93 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                                 Write(alert.Volunteer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>&nbsp;<span>");
#nullable restore
#line 93 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                                                                              Write(alert.Volunteer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n");
#nullable restore
#line 94 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28565787659756d5c7b2037e09d22f039b459b8023304", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28565787659756d5c7b2037e09d22f039b459b8023595", async() => {
                    WriteLiteral("See Request");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                                                                                                        WriteLiteral(alert.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 101 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                </tr>\r\n            </table>\r\n");
#nullable restore
#line 105 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <h5>Archived Requests</h5>\r\n");
#nullable restore
#line 108 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
         if (Model.ArchivedRequests.Count < 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <hr />\r\n            <p><strong>No archived requests</strong></p>\r\n");
#nullable restore
#line 112 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table\">\r\n                <tr>\r\n                    <th>Date</th>\r\n                    <th>Addressed By</th>\r\n                    <th>From</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n");
#nullable restore
#line 122 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                 foreach (Alert alert in @Model.ArchivedRequests)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 125 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                       Write(alert.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 126 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                         if (alert is ShiftRequestAlert shiftRequestAlert)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td><span>");
#nullable restore
#line 128 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                                 Write(shiftRequestAlert.AddressedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n");
#nullable restore
#line 129 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td></td>\r\n");
#nullable restore
#line 133 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><span>");
#nullable restore
#line 134 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                             Write(alert.Volunteer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>&nbsp;<span>");
#nullable restore
#line 134 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                                                                          Write(alert.Volunteer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28565787659756d5c7b2037e09d22f039b459b8031248", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28565787659756d5c7b2037e09d22f039b459b8031539", async() => {
                    WriteLiteral("See Request");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 137 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                                                                                                        WriteLiteral(alert.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28565787659756d5c7b2037e09d22f039b459b8034031", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 138 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                                                                                                       WriteLiteral(alert.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 142 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                </tr>\r\n            </table>\r\n");
#nullable restore
#line 146 "C:\Users\dofus\Downloads\VS Proj\FBWebsite-V3\MHFoodBank.Web\Areas\Admin\Pages\Alerts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MHFoodBank.Web.Areas.Admin.Pages.AlertsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MHFoodBank.Web.Areas.Admin.Pages.AlertsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MHFoodBank.Web.Areas.Admin.Pages.AlertsModel>)PageContext?.ViewData;
        public MHFoodBank.Web.Areas.Admin.Pages.AlertsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591