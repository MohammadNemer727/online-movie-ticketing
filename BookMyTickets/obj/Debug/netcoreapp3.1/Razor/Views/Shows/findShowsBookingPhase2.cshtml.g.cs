#pragma checksum "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f09a7256efc113aa5cef5be7c867b6eb1760772f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shows_findShowsBookingPhase2), @"mvc.1.0.view", @"/Views/Shows/findShowsBookingPhase2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f09a7256efc113aa5cef5be7c867b6eb1760772f", @"/Views/Shows/findShowsBookingPhase2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d4fa06c6760776c56380e4fc908cd98cb71bee7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shows_findShowsBookingPhase2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookMyTickets.Models.Show>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
  
    ViewData["Title"] = "findShowsBookingPhase2";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .page-wrapper,
    .content-wrapper {
        background: #f2f2f2;
        margin: 0;
        padding: 0;
    }

    .content-wrapper {
        margin-top: 1vh;
        margin-bottom: 0vh;
        margin-left: 4vw;
        margin-right: 4vw;
        padding: 2vh 2vw;
    }
</style>


<div class=""page-wrapper"">
    <div class=""content-wrapper"">
        <div class=""container"">
            <div class=""row"">
                <div class=""column"">
                    <div class=""card"" style=""width: 18rem;"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 649, "\"", 667, 1);
#nullable restore
#line 31 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
WriteAttributeValue("", 655, ViewBag.Url, 655, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\">\n                    </div>\n                </div>\n                <div class=\"column\">\n                    <h2> Movie Name:- ");
#nullable restore
#line 35 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                                 Write(ViewBag.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                    <b>Movie Language:-</b>\n                    <p>");
#nullable restore
#line 37 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                  Write(ViewBag.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <b>Movie Genre:-</b>\n                    <p>");
#nullable restore
#line 39 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                  Write(ViewBag.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <b>Movie Director:-</b>\n                    <p>");
#nullable restore
#line 41 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                  Write(ViewBag.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <b>Movie duration:-</b>\n                    <p>");
#nullable restore
#line 43 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                  Write(ViewBag.Duretion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" min.</p>\n                    <b>Movie releaseDate:-</b>\n                    <p>");
#nullable restore
#line 45 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                  Write(ViewBag.ReleaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n            </div>\n        </div>\n        <hr />\n        <div class=\"container\" style=\"margin:4rem;\">\n");
#nullable restore
#line 51 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                  if (item.accepted == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\n                        <table>\n                            <tr>\n                                <td><b>Show Id:-</b></td>\n                                <td>");
#nullable restore
#line 58 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ShowId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td></td>\n                            </tr>\n                            <tr>\n                                <td><b>Theater Name:-</b></td>\n                                <td>");
#nullable restore
#line 63 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TheaterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td></td>\n                            </tr>\n                            <tr>\n                                <td><b>Show Starting Time:-</b></td>\n                                <td>");
#nullable restore
#line 68 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                               Write(Html.DisplayFor(modelItem => item.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>\n");
#nullable restore
#line 70 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                                     using (Html.BeginForm("seatSelectionBookingPhase3", "Bookings", FormMethod.Post))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                                   Write(Html.TextBox("ShowId", @item.ShowId, new { @hidden = "hidden" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <input type=\"submit\" class=\"btn btn-primary\" value=\"Buy Tickets for This Show\">\n");
#nullable restore
#line 74 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\n                            </tr>\n                            <tr>\n                                <td><b>Show Date:-</b></td>\n                                <td>");
#nullable restore
#line 79 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td></td>\n                            </tr>\n                            <tr>\n                                <td><b>Price per seat:-</b></td>\n                                <td>");
#nullable restore
#line 84 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" USD</td>\n                                <td></td>\n                            </tr>\n                        </table>\n                    </div>\n                    <br>\n");
#nullable restore
#line 90 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Shows\findShowsBookingPhase2.cshtml"
                 
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n    <hr />\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookMyTickets.Models.Show>> Html { get; private set; }
    }
}
#pragma warning restore 1591