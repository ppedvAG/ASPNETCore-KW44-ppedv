#pragma checksum "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\ASPNETCore5\RazorPageSamples\Pages\Modul007\Gallery2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76c302523df2c15a248f4862860cd9850df81909"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPageSamples.Pages.Modul007.Pages_Modul007_Gallery2), @"mvc.1.0.razor-page", @"/Pages/Modul007/Gallery2.cshtml")]
namespace RazorPageSamples.Pages.Modul007
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
#line 1 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\ASPNETCore5\RazorPageSamples\Pages\_ViewImports.cshtml"
using RazorPageSamples;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\ASPNETCore5\RazorPageSamples\Pages\_ViewImports.cshtml"
using RazorPageSamples.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\ASPNETCore5\RazorPageSamples\Pages\_ViewImports.cshtml"
using RazorPageSamples.TagHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76c302523df2c15a248f4862860cd9850df81909", @"/Pages/Modul007/Gallery2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a62f2db48577cbaf53f7af60ccde9211900af9c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Modul007_Gallery2 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\ASPNETCore5\RazorPageSamples\Pages\Modul007\Gallery2.cshtml"
     foreach (var item in Model.Bilder)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12 col-md-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76c302523df2c15a248f4862860cd9850df819093788", async() => {
                WriteLiteral("\r\n                <img class=\"img-fluid\"");
                BeginWriteAttribute("src", " src=\"", 299, "\"", 353, 2);
                WriteAttributeValue("", 305, "/imagegen?img=/", 305, 15, true);
#nullable restore
#line 13 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\ASPNETCore5\RazorPageSamples\Pages\Modul007\Gallery2.cshtml"
WriteAttributeValue("", 320, System.IO.Path.GetFileName(item), 320, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 215, "~/images/", 215, 9, true);
#nullable restore
#line 12 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\ASPNETCore5\RazorPageSamples\Pages\Modul007\Gallery2.cshtml"
AddHtmlAttributeValue("", 224, System.IO.Path.GetFileName(item), 224, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 16 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\ASPNETCore5\RazorPageSamples\Pages\Modul007\Gallery2.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPageSamples.Pages.Modul007.Gallery2Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPageSamples.Pages.Modul007.Gallery2Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPageSamples.Pages.Modul007.Gallery2Model>)PageContext?.ViewData;
        public RazorPageSamples.Pages.Modul007.Gallery2Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591