#pragma checksum "/home/e1/Desktop/dotnet/Pages/Stat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feae737b914c192cc98a47d11cceda1bcd6d27d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(dotnet.Pages.Pages_Stat), @"mvc.1.0.razor-page", @"/Pages/Stat.cshtml")]
namespace dotnet.Pages
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
#line 1 "/home/e1/Desktop/dotnet/Pages/_ViewImports.cshtml"
using dotnet;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feae737b914c192cc98a47d11cceda1bcd6d27d2", @"/Pages/Stat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"191f181b2c2bc8835baf6c181e4db111f8260a6c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Stat : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/e1/Desktop/dotnet/Pages/Stat.cshtml"
  
    ViewData["Title"] = "Stat";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n\n    <div>");
#nullable restore
#line 9 "/home/e1/Desktop/dotnet/Pages/Stat.cshtml"
    Write(ViewData["count"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StatModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StatModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StatModel>)PageContext?.ViewData;
        public StatModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
