#pragma checksum "C:\Users\serge\source\repos\TantsuvõistlusMVC\TantsuvõistlusMVC\Views\Võistlus\Koondhinne.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76618429b3ff578243ea5b5e90461e930520b0bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Võistlus_Koondhinne), @"mvc.1.0.view", @"/Views/Võistlus/Koondhinne.cshtml")]
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
#line 1 "C:\Users\serge\source\repos\TantsuvõistlusMVC\TantsuvõistlusMVC\Views\_ViewImports.cshtml"
using TantsuvõistlusMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\serge\source\repos\TantsuvõistlusMVC\TantsuvõistlusMVC\Views\_ViewImports.cshtml"
using TantsuvõistlusMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76618429b3ff578243ea5b5e90461e930520b0bb", @"/Views/Võistlus/Koondhinne.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4543db096fd612c7cc0e8b9148ff85f5ba817350", @"/Views/_ViewImports.cshtml")]
    public class Views_Võistlus_Koondhinne : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TantsuvõistlusMVC.Models.KeskmineHinneViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\serge\source\repos\TantsuvõistlusMVC\TantsuvõistlusMVC\Views\Võistlus\Koondhinne.cshtml"
  
    ViewData["Title"] = "Koondleht";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Koondleht</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\serge\source\repos\TantsuvõistlusMVC\TantsuvõistlusMVC\Views\Võistlus\Koondhinne.cshtml"
           Write(Html.DisplayNameFor(model => model.Tantsupaari_Nimi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\serge\source\repos\TantsuvõistlusMVC\TantsuvõistlusMVC\Views\Võistlus\Koondhinne.cshtml"
           Write(Html.DisplayNameFor(model => model.Voor1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\serge\source\repos\TantsuvõistlusMVC\TantsuvõistlusMVC\Views\Võistlus\Koondhinne.cshtml"
           Write(Html.DisplayNameFor(model => model.Voor2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\serge\source\repos\TantsuvõistlusMVC\TantsuvõistlusMVC\Views\Võistlus\Koondhinne.cshtml"
           Write(Html.DisplayNameFor(model => model.Voor3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\serge\source\repos\TantsuvõistlusMVC\TantsuvõistlusMVC\Views\Võistlus\Koondhinne.cshtml"
           Write(Html.DisplayNameFor(model => model.KeskmineHinne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\serge\source\repos\TantsuvõistlusMVC\TantsuvõistlusMVC\Views\Võistlus\Koondhinne.cshtml"
 foreach (var item in Model.OrderByDescending(item => item.KeskmineHinne)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\serge\source\repos\TantsuvõistlusMVC\TantsuvõistlusMVC\Views\Võistlus\Koondhinne.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tantsupaari_Nimi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\serge\source\repos\TantsuvõistlusMVC\TantsuvõistlusMVC\Views\Võistlus\Koondhinne.cshtml"
           Write(Html.DisplayFor(modelItem => item.Voor1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\serge\source\repos\TantsuvõistlusMVC\TantsuvõistlusMVC\Views\Võistlus\Koondhinne.cshtml"
           Write(Html.DisplayFor(modelItem => item.Voor2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\serge\source\repos\TantsuvõistlusMVC\TantsuvõistlusMVC\Views\Võistlus\Koondhinne.cshtml"
           Write(Html.DisplayFor(modelItem => item.Voor3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\serge\source\repos\TantsuvõistlusMVC\TantsuvõistlusMVC\Views\Võistlus\Koondhinne.cshtml"
           Write(Html.DisplayFor(modelItem => item.KeskmineHinne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\serge\source\repos\TantsuvõistlusMVC\TantsuvõistlusMVC\Views\Võistlus\Koondhinne.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TantsuvõistlusMVC.Models.KeskmineHinneViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
