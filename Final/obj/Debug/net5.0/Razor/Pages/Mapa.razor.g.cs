#pragma checksum "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\Pages\Mapa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34fe46c4b30f31b8b9d0bbde9e2e1c763cd6c668"
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
#line 3 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\Pages\Mapa.razor"
using Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Mapa")]
    public partial class Mapa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    #mapid {\r\n        height: 400px;\r\n    }\r\n</style>\r\n\r\n<div id=\"mapid\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\Pages\Mapa.razor"
      

    List<ClienteFinal> CF = new List<ClienteFinal>();

    



    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            CF = await Task.Run(() => Service.GetClientes());
            await JSRuntime.InvokeVoidAsync("InitMapa", CF);

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClienteService Service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
