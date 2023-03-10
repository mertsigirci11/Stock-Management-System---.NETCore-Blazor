// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KLN_Proje.UI.Pages.Stocks
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\_Imports.razor"
using KLN_Proje.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\_Imports.razor"
using KLN_Proje.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\_Imports.razor"
using KLN_Proje.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/stocks")]
    public partial class HandleAllStocks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 192 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Stocks\HandleAllStocks.razor"
 
    public List<Stock> stocks;
    public List<Warehouse> warehouses;
    public List<Stock> stocks2;
    public bool isEdit = false;
    public bool isCreate = false;
    public bool key = true;
    public int stockId = 0;
    public int warehouseId = 0;
    public string stocksString;
    public string warehousesString;

    public Stock stockForUpdate = new Stock();
    public Stock stockForAdd = new Stock();
    public Warehouse warehouse = new Warehouse();

    public void TakeIdForEdit(int id, int _warehouseId)
    {
        stockId = id;
        warehouseId = _warehouseId;
        isEdit = true;
        isCreate = false;
    }

    public void TakeIdForDelete(int id, Stock stock)
    {
        Http.DeleteAsync($"api/stocks/{id}");
        stocks.Remove(stock);
        UriHelper.NavigateTo("stocks");
        isEdit = false;
        isCreate = false;
    }

    private async void PutStock() //Liste g??ncellenecek
    {
        await Http.PutAsJsonAsync("api/stocks", stockForUpdate);

        /*stocks2 = stocks.Where(x => x.Id == stockForUpdate.Id).ToList();
        var x = stocks2.FirstOrDefault();
        x.Name = stockForUpdate.Name;
        x.Price = stockForUpdate.Price;
        x.Piece = stockForUpdate.Piece;
        x.WarehouseId = stockForUpdate.WarehouseId;

        //var warehouseUpdate = warehousesFromParent.FirstOrDefault(x => x.Id == warehouseId);
        var deneme = stocks2.FirstOrDefault(x => x.Id == stockForUpdate.Id);
        deneme.Name = stockForUpdate.Name;
        deneme.Price = stockForUpdate.Price;
        deneme.Piece = stockForUpdate.Piece;
        deneme.WarehouseId = stockForUpdate.WarehouseId;*/

        isEdit = false;
    }

    public async void CreateStock()
    {
        await Http.PostAsJsonAsync("api/stocks", stockForAdd);
        stocks.Add(stockForAdd);
    }
    public void StocktoBeSent(Stock stocksToBeSent)
    {
        var x = stocks.Find(x => x.Id == stocksToBeSent.Id);
        x.WarehouseId = stocksToBeSent.WarehouseId;
        x.Name = stocksToBeSent.Name;
    }
    public void IsCreate(bool key)
    {
        isCreate = key;
    }

    public void Creating()
    {
        isCreate = true;
        isEdit = false;
    }

    protected override async Task OnInitializedAsync()
    {
        stocks = await Http.GetFromJsonAsync<List<Stock>>("api/Stocks");
        stocksString = await Http.GetStringAsync("api/Stocks");
        warehouses = await Http.GetFromJsonAsync<List<Warehouse>>("api/Warehouses");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
