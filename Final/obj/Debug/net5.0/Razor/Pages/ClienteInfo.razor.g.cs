#pragma checksum "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5dbae1f98a0fcd0c3bd153fc5ee8001f517359e"
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
#line 2 "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor"
using Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ClienteInfo")]
    public partial class ClienteInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Informacion de clientes</h1>\n\n<br>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "nav-link");
            __builder.AddAttribute(3, "href", "AddCliente");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<span class=\"oi oi-plus\" aria-hidden=\"true\"></span>Agregar Cliente\n\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n<br>");
#nullable restore
#line 17 "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor"
 if (cliente == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading.....</em></p>");
#nullable restore
#line 20 "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, @"<thead><tr><th>ID</th>
                <th>RNC</th>
                <th>Nombre</th>
                <th>Direccion</th>
                <th>Lat</th>
                <th>Long</th>
                <th>Correo</th>
                <th>Fecha</th></tr></thead>
        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 39 "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor"
             foreach (var prop in cliente)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 42 "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor"
                     prop.Cliente_Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 43 "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor"
                     prop.RNC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 44 "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor"
                     prop.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 45 "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor"
                     prop.Direccion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 46 "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor"
                     prop.Latitud

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 47 "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor"
                     prop.Longitud

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 48 "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor"
                     prop.Correo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 49 "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor"
                     prop.Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n                ");
            __builder.OpenElement(37, "td");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "class", "nav-link");
            __builder.AddAttribute(40, "href", "EditClientes/" + (
#nullable restore
#line 51 "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor"
                                                            prop.Cliente_Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(41, "<span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>Edit\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                    ");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "class", "nav-link");
            __builder.AddAttribute(45, "href", "DeleteClientes/" + (
#nullable restore
#line 54 "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor"
                                                              prop.Cliente_Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(46, "<span class=\"oi oi-trash\" aria-hidden=\"true\"></span>Delete\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\JOEL\Desktop\Final\Final\Pages\ClienteInfo.razor"
       

    List<ClienteFinal> cliente;

    protected override async Task OnInitializedAsync()
    {
        cliente = await Task.Run(() => Service.GetClientes());

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClienteService Service { get; set; }
    }
}
#pragma warning restore 1591