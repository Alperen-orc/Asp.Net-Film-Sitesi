#pragma checksum "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9a2c3ff2a0c7f0315e23f6ecedbffd9e7b4536d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GenreUpdate), @"mvc.1.0.view", @"/Views/Admin/GenreUpdate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a2c3ff2a0c7f0315e23f6ecedbffd9e7b4536d", @"/Views/Admin/GenreUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5c69e29f71855f10dfce6b593d2b987a3ba2dc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_GenreUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminGenreEditViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GenreUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <h1>Edit Genre</h1>\r\n    <hr />\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9a2c3ff2a0c7f0315e23f6ecedbffd9e7b4536d6003", async() => {
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col md-3\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9a2c3ff2a0c7f0315e23f6ecedbffd9e7b4536d6348", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 9 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"GenreId\"");
                BeginWriteAttribute("value", " value=\"", 319, "\"", 341, 1);
#nullable restore
#line 10 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 327, Model.GenreId, 327, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <div class=\"mb-3\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9a2c3ff2a0c7f0315e23f6ecedbffd9e7b4536d8410", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 12 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9a2c3ff2a0c7f0315e23f6ecedbffd9e7b4536d9915", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 13 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9a2c3ff2a0c7f0315e23f6ecedbffd9e7b4536d11501", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 14 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n            </div>\r\n            <div class=\"col-md-9\">\r\n");
#nullable restore
#line 19 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
                 for (int i = 0; i < Model.Movies.Count; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 864, "\"", 889, 3);
                WriteAttributeValue("", 871, "Movies[", 871, 7, true);
#nullable restore
#line 21 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 878, i, 878, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 880, "].MovieId", 880, 9, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 890, "\"", 922, 1);
#nullable restore
#line 21 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 898, Model.Movies[i].MovieId, 898, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 968, "\"", 994, 3);
                WriteAttributeValue("", 975, "Movies[", 975, 7, true);
#nullable restore
#line 22 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 982, i, 982, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 984, "].ImageUrl", 984, 10, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 995, "\"", 1028, 1);
#nullable restore
#line 22 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 1003, Model.Movies[i].ImageUrl, 1003, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1074, "\"", 1097, 3);
                WriteAttributeValue("", 1081, "Movies[", 1081, 7, true);
#nullable restore
#line 23 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 1088, i, 1088, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1090, "].Title", 1090, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1098, "\"", 1128, 1);
#nullable restore
#line 23 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 1106, Model.Movies[i].Title, 1106, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 24 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <table class=""table table-striped table-hover table-bordered"">
                    <thead>
                        <tr>
                            <th style=""width:15px"">Remove</th>
                            <th style=""width:30px"">#</th>
                            <th style=""width:100px"">Image</th>
                            <th>Title</th>
                            <th style=""width:70px"">Genres</th>
                            <th style=""width:160px""></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 37 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
                         foreach (var movie in Model.Movies)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <input class=\"form-check-input\" type=\"checkbox\" name=\"movieIds\"");
                BeginWriteAttribute("value", " value=\"", 1996, "\"", 2018, 1);
#nullable restore
#line 41 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 2004, movie.MovieId, 2004, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 43 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
                               Write(movie.MovieId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9a2c3ff2a0c7f0315e23f6ecedbffd9e7b4536d18315", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2166, "~/img/", 2166, 6, true);
#nullable restore
#line 44 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
AddHtmlAttributeValue("", 2172, movie.ImageUrl, 2172, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
                               Write(movie.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 2340, "\"", 2380, 2);
                WriteAttributeValue("", 2347, "/admin/movieupdate/", 2347, 19, true);
#nullable restore
#line 47 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
WriteAttributeValue("", 2366, movie.MovieId, 2366, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary btn-sm\">Update</a>\r\n                                    <a href=\"#\" class=\"btn btn-danger btn-sm\">Delete</a>\r\n\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Alperen\Desktop\MVC.Net\Kod_1\Kod_1\Views\Admin\GenreUpdate.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminGenreEditViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
