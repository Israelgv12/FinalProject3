#pragma checksum "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\ProductoInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d30a0b48edafdc2238309ea705e649c58b6e2757"
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
#line 1 "C:\Users\daniel\Source\Repos\FinalProject3\Final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daniel\Source\Repos\FinalProject3\Final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\daniel\Source\Repos\FinalProject3\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\daniel\Source\Repos\FinalProject3\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\daniel\Source\Repos\FinalProject3\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\daniel\Source\Repos\FinalProject3\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\daniel\Source\Repos\FinalProject3\Final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\daniel\Source\Repos\FinalProject3\Final\_Imports.razor"
using Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\daniel\Source\Repos\FinalProject3\Final\_Imports.razor"
using Final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\ProductoInfo.razor"
using Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProductoInfo")]
    public partial class ProductoInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "nav-link");
            __builder.AddAttribute(2, "href", "AddProducto");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "<span class=\"oi oi-plus\" aria-hidden=\"true\"></span>&nbsp; Agregar Producto\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<h1>Almacen de Productos </h1>");
#nullable restore
#line 12 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\ProductoInfo.razor"
 if (product == null)
 {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Cargando.....</em></p>");
#nullable restore
#line 15 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\ProductoInfo.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, @"<thead><tr><th>ProductoId</th>
                <th>Nombre</th>
                <th>Precio</th>
                <th>Cantidad</th>
                <th>Fecha</th>
                <th>Descripcion</th>
                <th>Action</th></tr></thead>
        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 32 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\ProductoInfo.razor"
             foreach(var prop in product)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 35 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\ProductoInfo.razor"
                     prop.IdProducto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 36 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\ProductoInfo.razor"
                     prop.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 37 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\ProductoInfo.razor"
                     prop.Precio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 38 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\ProductoInfo.razor"
                     prop.Cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 39 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\ProductoInfo.razor"
                     prop.Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 40 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\ProductoInfo.razor"
                     prop.Descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "class", "nav-link");
            __builder.AddAttribute(34, "href", "EditProducto/" + (
#nullable restore
#line 42 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\ProductoInfo.razor"
                                                            prop.IdProducto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "<span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>Editar\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "class", "nav-link");
            __builder.AddAttribute(39, "href", "DeleteProducto/" + (
#nullable restore
#line 45 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\ProductoInfo.razor"
                                                              prop.IdProducto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(40, "<span class=\"oi oi-trash\" aria-hidden=\"true\"></span>Borrar\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\ProductoInfo.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\ProductoInfo.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\ProductoInfo.razor"
       

   List<Producto> product;

    protected override async Task OnInitializedAsync()
    {
        product = await Task.Run(() => Service.GetProductos());

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductoService Service { get; set; }
    }
}
#pragma warning restore 1591
