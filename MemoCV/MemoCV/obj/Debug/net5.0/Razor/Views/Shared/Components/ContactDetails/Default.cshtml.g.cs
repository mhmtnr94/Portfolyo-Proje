#pragma checksum "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\ContactDetails\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1ab39ca065ac38f75f994969c362ec428adaa28ebaa7a2856bbef798a641d68a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContactDetails_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ContactDetails/Default.cshtml")]
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
#line 1 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\ContactDetails\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1ab39ca065ac38f75f994969c362ec428adaa28ebaa7a2856bbef798a641d68a", @"/Views/Shared/Components/ContactDetails/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"53845d265e939d4425388a37539c3bdf049b196661889a7051128b1f216a7644", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ContactDetails_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\ContactDetails\Default.cshtml"
 foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"contact-infos\">\r\n    <div class=\"item\">\r\n        <i class=\"ti-mobile\"></i>\r\n        <div>\r\n            <h5>Telefon</h5>\r\n            <p>");
#nullable restore
#line 9 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\ContactDetails\Default.cshtml"
          Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"item\">\r\n        <i class=\"ti-email\"></i>\r\n        <div class=\"mb-0\">\r\n            <h5>E-Posta Adresi</h5>\r\n            <p>");
#nullable restore
#line 16 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\ContactDetails\Default.cshtml"
          Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>  \r\n");
#nullable restore
#line 20 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\ContactDetails\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591