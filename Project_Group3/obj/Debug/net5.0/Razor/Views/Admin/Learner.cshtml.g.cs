#pragma checksum "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "90d9ecd3325f194ca610049e5e249f287bde2c58cfc35212fd8d2237cc8e5d97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Learner), @"mvc.1.0.view", @"/Views/Admin/Learner.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Group03_Project\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Group03_Project\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"90d9ecd3325f194ca610049e5e249f287bde2c58cfc35212fd8d2237cc8e5d97", @"/Views/Admin/Learner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9414e8f56e2cc2d04e73044b10dc6e2cfbadc9fd54b07a1fac15f562fe514924", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Learner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebLibrary.Models.Learner>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fonts/boxicons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table-search d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/learner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar-initial rounded-circle bg-label-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
  
    ViewData["Title"] = "Learner Management";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "90d9ecd3325f194ca610049e5e249f287bde2c58cfc35212fd8d2237cc8e5d976254", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "90d9ecd3325f194ca610049e5e249f287bde2c58cfc35212fd8d2237cc8e5d977392", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js\"></script>\r\n\r\n");
#nullable restore
#line 10 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
  
    String iconClass = "";
    if(ViewBag.IconClass == "bxs-down-arrow")
    {
        iconClass = "bxs-up-arrow";
    }else{
        iconClass = "bxs-down-arrow";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 20 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
 if (TempData["EditSuccess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"editAlert\"");
            BeginWriteAttribute("class", " class=\"", 607, "\"", 710, 6);
            WriteAttributeValue("", 615, "alert", 615, 5, true);
            WriteAttributeValue(" ", 620, "alert-", 621, 7, true);
#nullable restore
#line 22 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue("", 627, (bool)TempData["EditSuccess"] ? "success" : "danger", 627, 55, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 682, "alert-dismissible", 683, 18, true);
            WriteAttributeValue(" ", 700, "fade", 701, 5, true);
            WriteAttributeValue(" ", 705, "show", 706, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
#nullable restore
#line 23 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
    Write((bool)TempData["EditSuccess"] ? "Learner edited successfully." : "Failed to edit learner.");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div id=\"progressBar\"></div>\r\n    </div>\r\n");
#nullable restore
#line 26 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 28 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
 if (TempData["DeleteSuccess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"deleteAlert\"");
            BeginWriteAttribute("class", " class=\"", 941, "\"", 1046, 6);
            WriteAttributeValue("", 949, "alert", 949, 5, true);
            WriteAttributeValue(" ", 954, "alert-", 955, 7, true);
#nullable restore
#line 30 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue("", 961, (bool)TempData["DeleteSuccess"] ? "success" : "danger", 961, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1018, "alert-dismissible", 1019, 18, true);
            WriteAttributeValue(" ", 1036, "fade", 1037, 5, true);
            WriteAttributeValue(" ", 1041, "show", 1042, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
#nullable restore
#line 31 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
    Write((bool)TempData["DeleteSuccess"] ? "Learner deleted successfully." : "Failed to delete learner.");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div id=\"progressBar\"></div>\r\n    </div>\r\n");
#nullable restore
#line 34 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"card bg-theme p-0 mt-2 mb-5\" >\r\n    <div class=\"container no-footer mt-5 mb-3 p-0\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12 col-md-6\">\r\n                <div class=\"container-fluid\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90d9ecd3325f194ca610049e5e249f287bde2c58cfc35212fd8d2237cc8e5d9712275", async() => {
                WriteLiteral("\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1563, "\"", 1586, 1);
#nullable restore
#line 43 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue("", 1571, ViewBag.search, 1571, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""search"" name=""search"" placeholder=""Search"">
                        <button class=""btn btn-primary btn-outline-primary ml-2"" type=""submit"">
                            <i class='bx bx-search-alt-2'></i>
                        </button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        </div>
    </div>
    
    <div class=""container p-0 mt-3"">
        <table class=""datatables-basic table mb-5"">
            <thead>
                <tr>
                    <th width=""10""><input type=""checkbox"" id=""all"" class=""checkbox-item""></th>
                    <th width=""50"" class=""text-theme"">Name</th>
                    <th width=""120"" class=""text-theme"">Gender</th>
                    <th width=""120"" class=""text-theme"">Country</th>
                    <th width=""150"" class=""text-theme"">Registration</th>
                    <th width=""120"" class=""text-theme"">Status</th>
                    <th width=""70"" class=""text-theme"">Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 67 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                 foreach (var learner in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("class", " class=\"", 2722, "\"", 2730, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <td class=""  dt-checkboxes-cell"">
                            <input type=""checkbox"">
                        </td>
                        <td>
                            <div class=""d-flex justify-content-start align-items-center user-name"">
                                <div class=""avatar-wrapper"">
                                    <div class=""avatar mr-2"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "90d9ecd3325f194ca610049e5e249f287bde2c58cfc35212fd8d2237cc8e5d9716051", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"d-flex flex-column\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3441, "\"", 3497, 3);
            WriteAttributeValue("", 3448, "/admin/userDetail/", 3448, 18, true);
#nullable restore
#line 80 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue("", 3466, learner.LearnerId, 3466, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3484, "?role=learner", 3484, 13, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <span class=\"text-truncate text-theme\">");
#nullable restore
#line 81 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                                                                          Write(learner.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 81 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                                                                                             Write(learner.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                                        <small class=\"text-truncate text-muted text-theme\">");
#nullable restore
#line 82 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                                                                                      Write(learner.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </a>\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                        <td class=\"text-theme\">");
#nullable restore
#line 87 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                                          Write(learner.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-theme\">");
#nullable restore
#line 88 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                                          Write(learner.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-theme\">");
#nullable restore
#line 89 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                                          Write(learner.RegistrationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <span class=\"badge bg-label-success text-theme\">");
#nullable restore
#line 91 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                                                                       Write(learner.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </td>\r\n                        <td class=\"text-theme\">\r\n                            <div class=\"action-icon d-flex text-center\">\r\n                                <a class=\"btn btn-warning mr-2\"");
            BeginWriteAttribute("href", " href=\"", 4458, "\"", 4497, 2);
            WriteAttributeValue("", 4465, "/learner/edit/", 4465, 14, true);
#nullable restore
#line 95 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue("", 4479, learner.LearnerId, 4479, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Edit\">\r\n                                    <i class=\'bx bxs-edit\'></i>\r\n                                </a>\r\n");
#nullable restore
#line 98 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                                   
                                    if(learner.Status != "Delete"){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <a class=""btn text-theme"" style=""background-color: rgb(169, 140, 140); cursor: pointer;"" data-bs-toggle=""modal"" data-bs-target=""#deleteModal"">
                                            <i class='bx bxs-trash-alt'></i>
                                        </a>
");
#nullable restore
#line 103 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                                    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 5140, "\"", 5181, 2);
            WriteAttributeValue("", 5147, "/learner/delete/", 5147, 16, true);
#nullable restore
#line 104 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue("", 5163, learner.LearnerId, 5163, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Delete\">\r\n                                            <i class=\'bx bxs-trash-alt\'></i>\r\n                                        </a>\r\n");
#nullable restore
#line 107 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                                    }
                                 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 112 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"7\">\r\n                        <div class=\"mt-3 text-theme\">\r\n                            Showing 1 to ");
#nullable restore
#line 116 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                                    Write(ViewBag.PageSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 116 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                                                         Write(ViewBag.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" entries\r\n                        </div>\r\n                        <ul class=\"pagination ml-5 justify-content-end\" style=\"margin-top: -10px;\">\r\n");
#nullable restore
#line 119 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                             if (ViewBag.CurrentPage > 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6059, "\"", 6112, 2);
            WriteAttributeValue("", 6066, "/learner/index?page=", 6066, 20, true);
#nullable restore
#line 122 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue("", 6086, ViewBag.CurrentPage - 1, 6086, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Previous</a>\r\n                                </li>\r\n");
#nullable restore
#line 124 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                             for(int i = 1; i <= ViewBag.TotalPages; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item \">\r\n                                    <a");
            BeginWriteAttribute("class", " class=\"", 6399, "\"", 6475, 2);
            WriteAttributeValue("", 6407, "page-link", 6407, 9, true);
#nullable restore
#line 128 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue(" ", 6416, ViewBag.CurrentPage == i ? "bg-primary text-white" : "", 6417, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 6476, "\"", 6505, 2);
            WriteAttributeValue("", 6483, "/learner/index?page=", 6483, 20, true);
#nullable restore
#line 128 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue("", 6503, i, 6503, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 128 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                                                                                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n");
#nullable restore
#line 130 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                             if (ViewBag.CurrentPage < ViewBag.TotalPages)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6804, "\"", 6857, 2);
            WriteAttributeValue("", 6811, "/learner/index?page=", 6811, 20, true);
#nullable restore
#line 134 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue("", 6831, ViewBag.CurrentPage + 1, 6831, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Next</a>\r\n                                </li>\r\n");
#nullable restore
#line 136 "D:\Group03_Project\Project_Group3\Views\Admin\Learner.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </td>
                    </tr>
            </tbody>
        </table>
    </div>
</div>

<!-- The Modal -->
<div class=""modal"" id=""deleteModal"">
  <div class=""modal-dialog"">
    <div class=""modal-content bg-theme"">
      <div class=""modal-header"">
        <h3 class=""text-danger modal-title"">Error</h3>
        <button type=""button"" class=""btn-close bg-theme text-theme border-0"" data-bs-dismiss=""modal"">x</button>
      </div>
      <div class=""text-theme modal-body"">
        You can't not delete this account
      </div>

      <!-- Modal footer -->
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-success"" data-bs-dismiss=""modal"">OK</button>
      </div>
    </div>
  </div>
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebLibrary.Models.Learner>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591