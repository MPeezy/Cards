#pragma checksum "C:\Users\MPatton5\source\repos\Cards\Cards\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2b13ca8576d8bebfe715b428f120dada480b365"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\MPatton5\source\repos\Cards\Cards\Views\_ViewImports.cshtml"
using Cards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MPatton5\source\repos\Cards\Cards\Views\_ViewImports.cshtml"
using Cards.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2b13ca8576d8bebfe715b428f120dada480b365", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"218d696472f75d68fed934370ccee98db1099256", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Card>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n<p>Image: ");
#nullable restore
#line 6 "C:\Users\MPatton5\source\repos\Cards\Cards\Views\Home\Index.cshtml"
     Write(Model.image);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Value: ");
#nullable restore
#line 7 "C:\Users\MPatton5\source\repos\Cards\Cards\Views\Home\Index.cshtml"
     Write(Model.value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Suit: ");
#nullable restore
#line 8 "C:\Users\MPatton5\source\repos\Cards\Cards\Views\Home\Index.cshtml"
    Write(Model.suit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Card> Html { get; private set; }
    }
}
#pragma warning restore 1591
