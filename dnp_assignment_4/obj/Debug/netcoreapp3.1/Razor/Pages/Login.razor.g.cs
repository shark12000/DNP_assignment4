#pragma checksum "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ad723377ff3677e15662b6b0531f8580639adaf"
// <auto-generated/>
#pragma warning disable 1591
namespace dnp_assignment_4.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\_Imports.razor"
using dnp_assignment_4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\_Imports.razor"
using dnp_assignment_4.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Login.razor"
using dnp_assignment_4.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Login.razor"
using dnp_assignment_4.Authentification;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sign-in")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddMarkupContent(4, "\r\n            ");
                __builder2.AddMarkupContent(5, "<label>Email address:</label>\r\n            ");
                __builder2.OpenElement(6, "input");
                __builder2.AddAttribute(7, "type", "email");
                __builder2.AddAttribute(8, "placeholder", "Email address");
                __builder2.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Login.razor"
                                                                         email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.AddMarkupContent(15, "<label>Password</label>\r\n            ");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "type", "password");
                __builder2.AddAttribute(18, "placeholder", "Password");
                __builder2.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Login.razor"
                                                                       password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "style", "color:red");
                __builder2.AddContent(25, 
#nullable restore
#line 20 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Login.razor"
                                errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n\r\n        ");
                __builder2.OpenElement(27, "a");
                __builder2.AddAttribute(28, "href", "");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Login.razor"
                             PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(30, "\r\n            Login\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n    ");
            }
            ));
            __builder.AddAttribute(32, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenElement(34, "a");
                __builder2.AddAttribute(35, "href", "");
                __builder2.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Login.razor"
                             PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(37, "\r\n            Log out\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Login.razor"
       
    private string email;
    private string password;
    private string errorMessage;

    public async Task PerformLogin()
    {
        errorMessage = "";
        try
        {
            await ((CustomAuthenticationStateProvider)AuthenticationStateProvider).ValidateLogin(email, password);
            email = "";
            password = "";
        }
        catch (Exception e)
        {
            Console.Write(e.Message);
            errorMessage = e.Message;
        }
    }

    public async Task PerformLogout()
    {
        errorMessage = "";
        email = "";
        password = "";
        try
        {
            ((CustomAuthenticationStateProvider)AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            Console.Write(e.Message);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserServiceImpl { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
