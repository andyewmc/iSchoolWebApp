#pragma checksum "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Minors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35383091b43da886c616134a3f2c35e71891a375"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Minors), @"mvc.1.0.view", @"/Views/Home/Minors.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35383091b43da886c616134a3f2c35e71891a375", @"/Views/Home/Minors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d65830e0cf286c100489d20fa53690508ae5adb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Minors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<iSchoolWebApp.Models.UgMinorsRoot>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Minors.cshtml"
   ViewData["Title"] = Model.Title; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"minors\">\r\n    <h3>Minors</h3>\r\n    <div id=\"holdMinors\">\r\n");
#nullable restore
#line 8 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Minors.cshtml"
         foreach (var minor in Model.UgMinors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4> ");
#nullable restore
#line 10 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Minors.cshtml"
            Write(minor.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 10 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Minors.cshtml"
                          Write(minor.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h4>\n            <div><p>  ");
#nullable restore
#line 11 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Minors.cshtml"
                 Write(minor.description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p> <p>");
#nullable restore
#line 11 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Minors.cshtml"
                                            Write(minor.note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\n");
#nullable restore
#line 12 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Minors.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<iSchoolWebApp.Models.UgMinorsRoot> Html { get; private set; }
    }
}
#pragma warning restore 1591
