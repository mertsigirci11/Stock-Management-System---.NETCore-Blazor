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
    [Microsoft.AspNetCore.Components.RouteAttribute("/stock-update-by-id")]
    public partial class UpdateStockById : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 266 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Stocks\UpdateStockById.razor"
       
    public Stock stock = new Stock();
    //variables for binding
    public string companyIdString = "";
    public int companyId = 0;
    public string warehouseIdString = "";
    public int warehouseId = 0;
    public int stockId = 0;

    //variables for check situations to show list
    public bool key = true;
    public bool showStockList = true;
    public bool keyWarehouse = true;
    public bool keyStock = false;
    public bool selecting = true;
    public bool selectingWarehouse = true;

    public void TakeId(int id)
    {
        stockId = id;
        if (id != 0)
        {
            keyStock = true;
        }
    }

    public void IsSelecting()
    {
        selecting = false;
        showStockList = false;
    }
    public void IsSelectingWarehouse()
    {
        selectingWarehouse = false;
        showStockList = false;
    }
    public void ChangeSitutation()
    {
        selecting = true;

        if (key == true)
        {
            key = false;
        }
        else
        {
            key = true;
        }
    }
    public void ChangeSitutationWarehouse()
    {
        selectingWarehouse = true;
        showStockList = true;

        if (keyWarehouse == true)
        {
            keyWarehouse = false;
        }
        else
        {
            keyWarehouse = true;
        }
    }
    public void SelectCompany(ChangeEventArgs e)  //Selectform işi halletti
    {
        companyIdString = e.Value.ToString();
        companyId = Int32.Parse(companyIdString);
    }
    public void SelectWarehouse(ChangeEventArgs e)
    {
        warehouseIdString = e.Value.ToString();
        warehouseId = Int32.Parse(warehouseIdString);
    }
    private async Task PutStock()
    {
        //warehouse.CompanyId = companyId;
        var stockUpdate = stocks.FirstOrDefault(x => x.Id == stockId);
        await Http.PutAsJsonAsync("api/stocks", stock);
        stockUpdate.Name = stock.Name;
        stockUpdate.Price = stock.Price;
        stockUpdate.Piece = stock.Piece;
        stockUpdate.WarehouseId = stock.WarehouseId;
        keyStock = false;
    }

    public string companiesString;

    //api consuming
    public List<Company> companies;
    public List<Warehouse> warehouses;
    public List<Stock> stocks;
    protected override async Task OnInitializedAsync()
    {
        companies = await Http.GetFromJsonAsync<List<Company>>("api/CompanyInformations");
        companiesString = await Http.GetStringAsync("api/CompanyInformations");
        warehouses = await Http.GetFromJsonAsync<List<Warehouse>>("api/Warehouses");
        stocks = await Http.GetFromJsonAsync<List<Stock>>("api/Stocks");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
