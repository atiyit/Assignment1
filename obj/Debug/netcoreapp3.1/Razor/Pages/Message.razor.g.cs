#pragma checksum "D:\github\Assignment1\Pages\Message.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbe80d76ab9112fc6aa7beb515bcbc4bb2eb2633"
// <auto-generated/>
#pragma warning disable 1591
namespace MessageComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\github\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\github\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\github\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\github\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\github\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\github\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\github\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\github\Assignment1\_Imports.razor"
using Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\github\Assignment1\_Imports.razor"
using Assignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\github\Assignment1\Pages\Message.razor"
using Assignment.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Message")]
    public partial class Message : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "D:\github\Assignment1\Pages\Message.razor"
                   Show

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(2, "\r\n             UpdateMessage\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "color:red");
            __builder.AddContent(6, 
#nullable restore
#line 7 "D:\github\Assignment1\Pages\Message.razor"
                         Messages

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\github\Assignment1\Pages\Message.razor"
       

    private string Messages;
    public async Task Show()
    {
        Messages = MessageModel.getInstance().messageManage;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
