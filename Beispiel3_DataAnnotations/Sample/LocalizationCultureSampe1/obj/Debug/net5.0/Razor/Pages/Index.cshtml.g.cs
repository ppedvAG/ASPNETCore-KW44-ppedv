#pragma checksum "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\Beispiel3_DataAnnotations\Sample\LocalizationCultureSampe1\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a16475ff490830b1315b5c2094ae4747f7fd1816"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LocalizationCultureSampe1.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace LocalizationCultureSampe1.Pages
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
#line 1 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\Beispiel3_DataAnnotations\Sample\LocalizationCultureSampe1\Pages\_ViewImports.cshtml"
using LocalizationCultureSampe1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\Beispiel3_DataAnnotations\Sample\LocalizationCultureSampe1\Pages\_ViewImports.cshtml"
using LocalizationCultureSampe1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\Beispiel3_DataAnnotations\Sample\LocalizationCultureSampe1\Pages\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\Beispiel3_DataAnnotations\Sample\LocalizationCultureSampe1\Pages\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\Beispiel3_DataAnnotations\Sample\LocalizationCultureSampe1\Pages\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\Beispiel3_DataAnnotations\Sample\LocalizationCultureSampe1\Pages\Index.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16475ff490830b1315b5c2094ae4747f7fd1816", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4a6934cdeda4855f6103e66967284a4b656cdf1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\Beispiel3_DataAnnotations\Sample\LocalizationCultureSampe1\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
    var requestCultureFeature = HttpContext.Features.Get<IRequestCultureFeature>();
    var requestCulture = requestCultureFeature.RequestCulture;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 14 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\Beispiel3_DataAnnotations\Sample\LocalizationCultureSampe1\Pages\Index.cshtml"
                     Write(localizer["Welcome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>");
#nullable restore
#line 15 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\Beispiel3_DataAnnotations\Sample\LocalizationCultureSampe1\Pages\Index.cshtml"
  Write(htmlLocalizer["Learn"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<IndexModel> htmlLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<IndexModel> localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
