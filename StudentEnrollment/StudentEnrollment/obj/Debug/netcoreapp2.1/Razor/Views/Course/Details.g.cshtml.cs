#pragma checksum "C:\Users\Max\codefellows\401 ASP.NET C#\Lab13-Student-Enrollment\StudentEnrollment\StudentEnrollment\Views\Course\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "420853d0ae9b60456c00215fee02a30ce91f3480"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Details), @"mvc.1.0.view", @"/Views/Course/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/Details.cshtml", typeof(AspNetCore.Views_Course_Details))]
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
#line 1 "C:\Users\Max\codefellows\401 ASP.NET C#\Lab13-Student-Enrollment\StudentEnrollment\StudentEnrollment\Views\Course\Details.cshtml"
using StudentEnrollment.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420853d0ae9b60456c00215fee02a30ce91f3480", @"/Views/Course/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentEnrollment.Models.CourseDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(88, 26, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<h3>");
            EndContext();
            BeginContext(115, 17, false);
#line 6 "C:\Users\Max\codefellows\401 ASP.NET C#\Lab13-Student-Enrollment\StudentEnrollment\StudentEnrollment\Views\Course\Details.cshtml"
Write(Model.Course.Name);

#line default
#line hidden
            EndContext();
            BeginContext(132, 11, true);
            WriteLiteral("</h3>\r\n<h3>");
            EndContext();
            BeginContext(144, 24, false);
#line 7 "C:\Users\Max\codefellows\401 ASP.NET C#\Lab13-Student-Enrollment\StudentEnrollment\StudentEnrollment\Views\Course\Details.cshtml"
Write(Model.Course.MaxStudents);

#line default
#line hidden
            EndContext();
            BeginContext(168, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Max\codefellows\401 ASP.NET C#\Lab13-Student-Enrollment\StudentEnrollment\StudentEnrollment\Views\Course\Details.cshtml"
 foreach (var student in Model.Students)
{

#line default
#line hidden
            BeginContext(222, 13, true);
            WriteLiteral("    <p>Name: ");
            EndContext();
            BeginContext(236, 12, false);
#line 11 "C:\Users\Max\codefellows\401 ASP.NET C#\Lab13-Student-Enrollment\StudentEnrollment\StudentEnrollment\Views\Course\Details.cshtml"
        Write(student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(248, 21, true);
            WriteLiteral("</p>\r\n    <p>Course: ");
            EndContext();
            BeginContext(270, 14, false);
#line 12 "C:\Users\Max\codefellows\401 ASP.NET C#\Lab13-Student-Enrollment\StudentEnrollment\StudentEnrollment\Views\Course\Details.cshtml"
          Write(student.Course);

#line default
#line hidden
            EndContext();
            BeginContext(284, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 13 "C:\Users\Max\codefellows\401 ASP.NET C#\Lab13-Student-Enrollment\StudentEnrollment\StudentEnrollment\Views\Course\Details.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentEnrollment.Models.CourseDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
