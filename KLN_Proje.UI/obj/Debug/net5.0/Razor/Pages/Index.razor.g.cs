#pragma checksum "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7bdd9e55f0ec83d57fcca9eb3174db1081f1c73"
// <auto-generated/>
#pragma warning disable 1591
namespace KLN_Proje.UI.Pages
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
#line 2 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Index.razor"
using KLN_Proje.UI.Pages.Customers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<KLN_Proje.UI.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Index.razor"
                    ()=> modal.Show<AddCustomer>("Modal Example")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddContent(7, "View");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
    }
}
#pragma warning restore 1591
