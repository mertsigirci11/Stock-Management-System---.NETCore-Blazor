#pragma checksum "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Warehouses\UpdateWarehouse.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd39b7a94a22ab6e9ac5aaf8a8579c61ee105aa4"
// <auto-generated/>
#pragma warning disable 1591
namespace KLN_Proje.UI.Pages.Warehouses
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
#nullable restore
#line 4 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Warehouses\UpdateWarehouse.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/update-warehouse")]
    public partial class UpdateWarehouse : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Warehouses\UpdateWarehouse.razor"
                 warehouse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(3);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(4, "\r\n\r\n    ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "card");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "card-body");
                __builder2.AddMarkupContent(9, "<h5 class=\"card-title\">Update Warehouse </h5>\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group row");
#nullable restore
#line 14 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Warehouses\UpdateWarehouse.razor"
                  
                    warehouse.Id = warehouseId;
                

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(12, "label");
                __builder2.AddAttribute(13, "class", "col-sm-4 col-form-label");
                __builder2.AddContent(14, "Warehouse Id: ");
                __builder2.OpenElement(15, "span");
                __builder2.AddAttribute(16, "class", "font-weight-bold");
                __builder2.AddContent(17, 
#nullable restore
#line 17 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Warehouses\UpdateWarehouse.razor"
                                                                                                     warehouseId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n\r\n            ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group row");
                __builder2.AddMarkupContent(21, "<label class=\"col-sm-4 col-form-label\">Name</label>\r\n                ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "col-sm-8");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "id", "name");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "placeholder", "Warehouse Name");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Warehouses\UpdateWarehouse.razor"
                                                                                                         warehouse.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => warehouse.Name = __value, warehouse.Name))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => warehouse.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.OpenElement(32, "span");
                __Blazor.KLN_Proje.UI.Pages.Warehouses.UpdateWarehouse.TypeInference.CreateValidationMessage_0(__builder2, 33, 34, 
#nullable restore
#line 24 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Warehouses\UpdateWarehouse.razor"
                                                    () => warehouse.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n            ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group row");
                __builder2.AddMarkupContent(38, "<label class=\"col-sm-4 col-form-label\">Company Name: <span class=\"font-weight-bolder\"></span></label>\r\n                ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col-sm-8");
                __Blazor.KLN_Proje.UI.Pages.Warehouses.UpdateWarehouse.TypeInference.CreateInputSelect_1(__builder2, 41, 42, "form-control", 43, 
#nullable restore
#line 31 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Warehouses\UpdateWarehouse.razor"
                                              companyId

#line default
#line hidden
#nullable disable
                , 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => companyId = __value, companyId)), 45, () => companyId, 46, (__builder3) => {
                    __builder3.AddMarkupContent(47, "<option value=\"0\">Choose</option>");
#nullable restore
#line 33 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Warehouses\UpdateWarehouse.razor"
                         foreach (var company in companiesFromParent)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(48, "option");
                    __builder3.AddAttribute(49, "value", 
#nullable restore
#line 35 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Warehouses\UpdateWarehouse.razor"
                                            company.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(50, 
#nullable restore
#line 35 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Warehouses\UpdateWarehouse.razor"
                                                         company.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 36 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Warehouses\UpdateWarehouse.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n            ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group row");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "col-sm-8");
                __builder2.OpenElement(56, "button");
                __builder2.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Warehouses\UpdateWarehouse.razor"
                                       PutWarehouse

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "type", "submit");
                __builder2.AddAttribute(59, "class", "btn btn-primary");
                __builder2.AddContent(60, "Update Stock");
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
#line 53 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Warehouses\UpdateWarehouse.razor"
      
    private Warehouse warehouse = new Warehouse();

    [Parameter]
    public int warehouseId { get; set; }

    [Parameter]
    public int companyId { get; set; }


    [Parameter]
    public string companiesString { get; set; }

    [Parameter]
    public string warehosuesString { get; set; }

    [Parameter]
    public EventCallback<Warehouse> WarehouseToBeSent { get; set; }

    public void Trigger()
    {
        WarehouseToBeSent.InvokeAsync(warehouse);
    }

    //Deserialize
    public List<Company> companiesFromParent;
    public List<Warehouse> warehousesFromParent;
    public void DeserializeLists(string _companiesString, string _warehousesString)
    {
        companiesFromParent = JsonConvert.DeserializeObject<List<Company>>(_companiesString);
        warehousesFromParent = JsonConvert.DeserializeObject<List<Warehouse>>(_warehousesString);
    }

    public void UpdateWarehouseList(int id, string name = null, int companyId = 0)
    {
        var warehouseUpdate = warehousesFromParent.FirstOrDefault(x => x.Id == warehouseId);
        warehouseUpdate.Name = name != null ? name : warehouse.Name;
        warehouseUpdate.CompanyId = companyId != 0 ? companyId : warehouse.CompanyId;
    }

    private async Task PutWarehouse()
    {
        warehouse.CompanyId = companyId;
        var warehouseUpdate = warehousesFromParent.FirstOrDefault(x => x.Id == warehouseId);
        UpdateWarehouseList(warehouseId, warehouse.Name, warehouse.CompanyId);
        await Http.PutAsJsonAsync("api/warehouses", warehouse);
        Trigger();
    }

    protected async override Task OnInitializedAsync()
    {
        warehouse.Id = warehouseId;
        DeserializeLists(companiesString, warehosuesString);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.KLN_Proje.UI.Pages.Warehouses.UpdateWarehouse
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
