#pragma checksum "C:\myblazors\SPABlazor\BlazorApp5\Pages\Calculateur.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d9549fd4baa85573a919bd579067dbf06de101e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp5.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\myblazors\SPABlazor\BlazorApp5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\myblazors\SPABlazor\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\myblazors\SPABlazor\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\myblazors\SPABlazor\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\myblazors\SPABlazor\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\myblazors\SPABlazor\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\myblazors\SPABlazor\BlazorApp5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\myblazors\SPABlazor\BlazorApp5\_Imports.razor"
using BlazorApp5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\myblazors\SPABlazor\BlazorApp5\_Imports.razor"
using BlazorApp5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\myblazors\SPABlazor\BlazorApp5\Pages\Calculateur.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron text-center");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h1 class=\"alert alert-info\">Calculateur (+)</h1>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "number");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\myblazors\SPABlazor\BlazorApp5\Pages\Calculateur.razor"
                                 clc.Val1

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => clc.Val1 = __value, clc.Val1, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "number");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\myblazors\SPABlazor\BlazorApp5\Pages\Calculateur.razor"
                                 clc.Val2

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => clc.Val2 = __value, clc.Val2, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\myblazors\SPABlazor\BlazorApp5\Pages\Calculateur.razor"
                                              Calc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Calcul");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "label");
            __builder.AddContent(20, 
#nullable restore
#line 8 "C:\myblazors\SPABlazor\BlazorApp5\Pages\Calculateur.razor"
            resultat

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n           ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\myblazors\SPABlazor\BlazorApp5\Pages\Calculateur.razor"
       
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
