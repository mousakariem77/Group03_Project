#pragma checksum "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5c7c100a90dcfd017d62d7e5ef89727cc709275f9de9b03658eb9bb02515c4cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Course), @"mvc.1.0.view", @"/Views/Home/Course.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5c7c100a90dcfd017d62d7e5ef89727cc709275f9de9b03658eb9bb02515c4cd", @"/Views/Home/Course.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9414e8f56e2cc2d04e73044b10dc6e2cfbadc9fd54b07a1fac15f562fe514924", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Course : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<WebLibrary.Models.Course>, List<WebLibrary.Models.Category>, 
    List<WebLibrary.Models.Instruct>, List<WebLibrary.Models.Instructor>, List<WebLibrary.Models.Review>>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fonts/boxicons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table-search d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/course"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "all", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "block", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/avatars/course/course-4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
  
    ViewData["Title"] = "Course";
    Layout = "~/Views/Shared/_LayoutHome.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5c7c100a90dcfd017d62d7e5ef89727cc709275f9de9b03658eb9bb02515c4cd8009", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5c7c100a90dcfd017d62d7e5ef89727cc709275f9de9b03658eb9bb02515c4cd9147", async() => {
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
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 11 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
  
    string searchKeyword = ViewBag.search ?? "";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid addvertising-course"">
    <!-- Welcome Start -->
    <div class=""container-fluid py-4 mt-3"" style=""background-color: rgb(12, 65, 93);"">
        <div class=""container-fluid"">
            <h4 class=""text-white ml-4 pt-4"">Search for course names online.</h4>
            <div class=""row pb-5 ml-3"">
                <div class=""col-sm-12 col-md-4 mt-3"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c7c100a90dcfd017d62d7e5ef89727cc709275f9de9b03658eb9bb02515c4cd10938", async() => {
                WriteLiteral(" <!-- Sửa phương thức thành GET -->\r\n                        <input type=\"search\" class=\"form-control mr-2\" placeholder=\"Search...\" name=\"search\"");
                BeginWriteAttribute("value", " value=\"", 1067, "\"", 1090, 1);
#nullable restore
#line 22 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
WriteAttributeValue("", 1075, ViewBag.search, 1075, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <button class=\"btn btn-primary\" type=\"submit\"><i class=\'bx bx-search-alt-2\'></i></button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-4 col-md-2 mt-3\">\r\n                    <select");
            BeginWriteAttribute("name", " name=\"", 1343, "\"", 1350, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-select bg-white text-dark\" aria-placeholder=\"Status\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c7c100a90dcfd017d62d7e5ef89727cc709275f9de9b03658eb9bb02515c4cd13567", async() => {
                WriteLiteral("All");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c7c100a90dcfd017d62d7e5ef89727cc709275f9de9b03658eb9bb02515c4cd14772", async() => {
                WriteLiteral("Enrolled");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c7c100a90dcfd017d62d7e5ef89727cc709275f9de9b03658eb9bb02515c4cd15982", async() => {
                WriteLiteral("Unregistered");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </select>
                </div>
            </div>
        </div>
    </div>
    <!-- Welcome End -->

    <!-- Courses Start -->
    <div class=""container-fluid"">
        <div class=""container py-5"">
            <div class=""text-center mb-5 mt-5"">
                <h1>Our Popular Courses</h1>
            </div>

");
#nullable restore
#line 45 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                  
                    foreach(var category in Model.Item2){
                        int courseCount = 0;
                        int categoryCount = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\">\r\n");
#nullable restore
#line 50 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                              
                                foreach(var course in Model.Item1){
                                    foreach(var instructor in Model.Item4){
                                        foreach(var instruct in Model.Item3){
                                            if(course.CourseId == instruct.CourseId && instructor.InstructorId == instruct.InstructorId){
                                                if(category.CategoryId == course.CategoryId){
                                                    if (string.IsNullOrEmpty(searchKeyword) || course.CourseName.Contains(searchKeyword)){
                                                        if(categoryCount == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <h3 class=\"col-lg-12 col-md-12 text-dark pt-2 mb-3\">");
#nullable restore
#line 58 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                                                                                                           Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 59 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                                                            categoryCount = 1;
                                                        }
                                                        if(courseCount < 3){ 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            <div class=""course-container col-lg-4 col-md-6 mb-4"">
                                                                <div class=""rounded overflow-hidden mb-2"">
                                                                    <a class=""text-decoration-none""");
            BeginWriteAttribute("href", " href=\"", 3570, "\"", 3616, 2);
            WriteAttributeValue("", 3577, "/Home/CourseDetail/", 3577, 19, true);
#nullable restore
#line 64 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
WriteAttributeValue("", 3596, instruct.InstructId, 3596, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", "\r\n                                                                    title=\"", 3617, "\"", 3712, 1);
#nullable restore
#line 65 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
WriteAttributeValue("", 3694, course.CourseName, 3694, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5c7c100a90dcfd017d62d7e5ef89727cc709275f9de9b03658eb9bb02515c4cd20850", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                                        <div class=""p-4"" style=""border: 1px solid #a7a7a7; background-color: #e3e3e3;"">
                                                                            <div class=""d-flex justify-content-between mb-3 text-theme"">
                                                                                <small class=""m-0""><i class=""fa fa-users text-dark mr-2""></i>26 Students</small>
                                                                                <small class=""m-0""><i class=""bx bxs-time text-primary mr-2""></i>");
#nullable restore
#line 70 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                                                                                                                                           Write(course.TotalTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                                                            </div>\r\n                                                                            <h5 class=\"course-name text-theme\">");
#nullable restore
#line 72 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                                                                                                          Write(course.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                                                            <div class=""border-top mt-4 pt-4"">
                                                                                <div class=""d-flex justify-content-between text-theme"">
");
#nullable restore
#line 75 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                                                                                      
                                                                                        int? rating = 0;
                                                                                        int count = 0;
                                                                                        foreach(var review in Model.Item5){
                                                                                            if(review.CourseId == course.CourseId){
                                                                                                rating += review.Rating;
                                                                                                count++;
                                                                                            }
                                                                                        }
                                                                                        int? average = count > 0 ? rating / count : 0;
                                                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                                    <h6 class=\"m-0\"><i class=\"bx bxs-star text-warning mr-2 mb-2\"></i>");
#nullable restore
#line 86 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                                                                                                                                                 Write(average);

#line default
#line hidden
#nullable disable
            WriteLiteral("<small class=\"ml-1\">(");
#nullable restore
#line 86 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                                                                                                                                                                              Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</small></h6>\r\n                                                                                    <h5 class=\"m-0\">");
#nullable restore
#line 87 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                                                                                                Write(course.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"đ</h5>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </a>
                                                                </div>
                                                            </div>
");
#nullable restore
#line 94 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                                                            courseCount++;
                                                        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <div class=\"course-container col-lg-4 col-md-6 mb-4 collapse\"");
            BeginWriteAttribute("id", " id=\"", 7197, "\"", 7231, 2);
            WriteAttributeValue("", 7202, "demo-", 7202, 5, true);
#nullable restore
#line 96 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
WriteAttributeValue("", 7207, category.CategoryName, 7207, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                <div class=\"rounded overflow-hidden mb-2\">\r\n                                                                    <a class=\"text-decoration-none\"");
            BeginWriteAttribute("title", " title=\"", 7442, "\"", 7468, 1);
#nullable restore
#line 98 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
WriteAttributeValue("", 7450, course.CourseName, 7450, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 7469, "\"", 7476, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5c7c100a90dcfd017d62d7e5ef89727cc709275f9de9b03658eb9bb02515c4cd28517", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                                        <div class=""p-4"" style=""border: 1px solid #a7a7a7; background-color: #e3e3e3;"">
                                                                            <div class=""d-flex justify-content-between mb-3 text-theme"">
                                                                                <small class=""m-0""><i class=""fa fa-users text-dark mr-2""></i>25 Students</small>
                                                                                <small class=""m-0""><i class=""bx bxs-time text-primary mr-2""></i>");
#nullable restore
#line 103 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                                                                                                                                           Write(course.TotalTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                                                            </div>\r\n                                                                            <h5 class=\"course-name text-theme\">");
#nullable restore
#line 105 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                                                                                                          Write(course.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                                                            <div class=""border-top mt-4 pt-4"">
                                                                                <div class=""d-flex justify-content-between text-theme"">
");
#nullable restore
#line 108 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                                                                                      
                                                                                        int? rating = 0;
                                                                                        int count = 0;
                                                                                        foreach(var review in Model.Item5){
                                                                                            if(review.CourseId == course.CourseId){
                                                                                                rating += review.Rating;
                                                                                                count++;
                                                                                            }
                                                                                        }
                                                                                        int? average = count > 0 ? rating / count : 0;
                                                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                                    <h6 class=\"m-0\"><i class=\"bx bxs-star text-warning mr-2 mb-2\"></i>");
#nullable restore
#line 119 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                                                                                                                                                 Write(average);

#line default
#line hidden
#nullable disable
            WriteLiteral("<small class=\"ml-1\">(");
#nullable restore
#line 119 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                                                                                                                                                                              Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</small></h6>\r\n                                                                                    <h5 class=\"m-0\">");
#nullable restore
#line 120 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                                                                                                Write(course.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"đ</h5>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </a>
                                                                </div>
                                                            </div>
");
#nullable restore
#line 127 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                                                        }
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 137 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                         if(courseCount >= 3){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"more-course mb-4\">\r\n                                <button type=\"button\" class=\"btn btn-primary\" data-bs-toggle=\"collapse\" data-bs-target=\"#demo-");
#nullable restore
#line 139 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                                                                                                                          Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                onclick=\"toggleButtonText(this)\">See more</button>\r\n                            </div>\r\n");
#nullable restore
#line 142 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "D:\Group03_Project\Project_Group3\Views\Home\Course.cshtml"
                         
                        
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <!-- Courses End -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<WebLibrary.Models.Course>, List<WebLibrary.Models.Category>, 
    List<WebLibrary.Models.Instruct>, List<WebLibrary.Models.Instructor>, List<WebLibrary.Models.Review>>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
