#pragma checksum "D:\2024\Group03_Project\Project_Group3\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4eaec9cea32829496e5817aaee28784305693a48c4972b8a6d3889ab117da6fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\2024\Group03_Project\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\2024\Group03_Project\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4eaec9cea32829496e5817aaee28784305693a48c4972b8a6d3889ab117da6fe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9414e8f56e2cc2d04e73044b10dc6e2cfbadc9fd54b07a1fac15f562fe514924", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<WebLibrary.Models.Category>, List<WebLibrary.Models.Instructor>>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fonts/boxicons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid img-equal-size"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/avatars/birdEdu.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\2024\Group03_Project\Project_Group3\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Course";
    Layout = "~/Views/Shared/_LayoutHome.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4eaec9cea32829496e5817aaee28784305693a48c4972b8a6d3889ab117da6fe5968", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4eaec9cea32829496e5817aaee28784305693a48c4972b8a6d3889ab117da6fe7106", async() => {
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
            WriteLiteral(@"

<div class=""addvertising-course"">
    <!-- Category Start -->
    <div class=""container-fluid py-5"">
        <div class=""container pt-3 pb-3"">
            <div class=""text-center mb-5"">
                <h5 class=""text-primary text-uppercase mb-3"" style=""letter-spacing: 5px;"">Subjects</h5>
                <h1>Explore Top Subjects</h1>
            </div>
            <div class=""row"">
");
#nullable restore
#line 18 "D:\2024\Group03_Project\Project_Group3\Views\Home\Index.cshtml"
                  
                    int count = 1;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\2024\Group03_Project\Project_Group3\Views\Home\Index.cshtml"
                 foreach(var category in Model.Item1){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""course-container col-lg-3 col-md-6 mb-4"">
                        <div class=""cat-item position-relative overflow-hidden rounded mb-2"">
                            <a class=""cat-overlay text-theme text-decoration-none"" href=""https://www.youtube.com/"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4eaec9cea32829496e5817aaee28784305693a48c4972b8a6d3889ab117da6fe9430", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1156, "~/img/elements/cat-", 1156, 19, true);
#nullable restore
#line 25 "D:\2024\Group03_Project\Project_Group3\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1175, count, 1175, 8, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1183, ".jpg", 1183, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <h5 class=\"text-theme font-weight-medium\">");
#nullable restore
#line 26 "D:\2024\Group03_Project\Project_Group3\Views\Home\Index.cshtml"
                                                                     Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <div class=\"d-flex justify-content-between align-items-end\">\r\n                                    <span class=\"ml-auto\">");
#nullable restore
#line 28 "D:\2024\Group03_Project\Project_Group3\Views\Home\Index.cshtml"
                                                     Write(category.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Courses</span>\r\n                                </div>\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 33 "D:\2024\Group03_Project\Project_Group3\Views\Home\Index.cshtml"
                    count = count+1;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <!-- Category Start -->

    <!-- Team Start -->
    <div class=""container-fluid py-5"">
        <div class=""container pb-3"">
            <div class=""text-center mb-5"">
                <h5 class=""text-primary text-uppercase mb-3"" style=""letter-spacing: 5px;"">Teachers</h5>
                <h1>Meet Our Teachers</h1>
            </div>
            <div class=""row"">
");
#nullable restore
#line 48 "D:\2024\Group03_Project\Project_Group3\Views\Home\Index.cshtml"
                  
                    int countIns=6;
                    foreach(var instructor in Model.Item2){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-md-6 col-lg-3 text-center team mb-4"">
                            <div class=""team-item rounded overflow-hidden mb-2"">
                                <div class=""team-img position-relative mt-4"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4eaec9cea32829496e5817aaee28784305693a48c4972b8a6d3889ab117da6fe13340", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2544, "~/img/avatars/instructor/", 2544, 25, true);
#nullable restore
#line 54 "D:\2024\Group03_Project\Project_Group3\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2569, countIns, 2569, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2580, ".png", 2580, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"text-them p-4\">\r\n                                    <h5>");
#nullable restore
#line 57 "D:\2024\Group03_Project\Project_Group3\Views\Home\Index.cshtml"
                                   Write(instructor.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 57 "D:\2024\Group03_Project\Project_Group3\Views\Home\Index.cshtml"
                                                         Write(instructor.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <p class=\"m-0\">Web Designer</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 62 "D:\2024\Group03_Project\Project_Group3\Views\Home\Index.cshtml"
                        countIns++;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <!-- Team End -->

    <!-- Registration Start -->
    <div class=""container-fluid bg-registration p-0 mt-4"">
        <div class=""container py-5"">
            <div class=""row align-items-center"">
                <div class=""col-lg-7 mb-5 mb-lg-0"">
                    <div class=""mb-4"">
                        <h5 class=""text-primary text-uppercase mb-3"" style=""letter-spacing: 5px;"">WELCOME TO OUR COURSES
                        </h5>
                        <h1 class=""text-white"">30% Off For New Students</h1>
                    </div>
                    <p class=""text-white"">Take advantage of our special offer! New students can enjoy a 30% discount on
                        any course they enroll in. Don't miss this opportunity to invest in your education at a
                        discounted price.</p>
                    <h5 class=""text-primary text-uppercase mb-3"" style=""letter-spacing: 5px;"">Why Choose Us?</h5>

                    ");
            WriteLiteral(@"<ul class=""list-inline text-white m-0"">
                        <li class=""py-2""><i class=""fa fa-check text-primary mr-3""></i>Experienced Instructors</li>
                        <li class=""py-2""><i class=""fa fa-check text-primary mr-3""></i>Comprehensive Curriculum</li>
                        <li class=""py-2""><i class=""fa fa-check text-primary mr-3""></i>Flexible Learning</li>
                        <li class=""py-2""><i class=""fa fa-check text-primary mr-3""></i>Interactive Learning Environment
                        </li>
                    </ul>
                </div>

                <div class=""col-lg-5"">
                    <div class="" border-0"">
                        <div class="" text-end"">
                            <a href=""register.html"" class=""btn btn-register"">Sign Up Now</a>
                        </div>
                        <div class=""card-body rounded-bottom"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4eaec9cea32829496e5817aaee28784305693a48c4972b8a6d3889ab117da6fe18225", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                \r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Registration End -->\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<WebLibrary.Models.Category>, List<WebLibrary.Models.Instructor>>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
