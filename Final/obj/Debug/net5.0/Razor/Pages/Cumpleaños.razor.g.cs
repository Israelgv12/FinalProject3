#pragma checksum "C:\Users\JOEL\Desktop\Final\Final\Pages\Cumpleaños.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5d5b6a465d26363ecb0be642da4dca499e6a1aa"
// <auto-generated/>
#pragma warning disable 1591
namespace Final.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\JOEL\Desktop\Final\Final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JOEL\Desktop\Final\Final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JOEL\Desktop\Final\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JOEL\Desktop\Final\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JOEL\Desktop\Final\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\JOEL\Desktop\Final\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\JOEL\Desktop\Final\Final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\JOEL\Desktop\Final\Final\_Imports.razor"
using Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\JOEL\Desktop\Final\Final\_Imports.razor"
using Final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JOEL\Desktop\Final\Final\Pages\Cumpleaños.razor"
using Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cumpleaños")]
    public partial class Cumpleaños : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "center");
            __builder.AddMarkupContent(1, "<h2>Listado de Cumpleaños de Clientes</h2>\n    ");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th scope=\"col\">#</th>\n                <th scope=\"col\">Nombre del Cliente</th>\n                <th scope=\"col\">Fecha del Cumpleaños</th></tr></thead>\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 16 "C:\Users\JOEL\Desktop\Final\Final\Pages\Cumpleaños.razor"
             foreach (var Clientes in CF)
            {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "th");
            __builder.AddAttribute(8, "scope", "row");
            __builder.AddContent(9, 
#nullable restore
#line 20 "C:\Users\JOEL\Desktop\Final\Final\Pages\Cumpleaños.razor"
                                     Clientes.Cliente_Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 21 "C:\Users\JOEL\Desktop\Final\Final\Pages\Cumpleaños.razor"
                         Clientes.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 22 "C:\Users\JOEL\Desktop\Final\Final\Pages\Cumpleaños.razor"
                         Clientes.Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\JOEL\Desktop\Final\Final\Pages\Cumpleaños.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\JOEL\Desktop\Final\Final\Pages\Cumpleaños.razor"
      

    List<ClienteFinal> CF = new List<ClienteFinal>();

    protected override async Task OnInitializedAsync()
    {
        CF = await Task.Run(() => Service.GetClientes());

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClienteService Service { get; set; }
    }
}
#pragma warning restore 1591
