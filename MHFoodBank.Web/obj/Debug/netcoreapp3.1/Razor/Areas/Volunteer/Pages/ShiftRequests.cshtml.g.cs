#pragma checksum "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b11e9991b5f71f0164c98e7f25469d6dcbd0bb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MHFoodBank.Web.Areas.Volunteer.Pages.Areas_Volunteer_Pages_ShiftRequests), @"mvc.1.0.razor-page", @"/Areas/Volunteer/Pages/ShiftRequests.cshtml")]
namespace MHFoodBank.Web.Areas.Volunteer.Pages
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
#line 1 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\_ViewImports.cshtml"
using MHFoodBank.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\_ViewImports.cshtml"
using MHFoodBank.Web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
using MHFoodBank.Web.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
using MHFoodBank.Web.Areas.Admin.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b11e9991b5f71f0164c98e7f25469d6dcbd0bb8", @"/Areas/Volunteer/Pages/ShiftRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bcbcb7236df829085fdafe20da2b878742e3be", @"/Areas/Volunteer/Pages/_ViewImports.cshtml")]
    public class Areas_Volunteer_Pages_ShiftRequests : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Calendar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
  
    ViewData["Title"] = "ShiftRequests";
    Layout = "~/Areas/Volunteer/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"ml-5 mr-5\">\r\n        <div class=\"row\">\r\n            <h1 class=\"col-md-4\">Shift Change Requests</h1>\r\n            <div class=\"col-md-6\"></div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b11e9991b5f71f0164c98e7f25469d6dcbd0bb86679", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b11e9991b5f71f0164c98e7f25469d6dcbd0bb86953", async() => {
                    WriteLiteral("Request Shift Change");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
         if (Model.Alerts.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <hr />\r\n            <h4>No Shift Requests</h4>\r\n");
#nullable restore
#line 23 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table\">\r\n                <tr>\r\n                    <th>Original Shift Date</th>\r\n                    <th>Request</th>\r\n                    <th>Status</th>\r\n                </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                 foreach (ShiftRequestAlert alert in Model.Alerts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
               Write(alert.OldShift.StartDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 35 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                                                                 Write(alert.OldShift.StartTime.ToString(@"hh\:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" to ");
#nullable restore
#line 35 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                                                                                                                  Write(alert.OldShift.EndTime.ToString(@"hh\:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <!--Request To Change Shift-->\r\n");
#nullable restore
#line 37 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                 if (alert.NewShift != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Change to ");
#nullable restore
#line 39 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                             Write(alert.NewShift.StartDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 39 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                                                                               Write(alert.NewShift.StartTime.ToString(@"hh\:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" to ");
#nullable restore
#line 39 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                                                                                                                                Write(alert.NewShift.EndTime.ToString(@"hh\:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 40 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Remove Shift</td>\r\n");
#nullable restore
#line 44 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                 if (alert.Status == ShiftRequestAlert.RequestStatus.Pending)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Pending</td>\r\n");
#nullable restore
#line 48 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                     if (alert.Status == ShiftRequestAlert.RequestStatus.Accepted)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Accepted</td>\r\n");
#nullable restore
#line 54 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                    }
                    else if (alert.Status == ShiftRequestAlert.RequestStatus.Declined)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Declined</td>\r\n");
#nullable restore
#line 58 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                 if (alert.Status != ShiftRequestAlert.RequestStatus.Pending)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b11e9991b5f71f0164c98e7f25469d6dcbd0bb815829", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b11e9991b5f71f0164c98e7f25469d6dcbd0bb816116", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
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
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 67 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 69 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
#nullable restore
#line 71 "C:\Users\Chase\Desktop\FBWebsite-V3\Github\MHFoodBank.Web\Areas\Volunteer\Pages\ShiftRequests.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MHFoodBank.Web.Areas.Volunteer.Pages.ShiftRequestsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MHFoodBank.Web.Areas.Volunteer.Pages.ShiftRequestsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MHFoodBank.Web.Areas.Volunteer.Pages.ShiftRequestsModel>)PageContext?.ViewData;
        public MHFoodBank.Web.Areas.Volunteer.Pages.ShiftRequestsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
