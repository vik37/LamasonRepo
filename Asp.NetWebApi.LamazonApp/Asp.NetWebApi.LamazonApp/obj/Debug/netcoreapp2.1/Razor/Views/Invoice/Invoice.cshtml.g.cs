#pragma checksum "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Invoice\Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e799368c03162191d16ab05ff8af2fb2b3ae6e2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Invoice), @"mvc.1.0.view", @"/Views/Invoice/Invoice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/Invoice.cshtml", typeof(AspNetCore.Views_Invoice_Invoice))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e799368c03162191d16ab05ff8af2fb2b3ae6e2e", @"/Views/Invoice/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54d7de4c146c79eda3ecd8ca78430017e140c6a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Invoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InvoiceVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Invoice\Invoice.cshtml"
  
    ViewData["Title"] = "Invoice";

#line default
#line hidden
            BeginContext(61, 98, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"col-md-6\">\r\n        <div class=\"row\">\r\n            <h2>");
            EndContext();
            BeginContext(160, 13, false);
#line 9 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Invoice\Invoice.cshtml"
           Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(173, 66, true);
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"row\">\r\n            <h2>");
            EndContext();
            BeginContext(240, 17, false);
#line 12 "C:\Users\vikto\source\repos\LamazonApp\Asp.NetWebApi.LamazonApp\Asp.NetWebApi.LamazonApp\Views\Invoice\Invoice.cshtml"
           Write(Model.PaymentType);

#line default
#line hidden
            EndContext();
            BeginContext(257, 47, true);
            WriteLiteral("</h2>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InvoiceVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
