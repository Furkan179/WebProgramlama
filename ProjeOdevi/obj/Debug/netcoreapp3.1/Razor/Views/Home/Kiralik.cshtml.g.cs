#pragma checksum "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83de7c012b0e1d526778f898e2cd211dedfe2cdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Kiralik), @"mvc.1.0.view", @"/Views/Home/Kiralik.cshtml")]
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
#line 1 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\_ViewImports.cshtml"
using ProjeOdevi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\_ViewImports.cshtml"
using ProjeOdevi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83de7c012b0e1d526778f898e2cd211dedfe2cdf", @"/Views/Home/Kiralik.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2bb95b2fc13bc1bfe1198b8c958fd16a9d64481", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Kiralik : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjeOdevi.Models.Car>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Kiralik", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Satilik", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-lg-3\">\r\n\r\n            <h1 class=\"my-4\">Just A Car</h1>\r\n            <div class=\"list-group\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83de7c012b0e1d526778f898e2cd211dedfe2cdf5133", async() => {
                WriteLiteral("Kiralık Araçlar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83de7c012b0e1d526778f898e2cd211dedfe2cdf6802", async() => {
                WriteLiteral("Satılık Araçlar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>

        </div>
        <!-- /.col-lg-3 -->



    </div>
    <!-- /.row -->

</div>



<div class=""col-lg-9"">

    <div id=""carouselExampleIndicators"" class=""carousel slide my-4"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">

            <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>

        </ol>
        <div class=""carousel-inner"">
");
#nullable restore
#line 43 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"carousel-item active\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1239, "\"", 1256, 1);
#nullable restore
#line 46 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
WriteAttributeValue("", 1245, item.Image, 1245, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\">\r\n                </div>\r\n");
#nullable restore
#line 48 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
                break;
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"carousel-item\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1471, "\"", 1488, 1);
#nullable restore
#line 53 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
WriteAttributeValue("", 1477, item.Image, 1477, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\">\r\n                </div>\r\n");
#nullable restore
#line 55 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>

    <div class=""row"">


");
#nullable restore
#line 70 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
         if (Model != null)
        {
            foreach (var item in Model)
            {
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-4 col-md-6 mb-4\">\r\n                        <div class=\"card h-100\">\r\n                            <a href=\"#\"><img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 2382, "\"", 2399, 1);
#nullable restore
#line 76 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
WriteAttributeValue("", 2388, item.Image, 2388, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2400, "\"", 2406, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                            <div class=\"card-body\">\r\n                                <h4 class=\"card-title\">\r\n                                    <h2 class=\"text-primary\" >");
#nullable restore
#line 79 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
                                                         Write(item.CarName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                </h4>\r\n                                <h3>");
#nullable restore
#line 81 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</h3>\r\n                                <p class=\"card-text\">Yılı:");
#nullable restore
#line 82 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
                                                     Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text\">Açıklama:");
#nullable restore
#line 83 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
                                                         Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text\">Vites Türü:");
#nullable restore
#line 84 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
                                                           Write(item.gear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text\">Rengi:");
#nullable restore
#line 85 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
                                                      Write(item.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text\">Yakıt Türü:");
#nullable restore
#line 86 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
                                                           Write(item.Fuel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text\">Km:");
#nullable restore
#line 87 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
                                                   Write(item.Distance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text\">Kategori:");
#nullable restore
#line 88 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
                                                         Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text\">Ülke:");
#nullable restore
#line 89 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
                                                     Write(item.Origin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"card-footer\">\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 95 "C:\Users\emrul\Desktop\New folder\WebProgramlama\ProjeOdevi\Views\Home\Kiralik.cshtml"
                }
            }
        }


       

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n        <!-- /.row -->\r\n\r\n    <!-- /.col-lg-9 -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjeOdevi.Models.Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
