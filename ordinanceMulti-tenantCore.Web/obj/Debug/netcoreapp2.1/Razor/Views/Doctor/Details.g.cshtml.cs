#pragma checksum "C:\Users\CC-PC\source\repos\ordinanceMulti-tenantCore\001_src\ordinanceMulti-tenantCore\ordinanceMulti-tenantCore.Web\Views\Doctor\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c288c8c88712af9d49195e3d7d83b1c45a6eeaa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_Details), @"mvc.1.0.view", @"/Views/Doctor/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Doctor/Details.cshtml", typeof(AspNetCore.Views_Doctor_Details))]
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
#line 1 "C:\Users\CC-PC\source\repos\ordinanceMulti-tenantCore\001_src\ordinanceMulti-tenantCore\ordinanceMulti-tenantCore.Web\Views\_ViewImports.cshtml"
using ordinanceMulti_tenantCore.Web;

#line default
#line hidden
#line 2 "C:\Users\CC-PC\source\repos\ordinanceMulti-tenantCore\001_src\ordinanceMulti-tenantCore\ordinanceMulti-tenantCore.Web\Views\_ViewImports.cshtml"
using ordinanceMulti_tenantCore.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c288c8c88712af9d49195e3d7d83b1c45a6eeaa8", @"/Views/Doctor/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd5aeaa6ce5018d25a2970d49d127294065895fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ordinanceMulti_tenantCore.Web.ViewModels.DoctorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\CC-PC\source\repos\ordinanceMulti-tenantCore\001_src\ordinanceMulti-tenantCore\ordinanceMulti-tenantCore.Web\Views\Doctor\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(157, 110, true);
            WriteLiteral("\r\n<h1 style=\"color: darkred\">Details</h1>\r\n\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(268, 38, false);
#line 13 "C:\Users\CC-PC\source\repos\ordinanceMulti-tenantCore\001_src\ordinanceMulti-tenantCore\ordinanceMulti-tenantCore.Web\Views\Doctor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(306, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(350, 34, false);
#line 16 "C:\Users\CC-PC\source\repos\ordinanceMulti-tenantCore\001_src\ordinanceMulti-tenantCore\ordinanceMulti-tenantCore.Web\Views\Doctor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(384, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(428, 52, false);
#line 19 "C:\Users\CC-PC\source\repos\ordinanceMulti-tenantCore\001_src\ordinanceMulti-tenantCore\ordinanceMulti-tenantCore.Web\Views\Doctor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Doctor_FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(480, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(524, 48, false);
#line 22 "C:\Users\CC-PC\source\repos\ordinanceMulti-tenantCore\001_src\ordinanceMulti-tenantCore\ordinanceMulti-tenantCore.Web\Views\Doctor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Doctor_FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(572, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(616, 51, false);
#line 25 "C:\Users\CC-PC\source\repos\ordinanceMulti-tenantCore\001_src\ordinanceMulti-tenantCore\ordinanceMulti-tenantCore.Web\Views\Doctor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Doctor_LastName));

#line default
#line hidden
            EndContext();
            BeginContext(667, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(711, 47, false);
#line 28 "C:\Users\CC-PC\source\repos\ordinanceMulti-tenantCore\001_src\ordinanceMulti-tenantCore\ordinanceMulti-tenantCore.Web\Views\Doctor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Doctor_LastName));

#line default
#line hidden
            EndContext();
            BeginContext(758, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(802, 50, false);
#line 31 "C:\Users\CC-PC\source\repos\ordinanceMulti-tenantCore\001_src\ordinanceMulti-tenantCore\ordinanceMulti-tenantCore.Web\Views\Doctor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Doctor_NrPhone));

#line default
#line hidden
            EndContext();
            BeginContext(852, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(896, 46, false);
#line 34 "C:\Users\CC-PC\source\repos\ordinanceMulti-tenantCore\001_src\ordinanceMulti-tenantCore\ordinanceMulti-tenantCore.Web\Views\Doctor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Doctor_NrPhone));

#line default
#line hidden
            EndContext();
            BeginContext(942, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(986, 50, false);
#line 37 "C:\Users\CC-PC\source\repos\ordinanceMulti-tenantCore\001_src\ordinanceMulti-tenantCore\ordinanceMulti-tenantCore.Web\Views\Doctor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Doctor_Address));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1080, 46, false);
#line 40 "C:\Users\CC-PC\source\repos\ordinanceMulti-tenantCore\001_src\ordinanceMulti-tenantCore\ordinanceMulti-tenantCore.Web\Views\Doctor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Doctor_Address));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1174, 74, false);
#line 45 "C:\Users\CC-PC\source\repos\ordinanceMulti-tenantCore\001_src\ordinanceMulti-tenantCore\ordinanceMulti-tenantCore.Web\Views\Doctor\Details.cshtml"
Write(Html.ActionLink("Edit", "EditUpdate", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1248, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1256, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98eca639944644bca787d15c6578a43b", async() => {
                BeginContext(1278, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1294, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ordinanceMulti_tenantCore.Web.ViewModels.DoctorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
