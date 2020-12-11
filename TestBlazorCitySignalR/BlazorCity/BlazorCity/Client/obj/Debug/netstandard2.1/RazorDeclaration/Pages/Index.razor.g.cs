// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
