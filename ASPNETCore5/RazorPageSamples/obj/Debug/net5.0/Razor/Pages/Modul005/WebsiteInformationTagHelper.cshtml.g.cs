#pragma checksum "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\ASPNETCore5\RazorPageSamples\Pages\Modul005\WebsiteInformationTagHelper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95c223e1f6a1c2e7ba5330c4d60c82029fa8dd09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPageSamples.Pages.Modul005.Pages_Modul005_WebsiteInformationTagHelper), @"mvc.1.0.razor-page", @"/Pages/Modul005/WebsiteInformationTagHelper.cshtml")]
namespace RazorPageSamples.Pages.Modul005
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
#line 2 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\ASPNETCore5\RazorPageSamples\Pages\Modul005\WebsiteInformationTagHelper.cshtml"
using RazorPageSamples.TagHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95c223e1f6a1c2e7ba5330c4d60c82029fa8dd09", @"/Pages/Modul005/WebsiteInformationTagHelper.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a62f2db48577cbaf53f7af60ccde9211900af9c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Modul005_WebsiteInformationTagHelper : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::RazorPageSamples.TagHelpers.WebsiteInformationTagHelper __RazorPageSamples_TagHelpers_WebsiteInformationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\ASPNETCore5\RazorPageSamples\Pages\Modul005\WebsiteInformationTagHelper.cshtml"
   
    WebsiteContext websiteContext = new WebsiteContext
    {
        Version = new Version(1, 3),
        CopyrightYear = 1919,
        Approved = true,
        TagsToShow = 131
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CustomTagHelper</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("website-information", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "95c223e1f6a1c2e7ba5330c4d60c82029fa8dd093997", async() => {
            }
            );
            __RazorPageSamples_TagHelpers_WebsiteInformationTagHelper = CreateTagHelper<global::RazorPageSamples.TagHelpers.WebsiteInformationTagHelper>();
            __tagHelperExecutionContext.Add(__RazorPageSamples_TagHelpers_WebsiteInformationTagHelper);
#nullable restore
#line 18 "C:\Aktueller Kurs\ASPNETCore-KW44-ppedv\ASPNETCore5\RazorPageSamples\Pages\Modul005\WebsiteInformationTagHelper.cshtml"
__RazorPageSamples_TagHelpers_WebsiteInformationTagHelper.Info = websiteContext;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("info", __RazorPageSamples_TagHelpers_WebsiteInformationTagHelper.Info, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsiteInformationTagHelperModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebsiteInformationTagHelperModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebsiteInformationTagHelperModel>)PageContext?.ViewData;
        public WebsiteInformationTagHelperModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
