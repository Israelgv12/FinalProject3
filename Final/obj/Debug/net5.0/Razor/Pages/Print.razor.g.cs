#pragma checksum "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8acd73648070148e8ebabb193ea542dd316a265"
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
#line 2 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
using Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Print/{CurrentID}")]
    public partial class Print : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "center");
            __builder.AddMarkupContent(1, "<h1>Factura</h1>");
#nullable restore
#line 11 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
         foreach (var cl in client)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
             foreach (var fs in facturas)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                 if (fs.Id_Factura == Convert.ToInt32(CurrentID))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                     if (fs.Cliente_Id == cl.Cliente_Id)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "h4");
            __builder.AddContent(3, "Cliente: ");
            __builder.AddContent(4, 
#nullable restore
#line 20 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                                      cl.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                     


                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-striped");
            __builder.AddMarkupContent(7, "<thead><tr><th class=\"alignright\">Producto/Servicio</th>\r\n                    <th class=\"alignright\">Precio </th>\r\n                    <th class=\"alignright\">Cantidad</th></tr></thead>\r\n            ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 41 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                 foreach (var pf in prodfact)
                {
                      

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                       if (pf.Id_Factura == Convert.ToInt32(CurrentID))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                     if(pf.Cantidad > 0){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.AddAttribute(10, "class", "total");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 48 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                             pf.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.OpenElement(14, "td");
            __builder.AddAttribute(15, "class", "alignmiddle");
            __builder.AddContent(16, 
#nullable restore
#line 49 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                                                 pf.Precio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "td");
            __builder.AddAttribute(19, "class", "alignright");
            __builder.AddContent(20, 
#nullable restore
#line 50 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                                                pf.Cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                   }
                   else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 54 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                             pf.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "td");
            __builder.AddAttribute(25, "class", "alignmiddle");
            __builder.AddContent(26, 
#nullable restore
#line 55 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                                                 pf.Precio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                    
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                 
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n<br><br>\r\n\r\n        ");
            __builder.OpenElement(28, "table");
            __builder.AddAttribute(29, "class", "body-wrap");
            __builder.OpenElement(30, "tbody");
#nullable restore
#line 67 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                 foreach (var fc in facturas)
                {
                    
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                     if (fc.Id_Factura == Convert.ToInt32(CurrentID))
                    {
                        


#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "tr");
            __builder.AddAttribute(32, "class", "total");
            __builder.AddMarkupContent(33, "<td class=\"alignright\" width=\"80%\">Sub.Total</td>\r\n                            ");
            __builder.OpenElement(34, "td");
            __builder.AddAttribute(35, "class", "alignright");
            __builder.AddContent(36, 
#nullable restore
#line 76 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                                                    fc.Monto_Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "tr");
            __builder.AddAttribute(39, "class", "total");
            __builder.AddMarkupContent(40, "<td class=\"alignright\" width=\"80%\">Itbis(18% de su compra)</td>\r\n                            ");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "class", "alignright");
            __builder.AddContent(43, 
#nullable restore
#line 80 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                                                    fc.Itbis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.OpenElement(45, "tr");
            __builder.AddAttribute(46, "class", "table-success");
            __builder.AddAttribute(47, "style", "border: 1px solid black;");
            __builder.AddMarkupContent(48, "<td class=\"alignright\" width=\"80%\">Total</td>\r\n                            ");
            __builder.OpenElement(49, "td");
            __builder.AddAttribute(50, "class", "alignright");
            __builder.AddContent(51, 
#nullable restore
#line 84 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                                                    total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(52, "tr");
            __builder.AddAttribute(53, "class", "total");
            __builder.AddMarkupContent(54, "<td class=\"alignright\" width=\"80%\">Fecha</td>\r\n                            ");
            __builder.OpenElement(55, "td");
            __builder.AddAttribute(56, "class", "alignright");
            __builder.AddContent(57, 
#nullable restore
#line 89 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                                                    fc.FechaYHora

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 91 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n\r\n\r\n\r\n\r\n        <br>\r\n        <br>\r\n\r\n        ");
            __builder.AddMarkupContent(59, "<button class=\"btn btn-success oi oi-print\" onclick=\"print()\">  Imprimir Factura </button>\r\n\r\n        <br>\r\n        <br>\r\n\r\n        ");
            __builder.AddMarkupContent(60, "<a class=\"btn btn-warning\" href=\"FacturaInfo\"><span class=\"oi oi-action-undo\" aria-hidden=\"true\">Volver</span></a>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "C:\Users\JOEL\Desktop\Final\Final\Pages\Print.razor"
           
        double total;

        [Parameter]
        public string CurrentID { get; set; }

        [Parameter]
        public string CurrentfactID { get; set; }
        List<Producto_Facturado> prodfact = new List<Producto_Facturado>();

        List<Factura> facturas = new List<Factura>();

        List<ClienteFinal> client = new List<ClienteFinal>();



        protected override async Task OnInitializedAsync()
        {

            facturas = await Task.Run(() => Service.GetFactura());
            prodfact = await Task.Run(() => ServiceProductoF.GetProductoFacturado());
            client = await Task.Run(() => ServiceCL.GetClientes());


            foreach (var fc in facturas)
            {
                if (fc.Id_Factura == Convert.ToInt32(CurrentID))
                {
                    total = fc.Monto_Total + fc.Itbis;
                }
            }
        }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClienteService ServiceCL { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FacturaService Service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PFacturadoService ServiceProductoF { get; set; }
    }
}
#pragma warning restore 1591