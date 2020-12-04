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
#line 2 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\EditFact.razor"
using Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditFact/{CurrentfactID}/{CurrentID}")]
    public partial class EditFact : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\EditFact.razor"
       

    [Parameter]
    public string CurrentID { get; set; }

    [Parameter]
    public string CurrentfactID { get; set; }
    Factura facturas = new Factura();

       List<Producto> product = new List<Producto>();

List<Producto_Facturado> pfacturado = new List<Producto_Facturado>();


    protected override async Task OnInitializedAsync()
    {
        facturas = await Task.Run(() => Service.GetFacturaById(Convert.ToInt32(CurrentfactID)));
                product = await Task.Run(() => ServiceP.GetProductos());
         pfacturado = await Task.Run(() => ServiceProductoF.GetProductoFacturado());


    }

    protected void UpdateFactura()
    {
   foreach(var item in pfacturado){
if(item.Id_Factura == facturas.Id_Factura){
 if(item.Cantidad > 0){
montoTotal += item.Precio*item.Cantidad;
productoCant = item.Cantidad;
Nprod= item.Nombre;
}
else{
montoTotal = item.Precio;
productoCant = item.Cantidad;
Nprod= item.Nombre;
}
}

foreach(var p in product){
if(item.Nombre == p.Nombre){
idprod = p.IdProducto;

   }
}
   
   }
   idpr = idprod.ToString();
   itbis = montoTotal*0.18;

        facturas.Nombre_Producto = Nprod ;
   facturas.Nombre_Servicio ="Servicio al cliente";
  facturas.Cantidad_Prod = productoCant;
  facturas.Monto_Total = montoTotal;
  facturas.Itbis = itbis;
        Service.UpdateFactura(facturas);
        NavigationManager.NavigateTo("EditProd"  + "/" + CurrentID + "/" + CurrentfactID);
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("deletfact" + "/" + CurrentfactID);

    }

    int montoTotal;
    int productoCant;
    double itbis;
    string Nprod;
    int idprod;
    string idpr;

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
