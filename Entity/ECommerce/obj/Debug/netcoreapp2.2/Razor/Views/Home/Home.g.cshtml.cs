#pragma checksum "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2485c5b7b5534fb6c21d2f63a6dceeee6e1b2a83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
#line 1 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\_ViewImports.cshtml"
using ECommerce;

#line default
#line hidden
#line 2 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\_ViewImports.cshtml"
using ECommerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2485c5b7b5534fb6c21d2f63a6dceeee6e1b2a83", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec470632cb3b1b75499bc0cdcc8d1831e35eecad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Activitee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 110, true);
            WriteLiteral("<div class=\"row\">\r\n    <h2 class=\"col-6\">Dojo Activity Center</h2>\r\n    <h5 class=\"col-4 text-right\">Welcome, ");
            EndContext();
            BeginContext(111, 18, false);
#line 3 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
                                     Write(ViewBag.User.FName);

#line default
#line hidden
            EndContext();
            BeginContext(129, 76, true);
            WriteLiteral("!</h5>\r\n    <a href=\"/logout\" class=\"col-2 text-right\">Log Out</a>\r\n</div>\r\n");
            EndContext();
            BeginContext(229, 406, true);
            WriteLiteral(@"<table class=""table table-striped"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Activity</th>
            <th scope=""col"">Date and Time</th>
            <th scope=""col"">Duration</th>
            <th scope=""col"">Event coordinator</th>
            <th scope=""col"">No. of Participants</th>
            <th scope=""col"">Action</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
         foreach(var i in Model){
            if(i.ActivityDate > DateTime.Now){

#line default
#line hidden
            BeginContext(718, 48, true);
            WriteLiteral("                <tr>\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 766, "\"", 796, 2);
            WriteAttributeValue("", 773, "/activity/", 773, 10, true);
#line 22 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
WriteAttributeValue("", 783, i.ActivityId, 783, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(797, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(799, 15, false);
#line 22 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
                                                     Write(i.ActivityTitle);

#line default
#line hidden
            EndContext();
            BeginContext(814, 35, true);
            WriteLiteral("</a></td>\r\n                    <td>");
            EndContext();
            BeginContext(850, 34, false);
#line 23 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
                   Write(i.ActivityDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(884, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(886, 33, true);
            WriteLiteral("@ </td>\r\n                    <td>");
            EndContext();
            BeginContext(920, 14, false);
#line 24 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
                   Write(i.ActivityDate);

#line default
#line hidden
            EndContext();
            BeginContext(934, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(936, 18, false);
#line 24 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
                                   Write(i.ActivityTimeType);

#line default
#line hidden
            EndContext();
            BeginContext(954, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(986, 13, false);
#line 25 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
                   Write(i.Coordinator);

#line default
#line hidden
            EndContext();
            BeginContext(999, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1031, 12, false);
#line 26 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
                   Write(i.GuestCount);

#line default
#line hidden
            EndContext();
            BeginContext(1043, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 27 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
                     if(i.Coordinator == ViewBag.User.FName){

#line default
#line hidden
            BeginContext(1113, 30, true);
            WriteLiteral("                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1143, "\"", 1171, 2);
            WriteAttributeValue("", 1150, "/delete/", 1150, 8, true);
#line 28 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
WriteAttributeValue("", 1158, i.ActivityId, 1158, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1172, 18, true);
            WriteLiteral(">Delete</a></td>\r\n");
            EndContext();
#line 29 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
                    } else if(i.Users.Any(a=>a.UserId == ViewBag.User.UserId)){

#line default
#line hidden
            BeginContext(1271, 30, true);
            WriteLiteral("                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1301, "\"", 1349, 4);
            WriteAttributeValue("", 1308, "/leave/", 1308, 7, true);
#line 30 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
WriteAttributeValue("", 1315, i.ActivityId, 1315, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1328, "/", 1328, 1, true);
#line 30 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
WriteAttributeValue("", 1329, ViewBag.User.UserId, 1329, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1350, 17, true);
            WriteLiteral(">Leave</a></td>\r\n");
            EndContext();
#line 31 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
                    } else {

#line default
#line hidden
            BeginContext(1397, 30, true);
            WriteLiteral("                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1427, "\"", 1453, 2);
            WriteAttributeValue("", 1434, "/join/", 1434, 6, true);
#line 32 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
WriteAttributeValue("", 1440, i.ActivityId, 1440, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1454, 16, true);
            WriteLiteral(">Join</a></td>\r\n");
            EndContext();
#line 33 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
                    }

#line default
#line hidden
            BeginContext(1493, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 35 "C:\Users\Mits\Desktop\Coding_Dojo\Work\C#\Entity\ECommerce\Views\Home\Home.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1542, 197, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<div class=\"row text-right\">\r\n    <span class=\"col-10\"></span>\r\n    <span class=\"col-2 text-right\"><a href=\"/new\" class=\"btn btn-primary\">Add New Activity</a></span>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Activitee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
