#pragma checksum "/Users/daesungchoi/Desktop/CodingDojo/csharp_stack/orms/wedding_planner/Views/Home/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccdf2b006d5d40304563881c12eca62e04a1bb74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
#line 1 "/Users/daesungchoi/Desktop/CodingDojo/csharp_stack/orms/wedding_planner/Views/_ViewImports.cshtml"
using wedding_planner;

#line default
#line hidden
#line 2 "/Users/daesungchoi/Desktop/CodingDojo/csharp_stack/orms/wedding_planner/Views/_ViewImports.cshtml"
using wedding_planner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccdf2b006d5d40304563881c12eca62e04a1bb74", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0aadd694686a14c367f0150bd67bec2e71f0b6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(15, 35, true);
            WriteLiteral("\n<br>\n\n<div class=\"container\">\n<h1>");
            EndContext();
            BeginContext(51, 15, false);
#line 6 "/Users/daesungchoi/Desktop/CodingDojo/csharp_stack/orms/wedding_planner/Views/Home/Detail.cshtml"
Write(Model.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(66, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(72, 15, false);
#line 6 "/Users/daesungchoi/Desktop/CodingDojo/csharp_stack/orms/wedding_planner/Views/Home/Detail.cshtml"
                    Write(Model.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(87, 13, true);
            WriteLiteral("\'s Wedding | ");
            EndContext();
            BeginContext(100, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccdf2b006d5d40304563881c12eca62e04a1bb744506", async() => {
                BeginContext(126, 9, true);
                WriteLiteral("Dashboard");
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
            BeginContext(139, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(142, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccdf2b006d5d40304563881c12eca62e04a1bb745855", async() => {
                BeginContext(165, 7, true);
                WriteLiteral("Log Out");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(176, 76, true);
            WriteLiteral("</h1>\n    <div class=\"row\">\n        <div class=\"col\">\n            <h4>Date: ");
            EndContext();
            BeginContext(253, 10, false);
#line 9 "/Users/daesungchoi/Desktop/CodingDojo/csharp_stack/orms/wedding_planner/Views/Home/Detail.cshtml"
                 Write(Model.Date);

#line default
#line hidden
            EndContext();
            BeginContext(263, 52, true);
            WriteLiteral("</h4>\n            <h4>Guests:</h4>\n            <ul>\n");
            EndContext();
#line 12 "/Users/daesungchoi/Desktop/CodingDojo/csharp_stack/orms/wedding_planner/Views/Home/Detail.cshtml"
                 foreach(var association in @Model.Associations)
                {

#line default
#line hidden
            BeginContext(398, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(423, 26, false);
#line 14 "/Users/daesungchoi/Desktop/CodingDojo/csharp_stack/orms/wedding_planner/Views/Home/Detail.cshtml"
                   Write(association.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(449, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(451, 25, false);
#line 14 "/Users/daesungchoi/Desktop/CodingDojo/csharp_stack/orms/wedding_planner/Views/Home/Detail.cshtml"
                                               Write(association.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(476, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 15 "/Users/daesungchoi/Desktop/CodingDojo/csharp_stack/orms/wedding_planner/Views/Home/Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(500, 116, true);
            WriteLiteral("            </ul>\n        </div>\n        <div class=\"col\">\n            <h1>Sup</h1>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591