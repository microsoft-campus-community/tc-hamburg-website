#pragma checksum "D:\dev\repos\tch-website\TCHomepage\TCHomepage\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81aba7b876589ba22e7205daee433d21dc0ccf04"
// <auto-generated/>
#pragma warning disable 1591
namespace TCHomepage.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using TCHomepage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using TCHomepage.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "slide");
            __builder.AddAttribute(2, "b-slmihmzlo8");
            __builder.OpenComponent<TCHomepage.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n    ");
#nullable restore
#line 6 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\Shared\MainLayout.razor"
__builder.AddContent(5, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "section");
            __builder.AddAttribute(8, "id", "contact");
            __builder.AddAttribute(9, "b-slmihmzlo8");
            __builder.AddMarkupContent(10, @"<div id=""contactArea"" b-slmihmzlo8><h1 b-slmihmzlo8>Lob, Kritik, Anerkennung?</h1>
            <p b-slmihmzlo8>
                Immer her damit! Wir versuchen uns stetig zu verbessern und jedes Feedback
                hilft uns die nächste TCH noch besser zu gestalten.
            </p></div>
        ");
            __builder.OpenComponent<TCHomepage.Shared.FooterArea>(11);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591