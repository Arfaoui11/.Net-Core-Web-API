#pragma checksum "/Users/macos/RiderProjects/.Net-Core-Web-API/RestApiView/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e96e0921d1aa4c6aea8e845675d868f0c2248dd"
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
#line 1 "/Users/macos/RiderProjects/.Net-Core-Web-API/RestApiView/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/macos/RiderProjects/.Net-Core-Web-API/RestApiView/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/macos/RiderProjects/.Net-Core-Web-API/RestApiView/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/macos/RiderProjects/.Net-Core-Web-API/RestApiView/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/macos/RiderProjects/.Net-Core-Web-API/RestApiView/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/macos/RiderProjects/.Net-Core-Web-API/RestApiView/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/macos/RiderProjects/.Net-Core-Web-API/RestApiView/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/macos/RiderProjects/.Net-Core-Web-API/RestApiView/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/macos/RiderProjects/.Net-Core-Web-API/RestApiView/_Imports.razor"
using RestApiView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/macos/RiderProjects/.Net-Core-Web-API/RestApiView/_Imports.razor"
using RestApiView.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\n\nWelcome to your new app.\n\n");
            __builder.OpenComponent<RestApiView.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
