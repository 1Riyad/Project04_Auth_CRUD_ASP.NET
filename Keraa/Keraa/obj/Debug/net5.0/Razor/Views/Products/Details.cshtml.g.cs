#pragma checksum "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2889f6c6dafecc21f48d000abefa08a5c6e0c6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml"
using Keraa.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2889f6c6dafecc21f48d000abefa08a5c6e0c6f", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b86b866be30f8b5e130d4c4c37e63769e62c4b1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ChatRooms", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Chat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 6 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml"
  
    var Product = (ProductModel)ViewData["Product"];
    var token = @Configuration["GoogleToken"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #map {
        height: 200px;
        /* The height is 100 pixels */
        width: 550px;
        /* The width is the width of the web page */
        left: -15px;
    }

    #D-bar {
    }

    #D-close {
        position: absolute;
        top: 0px;
        left: 100%;
    }

    #D-chat {
        position: absolute;
        top: 50px;
        left: 100%;
    }

    #D-edit {
        position: absolute;
        top: 100px;
        left: 100%;
    }

    #D-delete {
        position: absolute;
        top: 150px;
        left: 100%;
    }

    #cvrImage {
        position: absolute;
        top: 5%;
        left: -250px;
        border: hidden;
        border-radius: 200px;
        width: 335px;
        height: 335px;
    }
</style>

<script>
    // Initialize and add the map
    function initMap() {
        // The location of Uluru
        //const uluru = { lat: -25.344, lng: 131.036 };
        const uluru = { lat: ");
#nullable restore
#line 63 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml"
                        Write(Product.LocationLat);

#line default
#line hidden
#nullable disable
            WriteLiteral(", lng: ");
#nullable restore
#line 63 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml"
                                                   Write(Product.LocationLng);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"};
        // The map, centered at Uluru
        const map = new google.maps.Map(document.getElementById(""map""), {
            zoom: 15,
            center: uluru,
        });
        // The marker, positioned at Uluru
        const marker = new google.maps.Marker({
            position: uluru,
            map: map,
        });
    }
</script>





<center class=""card mb-3"" style=""max-width: 550px; position: center; margin: 0 auto; border: hidden; background-color: #fd7e14; "">
    <div class=""row g-0"" dir=""rtl"">
        <div class=""col-md-12"">
            <div class=""card-body"" style=""text-align: center; margin-left: 50px;"">
                <h3 class=""card-title"">");
#nullable restore
#line 85 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml"
                                  Write(Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <p class=\"card-text\">\r\n                    <span style=\"font-weight: bold;\">التصنيف: </span>\r\n                    ");
#nullable restore
#line 88 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml"
               Write(Product.Catagory);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p class=\"card-text\">\r\n                    <span style=\"font-weight: bold;\">الوصف: </span>\r\n                    ");
#nullable restore
#line 92 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml"
               Write(Product.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p class=\"card-text\">\r\n                    <span style=\"font-weight: bold;\">متاحة : </span>\r\n                    ");
#nullable restore
#line 96 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml"
               Write(Product.IsRented);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>

            </div>
        </div>
        <div>
            <!--The div element for the map -->
            <div id=""map""></div>

            <!-- Async script executes immediately and must be after any DOM elements used in callback. -->
            <script");
            BeginWriteAttribute("src", " src=\"", 2833, "\"", 2926, 3);
            WriteAttributeValue("", 2839, "https://maps.googleapis.com/maps/api/js?key=", 2839, 44, true);
#nullable restore
#line 106 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml"
WriteAttributeValue("", 2883, token, 2883, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2889, "&callback=initMap&libraries=&v=weekly", 2889, 37, true);
            EndWriteAttribute();
            WriteLiteral(@"
                    async></script>
        </div>

    </div>


    <span id=""D-bar"">
        <span id=""D-close"">
            <button href type=""button"" onclick=""location.href='/Products';"" class=""btn btn-outline-dark"" aria-label=""Close"">
                <span aria-hidden=""true"">
                    <i class=""material-icons"">arrow_back</i>
                </span>
            </button>
        </span>
        <span id=""D-chat"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2889f6c6dafecc21f48d000abefa08a5c6e0c6f12341", async() => {
                WriteLiteral("\r\n                <span aria-hidden=\"true\">\r\n                    <i class=\"material-icons\">insert_comment</i>\r\n                </span>\r\n            ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-OwnerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml"
                                                                                                   WriteLiteral(Product.OwnerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["OwnerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OwnerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["OwnerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </span>\r\n");
#nullable restore
#line 128 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml"
         if (UserManager.GetUserId(User) == Product.OwnerId)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span id=\"D-edit\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2889f6c6dafecc21f48d000abefa08a5c6e0c6f15448", async() => {
                WriteLiteral("\r\n                    <span aria-hidden=\"true\">\r\n                        <i class=\"material-icons\">edit</i>\r\n                    </span>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 131 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml"
                                                                                                 WriteLiteral(Product.Id);

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
            WriteLiteral("\r\n            </span>\r\n            <span id=\"D-delete\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2889f6c6dafecc21f48d000abefa08a5c6e0c6f18230", async() => {
                WriteLiteral("\r\n                    <input type=\"submit\" value=close class=\"btn btn-outline-danger material-icons\" />\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 138 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml"
                                                                                    WriteLiteral(Product.Id);

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
            WriteLiteral("\r\n            </span>\r\n");
#nullable restore
#line 143 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 4403, "\"", 4411, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img id=\"cvrImage\"");
            BeginWriteAttribute("src", " src=", 4445, "", 4469, 1);
#nullable restore
#line 145 "C:\Users\SAFCSP\Desktop\dotNetBootcamp\AspDotNet\Proj\Project04_Auth_CRUD_ASP.NET\Keraa\Keraa\Views\Products\Details.cshtml"
WriteAttributeValue("", 4450, Product.CoverImage, 4450, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\">\r\n        </div>\r\n    </span>\r\n</center>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
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
