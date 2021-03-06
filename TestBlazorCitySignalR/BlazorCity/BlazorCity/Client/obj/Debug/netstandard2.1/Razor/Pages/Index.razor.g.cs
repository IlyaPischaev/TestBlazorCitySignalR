#pragma checksum "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f9a7f871f7a749dd26ca2aaf76e0066e7b44cc8"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table table-striped");
            __builder.AddMarkupContent(8, @"<thead class=""table-dark""><tr><th scope=""col"">Название города</th>
                        <th scope=""col"">Население</th>
                        <th scope=""col"">Дата основания</th>
                        <th scope=""col""></th>
                        <th scope=""col""></th></tr></thead>");
#nullable restore
#line 19 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
                 foreach (var item in cities)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tbody");
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 24 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
                                 item.CityName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                            ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 27 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
                                 item.CityPopulation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                            ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 30 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
                                 item.CityDoundationDay

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, ".");
            __builder.AddContent(20, 
#nullable restore
#line 30 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
                                                         item.CityDoundationMonth

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, ".");
            __builder.AddContent(22, 
#nullable restore
#line 30 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
                                                                                   item.CityFoundationYear

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                            ");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-info");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
                                                                         () => EditCity(item.CityId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "Редактировать");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-danger");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
                                                                           () => DeleteCity(item.CityId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "Удалить");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(36, "<h2>Выбор даты1</h2>\r\n");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "type", "date");
            __builder.AddAttribute(40, "min", "1980-01-01");
            __builder.AddAttribute(41, "max", 
#nullable restore
#line 56 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
                              value

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
                     value

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => value = __value, value, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "class", "btn btn-block");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
                                         OnChange

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(48, "Сделать");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "value", 
#nullable restore
#line 59 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
               year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "value", 
#nullable restore
#line 60 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
               month

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "value", 
#nullable restore
#line 61 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
               day

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n");
            __builder.AddMarkupContent(59, "<h2>Выбор даты2</h2>\r\n");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "class", "form-control");
            __builder.AddAttribute(62, "type", "date");
            __builder.AddAttribute(63, "min", "1980-01-01");
            __builder.AddAttribute(64, "max", 
#nullable restore
#line 66 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
                              value

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
                      dt

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dt = __value, dt, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Work\C#\BlazorCity\BlazorCity\Client\Pages\Index.razor"
       
    private List<City> cities = new List<City>();
    private HubConnection hubConnection;

    DateTime? value = DateTime.Now;
    DateTime? dt;
    int? year, month, day;
    string date;

    void OnChange()
    {
        date = value?.ToString("yyyyMMdd");

        if (date == null)
        {
            year = month = day = 0;
        }
        else
        {
            year = Int32.Parse(date.Substring(0, 4));
            month = Int32.Parse(date.Substring(4, 2));
            day = Int32.Parse(date.Substring(6));
        }

        int i = 20140820;
        string time = i.ToString();

        dt = DateTime.ParseExact(time, "yyyyMMdd", null);
    }

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("Here");

        hubConnection = new HubConnectionBuilder()
        .WithUrl(NavigationManager.ToAbsoluteUri("/CityHub"))
        .Build();

        hubConnection.On("RecieveMessage", () =>
        {
            CallLoadData();
            StateHasChanged();
        });

        await hubConnection.StartAsync();
        await LoadData();
    }

    private void CallLoadData()
    {
        Task.Run(async () =>
        {
            await LoadData();
        });
    }

    protected async Task LoadData()
    {
        cities = await Http.GetFromJsonAsync<List<City>>("City");
        StateHasChanged();
    }

    Task Send() => hubConnection.SendAsync("SendMessage");

    public bool IsConnected =>
    hubConnection.State == HubConnectionState.Connected;

    private async Task DeleteCity(int id)
    {
        await Http.DeleteAsync("City/" + id);
        if (IsConnected) await Send();
    }

    private void EditCity(int id)
    {
        NavigationManager.NavigateTo("/editcity/" + id);
    }

    public void Dispose()
    {
        _ = hubConnection.DisposeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
