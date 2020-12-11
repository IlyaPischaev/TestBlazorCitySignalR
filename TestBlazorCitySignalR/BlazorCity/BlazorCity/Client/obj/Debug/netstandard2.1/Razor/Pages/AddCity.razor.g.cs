#pragma checksum "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\AddCity.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "059ea522f0d27a86ed24c7d3425b35be13700d24"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCity.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Work\C#\BlazorCity\BlazorCity\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Work\C#\BlazorCity\BlazorCity\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Work\C#\BlazorCity\BlazorCity\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Work\C#\BlazorCity\BlazorCity\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Work\C#\BlazorCity\BlazorCity\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Work\C#\BlazorCity\BlazorCity\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Work\C#\BlazorCity\BlazorCity\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Work\C#\BlazorCity\BlazorCity\Client\_Imports.razor"
using BlazorCity.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Work\C#\BlazorCity\BlazorCity\Client\_Imports.razor"
using BlazorCity.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Work\C#\BlazorCity\BlazorCity\Client\_Imports.razor"
using BlazorCity.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Work\C#\BlazorCity\BlazorCity\Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Work\C#\BlazorCity\BlazorCity\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Work\C#\BlazorCity\BlazorCity\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addcity")]
    public partial class AddCity : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\AddCity.razor"
                  newCity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\AddCity.razor"
                                          AddCityToDb

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "container-fluid");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "row");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col");
                __builder2.OpenElement(14, "table");
                __builder2.AddAttribute(15, "class", "table table-striped");
                __builder2.AddMarkupContent(16, @"<thead class=""table-dark""><tr><th scope=""col"">Название города</th>
                            <th scope=""col"">Население</th>
                            <th scope=""col"">Год основания</th>
                            <th scope=""col"">Месяц основания</th>
                            <th scope=""col"">День основания</th></tr></thead>
                    ");
                __builder2.OpenElement(17, "tbody");
                __builder2.OpenElement(18, "tr");
                __builder2.OpenElement(19, "td");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\AddCity.razor"
                                                                         newCity.CityName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newCity.CityName = __value, newCity.CityName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                            ");
                __builder2.OpenElement(25, "td");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\AddCity.razor"
                                                                         newCity.CityPopulation

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newCity.CityPopulation = __value, newCity.CityPopulation));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                            ");
                __builder2.OpenElement(31, "td");
                __builder2.OpenElement(32, "input");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\AddCity.razor"
                                                                         newCity.CityFoundationYear

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newCity.CityFoundationYear = __value, newCity.CityFoundationYear));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                            ");
                __builder2.OpenElement(37, "td");
                __builder2.OpenElement(38, "select");
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\AddCity.razor"
                                                                    newCity.CityDoundationMonth

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newCity.CityDoundationMonth = __value, newCity.CityDoundationMonth));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(42, "option");
                __builder2.AddAttribute(43, "selected", true);
                __builder2.AddAttribute(44, "disabled", true);
                __builder2.AddAttribute(45, "value", "-1");
                __builder2.AddMarkupContent(46, "Выберите месяц");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                                    ");
                __builder2.OpenElement(48, "option");
                __builder2.AddAttribute(49, "value", "1");
                __builder2.AddMarkupContent(50, "Январь");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                                    ");
                __builder2.OpenElement(52, "option");
                __builder2.AddAttribute(53, "value", "2");
                __builder2.AddMarkupContent(54, "Февраль");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                                    ");
                __builder2.OpenElement(56, "option");
                __builder2.AddAttribute(57, "value", "3");
                __builder2.AddMarkupContent(58, "Март");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                                    ");
                __builder2.OpenElement(60, "option");
                __builder2.AddAttribute(61, "value", "4");
                __builder2.AddMarkupContent(62, "Апрель");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                                    ");
                __builder2.OpenElement(64, "option");
                __builder2.AddAttribute(65, "value", "5");
                __builder2.AddMarkupContent(66, "Май");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                                    ");
                __builder2.OpenElement(68, "option");
                __builder2.AddAttribute(69, "value", "6");
                __builder2.AddMarkupContent(70, "Июнь");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                                    ");
                __builder2.OpenElement(72, "option");
                __builder2.AddAttribute(73, "value", "7");
                __builder2.AddMarkupContent(74, "Июль");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                                    ");
                __builder2.OpenElement(76, "option");
                __builder2.AddAttribute(77, "value", "8");
                __builder2.AddMarkupContent(78, "Август");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                                    ");
                __builder2.OpenElement(80, "option");
                __builder2.AddAttribute(81, "value", "9");
                __builder2.AddMarkupContent(82, "Сентябрь");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                                    ");
                __builder2.OpenElement(84, "option");
                __builder2.AddAttribute(85, "value", "10");
                __builder2.AddMarkupContent(86, "Октябрь");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                                    ");
                __builder2.OpenElement(88, "option");
                __builder2.AddAttribute(89, "value", "11");
                __builder2.AddMarkupContent(90, "Ноябрь");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                                    ");
                __builder2.OpenElement(92, "option");
                __builder2.AddAttribute(93, "value", "12");
                __builder2.AddMarkupContent(94, "Декабрь");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n                            ");
                __builder2.OpenElement(96, "td");
                __builder2.OpenElement(97, "input");
                __builder2.AddAttribute(98, "class", "form-control");
                __builder2.AddAttribute(99, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\AddCity.razor"
                                                                         newCity.CityDoundationDay

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(100, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newCity.CityDoundationDay = __value, newCity.CityDoundationDay));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n\r\n                ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "row");
                __builder2.AddMarkupContent(104, "<div class=\"col\"><button type=\"submit\" class=\"btn btn-success\">Добавить город</button></div>\r\n                    ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "col");
                __builder2.OpenElement(107, "button");
                __builder2.AddAttribute(108, "type", "submit");
                __builder2.AddAttribute(109, "class", "btn btn-danger");
                __builder2.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\AddCity.razor"
                                                                                Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(111, "Отмена");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\AddCity.razor"
       
    private City newCity = new City();

    private HubConnection hubConnection;

    protected override async Task OnInitializedAsync()
    {

        hubConnection = new HubConnectionBuilder()
        .WithUrl(NavigationManager.ToAbsoluteUri("/CityHub"))
        .Build();

        await hubConnection.StartAsync();
    }

    public async Task AddCityToDb()
    {
        await Http.PostAsJsonAsync("City", newCity);
        if (IsConnected) await SendMessage();

        NavigationManager.NavigateTo("");
    }

    Task SendMessage() => hubConnection.SendAsync("SendMessage");

    public bool IsConnected => hubConnection.State == HubConnectionState.Connected;

    public void Dispose()
    {
        _ = hubConnection.DisposeAsync();
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591