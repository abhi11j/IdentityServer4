#pragma checksum "C:\MyWorkItem\quickstart\src\MvcClient\Views\Shared\Json.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c115563a4784eada1fe49d8d19246905df7dd528"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Json), @"mvc.1.0.view", @"/Views/Shared/Json.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Json.cshtml", typeof(AspNetCore.Views_Shared_Json))]
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
#line 1 "C:\MyWorkItem\quickstart\src\MvcClient\Views\_ViewImports.cshtml"
using MvcClient;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c115563a4784eada1fe49d8d19246905df7dd528", @"/Views/Shared/Json.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c636607b21b02315b98fd6a0b039b1791dfb41a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Json : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\MyWorkItem\quickstart\src\MvcClient\Views\Shared\Json.cshtml"
  
    ViewData["Title"] = "Json";

#line default
#line hidden
            BeginContext(42, 24, true);
            WriteLiteral("\r\n<h2>Json</h2>\r\n\r\n<pre>");
            EndContext();
            BeginContext(67, 12, false);
#line 8 "C:\MyWorkItem\quickstart\src\MvcClient\Views\Shared\Json.cshtml"
Write(ViewBag.Json);

#line default
#line hidden
            EndContext();
            BeginContext(79, 8, true);
            WriteLiteral("</pre>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
