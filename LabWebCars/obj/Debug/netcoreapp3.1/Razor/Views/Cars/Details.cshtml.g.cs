#pragma checksum "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28a40eeac63ccd48751a7966555a7e04b63ad28e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Details), @"mvc.1.0.view", @"/Views/Cars/Details.cshtml")]
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
#line 1 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\_ViewImports.cshtml"
using LabWebCars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\_ViewImports.cshtml"
using LabWebCars.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a40eeac63ccd48751a7966555a7e04b63ad28e", @"/Views/Cars/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"726bfbd70bac0acca9b2409b6015b6f012dc2cf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LabWebCars.Models.Car>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
  
    ViewData["Title"] = "Детальніше";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Детальніше про авто</h1>\r\n\r\n<div>\r\n    <h4>");
#nullable restore
#line 10 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <div class=\"row\">\r\n    <div class=\"col-sm\">\r\n       <dl>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Transmission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Transmission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Info));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Info));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Producer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Producer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        </dl>\r\n       </div>\r\n    <div class=\"col-sm\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 1562, "\"", 1606, 1);
#nullable restore
#line 54 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
WriteAttributeValue("", 1568, Html.DisplayFor(model => model.Photo), 1568, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  width=\"400\" height=\"300\" />\r\n    </div>\r\n     </div>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 59 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
     if (ViewContext.HttpContext.User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28a40eeac63ccd48751a7966555a7e04b63ad28e8729", async() => {
                WriteLiteral("Редагувати");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
                               WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 62 "D:\3 курс\лабы веб\LabWebCars_last\LabWebCars\LabWebCars\Views\Cars\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"javascript:history.go(-1)\">Повернутися назад</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LabWebCars.Models.Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
