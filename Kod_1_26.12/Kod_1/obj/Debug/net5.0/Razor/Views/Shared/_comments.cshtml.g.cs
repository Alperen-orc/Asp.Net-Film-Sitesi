#pragma checksum "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Shared\_comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eca6a5c3908d58810888e7fee32de4265aac988d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__comments), @"mvc.1.0.view", @"/Views/Shared/_comments.cshtml")]
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
#line 1 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\_ViewImports.cshtml"
using Kod_1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\_ViewImports.cshtml"
using Kod_1.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eca6a5c3908d58810888e7fee32de4265aac988d", @"/Views/Shared/_comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5c69e29f71855f10dfce6b593d2b987a3ba2dc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Comment>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card mb-3\">\r\n    <div class=\"row \">\r\n        <div class=\"col-md-3\">\r\n            \r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            <div class=\"card-body\">\r\n                \r\n                <div>\r\n");
            WriteLiteral("                    <div>\r\n                        \r\n                        ");
#nullable restore
#line 15 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Shared\_comments.cshtml"
                   Write(Model.comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Comment> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
