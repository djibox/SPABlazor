#pragma checksum "C:\Users\leger\source\repos\BlazorApp5\BlazorApp5\Pages\CustomUI.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b59b3d21e0554cbe20199e9be5289275766bbc67"
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
#line 2 "C:\Users\leger\source\repos\BlazorApp5\BlazorApp5\Pages\CustomUI.razor"
using BlazorApp5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\leger\source\repos\BlazorApp5\BlazorApp5\Pages\CustomUI.razor"
using Microsoft.CodeAnalysis.CSharp.Syntax;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CustomUI")]
    public partial class CustomUI : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\leger\source\repos\BlazorApp5\BlazorApp5\Pages\CustomUI.razor"
       
    decimal _totalbudget = 1000000;

    public List<BudgetItem> Budgets = new List<BudgetItem>()
    {
            new BudgetItem { Name = "Developers", Amount = 0},
            new BudgetItem { Name = "Designer", Amount = 0}
    };

    BudgetItem bi = new BudgetItem
    {


    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591