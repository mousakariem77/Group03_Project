#pragma checksum "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bb52542d615af213782a42a64d29ca17eb29ea89a8f28b19afbcdf99bd616884"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Detail), @"mvc.1.0.view", @"/Views/Course/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bb52542d615af213782a42a64d29ca17eb29ea89a8f28b19afbcdf99bd616884", @"/Views/Course/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9414e8f56e2cc2d04e73044b10dc6e2cfbadc9fd54b07a1fac15f562fe514924", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Course_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<WebLibrary.Models.Course, IEnumerable<WebLibrary.Models.Chapter>, IEnumerable<WebLibrary.Models.Category>,
     IEnumerable<WebLibrary.Models.Instruct>, IEnumerable<WebLibrary.Models.Lesson>>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fonts/boxicons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar-initial bg-label-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary ml-5 mb-5 mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 8rem;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_LayoutCourse.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"/wwwroot/css/site.css\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb52542d615af213782a42a64d29ca17eb29ea89a8f28b19afbcdf99bd6168846293", async() => {
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
            WriteLiteral(@"


<div class=""container-fluid mt-2 mb-3 p-0"">
    <div class=""card mb-4 bg-theme"">
        <div class=""card-body d-flex"" style=""justify-content: space-between;"">
            <div class=""d-flex align-items-start align-items-sm-center gap-4 ml-5"">
                <div class=""mr-2 mt-5"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bb52542d615af213782a42a64d29ca17eb29ea89a8f28b19afbcdf99bd6168847755", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"id-text form-group ml-2\">\r\n                    <label class=\"text-theme font-weight-bold\">Course ID</label>\r\n                    <input");
            BeginWriteAttribute("value", " value=\"", 979, "\"", 1008, 1);
#nullable restore
#line 20 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 987, Model.Item1.CourseId, 987, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" style=""width: 80%;"" disabled/>
                </div>
            </div>
        </div>
        <div class=""container-fluid ml-5"">
            <div class=""row"">
                <div class=""mb-3 col-md-6"">
                    <div class=""form-group"">
                        <label class=""text-theme font-weight-bold"">Course Name</label>
                        <input");
            BeginWriteAttribute("value", " value=\"", 1407, "\"", 1438, 1);
#nullable restore
#line 29 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 1415, Model.Item1.CourseName, 1415, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width: 80%;\" disabled/>\r\n                    </div>\r\n                </div>\r\n                <div class=\"mb-3 col-md-6\">\r\n                    <div class=\"form-group\"> \r\n");
#nullable restore
#line 34 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
                          
                            foreach (var category in Model.Item3){
                                if(Model.Item1.CategoryId == category.CategoryId){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <label class=\"text-theme font-weight-bold\">Category Name</label>\r\n                                    <input");
            BeginWriteAttribute("value", " value=\"", 1961, "\"", 1991, 1);
#nullable restore
#line 38 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 1969, category.CategoryName, 1969, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width: 80%;\" disabled/>\r\n");
#nullable restore
#line 39 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
                                }
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"mb-3 col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        <label class=\"text-theme font-weight-bold\">Price</label>\r\n                        <input");
            BeginWriteAttribute("value", " value=\"", 2394, "\"", 2420, 1);
#nullable restore
#line 47 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 2402, Model.Item1.Price, 2402, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" style=""width: 80%;"" disabled/>
                    </div>
                </div>
                <div class=""mb-3 col-md-6"">
                    <div class=""form-group"">
                        <label class=""text-theme font-weight-bold"">Total Time</label>
                        <input");
            BeginWriteAttribute("value", " value=\"", 2735, "\"", 2765, 1);
#nullable restore
#line 53 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 2743, Model.Item1.TotalTime, 2743, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" style=""width: 80%;"" disabled/>
                    </div>
                </div> 
                <div class=""mb-3 col-md-6"">
                    <div class=""form-group"">
                        <label class=""text-theme font-weight-bold"">Start Date</label>
                        <input");
            BeginWriteAttribute("value", " value=\"", 3081, "\"", 3111, 1);
#nullable restore
#line 59 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 3089, Model.Item1.StartDate, 3089, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" style=""width: 80%;"" disabled/>
                    </div>
                </div>
                <div class=""mb-3 col-md-6"">
                    <div class=""form-group"">
                        <label class=""text-theme font-weight-bold"">End Date</label>
                        <input");
            BeginWriteAttribute("value", " value=\"", 3424, "\"", 3452, 1);
#nullable restore
#line 65 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 3432, Model.Item1.EndDate, 3432, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" style=""width: 80%;"" disabled/>
                    </div>
                </div>
                <div class=""mb-3 col-md-6"">
                    <div class=""form-group"">
                        <label class=""text-theme font-weight-bold"">Description</label><br>
                        <textarea rows=""3"" cols=""60"" class=""outline-0 mt-2"" disabled>");
#nullable restore
#line 71 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
                                                                                Write(Model.Item1.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                    </div>
                </div>
                <div class=""mb-3 col-md-6"">
                    <div class=""form-group"">
                        <label class=""text-theme font-weight-bold"">Status</label>
                        <input");
            BeginWriteAttribute("value", " value=\"", 4120, "\"", 4147, 1);
#nullable restore
#line 77 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 4128, Model.Item1.Status, 4128, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width: 80%;\" disabled/>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"container\">\r\n            <!-- List of Chapter Start-->\r\n");
#nullable restore
#line 85 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
              
                foreach(var chapter in Model.Item2){
                    if(chapter.CourseId == Model.Item1.CourseId){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-12 col-md-12\">\r\n                            <div class=\"box-chaper mb-2\" data-bs-toggle=\"collapse\" data-bs-target=\"#list-lesson");
#nullable restore
#line 89 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
                                                                                                           Write(chapter.Index);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                <div class=""chapter-list d-flex"">
                                    <div class=""chapter-item d-flex"">
                                        <i class='bx bx-plus text-primary mr-1 mt-3 ml-3'></i>
                                        <h5 class=""pt-3 text-theme""><b>");
#nullable restore
#line 93 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
                                                                  Write(chapter.Index);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 93 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
                                                                                 Write(chapter.ChapterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h5>\r\n                                    </div>\r\n");
#nullable restore
#line 95 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
                                      
                                        int lessonTmp = 0;
                                        foreach(var lesson in Model.Item5){
                                            if(chapter.ChapterId == lesson.ChapterId){
                                                lessonTmp++;
                                            }
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"quanity-lesson text-dark text-end mr-4\"><b>");
#nullable restore
#line 103 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
                                                                                    Write(lessonTmp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> lesson</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div");
            BeginWriteAttribute("id", " id=\"", 5798, "\"", 5830, 2);
            WriteAttributeValue("", 5803, "list-lesson", 5803, 11, true);
#nullable restore
#line 107 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 5814, chapter.Index, 5814, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""collapse"">
                            <div class=""container"">
                                <div class=""row"">
                                    <div class=""col-lg-12 col-md-12"">
                                        <div class=""box-chaper mb-2"">
                                            <div class="" d-flex"">
");
#nullable restore
#line 113 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
                                                  
                                                    foreach(var lesson in Model.Item5){
                                                        if(chapter.ChapterId == lesson.ChapterId){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <a");
            BeginWriteAttribute("href", " href=\"", 6467, "\"", 6505, 2);
            WriteAttributeValue("", 6474, "/Home/Learning/", 6474, 15, true);
#nullable restore
#line 116 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 6489, lesson.LessonId, 6489, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""d-flex justify-content-between"">
                                                                <div class=""lesson-item d-flex ml-4"">
                                                                    <i class='text-primary bx bxs-caret-right-circle mr-1 mt-3 ml-3'></i>
                                                                    <h6 class=""pt-3"">");
#nullable restore
#line 119 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
                                                                                Write(lesson.Index);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 119 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
                                                                                               Write(lesson.LessonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                                </div>\r\n");
#nullable restore
#line 121 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
                                                                  
                                                                    int? hourLesson = @lesson.Time / 60; // Số giờ
                                                                    int? minuteLesson = @lesson.Time % 60; // Số phút
                                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <p class=\"quanity-lesson text-end mt-2 ml-5\">");
#nullable restore
#line 125 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
                                                                                                        Write(hourLesson);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 125 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
                                                                                                                      Write(minuteLesson);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                            </a>\r\n");
#nullable restore
#line 127 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
                                                        }
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div> 
                        </div>
                        <!-- List of Chapter End-->
");
#nullable restore
#line 137 "D:\Group03_Project\Project_Group3\Views\Course\Detail.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb52542d615af213782a42a64d29ca17eb29ea89a8f28b19afbcdf99bd61688423640", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<WebLibrary.Models.Course, IEnumerable<WebLibrary.Models.Chapter>, IEnumerable<WebLibrary.Models.Category>,
     IEnumerable<WebLibrary.Models.Instruct>, IEnumerable<WebLibrary.Models.Lesson>>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
