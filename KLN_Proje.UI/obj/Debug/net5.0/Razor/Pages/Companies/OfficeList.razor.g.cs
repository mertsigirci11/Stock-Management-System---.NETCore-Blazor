#pragma checksum "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Companies\OfficeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32b73368c76edb94974ec186565fc999614535f3"
// <auto-generated/>
#pragma warning disable 1591
namespace KLN_Proje.UI.Pages.Companies
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/office-list")]
    public partial class OfficeList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>List of companies</h3>");
#nullable restore
#line 6 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Companies\OfficeList.razor"
 if (offices == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 9 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Companies\OfficeList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Name</th>\r\n                <th>Address</th>\r\n                <th>Id</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 21 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Companies\OfficeList.razor"
             foreach (var company in offices)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 24 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Companies\OfficeList.razor"
                         company.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 25 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Companies\OfficeList.razor"
                         company.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 26 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Companies\OfficeList.razor"
                         company.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Companies\OfficeList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Companies\OfficeList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Companies\OfficeList.razor"
       
    private List<Office> offices;


    protected override async Task OnInitializedAsync()
    {
        offices = await Http.GetFromJsonAsync<List<Office>>("api/Companies");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591