// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KLN_Proje.UI.Pages.Customers
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/customer-manage")]
    public partial class ManageCustomer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Customers\ManageCustomer.razor"
 
    public Customer customerForUpdate = new Customer();

    public bool isEdit = false;
    public bool isDelete = false;
    public bool operationKey = false;
    public bool isChange = true;

    public int customerId = 0;

    /*public void TakeIdForEdit(int id)
    {
        customerId = id;
        isEdit = true;
    }*/

    /*public async void UpdateCustomer()
    {
        customerForUpdate.Id = customerId;
        customers.Where(x => x.Id == customerId).FirstOrDefault().Id = customerForUpdate.Id;
        customers.Where(x => x.Id == customerId).FirstOrDefault().Name = customerForUpdate.Name;
        customers.Where(x => x.Id == customerId).FirstOrDefault().Surname = customerForUpdate.Surname;
        customers.Where(x => x.Id == customerId).FirstOrDefault().Username = customerForUpdate.Username;
        customers.Where(x => x.Id == customerId).FirstOrDefault().Password = customerForUpdate.Password;
        customers.Where(x => x.Id == customerId).FirstOrDefault().TaxAdministration = customerForUpdate.TaxAdministration;
        customers.Where(x => x.Id == customerId).FirstOrDefault().BankAccountNumber = customerForUpdate.BankAccountNumber;

        await Http.PutAsJsonAsync<Customer>("api/Customers", customerForUpdate);
    }*/

    public Customer customerFromEditComponent = new Customer();

    public async void ShowTheEditModal(int id)
    {
        var parameters1 = new ModalParameters();
        parameters1.Add(nameof(EditComponent.CustomerId), id);

        var editComponent = Modal.Show<EditComponent>("", parameters1);
        var result = await editComponent.Result;

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Customers\ManageCustomer.razor"
         if (!result.Cancelled)
        {
            var customerString = result.Data.ToString();
            string[] array = customerString.Split(",");
            customerFromEditComponent.Id = Int32.Parse(array[0]);
            customerFromEditComponent.Name = array[1];
            customerFromEditComponent.Surname = array[2];
            customerFromEditComponent.Username = array[3];
            customerFromEditComponent.Password = array[4];
            customerFromEditComponent.TaxAdministration = array[5];
            customerFromEditComponent.BankAccountNumber = array[6];
            customers.Remove(customers.Where(x => x.Id == customerFromEditComponent.Id).FirstOrDefault());
            customers.Add(customerFromEditComponent);

            if (isChange == true)
            {
                isChange = false;
            }
            else
            {
                isChange = true;
            }
            UriHelper.NavigateTo("customer-manage1");
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Customers\ManageCustomer.razor"
         
    }

    public async void ShowTheCreateModal()
    {
        
    }

    //Deleting
    public void OnClose(bool _key)
    {
        isDelete = false;
        operationKey = _key;
        NewMethod(customerId);
    }
    public void NewMethod(int id)
    {
        if (operationKey)
        {
            Http.DeleteAsync($"api/Customers/{id}");
            var x = customers.Where(i => i.Id == id).ToList();
            customers.Remove(x.First());
            isDelete = false;
        }
    }
    public void TakeIdForDelete(int id)
    {
        customerId = id;
        isDelete = true;
    }

    //api consuming
    private List<Customer> customers;
    protected override async Task OnInitializedAsync()
    {
        customers = await Http.GetFromJsonAsync<List<Customer>>("api/Customers");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
