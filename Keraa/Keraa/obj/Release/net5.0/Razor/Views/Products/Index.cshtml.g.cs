#pragma checksum "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aa81a14de74d9abc804d8e1a716e2fe9adfd727"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\_ViewImports.cshtml"
using Keraa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\_ViewImports.cshtml"
using Keraa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aa81a14de74d9abc804d8e1a716e2fe9adfd727", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b86b866be30f8b5e130d4c4c37e63769e62c4b1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Index.cshtml"
  
    var products = (List<ProductModel>)ViewData["products"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Hey Products</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Index.cshtml"
 foreach (var product in products)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <center>\r\n        <div>  ");
#nullable restore
#line 13 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Index.cshtml"
          Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>  ");
#nullable restore
#line 14 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Index.cshtml"
          Write(product.Catagory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>  ");
#nullable restore
#line 15 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Index.cshtml"
          Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>  ");
#nullable restore
#line 16 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Index.cshtml"
          Write(product.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>  ");
#nullable restore
#line 17 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Index.cshtml"
          Write(product.CoverImage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>  ");
#nullable restore
#line 18 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Index.cshtml"
          Write(product.IsRented);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>\r\n            <span><button type=\"button\" class=\"btn btn-dark\"><a style=\"color:white\"");
            BeginWriteAttribute("href", " href=\"", 486, "\"", 522, 2);
            WriteAttributeValue("", 493, "/products/details/", 493, 18, true);
#nullable restore
#line 20 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Index.cshtml"
WriteAttributeValue("", 511, product.Id, 511, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> SHOW </a></button></span>\r\n            <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3aa81a14de74d9abc804d8e1a716e2fe9adfd7278054", async() => {
                WriteLiteral("edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Index.cshtml"
                                                                                           WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3aa81a14de74d9abc804d8e1a716e2fe9adfd72710631", async() => {
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Index.cshtml"
                                                                                    WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n        </div>\r\n    </center>\r\n");
#nullable restore
#line 29 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
