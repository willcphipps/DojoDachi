#pragma checksum "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/DojoDachi/Views/Home/Died.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bc62eda55202a97e46266ba0ffc7b779101e693"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Died), @"mvc.1.0.view", @"/Views/Home/Died.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Died.cshtml", typeof(AspNetCore.Views_Home_Died))]
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
#line 1 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/DojoDachi/Views/_ViewImports.cshtml"
using DojoDachi;

#line default
#line hidden
#line 2 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/DojoDachi/Views/_ViewImports.cshtml"
using DojoDachi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bc62eda55202a97e46266ba0ffc7b779101e693", @"/Views/Home/Died.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bce70f5dafba3f05b5d94a87a662fc8c5511826", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Died : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DojoDachi>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 153, true);
            WriteLiteral("\n<div id=\"upper\" class=\"jumbotron jumbotron-fluid\">\n    <div class=\"container\">\n        <h1 class=\"display-3\">You have Died</h1>\n        <p class=\"lead\">");
            EndContext();
            BeginContext(171, 9, false);
#line 6 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/DojoDachi/Views/Home/Died.cshtml"
                   Write(Model.Log);

#line default
#line hidden
            EndContext();
            BeginContext(180, 179, true);
            WriteLiteral("</p>\n        <hr class=\"my-2\">\n    <div class=\"d-flex justify-content-between\">\n        <div class=\"flex-columm\">\n            <h4>Here are your stats.</h4>\n            <p>Meals:  ");
            EndContext();
            BeginContext(360, 10, false);
#line 11 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/DojoDachi/Views/Home/Died.cshtml"
                  Write(Model.Meal);

#line default
#line hidden
            EndContext();
            BeginContext(370, 31, true);
            WriteLiteral("</p>\n            <p>Happiness: ");
            EndContext();
            BeginContext(402, 15, false);
#line 12 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/DojoDachi/Views/Home/Died.cshtml"
                     Write(Model.Happiness);

#line default
#line hidden
            EndContext();
            BeginContext(417, 31, true);
            WriteLiteral("</p>\n            <p>Fullness:  ");
            EndContext();
            BeginContext(449, 14, false);
#line 13 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/DojoDachi/Views/Home/Died.cshtml"
                     Write(Model.Fullness);

#line default
#line hidden
            EndContext();
            BeginContext(463, 29, true);
            WriteLiteral("</p>\n            <p>Energy:  ");
            EndContext();
            BeginContext(493, 12, false);
#line 14 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/DojoDachi/Views/Home/Died.cshtml"
                   Write(Model.Energy);

#line default
#line hidden
            EndContext();
            BeginContext(505, 38, true);
            WriteLiteral("</p>\n        </div>\n        <div> <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 543, "\"", 559, 1);
#line 16 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/DojoDachi/Views/Home/Died.cshtml"
WriteAttributeValue("", 549, Model.Img, 549, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(560, 183, true);
            WriteLiteral(" height=\"250px\" alt=\"\"> </div>\n    <div>\n        <p class=\"lead\">\n            <a class=\"btn btn-danger btn-lg\" href=\"/Restart\" role=\"button\">Restart</a>\n        </p>\n    </div>\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DojoDachi> Html { get; private set; }
    }
}
#pragma warning restore 1591
