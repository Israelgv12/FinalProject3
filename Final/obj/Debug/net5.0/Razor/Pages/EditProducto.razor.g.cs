#pragma checksum "C:\Users\JOEL\Desktop\Final\Final\Pages\EditProducto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "015de0e19078a41e931f954cc9a45ae6ea7c9104"
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
#line 2 "C:\Users\JOEL\Desktop\Final\Final\Pages\EditProducto.razor"
using Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditProducto/{CurrentID}")]
    public partial class EditProducto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Update Producto</h2>\n<hr>\n\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group col-md-4");
            __builder.AddMarkupContent(6, "<label for=\"id\">ID</label>\n            ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "for", "Nombre");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "disabled");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\JOEL\Desktop\Final\Final\Pages\EditProducto.razor"
                                                                      producto.IdProducto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.IdProducto = __value, producto.IdProducto));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group col-md-4");
            __builder.AddMarkupContent(16, "<label for=\"Nombre\">Nombre</label>\n            ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "text");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "id", "inputNombre");
            __builder.AddAttribute(21, "placeholder", "Nombre");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\JOEL\Desktop\Final\Final\Pages\EditProducto.razor"
                                                                                                  producto.Nombre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.Nombre = __value, producto.Nombre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group col-md-4");
            __builder.AddMarkupContent(27, "<label for=\"inputcantidad\">Precio</label>\n            ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "text");
            __builder.AddAttribute(30, "class", "form-control");
            __builder.AddAttribute(31, "id", "cantidad");
            __builder.AddAttribute(32, "placeholder", "Nombre");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\JOEL\Desktop\Final\Final\Pages\EditProducto.razor"
                                                                                               producto.Precio

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.Precio = __value, producto.Precio));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "form-group col-md-4");
            __builder.AddMarkupContent(38, "<label for=\"inputcantidad\">Cantidad</label>\n            ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "text");
            __builder.AddAttribute(41, "class", "form-control");
            __builder.AddAttribute(42, "id", "cantidad");
            __builder.AddAttribute(43, "placeholder", "Nombre");
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\JOEL\Desktop\Final\Final\Pages\EditProducto.razor"
                                                                                               producto.Cantidad

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.Cantidad = __value, producto.Cantidad));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "form-group col-md-4");
            __builder.AddMarkupContent(49, "<label for=\"fecha\">Fecha</label>\n            ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "type", "date");
            __builder.AddAttribute(52, "class", "form-control");
            __builder.AddAttribute(53, "id", "fecha");
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\JOEL\Desktop\Final\Final\Pages\EditProducto.razor"
                                                                       producto.Fecha

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.Fecha = __value, producto.Fecha, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "form-group");
            __builder.AddMarkupContent(59, "<label for=\"Descripcion\">Descripcion</label>\n            ");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "type", "text");
            __builder.AddAttribute(62, "class", "form-control");
            __builder.AddAttribute(63, "id", "Descripcion");
            __builder.AddAttribute(64, "placeholder", "Descripcion");
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\JOEL\Desktop\Final\Final\Pages\EditProducto.razor"
                                                                                                       producto.Descripcion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.Descripcion = __value, producto.Descripcion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n    ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "row");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "col-md-4");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "form-group");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "button");
            __builder.AddAttribute(76, "class", "btn btn-primary");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\JOEL\Desktop\Final\Final\Pages\EditProducto.razor"
                                                                        UpdateProducto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "value", "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n                ");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "type", "button");
            __builder.AddAttribute(82, "class", "btn btn-danger");
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\JOEL\Desktop\Final\Final\Pages\EditProducto.razor"
                                                                       Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\JOEL\Desktop\Final\Final\Pages\EditProducto.razor"
       
    [Parameter]
    public string CurrentID { get; set; }
    Producto producto = new Producto();


    protected override async Task OnInitializedAsync()
    {
        producto = await Task.Run(() => Service.GetProductoById(Convert.ToInt32(CurrentID)));

    }

    protected void UpdateProducto()
    {
        Service.UpdateProducto(producto);
        NavigationManager.NavigateTo("ProductoInfo");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("ProductoInfo");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductoService Service { get; set; }
    }
}
#pragma warning restore 1591
