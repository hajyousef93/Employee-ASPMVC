#pragma checksum "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c774f5b88e67cf90d71660dc69db111720902e34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Index), @"mvc.1.0.view", @"/Views/Employees/Index.cshtml")]
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
#line 1 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\_ViewImports.cshtml"
using ASPMVC_Mohammad_Haj_yousef;

#line default
#line hidden
#line 2 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\_ViewImports.cshtml"
using ASPMVC_Mohammad_Haj_yousef.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c774f5b88e67cf90d71660dc69db111720902e34", @"/Views/Employees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75b6ff1180bba40e1e930a45995d5f6a713c2272", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASPMVC_Mohammad_Haj_yousef.Models.employee.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            WriteLiteral("\r\n\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c774f5b88e67cf90d71660dc69db111720902e344645", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#line 17 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 20 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 23 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 26 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProfileImage));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#line 32 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#line 35 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n");
#line 37 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
              
                var avgAge = Model.Average(i => i.Age);
                if (avgAge > item.Age)
                {

#line default
#line hidden
            WriteLiteral("                    <td class=\"text-success\">\r\n                        ");
#line 42 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
            WriteLiteral("\r\n                    </td>\r\n");
#line 44 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            WriteLiteral("                    <td class=\"text-danger\">\r\n                        ");
#line 48 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
            WriteLiteral("\r\n                    </td>\r\n");
#line 50 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
                }
            

#line default
#line hidden
#line 52 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
              
                var avgSalry = Model.Average(i => i.Salary);
                if (avgSalry > item.Salary)
                {

#line default
#line hidden
            WriteLiteral("                        <td class=\"text-success\">\r\n                            ");
#line 57 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
            WriteLiteral("\r\n                        </td>\r\n");
#line 59 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            WriteLiteral("                        <td class=\"text-danger\">\r\n                           ");
#line 63 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
            WriteLiteral("\r\n                        </td>\r\n");
#line 65 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
                }
            

#line default
#line hidden
            WriteLiteral("            <td>\r\n                ");
#line 68 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProfileImage));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c774f5b88e67cf90d71660dc69db111720902e3411065", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c774f5b88e67cf90d71660dc69db111720902e3413223", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c774f5b88e67cf90d71660dc69db111720902e3415387", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#line 76 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
}

#line default
#line hidden
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr class=\"text-primary\">\r\n            <td >AvgAge</td>\r\n            <td>");
#line 81 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
           Write(Model.Average(i => i.Age));

#line default
#line hidden
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr class=\"text-primary\">\r\n            <td >AvgSalary</td>\r\n            <td>");
#line 85 "C:\Users\USER\source\repos\ASPMVC-Mohammad-Haj-yousef\ASPMVC-Mohammad-Haj-yousef\Views\Employees\Index.cshtml"
           Write(Model.Average(i => i.Salary).ToString("0.00"));

#line default
#line hidden
            WriteLiteral("</td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASPMVC_Mohammad_Haj_yousef.Models.employee.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591