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
#line 1 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\_Imports.razor"
using Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\_Imports.razor"
using Final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\Pages\EditarFactura.razor"
using Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditarFactura/{CurrentID}")]
    public partial class EditarFactura : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\Pages\EditarFactura.razor"
       

    [Parameter]
    public string CurrentID { get; set; }
    Factura facturas = new Factura();


    protected override async Task OnInitializedAsync()
    {
        facturas = await Task.Run(() => Service.GetFacturaById(Convert.ToInt32(CurrentID)));

    }

    protected void UpdateFactura()
    {
        Service.UpdateFactura(facturas);
        NavigationManager.NavigateTo("FacturaInfo");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("FacturaInfo");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FacturaService Service { get; set; }
    }
}
#pragma warning restore 1591
