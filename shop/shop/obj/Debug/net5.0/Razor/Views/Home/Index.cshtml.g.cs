#pragma checksum "C:\Users\turka\source\repos\Kurumsal\Softtech\Temel ASP.NET Core\Part I\shop\shop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c7c19c1dc6c10e7f0be6cca7fb68a2cfdb5f152"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\turka\source\repos\Kurumsal\Softtech\Temel ASP.NET Core\Part I\shop\shop\Views\_ViewImports.cshtml"
using shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\turka\source\repos\Kurumsal\Softtech\Temel ASP.NET Core\Part I\shop\shop\Views\_ViewImports.cshtml"
using shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c7c19c1dc6c10e7f0be6cca7fb68a2cfdb5f152", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7138caaf01817fa81aef682111e6c29223a425e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\turka\source\repos\Kurumsal\Softtech\Temel ASP.NET Core\Part I\shop\shop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\turka\source\repos\Kurumsal\Softtech\Temel ASP.NET Core\Part I\shop\shop\Views\Home\Index.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-3\">\r\n            <div class=\"card\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 226, "\"", 249, 1);
#nullable restore
#line 14 "C:\Users\turka\source\repos\Kurumsal\Softtech\Temel ASP.NET Core\Part I\shop\shop\Views\Home\Index.cshtml"
WriteAttributeValue("", 232, product.ImageUrl, 232, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\turka\source\repos\Kurumsal\Softtech\Temel ASP.NET Core\Part I\shop\shop\Views\Home\Index.cshtml"
                                      Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 17 "C:\Users\turka\source\repos\Kurumsal\Softtech\Temel ASP.NET Core\Part I\shop\shop\Views\Home\Index.cshtml"
                                    Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" yerine ");
#nullable restore
#line 17 "C:\Users\turka\source\repos\Kurumsal\Softtech\Temel ASP.NET Core\Part I\shop\shop\Views\Home\Index.cshtml"
                                                           Write(product.Price * (1-product.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</p>\r\n                    <a href=\"#\" class=\"btn btn-primary\">Sepete Ekle</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 22 "C:\Users\turka\source\repos\Kurumsal\Softtech\Temel ASP.NET Core\Part I\shop\shop\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n</div>\r\n\r\n<div class=\"row\">\r\n\r\n    <nav aria-label=\"Page navigation example\">\r\n        <ul class=\"pagination\">\r\n");
#nullable restore
#line 33 "C:\Users\turka\source\repos\Kurumsal\Softtech\Temel ASP.NET Core\Part I\shop\shop\Views\Home\Index.cshtml"
             for (int i = 1; i <= ViewBag.TotalPages; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 853, "\"", 904, 2);
            WriteAttributeValue("", 861, "page-item", 861, 9, true);
#nullable restore
#line 35 "C:\Users\turka\source\repos\Kurumsal\Softtech\Temel ASP.NET Core\Part I\shop\shop\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 870, ViewBag.Page==@i ? "active":"", 871, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c7c19c1dc6c10e7f0be6cca7fb68a2cfdb5f1527180", async() => {
#nullable restore
#line 35 "C:\Users\turka\source\repos\Kurumsal\Softtech\Temel ASP.NET Core\Part I\shop\shop\Views\Home\Index.cshtml"
                                                                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\turka\source\repos\Kurumsal\Softtech\Temel ASP.NET Core\Part I\shop\shop\Views\Home\Index.cshtml"
                                                                                                                      WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 36 "C:\Users\turka\source\repos\Kurumsal\Softtech\Temel ASP.NET Core\Part I\shop\shop\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </ul>\r\n    </nav>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
