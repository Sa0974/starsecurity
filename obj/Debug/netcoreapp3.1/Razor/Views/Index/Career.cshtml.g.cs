#pragma checksum "C:\Users\Hp\source\repos\StarSecurityServices\Views\Index\Career.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f41c13f9f71b3a652bf7076c2dcdf2e7325cd28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Index_Career), @"mvc.1.0.view", @"/Views/Index/Career.cshtml")]
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
#line 1 "C:\Users\Hp\source\repos\StarSecurityServices\Views\_ViewImports.cshtml"
using StarSecurityServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp\source\repos\StarSecurityServices\Views\_ViewImports.cshtml"
using StarSecurityServices.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f41c13f9f71b3a652bf7076c2dcdf2e7325cd28", @"/Views/Index/Career.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb0ffc8e53fbcbd00ae6dd45d5be8df43471ed22", @"/Views/_ViewImports.cshtml")]
    public class Views_Index_Career : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StarSecurityServices.Models.Vacancies>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hp\source\repos\StarSecurityServices\Views\Index\Career.cshtml"
  
    ViewData["Title"] = "Career";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"page-title-area page-title-style-two\">\r\n<div class=\"container\">\r\n<div class=\"page-title-content\">\r\n<h2>Career With Us</h2>\r\n<ul>\r\n<li>\r\n<a");
            BeginWriteAttribute("href", "  href=\"", 302, "\"", 339, 1);
#nullable restore
#line 14 "C:\Users\Hp\source\repos\StarSecurityServices\Views\Index\Career.cshtml"
WriteAttributeValue("", 310, Url.Action("Index", "Index"), 310, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
<i class=""bx bx-home""></i>
Home
</a>
</li>
<li class=""active"">Career</li>
</ul>
</div>
</div>
</div>
<table class=""table"">
  <thead class=""thead-dark"">
    <tr>
      <th scope=""col"">Company Name</th>
      <th scope=""col"">First</th>
      <th scope=""col"">Last</th>
      <th scope=""col"">Handle</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 34 "C:\Users\Hp\source\repos\StarSecurityServices\Views\Index\Career.cshtml"
 foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n      <th scope=\"row\"></th>\r\n      < a href=\"#\"><td>");
#nullable restore
#line 37 "C:\Users\Hp\source\repos\StarSecurityServices\Views\Index\Career.cshtml"
                  Write(Html.DisplayFor(modelitem => item.EmpName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>< /a >\r\n      <td>");
#nullable restore
#line 38 "C:\Users\Hp\source\repos\StarSecurityServices\Views\Index\Career.cshtml"
     Write(Html.DisplayFor(modelitem => item.EmpAdd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 39 "C:\Users\Hp\source\repos\StarSecurityServices\Views\Index\Career.cshtml"
     Write(Html.DisplayFor(modelitem => item.EmpCon));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 40 "C:\Users\Hp\source\repos\StarSecurityServices\Views\Index\Career.cshtml"
     Write(Html.DisplayFor(modelitem => item.EmpEdu));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 41 "C:\Users\Hp\source\repos\StarSecurityServices\Views\Index\Career.cshtml"
     Write(Html.DisplayFor(modelitem => item.Depart));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 42 "C:\Users\Hp\source\repos\StarSecurityServices\Views\Index\Career.cshtml"
     Write(Html.DisplayFor(modelitem => item.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 43 "C:\Users\Hp\source\repos\StarSecurityServices\Views\Index\Career.cshtml"
     Write(Html.DisplayFor(modelitem => item.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 45 "C:\Users\Hp\source\repos\StarSecurityServices\Views\Index\Career.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StarSecurityServices.Models.Vacancies>> Html { get; private set; }
    }
}
#pragma warning restore 1591
