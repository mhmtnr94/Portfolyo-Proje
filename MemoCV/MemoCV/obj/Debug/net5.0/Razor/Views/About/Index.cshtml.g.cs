#pragma checksum "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\About\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "76f9acf97cb5d7360a216a0dfe3991f2f588ea4f452ed813be915a040720b735"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"76f9acf97cb5d7360a216a0dfe3991f2f588ea4f452ed813be915a040720b735", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"53845d265e939d4425388a37539c3bdf049b196661889a7051128b1f216a7644", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.About>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Hakkımda Düzenleme Sayfası</h1>\r\n");
#nullable restore
#line 8 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\About\Index.cshtml"
 using (Html.BeginForm("Index", "About", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\About\Index.cshtml"
Write(Html.HiddenFor(x=>x.AboutID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Başlık</label>\r\n");
#nullable restore
#line 13 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Title,new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Açıklama</label>\r\n");
#nullable restore
#line 16 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\About\Index.cshtml"
Write(Html.TextAreaFor(x=>x.Description,10,2,new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Görsel</label>\r\n");
#nullable restore
#line 19 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x=>x.ImageURL,new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Güncelle</button>\r\n");
#nullable restore
#line 22 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\About\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.About> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
