#pragma checksum "C:\Users\leger\source\repos\BlazorApp5\BlazorApp5\Pages\Calculateur.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d9549fd4baa85573a919bd579067dbf06de101e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp5.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\leger\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leger\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\leger\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\leger\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\leger\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\leger\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\leger\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\leger\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using BlazorApp5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\leger\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using BlazorApp5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leger\source\repos\BlazorApp5\BlazorApp5\Pages\Calculateur.razor"
using BlazorApp5.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Calculateur")]
    public partial class Calculateur : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\leger\source\repos\BlazorApp5\BlazorApp5\Pages\Calculateur.razor"
       
    Calcul clc = new Calcul();
    decimal resultat;

    void Calc()
    {
        resultat = clc.Val1 + clc.Val2;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
