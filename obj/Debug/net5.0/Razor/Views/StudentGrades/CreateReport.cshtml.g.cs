#pragma checksum "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\StudentGrades\CreateReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "595a3d5f64538c2325eab5b8b12bdaa8eea728de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentGrades_CreateReport), @"mvc.1.0.view", @"/Views/StudentGrades/CreateReport.cshtml")]
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
#line 1 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\_ViewImports.cshtml"
using CenedexUniversityWebSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\_ViewImports.cshtml"
using CenedexUniversityWebSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"595a3d5f64538c2325eab5b8b12bdaa8eea728de", @"/Views/StudentGrades/CreateReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a567708cef0a3c29b262da8729f871a564e8d8e8", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentGrades_CreateReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CenedexUniversityWebSystem.Models.CourseReportViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\StudentGrades\CreateReport.cshtml"
  
    ViewData["Title"] = "Student's Grade Report";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<h1 class=""text-center"">CENEDEX UNIVERSITY</h1>

<div class=""card"">
    <div class=""card-header"">
        <h4 class=""text-center"">
            <span class=""text-info italic"">Student's Course Report</span>
            <span class=""small font-weight-bold"">Created on - ");
#nullable restore
#line 13 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\StudentGrades\CreateReport.cshtml"
                                                         Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </h4>\r\n    </div>\r\n</div>\r\n<div class=\"table-responsive-xs\">\r\n    <table class=\"table table-hover table-xs\" id=\"tbl-list\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\StudentGrades\CreateReport.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\StudentGrades\CreateReport.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 28 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\StudentGrades\CreateReport.cshtml"
               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 31 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\StudentGrades\CreateReport.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 34 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\StudentGrades\CreateReport.cshtml"
               Write(Html.DisplayNameFor(model => model.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\StudentGrades\CreateReport.cshtml"
               Write(Html.DisplayNameFor(model => model.DateTaken));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\StudentGrades\CreateReport.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\StudentGrades\CreateReport.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\StudentGrades\CreateReport.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 52 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\StudentGrades\CreateReport.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\StudentGrades\CreateReport.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 58 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\StudentGrades\CreateReport.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 61 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\StudentGrades\CreateReport.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DateTaken));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 64 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\StudentGrades\CreateReport.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<div class=\"container mt-4\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "595a3d5f64538c2325eab5b8b12bdaa8eea728de11178", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "595a3d5f64538c2325eab5b8b12bdaa8eea728de12456", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CenedexUniversityWebSystem.Models.CourseReportViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
