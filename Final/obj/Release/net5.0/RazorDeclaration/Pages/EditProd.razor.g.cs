// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Final.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\daniel\Source\Repos\Final\Final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daniel\Source\Repos\Final\Final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\daniel\Source\Repos\Final\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\daniel\Source\Repos\Final\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\daniel\Source\Repos\Final\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\daniel\Source\Repos\Final\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\daniel\Source\Repos\Final\Final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\daniel\Source\Repos\Final\Final\_Imports.razor"
using Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\daniel\Source\Repos\Final\Final\_Imports.razor"
using Final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daniel\Source\Repos\Final\Final\Pages\EditProd.razor"
using Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditProd/{CurrentID}/{CurrentfactID}")]
    public partial class EditProd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\daniel\Source\Repos\Final\Final\Pages\EditProd.razor"
       

    [Parameter]
    public string CurrentID { get; set; }

    [Parameter]
    public string CurrentfactID { get; set; }
    Producto product = new Producto();

       List<Factura> facturas = new List<Factura>();





    protected override async Task OnInitializedAsync()
    {
        product = await Task.Run(() => ServiceP.GetProductoById(Convert.ToInt32(CurrentID)));
                facturas = await Task.Run(() => Service.GetFactura());


    }

    protected void UpdateFactura()
    {
   foreach(var item in facturas){   
if(item.Nombre_Producto == product.Nombre){
productoCant = product.Cantidad-item.Cantidad_Prod;


}

   }

   

        product.Cantidad = productoCant;
        ServiceP.UpdateProducto(product);
        NavigationManager.NavigateTo("ProductoInfo");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("deletfact" + "/" + CurrentfactID);
    }

    int montoTotal;
    int productoCant;
    double itbis;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PFacturadoService ServiceProductoF { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductoService ServiceP { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FacturaService Service { get; set; }
    }
}
#pragma warning restore 1591