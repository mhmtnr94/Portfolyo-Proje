#pragma checksum "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\TestimonialList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9815ed32fd6db94f990c1f7637b529daf1ae16e3a16b87323e5f842b3f7c84f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TestimonialList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TestimonialList/Default.cshtml")]
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
#line 1 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\_ViewImports.cshtml"
using MemoCV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\_ViewImports.cshtml"
using MemoCV.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\TestimonialList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9815ed32fd6db94f990c1f7637b529daf1ae16e3a16b87323e5f842b3f7c84f2", @"/Views/Shared/Components/TestimonialList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"53845d265e939d4425388a37539c3bdf049b196661889a7051128b1f216a7644", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_TestimonialList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section id=""testmonial"" class=""section"">
    <div class=""container text-center"">
        <h6 class=""subtitle"">Referanslarım</h6>
        <h6 class=""section-title mb-4"">İnsanlar Hakkımda Ne Düşünüyor?</h6>
        <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
            <ol class=""carousel-indicators"">
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
            </ol>
            <div class=""carousel-inner"">
");
#nullable restore
#line 14 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\TestimonialList\Default.cshtml"
                 foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"carousel-item active\">\r\n                    <div class=\"card testmonial-card border\">\r\n                        <div class=\"card-body\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 977, "\"", 997, 1);
#nullable restore
#line 18 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\TestimonialList\Default.cshtml"
WriteAttributeValue("", 983, item.ImageURL, 983, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 998, "\"", 1004, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <p>");
#nullable restore
#line 19 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\TestimonialList\Default.cshtml"
                          Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <h1 class=\"title\">");
#nullable restore
#line 20 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\TestimonialList\Default.cshtml"
                                         Write(item.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <h1 class=\"subtitle\">");
#nullable restore
#line 21 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\TestimonialList\Default.cshtml"
                                            Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 25 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\TestimonialList\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591