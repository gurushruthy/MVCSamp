#pragma checksum "C:\Users\Shruthi\source\repos\MVCpro\MVCpro\Views\Demo\ShowFruits.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "634a255efc3dbab556c380aa08ea8a28638ae040"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_ShowFruits), @"mvc.1.0.view", @"/Views/Demo/ShowFruits.cshtml")]
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
#line 1 "C:\Users\Shruthi\source\repos\MVCpro\MVCpro\Views\_ViewImports.cshtml"
using MVCpro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shruthi\source\repos\MVCpro\MVCpro\Views\_ViewImports.cshtml"
using MVCpro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"634a255efc3dbab556c380aa08ea8a28638ae040", @"/Views/Demo/ShowFruits.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6e762f7fc5a77f3432c27272e601d7ae8e7e67b", @"/Views/_ViewImports.cshtml")]
    public class Views_Demo_ShowFruits : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>List of Fruits</h1>\r\n<ol>\r\n");
#nullable restore
#line 5 "C:\Users\Shruthi\source\repos\MVCpro\MVCpro\Views\Demo\ShowFruits.cshtml"
     foreach (string s in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 7 "C:\Users\Shruthi\source\repos\MVCpro\MVCpro\Views\Demo\ShowFruits.cshtml"
               Write(s);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 8 "C:\Users\Shruthi\source\repos\MVCpro\MVCpro\Views\Demo\ShowFruits.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
