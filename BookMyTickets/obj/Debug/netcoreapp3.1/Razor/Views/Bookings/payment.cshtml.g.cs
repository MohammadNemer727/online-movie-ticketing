#pragma checksum "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f57296f02c7153878aa34f334bc7260dc0cc99ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_payment), @"mvc.1.0.view", @"/Views/Bookings/payment.cshtml")]
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
#line 1 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\_ViewImports.cshtml"
using BookMyTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\_ViewImports.cshtml"
using BookMyTickets.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\payment.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f57296f02c7153878aa34f334bc7260dc0cc99ed", @"/Views/Bookings/payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d4fa06c6760776c56380e4fc908cd98cb71bee7", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmBookingPhase4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f57296f02c7153878aa34f334bc7260dc0cc99ed4198", async() => {
                WriteLiteral(@"
    <noscript>You must <a href=""http://www.enable-javascript.com"" target=""_blank"">enable JavaScript</a> in your web browser in order to pay via Stripe.</noscript>
    <div class=""text-center"">
        <label>order is ready pay to complete</label>
        <input name=""seat"" type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 1597, "\"", 1618, 1);
#nullable restore
#line 42 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\payment.cshtml"
WriteAttributeValue("", 1605, ViewBag.Seat, 1605, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly=\"readonly\" />\r\n        <input name=\"ShowId\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1686, "\"", 1709, 1);
#nullable restore
#line 43 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\payment.cshtml"
WriteAttributeValue("", 1694, ViewBag.ShowId, 1694, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly=\"readonly\" />\r\n        <input type=\"submit\"\r\n               value=\"Pay with Card\"\r\n               data-key=\"");
#nullable restore
#line 46 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\payment.cshtml"
                    Write(Stripe.Value.PublishableKey);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n               data-amount=\"");
#nullable restore
#line 47 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\payment.cshtml"
                       Write(ViewBag.price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
               data-currency=""US""
               data-locale=""auto""
               data-name=""Example Company Inc""
               data-description=""pay"" />
    </div>
    
    <script src=""https://checkout.stripe.com/v2/checkout.js""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.js""></script>
    <script>
        $(document).ready(function () {
            $(':submit').on('click', function (event) {
                event.preventDefault();

                var $button = $(this),
                    $form = $button.parents('form');

                var opts = $.extend({}, $button.data(), {
                    token: function (result) {
                        $form.append($('<input>').attr({ type: 'hidden', name: 'stripeToken', value: result.id })).submit();
                    }
                });

                StripeCheckout.open(opts);
            });
        });
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<BookMyTickets.Data.StripeSettings> Stripe { get; private set; }
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
