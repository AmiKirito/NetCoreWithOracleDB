#pragma checksum "C:\Users\Roman_Mykhaylenko\source\repos\KIC_Lab_4\KIC_Lab_4\Views\Good\GetGoodById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "640ef6c018b144f6495ec51a25213ef91d79dc52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Good_GetGoodById), @"mvc.1.0.view", @"/Views/Good/GetGoodById.cshtml")]
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
#line 1 "C:\Users\Roman_Mykhaylenko\source\repos\KIC_Lab_4\KIC_Lab_4\Views\_ViewImports.cshtml"
using KIC_Lab_4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"640ef6c018b144f6495ec51a25213ef91d79dc52", @"/Views/Good/GetGoodById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cca5b823bc2ddabf6d56eaa850a43e2b3d55dd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Good_GetGoodById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Good>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetGoods", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Good", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Roman_Mykhaylenko\source\repos\KIC_Lab_4\KIC_Lab_4\Views\Good\GetGoodById.cshtml"
  
    ViewBag.Title = "Good details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>ID: ");
#nullable restore
#line 6 "C:\Users\Roman_Mykhaylenko\source\repos\KIC_Lab_4\KIC_Lab_4\Views\Good\GetGoodById.cshtml"
   Write(Model.Good_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>Name: ");
#nullable restore
#line 7 "C:\Users\Roman_Mykhaylenko\source\repos\KIC_Lab_4\KIC_Lab_4\Views\Good\GetGoodById.cshtml"
     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>Price: $");
#nullable restore
#line 8 "C:\Users\Roman_Mykhaylenko\source\repos\KIC_Lab_4\KIC_Lab_4\Views\Good\GetGoodById.cshtml"
       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>Producer: ");
#nullable restore
#line 9 "C:\Users\Roman_Mykhaylenko\source\repos\KIC_Lab_4\KIC_Lab_4\Views\Good\GetGoodById.cshtml"
         Write(Model.Producer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>Quantity: ");
#nullable restore
#line 10 "C:\Users\Roman_Mykhaylenko\source\repos\KIC_Lab_4\KIC_Lab_4\Views\Good\GetGoodById.cshtml"
         Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" items</h4>\r\n<h4>Department ID: ");
#nullable restore
#line 11 "C:\Users\Roman_Mykhaylenko\source\repos\KIC_Lab_4\KIC_Lab_4\Views\Good\GetGoodById.cshtml"
              Write(Model.Dept_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>Description: ");
#nullable restore
#line 12 "C:\Users\Roman_Mykhaylenko\source\repos\KIC_Lab_4\KIC_Lab_4\Views\Good\GetGoodById.cshtml"
            Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "640ef6c018b144f6495ec51a25213ef91d79dc525895", async() => {
                WriteLiteral("Back to goods");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Good> Html { get; private set; }
    }
}
#pragma warning restore 1591
