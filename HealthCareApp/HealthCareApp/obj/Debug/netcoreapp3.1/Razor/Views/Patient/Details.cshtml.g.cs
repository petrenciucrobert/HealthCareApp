#pragma checksum "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "038ef20570ea4ece9a86e0e2da85a16510d84c8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_Details), @"mvc.1.0.view", @"/Views/Patient/Details.cshtml")]
namespace AspNetCore
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
#line 1 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\_ViewImports.cshtml"
using HealthCareApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\_ViewImports.cshtml"
using HealthCareApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"038ef20570ea4ece9a86e0e2da85a16510d84c8c", @"/Views/Patient/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb9db17d7d196d01c276d3b2ad7358bce28f041d", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HealthCareApp.ViewModels.PatientViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Add new"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success float-right btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Patient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckUp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""wrapper"">
    <div class=""content-wrapper"">
        <section class=""content"">
            <div class=""container-fluid"">
               <div class=""row"">
                   <div class=""col-md-3"">
                       <div class=""card card-primary card-outline"">
                           <div class=""card-body box-profile"">
                               <h3 class=""profile-username text-center"">");
#nullable restore
#line 17 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                                                   Write(Html.DisplayFor(model => model.PatientDetail.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                               <p class=\"text-muted text-center\">");
#nullable restore
#line 19 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.PatientDetail.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                               <ul class=\"list-group list-group-unbordered mb-3\">\r\n                                   <li class=\"list-group-item\">\r\n                                       <b>");
#nullable restore
#line 23 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                     Write(Html.DisplayNameFor(model => model.PatientDetail.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                       <a class=\"float-right\">");
#nullable restore
#line 24 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                                         Write(Html.DisplayFor(model => model.PatientDetail.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                   </li>\r\n                                   <li class=\"list-group-item\">\r\n                                       <b>");
#nullable restore
#line 27 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                     Write(Html.DisplayNameFor(model => model.PatientDetail.BloodGroup));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                       <a class=\"float-right\">");
#nullable restore
#line 28 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                                         Write(Html.DisplayFor(model => model.PatientDetail.BloodGroup));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                   </li>\r\n                                   <li class=\"list-group-item\">\r\n                                       <b>");
#nullable restore
#line 31 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                     Write(Html.DisplayNameFor(model => model.PatientDetail.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                       <a class=\"float-right\">");
#nullable restore
#line 32 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                                         Write(Html.DisplayFor(model => model.PatientDetail.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                   </li>
                               </ul>
                           </div>
                       </div>

                       <div class=""card card-primary"">
                           <div class=""card-header"">
                               <h3 class=""card-title"">Other Info</h3>
                           </div>
                           <div class=""card-body"">
                               <strong><i class=""fa fa-phone margin-r-5""></i> Contact</strong>
                               <p class=""text-muted"">");
#nullable restore
#line 44 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                                Write(Html.DisplayFor(model => model.PatientDetail.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                               <hr>\r\n                               <strong><i class=\"fa fa-map-marker margin-r-5\"></i> Address</strong>\r\n                               <p class=\"text-muted\">");
#nullable restore
#line 47 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                                Write(Html.DisplayFor(model => model.PatientDetail.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                       </div>
                       </div>
                                    <div class=""col-md-9"">
                                        <div class=""card"">
                                            <div class=""card-header p-2"">
                                                <h3 class=""card-title"">Checkup History</h3>
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "038ef20570ea4ece9a86e0e2da85a16510d84c8c10416", async() => {
                WriteLiteral("<i class=\"fa fa-plus\"></i>  Add New Checkup ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-patientId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                                                                                                                                                     WriteLiteral(Model.PatientDetail.PatientId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["patientId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-patientId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["patientId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"                                            </div>
                                            <!-- /.box-header -->
                                            <div class=""card-body"">
                                                
                                                <div class=""tab-pane"" id=""timeline"">
                                                    <!-- The timeline -->
                                                    
");
#nullable restore
#line 65 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                                     if (Model.CheckupHistoryList != null && Model.CheckupHistoryList.Count > 0)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <div class=\"timeline timeline-inverse\">\r\n\r\n\r\n");
#nullable restore
#line 70 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                                             foreach (var each in Model.CheckupHistoryList)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                <!-- timeline time label -->
                                                                <div class=""time-label"">
                                                                    <span class=""bg-red"">
                                                                        ");
#nullable restore
#line 75 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                                                    Write(each.CheckupDate.HasValue ? each.CheckupDate.Value.ToString("dd MMM yyyy") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                    </span>\r\n");
            WriteLiteral("                                                                    <span class=\"pull-right margin-r-10\">\r\n");
            WriteLiteral(@"
                                                                    </span>
                                                                </div>
                                                                <!-- end timeline time label -->
                                                                <!-- timeline item : Symptoms -->
                                                                <div>
                                                                    <i class=""fas fa-user bg-info""></i>
                                                                    <div class=""timeline-item"">
                                                                       
                                                                        <h3 class=""timeline-header""><a>Symptoms</a></h3>
                                                                        <div class=""timeline-body"">
                                                                            ");
#nullable restore
#line 94 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                                                       Write(each.Symptoms);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <!-- END timeline item : Symptoms-->
                                                                <!-- timeline item : Diagnosis-->
                                                                <div>
                                                                    <i class=""fas fa-user bg-info""></i>
                                                                    <div class=""timeline-item"">
                                                                       
                                                                        <h3 class=""timeline-header"">
                                                                            <a>Diagnosis</a>
                                                   ");
            WriteLiteral("                     </h3>\r\n                                                                        <div class=\"timeline-body\">\r\n                                                                            ");
#nullable restore
#line 108 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                                                       Write(each.Diagnosis);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <!-- End timeline item : Diagnosis-->
                                                                <!-- timeline item : Prescription-->
");
            WriteLiteral("                                                                <!-- End timeline item : Prescription-->\r\n");
#nullable restore
#line 161 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            \r\n                                                        </div>\r\n");
#nullable restore
#line 165 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span>No checkup history found</span>\r\n");
#nullable restore
#line 169 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                                </div>
                                            
                                                </div>
                                        </div>
                                    </div>
                                    <!-- /.col -->
");
            WriteLiteral("                                \r\n            <!-- /.container-fluid -->\r\n                   </div>\r\n                </div>\r\n        </section>\r\n    </div>\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n    $(this.document).ready(function () {\r\n        if (\'");
#nullable restore
#line 195 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
        Write(ViewBag.SuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' != null && \'");
#nullable restore
#line 195 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                                         Write(ViewBag.SuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' != \'\') {\r\n            notificationMessage(\'");
#nullable restore
#line 196 "E:\HealthCareApp\HealthCareApp\HealthCareApp\Views\Patient\Details.cshtml"
                            Write(ViewBag.SuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', 'success')
        }

        $(""a.detailRow"").live(""click"", function (e) {

            e.preventDefault();

            var pid = $(this).data('id')
            var postData = { ""pid"": pid, ""mode"": ""del"" };
            var href = this.href;
            var confirmMsg = 'Are you sure want to delete detail?'
            jConfirm(confirmMsg, 'Confirm', function (r) {
                if (r == true) {
                    HRN.showLoader();

                    $.ajax({
                        url: href,
                        data: postData,
                        type: 'POST',
                        success: function (response) {
                            if (response.IsError) {
                                notificationMessage(response.ErrorMsg, 'danger')
                            }
                            else {
                                $('#divPageBody').html(response);
                                notificationMessage('Patient checkup detail deleted successful");
            WriteLiteral("ly.\', \'success\');\r\n                            }\r\n\r\n                            HRN.hideLoader();\r\n                        }\r\n                    });\r\n                }\r\n            });\r\n        });\r\n    });\r\n\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthCareApp.ViewModels.PatientViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
