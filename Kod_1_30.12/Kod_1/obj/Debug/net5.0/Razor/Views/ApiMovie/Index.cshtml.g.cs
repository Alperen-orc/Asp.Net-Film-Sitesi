#pragma checksum "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\ApiMovie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33fcacfebeca2a867e0e57f96dbf9d303dd78762"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApiMovie_Index), @"mvc.1.0.view", @"/Views/ApiMovie/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33fcacfebeca2a867e0e57f96dbf9d303dd78762", @"/Views/ApiMovie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5c69e29f71855f10dfce6b593d2b987a3ba2dc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ApiMovie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ApiMovieViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/sneat-1.0.0/assets/js/ui-modals.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"           
<table class=""table table-striped"">
    <tr>
        <th class=""text-center"">#</th>
        <th class=""text-center"">Görsel</th>
        <th class=""text-center"">Film Adı</th>
        <th class=""text-center"">Puanı</th>
        <th class=""text-center"">Çıkış Yılı</th>
        <th class=""text-center"">Fragman</th>
    </tr>
");
#nullable restore
#line 12 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\ApiMovie\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\ApiMovie\Index.cshtml"
           Write(item.rank);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <img class=\"rounded\"");
            BeginWriteAttribute("src", " src=\"", 516, "\"", 533, 1);
#nullable restore
#line 17 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\ApiMovie\Index.cshtml"
WriteAttributeValue("", 522, item.image, 522, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"150\" /> \r\n            </td>\r\n            <td class=\"text-center\" style=\"zoom: 90%;\"><b>");
#nullable restore
#line 19 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\ApiMovie\Index.cshtml"
                                                     Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td> \r\n            <td>");
#nullable restore
#line 20 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\ApiMovie\Index.cshtml"
           Write(item.rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\ApiMovie\Index.cshtml"
           Write(item.year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n\r\n                <button type=\"button\" class=\"btn btn-outline-primary\" data-bs-toggle=\"modal\" data-bs-target=\"#youTubeModal\" data-thevideo=\"");
#nullable restore
#line 24 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\ApiMovie\Index.cshtml"
                                                                                                                                      Write(item.trailer);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                    <i class='bx bx-movie-play'></i> &nbsp;
                    Fragman
                </button>
                <div class=""modal fade"" id=""youTubeModal"" tabindex=""-1"" style=""display: none;"" aria-hidden=""true"">
                    <div class=""modal-dialog"" role=""document"">
                        <div class=""modal-content"">
                            <iframe height=""350""");
            BeginWriteAttribute("src", " src=\"", 1307, "\"", 1326, 1);
#nullable restore
#line 31 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\ApiMovie\Index.cshtml"
WriteAttributeValue("", 1313, item.trailer, 1313, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></iframe>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\ApiMovie\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33fcacfebeca2a867e0e57f96dbf9d303dd787627285", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ApiMovieViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
