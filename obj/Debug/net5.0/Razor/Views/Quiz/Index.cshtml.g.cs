#pragma checksum "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\Quiz\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5cf9f1554e676915ba6d753388823d1e08efb944392e3fc3c9a9658f4f1f6cfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_Index), @"mvc.1.0.view", @"/Views/Quiz/Index.cshtml")]
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
#line 1 "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5cf9f1554e676915ba6d753388823d1e08efb944392e3fc3c9a9658f4f1f6cfa", @"/Views/Quiz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9414e8f56e2cc2d04e73044b10dc6e2cfbadc9fd54b07a1fac15f562fe514924", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Quiz_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<IEnumerable<WebLibrary.Models.Quiz>, IEnumerable<WebLibrary.Models.Answer>>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\Quiz\Index.cshtml"
  
    ViewData["Title"] = "Index";
      Layout = "~/Views/Shared/_Login.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List Quiz</h1>\r\n");
            WriteLiteral("    <a class=\"btn btn-success mb-2\"");
            BeginWriteAttribute("href", " href=\"", 533, "\"", 637, 1);
#nullable restore
#line 11 "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 540, Url.Action("Create", "Quiz", new { chapterId = ViewBag.ChapterId, courseId = ViewBag.CourseId }), 540, 97, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">add Quiz</a>\r\n        <a class=\"btn btn-success mb-2\"");
            BeginWriteAttribute("href", " href=\"", 692, "\"", 767, 1);
#nullable restore
#line 12 "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 699, Url.Action("Index", "Chapter", new { courseId = ViewBag.CourseId }), 699, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Back to Chapter</a>
<table class=""table"">
    <thead>
        <tr>
             <th>CourseName</th>
            <th>ChapterName</th>
            <th>Quiz1</th>
            <th>DapAnA</th>
            <th>DapAnB</th>
            <th>DapAnC</th>
            <th>DapAnD</th>
            <th>DapAn</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\Quiz\Index.cshtml"
         if (Model != null)
        {
            foreach (var quiz in Model.Item1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 32 "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\Quiz\Index.cshtml"
                   Write(ViewBag.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\Quiz\Index.cshtml"
                   Write(ViewBag.ChapterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\Quiz\Index.cshtml"
                   Write(quiz.Quiz1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\Quiz\Index.cshtml"
                   Write(quiz.DapAnA);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\Quiz\Index.cshtml"
                   Write(quiz.DapAnB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\Quiz\Index.cshtml"
                   Write(quiz.DapAnC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\Quiz\Index.cshtml"
                   Write(quiz.DapAnD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\Quiz\Index.cshtml"
                                       
                        string answerName = "";
                        foreach(var answer in Model.Item2){
                            if(quiz.AnswerId == answer.AnswerId){
                                answerName = answer.Answer1;
                                break;
                            }
                        }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
#nullable restore
#line 48 "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\Quiz\Index.cshtml"
   Write(answerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 51 "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\Quiz\Index.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td colspan=\"11\">No Quiz found.</td>\r\n            </tr>\r\n");
#nullable restore
#line 58 "E:\Hong_Linh\Chay_Thu\Project_Group3\Views\Quiz\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5cf9f1554e676915ba6d753388823d1e08efb944392e3fc3c9a9658f4f1f6cfa8693", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<IEnumerable<WebLibrary.Models.Quiz>, IEnumerable<WebLibrary.Models.Answer>>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
