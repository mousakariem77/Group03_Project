#pragma checksum "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5d4f64f208a0c419b4f57e3f9b51cedf087a102d70e429be17356779cabdc357"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_courseDetail), @"mvc.1.0.view", @"/Views/Admin/courseDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5d4f64f208a0c419b4f57e3f9b51cedf087a102d70e429be17356779cabdc357", @"/Views/Admin/courseDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9414e8f56e2cc2d04e73044b10dc6e2cfbadc9fd54b07a1fac15f562fe514924", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_courseDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<WebLibrary.Models.Course, IEnumerable<WebLibrary.Models.Chapter>, IEnumerable<WebLibrary.Models.Category>,
     IEnumerable<WebLibrary.Models.Instruct>, IEnumerable<WebLibrary.Models.Lesson>, IEnumerable<WebLibrary.Models.Instructor>>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fonts/boxicons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar-initial rounded-circle bg-label-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
  
    ViewData["Title"] = "Course Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"/wwwroot/css/site.css\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d4f64f208a0c419b4f57e3f9b51cedf087a102d70e429be17356779cabdc3575578", async() => {
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
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js""></script>

<div class=""container-fluid mt-2 mb-3 p-0"">
    <div class=""card mb-5 bg-theme"">
        <div class=""card-body d-flex"" style=""justify-content: space-between;"">
            <div class=""d-flex align-items-start align-items-sm-center gap-4 ml-5"">
                <div class=""mt-5 mr-4"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5d4f64f208a0c419b4f57e3f9b51cedf087a102d70e429be17356779cabdc3577142", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"id-text form-group\">\r\n                    <label class=\"text-theme font-weight-bold\">Make by:</label>\r\n");
#nullable restore
#line 20 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
                     foreach (var instructor in Model.Item6)
                        {
                            foreach (var instruct in Model.Item4)
                            {
                                if (Model.Item1.CourseId == instruct.CourseId && instructor.InstructorId == instruct.InstructorId)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input");
            BeginWriteAttribute("value", " value=\"", 1523, "\"", 1573, 2);
#nullable restore
#line 26 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
WriteAttributeValue("", 1531, instructor.FirstName, 1531, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
WriteAttributeValue(" ", 1552, instructor.LastName, 1553, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width: 80%;\" readonly/>\r\n");
#nullable restore
#line 27 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
                                }
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    }
                </div>
            </div>
        </div>
        <div class=""container-fluid ml-5"">
            <div class=""row"">
                <div class=""mb-3 col-md-6"">
                    <div class=""form-group"">
                        <label class=""text-theme font-weight-bold"">Course Name</label>
                        <input");
            BeginWriteAttribute("value", " value=\"", 2088, "\"", 2119, 1);
#nullable restore
#line 39 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
WriteAttributeValue("", 2096, Model.Item1.CourseName, 2096, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width: 80%;\" readonly/>\r\n                    </div>\r\n                </div>\r\n                <div class=\"mb-3 col-md-6\">\r\n                    <div class=\"form-group\"> \r\n");
#nullable restore
#line 44 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
                          
                            foreach (var category in Model.Item3){
                                if(Model.Item1.CategoryId == category.CategoryId){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <label class=\"text-theme font-weight-bold\">Category Name</label>\r\n                                    <input");
            BeginWriteAttribute("value", " value=\"", 2642, "\"", 2672, 1);
#nullable restore
#line 48 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
WriteAttributeValue("", 2650, category.CategoryName, 2650, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width: 80%;\" readonly/>\r\n");
#nullable restore
#line 49 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
                                }
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"mb-3 col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        <label class=\"text-theme font-weight-bold\">Price</label>\r\n                        <input");
            BeginWriteAttribute("value", " value=\"", 3075, "\"", 3101, 1);
#nullable restore
#line 57 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
WriteAttributeValue("", 3083, Model.Item1.Price, 3083, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" style=""width: 80%;"" readonly/>
                    </div>
                </div>
                <div class=""mb-3 col-md-6"">
                    <div class=""form-group"">
                        <label class=""text-theme font-weight-bold"">Total Time</label>
                        <input");
            BeginWriteAttribute("value", " value=\"", 3416, "\"", 3446, 1);
#nullable restore
#line 63 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
WriteAttributeValue("", 3424, Model.Item1.TotalTime, 3424, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" style=""width: 80%;"" readonly/>
                    </div>
                </div> 
                <div class=""mb-3 col-md-6"">
                    <div class=""form-group"">
                        <label class=""text-theme font-weight-bold"">Start Date</label>
                        <input");
            BeginWriteAttribute("value", " value=\"", 3762, "\"", 3792, 1);
#nullable restore
#line 69 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
WriteAttributeValue("", 3770, Model.Item1.StartDate, 3770, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" style=""width: 80%;"" readonly/>
                    </div>
                </div>
                <div class=""mb-3 col-md-6"">
                    <div class=""form-group"">
                        <label class=""text-theme font-weight-bold"">End Date</label>
                        <input");
            BeginWriteAttribute("value", " value=\"", 4105, "\"", 4133, 1);
#nullable restore
#line 75 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
WriteAttributeValue("", 4113, Model.Item1.EndDate, 4113, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" style=""width: 80%;"" readonly/>
                    </div>
                </div>
                <div class=""mb-3 col-md-6"">
                    <div class=""form-group"">
                        <label class=""text-theme font-weight-bold"">Description</label><br>
                        <textarea rows=""3"" cols=""60"" class=""outline-0 mt-2"" disabled>");
#nullable restore
#line 81 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
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
            BeginWriteAttribute("value", " value=\"", 4801, "\"", 4828, 1);
#nullable restore
#line 87 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
WriteAttributeValue("", 4809, Model.Item1.Status, 4809, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width: 80%;\" readonly/>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"container\">\r\n            <!-- List of Chapter Start-->\r\n");
#nullable restore
#line 95 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
              
                foreach(var chapter in Model.Item2){
                    if(chapter.CourseId == Model.Item1.CourseId){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-12 col-md-12\">\r\n                            <div class=\"box-chaper mb-2\" data-bs-toggle=\"collapse\" data-bs-target=\"#list-lesson");
#nullable restore
#line 99 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
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
#line 103 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
                                                                  Write(chapter.Index);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 103 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
                                                                                 Write(chapter.ChapterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h5>\r\n                                    </div>\r\n");
#nullable restore
#line 105 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
                                      
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
#line 113 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
                                                                                    Write(lessonTmp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> lesson</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div");
            BeginWriteAttribute("id", " id=\"", 6479, "\"", 6511, 2);
            WriteAttributeValue("", 6484, "list-lesson", 6484, 11, true);
#nullable restore
#line 117 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
WriteAttributeValue("", 6495, chapter.Index, 6495, 16, false);

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
#line 123 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
                                                  
                                                    foreach(var lesson in Model.Item5){
                                                        if(chapter.ChapterId == lesson.ChapterId){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <a");
            BeginWriteAttribute("href", " href=\"", 7148, "\"", 7186, 2);
            WriteAttributeValue("", 7155, "/Home/Learning/", 7155, 15, true);
#nullable restore
#line 126 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
WriteAttributeValue("", 7170, lesson.LessonId, 7170, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""d-flex justify-content-between"">
                                                                <div class=""lesson-item d-flex ml-4"">
                                                                    <i class='text-primary bx bxs-caret-right-circle mr-1 mt-3 ml-3'></i>
                                                                    <h6 class=""pt-3"">");
#nullable restore
#line 129 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
                                                                                Write(lesson.Index);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 129 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
                                                                                               Write(lesson.LessonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                                </div>\r\n");
#nullable restore
#line 131 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
                                                                  
                                                                    int? hourLesson = @lesson.Time / 60; // Số giờ
                                                                    int? minuteLesson = @lesson.Time % 60; // Số phút
                                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <p class=\"quanity-lesson text-end mt-2 ml-5\">");
#nullable restore
#line 135 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
                                                                                                        Write(hourLesson);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 135 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
                                                                                                                      Write(minuteLesson);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                            </a>\r\n");
#nullable restore
#line 137 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
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
#line 147 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 8800, "\"", 8837, 1);
#nullable restore
#line 151 "D:\Group03_Project\Project_Group3\Views\Admin\courseDetail.cshtml"
WriteAttributeValue("", 8807, Url.Action("Course", "Admin"), 8807, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary mb-4 ml-5 mt-4\" style=\"width: 10%;\">Back</a>\r\n    </div>\r\n</div>\r\n\r\n");
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
     IEnumerable<WebLibrary.Models.Instruct>, IEnumerable<WebLibrary.Models.Lesson>, IEnumerable<WebLibrary.Models.Instructor>>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
