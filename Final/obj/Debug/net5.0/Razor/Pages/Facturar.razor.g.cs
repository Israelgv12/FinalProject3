#pragma checksum "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e54de315b1bc9cd9e3caae71cc29f1af4ff490e"
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
#line 2 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
using Final.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Facturar")]
    public partial class Facturar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 15 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
 if (carr1 == 0 )
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
     if(principal1 == 1){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<label for></label>\r\n ");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "class", "form-control");
            __builder.AddAttribute(3, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                                     clientess

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => clientess = __value, clientess));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(5, "option");
            __builder.AddAttribute(6, "value");
            __builder.AddContent(7, "Seleccione un cliente");
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
             foreach(var cl in client)
            {
           

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "value", 
#nullable restore
#line 25 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                cl.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, 
#nullable restore
#line 25 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                            cl.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "    <br>\r\n            <br>");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                                           getidclient

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "class", "btn btn-primary    oi oi-cart");
            __builder.AddContent(16, "Seleccionar cliente");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "<br><br>");
#nullable restore
#line 34 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"


}

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
 
            if ((clientess != "") && (carr == 2))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                                                 carrito

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "class", "btn btn-primary    oi oi-cart");
            __builder.AddContent(22, "Habilitar carrito");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "<br><br>");
#nullable restore
#line 40 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
              

            }
            else{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "<h1>Seleccione un cliente</h1>");
#nullable restore
#line 45 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
            }

    
           
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
 if (carr==1)
{
    


#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
 if (product != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "<label for>Seleccione el producto que desea comprar</label><br>\r\n       ");
            __builder.OpenElement(26, "select");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                                           selected

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selected = __value, selected));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value");
            __builder.AddContent(32, "Seleccione producto");
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
             foreach(var prop in product)
            {
           

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
            if(prop.Cantidad > 0){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", 
#nullable restore
#line 64 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                prop.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(35, 
#nullable restore
#line 64 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                              prop.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "    <br>");
            __builder.AddMarkupContent(37, "<br>");
#nullable restore
#line 72 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                         foreach(var prop in product)
            {
              

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
               if(prop.Nombre == selected){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "b");
            __builder.AddContent(39, "Cantidad de ");
            __builder.AddContent(40, 
#nullable restore
#line 75 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                                prop.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(41, " disponibles: ");
            __builder.AddContent(42, 
#nullable restore
#line 75 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                                                          prop.Cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
               
           

            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "<br>\r\n                ");
            __builder.AddMarkupContent(44, "<label for>Seleccione la cantidad que desea comprar</label><br>\r\n               ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "number");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 84 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                                                               canti

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => canti = __value, canti, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n               <br><br>\r\n                             ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "class", "btn btn-success    oi oi-cart");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                                                                                                   AgregarPfacturado

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "value", "Añadir producto al carrito");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n<br>\r\n               ");
            __builder.AddMarkupContent(57, "<label for>Seleccione el servicio que desea adquirir</label><br>\r\n       ");
            __builder.OpenElement(58, "select");
            __builder.AddAttribute(59, "class", "form-control");
            __builder.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                                           selectedserv

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedserv = __value, selectedserv));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(62, "option");
            __builder.AddAttribute(63, "value");
            __builder.AddContent(64, "Seleccione servicio");
            __builder.CloseElement();
#nullable restore
#line 91 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
             foreach(var prop in servvice)
            {
          

#line default
#line hidden
#nullable disable
            __builder.OpenElement(65, "option");
            __builder.AddAttribute(66, "value", 
#nullable restore
#line 94 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                prop.Nombre_Servicio

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(67, 
#nullable restore
#line 94 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                                       prop.Nombre_Servicio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 95 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "    <br>");
            __builder.AddMarkupContent(69, "<br>\r\n                <br>\r\n                              ");
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "type", "button");
            __builder.AddAttribute(72, "class", "btn btn-primary    oi oi-cart");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                                                                                                    agregarservice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "value", "Añadir servicio al carrito");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "<br><br><br><br><br>");
            __builder.AddMarkupContent(76, "<br>");
            __builder.AddMarkupContent(77, "<h3>Productos y servicios en su carrito: </h3> \r\n                ");
            __builder.OpenElement(78, "table");
            __builder.AddAttribute(79, "class", "table");
            __builder.AddMarkupContent(80, "<thead class=\"thead-dark\"><tr><th scope=\"col\">Nombre</th>\r\n      <th scope=\"col\">Cantidad</th>\r\n      <th scope=\"col\">Descripcion</th></tr></thead> \r\n  ");
            __builder.OpenElement(81, "tbody");
#nullable restore
#line 120 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
     foreach (var item in prodfact)
      {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
         if(item.Id_Factura == idfact){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(82, "tr");
            __builder.OpenElement(83, "th");
            __builder.AddContent(84, 
#nullable restore
#line 125 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
               item.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n          ");
            __builder.OpenElement(86, "th");
            __builder.AddContent(87, 
#nullable restore
#line 126 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
               item.Cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n          ");
            __builder.OpenElement(89, "th");
            __builder.AddContent(90, 
#nullable restore
#line 127 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
               item.Descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 131 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
      
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "<br><br>");
            __builder.OpenElement(92, "a");
            __builder.AddAttribute(93, "class", "nav-link");
            __builder.AddAttribute(94, "href", "deletfact/" + (
#nullable restore
#line 138 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                                                             curId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(95, "<span class=\"oi oi-trash btn btn-danger\" aria-hidden=\"true\">Cancelar factura</span>");
            __builder.CloseElement();
            __builder.OpenElement(96, "a");
            __builder.AddAttribute(97, "class", "nav-link");
            __builder.AddAttribute(98, "href", "EditFact/" + (
#nullable restore
#line 142 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
                                                          curId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(99, "<span class=\"oi oi-check btn btn-success\" aria-hidden=\"true\">Confirmar factura</span>");
            __builder.CloseElement();
#nullable restore
#line 145 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"

                }


         
else{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(100, "<h1>No hay productos ni servicios disponibles</h1>");
#nullable restore
#line 152 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
 
         
         
}
else if((carr == 0) && (idcliente != 0)){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(101, "<h1>Habilite el carrito</h1>");
#nullable restore
#line 158 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 163 "C:\Users\daniel\Source\Repos\FinalProject3\Final\Pages\Facturar.razor"
       
    DateTime now = DateTime.Now;

    int idcliente;
    string selected;
    string selectedserv;

    string clientess;
    int canti;
    int carr;
    int principal1 = 1;
    int carr1 = 0;
    int idfact;
    string descr;
    string servicedescr;
    int serviceprice;

    string  curId;
    int money;
    private Guid userId;
    string idclien;

    AppUser user = new AppUser();
    Factura facturas = new Factura();


    Producto_Facturado pfacturado = new Producto_Facturado();


    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    List<Producto> product = new List<Producto>();

    List<Servicio> servvice = new List<Servicio>();


    List<ClienteFinal> client = new List<ClienteFinal>();
    List<Producto_Facturado> prodfact = new List<Producto_Facturado>();


    protected override async Task OnInitializedAsync()
    {
        product = await Task.Run(() => Service.GetProductos());
        client = await Task.Run(() => ServiceCl.GetClientes());

        prodfact = await Task.Run(() => ServiceProductoF.GetProductoFacturado());
        servvice = await Task.Run(() => ServiceServicio.GetServicio());

        var authState = await authenticationStateTask;
        user = await UserManager.GetUserAsync(authState.User);
        userId = user.Uid;
    }

    protected void carrito(){
        carr = 1;
        carr1 = 1;
        principal1 = 2;
        idclien = idcliente.ToString();

        Console.WriteLine("inicio");

        facturas.Nombre_Producto = "";
        facturas.Nombre_Servicio = "";
        facturas.Cantidad_Prod = 0;
        facturas.Monto_Total = 0;
        facturas.Itbis = 0;
        facturas.FechaYHora= now.ToString();
        facturas.Cliente_Id = idcliente;
        facturas.Uid = userId;
        Console.WriteLine("casi");

        ServiceF.Create(facturas);
        idfact = facturas.Id_Factura;

        Console.WriteLine("guardado");
        curId = idfact.ToString();


    }
    protected void dcarrito(){




    }

    protected void BorrarFactura(){
        carr = 0;
        carr1 = 0;
        principal1 = 1;

        ServiceF.DeleteFactura(facturas);
    }



    void getidclient(){
if ((clientess != "") && (clientess != null))
{
            carr = 2;
            principal1 = 2;

            foreach(var cl in client)
            {
                if (cl.Nombre==clientess)
                {

                    idcliente = cl.Cliente_Id;
                }


            }


        }
    }


    void AgregarPfacturado(){
if ((selected != "") && (selected != null) && (canti>0))
{
        foreach(var prop in product)
        {
            if(prop.Nombre == selected){
                descr = prop.Descripcion;
                money = prop.Precio;
            }
        }


        pfacturado.Nombre = selected;
        pfacturado.Cantidad = canti;
        pfacturado.Precio = money;
        pfacturado.Descripcion = descr;
        pfacturado.Id_Factura = idfact;
        ServiceProductoF.Create(pfacturado);
        NavigationManager.NavigateTo("AddFactura" + "/" + idclien + "/" + curId);
        
}

    }
    void agregarservice(){
        idclien = idcliente.ToString();

if ((selectedserv != "") && (selectedserv != null))
{
        foreach(var prop in servvice)
        {
            if(prop.Nombre_Servicio == selectedserv){
                servicedescr = prop.Descripcion;
                serviceprice = prop.Precio_servicio;
            }
        }


        pfacturado.Nombre = selectedserv;
        pfacturado.Precio = serviceprice;
        pfacturado.Descripcion = servicedescr;
        pfacturado.Id_Factura = idfact;
        ServiceProductoF.Create(pfacturado);
        NavigationManager.NavigateTo("AddFactura" + "/" + idclien + "/" + curId);
}

    }
    void Cancel()
    {
        NavigationManager.NavigateTo("FacturaInfo");


    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<AppUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<AppUser> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PFacturadoService ServiceProductoF { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductoServicio2 ServiceServicio { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FacturaService ServiceF { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClienteService ServiceCl { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductoService Service { get; set; }
    }
}
#pragma warning restore 1591
