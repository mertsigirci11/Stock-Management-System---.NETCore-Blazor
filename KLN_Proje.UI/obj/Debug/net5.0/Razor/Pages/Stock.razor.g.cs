#pragma checksum "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Stock.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d87f1a7a240ede3c9f244162c90bcefff309437f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/stock")]
    public partial class Stock : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Stock</h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Stock.razor"
                                          NavigateTo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Show All Stocks");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n<br>\r\n\r\n");
            __builder.AddMarkupContent(6, "<div class=\"container-fluid\"><div class=\"pricing-header px-3 py-3 pt-md-5 pb-md-4 mx-auto text-center\"><div class=\"row mb-3\"><div class=\"col-xl-3 col-sm-6 py-2\"><a style=\"padding:0px;margin:0px;text-decoration:none\" href=\"stock-list-by-id\"><div class=\"card text-white bg-info h-100\"><div class=\"card-body bg-info\"><div class=\"rotate\"><i class=\"fa fa-user fa-4x\"></i></div>\r\n                            <h6 class=\"text-uppercase\">List Stocks</h6>\r\n                            <p class=\"font-weight-bold\">List Stocks By Id</p></div></div></a></div>\r\n\r\n\r\n            <div class=\"col-xl-3 col-sm-6 py-2\"><a style=\"padding:0px;margin:0px;text-decoration:none\" href=\"stock-add-by-id\"><div class=\"card bg-success text-white h-100\"><div class=\"card-body bg-success\"><div class=\"rotate\"><i class=\"fa fa-list fa-4x\"></i></div>\r\n                            <h6 class=\"text-uppercase\">Create Stock</h6>\r\n                            <p class=\"font-weight-bold\">Create Stock By Id</p></div></div></a></div>\r\n\r\n\r\n\r\n            <div class=\"col-xl-3 col-sm-6 py-2\"><a style=\"padding:0px;margin:0px;text-decoration:none\" href=\"stock-update-by-id\"><div class=\"card text-white bg-warning h-100\"><div class=\"card-body\"><div class=\"rotate\"><i class=\"fa fa-building fa-4x\"></i></div>\r\n                            <h6 class=\"text-uppercase\">Update Stock</h6>\r\n                            <p class=\"font-weight-bold\">Update Stock By Id</p></div></div></a></div>\r\n\r\n\r\n\r\n            <div class=\"col-xl-3 col-sm-6 py-2\"><a style=\"padding:0px;margin:0px;text-decoration:none\" href=\"stock-delete-by-id\"><div class=\"card text-white bg-danger h-100\"><div class=\"card-body bg-danger\"><div class=\"rotate\"><i class=\"fa fa-city fa-4x\"></i></div>\r\n                            <h6 class=\"text-uppercase\">Delete Stock</h6>\r\n                            <p class=\"font-weight-bold\">Delete Stock By Id</p></div></div></a></div></div>\r\n        \r\n\r\n        <style>\r\n            .card {\r\n                overflow: hidden;\r\n            }\r\n\r\n            .card-body .rotate {\r\n                z-index: 8;\r\n                float: right;\r\n                height: 100%;\r\n            }\r\n\r\n                .card-body .rotate i {\r\n                    color: rgba(20, 20, 20, 0.15);\r\n                    position: absolute;\r\n                    left: 0;\r\n                    left: auto;\r\n                    right: -10px;\r\n                    bottom: 0;\r\n                    display: block;\r\n                    -webkit-transform: rotate(-44deg);\r\n                    -moz-transform: rotate(-44deg);\r\n                    -o-transform: rotate(-44deg);\r\n                    -ms-transform: rotate(-44deg);\r\n                    transform: rotate(-44deg);\r\n                }\r\n        </style></div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 175 "C:\Users\Mert Sigirci\Desktop\UMDE\KLN\KLN CRUD (.NET-Web Assembly) Website\KLN_Proje\KLN_Proje.UI\Pages\Stock.razor"
 
    public void NavigateTo()
    {
        UriHelper.NavigateTo("stocks");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
