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
#line 2 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\EditFacturado.razor"
using Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditFacturado/{CurrentID}")]
    public partial class EditFacturado : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\EditFacturado.razor"
       

    [Parameter]
    public string CurrentID { get; set; }
    Producto_Facturado facturado = new Producto_Facturado();


    protected override async Task OnInitializedAsync()
    {
        facturado = await Task.Run(() => Service.GetProductoFacturadoById(Convert.ToInt32(CurrentID)));

    }

    protected void UpdateFacturado()
    {
        Service.UpdateProductoFacturado(facturado);
        NavigationManager.NavigateTo("FacturadoInfo");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("FacturadoInfo");

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PFacturadoService Service { get; set; }
    }
}
#pragma warning restore 1591
