#pragma checksum "E:\SHFWeb\SHFWeb\Views\Todo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b06aa6d9a4e492451773b6ad838441614ec3dc99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Todo/Index.cshtml", typeof(AspNetCore.Views_Todo_Index))]
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
#line 1 "E:\SHFWeb\SHFWeb\Views\_ViewImports.cshtml"
using SHFWeb;

#line default
#line hidden
#line 2 "E:\SHFWeb\SHFWeb\Views\_ViewImports.cshtml"
using SHFWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b06aa6d9a4e492451773b6ad838441614ec3dc99", @"/Views/Todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2c723fea584689542d07362cae535def17e241e", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\SHFWeb\SHFWeb\Views\Todo\Index.cshtml"
  
    ViewData["Title"] = "待办事项管理列表";

#line default
#line hidden
            BeginContext(68, 79, true);
            WriteLiteral("\r\n<div class=\"panel panel-default todo-panel\">\r\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(148, 17, false);
#line 8 "E:\SHFWeb\SHFWeb\Views\Todo\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(165, 227, true);
            WriteLiteral("</div>\r\n\r\n    <table class=\"table table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <td>&#x2714;</td>\r\n                <td>Item</td>\r\n                <td>Due</td>\r\n            </tr>\r\n        </thead>\r\n        \r\n");
            EndContext();
#line 19 "E:\SHFWeb\SHFWeb\Views\Todo\Index.cshtml"
        foreach (var item in Model.Items)
        {

#line default
#line hidden
            BeginContext(446, 150, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <input type=\"checkbox\" class=\"done-checkbox\">\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(597, 10, false);
#line 25 "E:\SHFWeb\SHFWeb\Views\Todo\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(607, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(635, 10, false);
#line 26 "E:\SHFWeb\SHFWeb\Views\Todo\Index.cshtml"
               Write(item.DueAt);

#line default
#line hidden
            EndContext();
            BeginContext(645, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 28 "E:\SHFWeb\SHFWeb\Views\Todo\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(682, 84, true);
            WriteLiteral("\r\n    </table>\r\n\r\n    <div class=\"panel-footer add-item-form\">\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
