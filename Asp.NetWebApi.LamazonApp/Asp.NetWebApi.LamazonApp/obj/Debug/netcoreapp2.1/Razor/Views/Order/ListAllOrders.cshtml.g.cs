#pragma checksum "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a971aaae0ff534d3fc261a81a996785fb5617722"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_ListAllOrders), @"mvc.1.0.view", @"/Views/Order/ListAllOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/ListAllOrders.cshtml", typeof(AspNetCore.Views_Order_ListAllOrders))]
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
#line 1 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\_ViewImports.cshtml"
using Asp.NetWebApi.LamazonApp;

#line default
#line hidden
#line 2 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\_ViewImports.cshtml"
using Asp.NetWebApi.LamazonApp.Models;

#line default
#line hidden
#line 3 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\_ViewImports.cshtml"
using SEDC.Lamazon.WebModels;

#line default
#line hidden
#line 4 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\_ViewImports.cshtml"
using SEDC.Lamazon.WebModels.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\_ViewImports.cshtml"
using SEDC.Lamazon.WebModels.Enum;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a971aaae0ff534d3fc261a81a996785fb5617722", @"/Views/Order/ListAllOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54d7de4c146c79eda3ecd8ca78430017e140c6a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_ListAllOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApproveOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeclineOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
  
    ViewData["Title"] = "ListAllOrders";

#line default
#line hidden
            BeginContext(71, 374, true);
            WriteLiteral(@"
<h2>All user's orders</h2>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Status</th>
            <th scope=""col"">Price</th>
            <th scope=""col"">User full name</th>
            <th scope=""col"">Products</th>
            <th scope=""col"">Action</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
         foreach (var order in Model)
        {

#line default
#line hidden
            BeginContext(495, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(526, 8, false);
#line 23 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
           Write(order.Id);

#line default
#line hidden
            EndContext();
            BeginContext(534, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(558, 18, false);
#line 24 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
           Write(order.StatusTypeVM);

#line default
#line hidden
            EndContext();
            BeginContext(576, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(600, 11, false);
#line 25 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
           Write(order.Price);

#line default
#line hidden
            EndContext();
            BeginContext(611, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(635, 21, false);
#line 26 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
           Write(order.UserVM.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(656, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 27 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
              
                int i = 0;
            

#line default
#line hidden
            BeginContext(722, 18, true);
            WriteLiteral("            <td>\r\n");
            EndContext();
#line 31 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
                 foreach (var product in order.ProductsVM)
                {
                    i++;
                    if (order.ProductsVM.Count() == i)
                    {

#line default
#line hidden
            BeginContext(924, 30, true);
            WriteLiteral("                        <span>");
            EndContext();
            BeginContext(955, 12, false);
#line 36 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
                         Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(967, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 37 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1048, 30, true);
            WriteLiteral("                        <span>");
            EndContext();
            BeginContext(1079, 12, false);
#line 40 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
                         Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1091, 10, true);
            WriteLiteral(",</span>\r\n");
            EndContext();
#line 41 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
                    }

                }

#line default
#line hidden
            BeginContext(1145, 19, true);
            WriteLiteral("            </td>\r\n");
            EndContext();
#line 45 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
             if (order.StatusTypeVM == StatusTypeVM.Pending)
            {

#line default
#line hidden
            BeginContext(1241, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(1283, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4c6aa99f269403fa6edb96301bf6a85", async() => {
                BeginContext(1389, 7, true);
                WriteLiteral("Approve");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
                                                                               WriteLiteral(order.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1400, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1422, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae48afccd8f54d56baff896fa412ea99", async() => {
                BeginContext(1528, 7, true);
                WriteLiteral("Decline");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
                                                                               WriteLiteral(order.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1539, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 51 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
            }
            else if (order.StatusTypeVM == StatusTypeVM.Confirmed)
            {

#line default
#line hidden
            BeginContext(1662, 51, true);
            WriteLiteral("                <td>Waiting to be delivered!</td>\r\n");
            EndContext();
#line 55 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
            }
            else if (order.StatusTypeVM == StatusTypeVM.Declined)
            {

#line default
#line hidden
            BeginContext(1810, 69, true);
            WriteLiteral("                <td>You have successfully declined this order!</td>\r\n");
            EndContext();
#line 59 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1927, 48, true);
            WriteLiteral("                <td>Waiting for customer!</td>\r\n");
            EndContext();
#line 63 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"
            }

#line default
#line hidden
            BeginContext(1990, 17, true);
            WriteLiteral("\r\n        </tr>\r\n");
            EndContext();
#line 66 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Order\ListAllOrders.cshtml"

        }

#line default
#line hidden
            BeginContext(2020, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591