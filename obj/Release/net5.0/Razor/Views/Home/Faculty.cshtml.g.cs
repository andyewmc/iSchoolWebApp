#pragma checksum "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51d2389c6d47a5294c56794502a6b2a171d6bdff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Faculty), @"mvc.1.0.view", @"/Views/Home/Faculty.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51d2389c6d47a5294c56794502a6b2a171d6bdff", @"/Views/Home/Faculty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d65830e0cf286c100489d20fa53690508ae5adb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Faculty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<iSchoolWebApp.Models.FacultyRootModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
  
    ViewData["Title"] = Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 8 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
 foreach (var faculty in Model.faculty) { 


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"min-height:260px;width:200px;display:inline-table\">\r\n        <div class=\"thumnail\">\r\n            <!--image path, name, username-->\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 328, "\"", 352, 1);
#nullable restore
#line 13 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
WriteAttributeValue("", 334, faculty.imagePath, 334, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("atl", " atl=\"", 353, "\"", 376, 1);
#nullable restore
#line 13 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
WriteAttributeValue("", 359, faculty.username, 359, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:200px\" />\r\n            <h3 style=\"font-size:small\">\r\n                ");
#nullable restore
#line 15 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
           Write(faculty.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h3>\r\n\r\n            <!--tagline-->\r\n");
#nullable restore
#line 19 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
             if (@faculty.tagline != "")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 style=\"font-size:small\">\r\n            ");
#nullable restore
#line 22 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
       Write(faculty.tagline);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>");
#nullable restore
#line 23 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!--title-->\r\n            <h3 style=\"font-size:small\">\r\n                ");
#nullable restore
#line 27 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
           Write(faculty.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h3>\r\n\r\n            <!--Areas of interest-->\r\n");
#nullable restore
#line 31 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
             if (@faculty.interestArea != "")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 style=\"font-size:small\">\r\n            Areas of Interest: ");
#nullable restore
#line 34 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
                          Write(faculty.interestArea);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>");
#nullable restore
#line 35 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!--website-->\r\n");
#nullable restore
#line 38 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
             if (@faculty.website != "")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 style=\"font-size:small\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1139, "\"", 1162, 1);
#nullable restore
#line 41 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
WriteAttributeValue("", 1146, faculty.website, 1146, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Faculty Site</a>\r\n        </h3>");
#nullable restore
#line 42 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!--email-->\r\n");
#nullable restore
#line 45 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
             if (@faculty.email != "")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 style=\"font-size:small\">\r\n            Email: ");
#nullable restore
#line 48 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
              Write(faculty.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>");
#nullable restore
#line 49 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!--phone-->\r\n");
#nullable restore
#line 52 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
             if (@faculty.phone != "" | @faculty.phone != "null")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 style=\"font-size:small\">\r\n            Phone: ");
#nullable restore
#line 55 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
              Write(faculty.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>");
#nullable restore
#line 56 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!--office-->\r\n");
#nullable restore
#line 59 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
             if (@faculty.office != "" | @faculty.office != "null")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 style=\"font-size:small\">\r\n            Phone: ");
#nullable restore
#line 62 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
              Write(faculty.office);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>");
#nullable restore
#line 63 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!--twitter-->\r\n");
#nullable restore
#line 66 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
             if (@faculty.twitter != "" | @faculty.twitter != "null")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 style=\"font-size:small\">\r\n            Twitter Handle: ");
#nullable restore
#line 69 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
                       Write(faculty.twitter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>");
#nullable restore
#line 70 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!--facebook-->\r\n");
#nullable restore
#line 73 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
             if (@faculty.facebook != "" | @faculty.facebook != "null")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 style=\"font-size:small\">\r\n            Facebook: ");
#nullable restore
#line 76 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
                 Write(faculty.facebook);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>");
#nullable restore
#line 77 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 80 "/Users/andersonerskine/Desktop/iSchoolWebAppDone/iSchoolWebApp/iSchoolWebApp/Views/Home/Faculty.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<iSchoolWebApp.Models.FacultyRootModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
