#pragma checksum "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "579211493e796cd7891f2805edffb9282a7507be"
// <auto-generated/>
#pragma warning disable 1591
namespace RestApiView.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\_Imports.razor"
using RestApiView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\_Imports.razor"
using RestApiView.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
#nullable restore
#line 5 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\Pages\Counter.razor"
__builder.AddContent(3, currentCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-primary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\Pages\Counter.razor"
                                           ModalShow

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Show Dialog!");
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\Pages\Counter.razor"
 if (showModal)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal fade show");
            __builder.AddAttribute(16, "id", "myModal");
            __builder.AddAttribute(17, "style", "display:block");
            __builder.AddAttribute(18, "aria-modal", "true");
            __builder.AddAttribute(19, "role", "dialog");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "modal-dialog");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "modal-content");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "modal-header");
            __builder.AddMarkupContent(26, "<h4 class=\"modal-title\">Confirm action</h4>\r\n                    ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "close");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\Pages\Counter.razor"
                                                                   ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "×");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n                \r\n                ");
            __builder.AddMarkupContent(33, "<div class=\"modal-body\"><p>This is the modal content!</p></div>\r\n\r\n                \r\n                ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "modal-footer");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "type", "button");
            __builder.AddAttribute(38, "class", "btn");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\Pages\Counter.razor"
                                                                 ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "class", "btn btn-danger");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\Pages\Counter.razor"
                                                                           ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\Pages\Counter.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "<hr>");
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\LEGION-5\Desktop\NET CORS\Examen\RestApiView\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }


    bool showModal = false;

    void ModalShow() => showModal = true;
    void ModalCancel() => showModal = false;
    void ModalOk()
    {
        Console.WriteLine("Modal ok");
        showModal = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
