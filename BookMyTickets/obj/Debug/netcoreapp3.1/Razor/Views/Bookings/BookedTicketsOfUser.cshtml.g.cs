#pragma checksum "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7da261eb3e5fad2e1d65da9b230b5a0f247d2352"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_BookedTicketsOfUser), @"mvc.1.0.view", @"/Views/Bookings/BookedTicketsOfUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da261eb3e5fad2e1d65da9b230b5a0f247d2352", @"/Views/Bookings/BookedTicketsOfUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d4fa06c6760776c56380e4fc908cd98cb71bee7", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_BookedTicketsOfUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookMyTickets.Models.Booking>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <style>\n        #navBookingOfUser {\n            background-color:aliceblue;\n        }\n    </style>\n\n    <h2>Booked Tickets</h2>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 17 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalTickets));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Seat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n           \n            <th>\n                ");
#nullable restore
#line 24 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 27 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 30 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
           Write(Html.DisplayNameFor(model => model.MovieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 33 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
           Write(Html.DisplayNameFor(model => model.TheaterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 36 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 39 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 42 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
           Write(Html.DisplayNameFor(model => model.ScreenNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            WriteLiteral("\n");
#nullable restore
#line 91 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
           int i = 0;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>\n            ");
#nullable restore
#line 96 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
       Write(Html.DisplayFor(modelItem => item.TotalTickets));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 99 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
       Write(Html.DisplayFor(modelItem => item.Seat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n\n        <td>\n            ");
#nullable restore
#line 103 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
       Write(Html.DisplayFor(modelItem => item.TotalCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 106 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 109 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
       Write(Html.DisplayFor(modelItem => item.MovieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 112 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
       Write(Html.DisplayFor(modelItem => item.TheaterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 115 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
       Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 118 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
       Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 121 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
       Write(Html.DisplayFor(modelItem => item.ScreenNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n\n\n            <img");
            BeginWriteAttribute("src", " src=\"", 3389, "\"", 3413, 1);
#nullable restore
#line 126 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
WriteAttributeValue("", 3395, ViewBag.codes[@i], 3395, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:200px;height:200px;\" />\n\n           \n        </td>\n    </tr>\n");
#nullable restore
#line 131 "C:\Users\moe\Desktop\New folder (7)\New folder\BookMyTickets\BookMyTickets\BookMyTickets\Views\Bookings\BookedTicketsOfUser.cshtml"
                i = i + 1;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookMyTickets.Models.Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591