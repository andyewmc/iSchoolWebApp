#pragma checksum "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Employment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c114023fd9db2988155912bcb8bc457e290666e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Employment), @"mvc.1.0.view", @"/Views/Home/Employment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c114023fd9db2988155912bcb8bc457e290666e", @"/Views/Home/Employment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d65830e0cf286c100489d20fa53690508ae5adb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Employment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<iSchoolWebApp.Models.EmploymentRootModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Outcomes</h1>\n\n<h3>");
#nullable restore
#line 8 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Employment.cshtml"
Write(Model.introduction.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n\n\n");
#nullable restore
#line 12 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Employment.cshtml"
 foreach (var stat in Model.degreeStatistics.statistics)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"bigText\">  ");
#nullable restore
#line 14 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Employment.cshtml"
                    Write(stat.value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n    <p>");
#nullable restore
#line 15 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Employment.cshtml"
  Write(stat.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 16 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Employment.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 18 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Employment.cshtml"
 foreach (var content in Model.introduction.content)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>");
#nullable restore
#line 20 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Employment.cshtml"
   Write(content.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    <p>");
#nullable restore
#line 21 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Employment.cshtml"
  Write(content.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 22 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Employment.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h4> Current Employers </h4>\n\n");
#nullable restore
#line 26 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Employment.cshtml"
 foreach (var emp in Model.employers.employerNames)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p> emp </p> <br>\n");
#nullable restore
#line 29 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Employment.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""coops"">
    <div id=""coopTable"">
        <table class=""table"" id=""coop"">
            <thead>
                <tr>
                    <th>Employer</th>
                    <th>City</th>
                    <th>Degree</th>
                </tr>
               
            </thead>
        </table>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<iSchoolWebApp.Models.EmploymentRootModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
