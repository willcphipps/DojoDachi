#pragma checksum "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/DojoDachi/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19cbb5aaa3206c3da8814cd6cc1a16cb9d8429ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19cbb5aaa3206c3da8814cd6cc1a16cb9d8429ee", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bce70f5dafba3f05b5d94a87a662fc8c5511826", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DojoDachi>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/DojoDachi/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(63, 232, true);
            WriteLiteral("<div class=\"jumbotron jumbotron-fluid\">\r\n    <div class=\"container\">\r\n        <h1 class=\"display-3\">Dojodachi</h1>\r\n        <p class=\"lead\">Here is a dojodachi</p>\r\n        <hr class=\"my-2\">\r\n        <p>Meals</p> <progress id=\"file\"");
            EndContext();
            BeginWriteAttribute("value", "  value=\"", 295, "\"", 315, 1);
#line 10 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/DojoDachi/Views/Home/Index.cshtml"
WriteAttributeValue("", 304, Model.Meal, 304, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(316, 68, true);
            WriteLiteral(" max=\"100\"> </progress>\r\n        <p>Fullness</p> <progress id=\"file\"");
            EndContext();
            BeginWriteAttribute("value", "  value=\"", 384, "\"", 408, 1);
#line 11 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/DojoDachi/Views/Home/Index.cshtml"
WriteAttributeValue("", 393, Model.Fullness, 393, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(409, 65, true);
            WriteLiteral(" max=\"100\"></progress>\r\n        <p>Energy</p> <progress id=\"file\"");
            EndContext();
            BeginWriteAttribute("value", "  value=\"", 474, "\"", 496, 1);
#line 12 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/DojoDachi/Views/Home/Index.cshtml"
WriteAttributeValue("", 483, Model.Energy, 483, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(497, 68, true);
            WriteLiteral(" max=\"100\"></progress>\r\n        <p>Happiness</p> <progress id=\"file\"");
            EndContext();
            BeginWriteAttribute("value", "  value=\"", 565, "\"", 590, 1);
#line 13 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/DojoDachi/Views/Home/Index.cshtml"
WriteAttributeValue("", 574, Model.Happiness, 574, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(591, 376, true);
            WriteLiteral(@" max=""100""></progress>

        <p class=""lead"">
            <a href=""/play""><button class=""btn-dark"">play</button></a>
            <a href=""/work""><button class=""btn-dark"">work</button></a>
            <a href=""/sleep""><button class=""btn-dark"">sleep</button></a>
            <a href=""/feed""><button class=""btn-dark"">feed</button></a>
        </p>
    </div>
</div>
");
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