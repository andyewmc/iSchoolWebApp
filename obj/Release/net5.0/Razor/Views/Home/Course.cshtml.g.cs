#pragma checksum "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Course.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebed0180db53ddb210bf37f654b169402c3e3723"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Course), @"mvc.1.0.view", @"/Views/Home/Course.cshtml")]
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
#line 1 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/_ViewImports.cshtml"
using iSchoolWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/_ViewImports.cshtml"
using iSchoolWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebed0180db53ddb210bf37f654b169402c3e3723", @"/Views/Home/Course.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d65830e0cf286c100489d20fa53690508ae5adb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Course : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<iSchoolWebApp.Models.CourseRootModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Course.cshtml"
   ViewData["Title"] = Model.Title; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Course.cshtml"
 foreach (var course in Model.course)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 6 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Course.cshtml"
   Write(course.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 6 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Course.cshtml"
                  Write(course.courseID);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h3>\r\n    <p>");
#nullable restore
#line 7 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Course.cshtml"
  Write(course.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 8 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Course.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<iSchoolWebApp.Models.CourseRootModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
