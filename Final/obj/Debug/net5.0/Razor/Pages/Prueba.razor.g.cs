#pragma checksum "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\Pages\Prueba.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d71c9f086741052a9d355e29db4e58af8a1745a"
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
#line 2 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\Pages\Prueba.razor"
using Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Prueba")]
    public partial class Prueba : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Prueba</h3>");
#nullable restore
#line 7 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\Pages\Prueba.razor"
 foreach(var prueba in product)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\Pages\Prueba.razor"
     if (prueba.Nombre=="Iphone 8")
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 11 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\Pages\Prueba.razor"
         prueba.IdProducto

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 11 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\Pages\Prueba.razor"
                          ;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\Pages\Prueba.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\JOEL\Downloads\Compressed\FinalProject3\final\Pages\Prueba.razor"
       



    List<Producto> product = new List<Producto>();

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
