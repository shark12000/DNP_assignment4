#pragma checksum "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09255865e68843f93feee6c400f86eaf9b54010f"
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
#line 3 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Register.razor"
using dnp_assignment_4.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Register.razor"
using dnp_assignment_4.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Register.razor"
using dnp_assignment_4.Authentification;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sign-up")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddMarkupContent(4, "\r\n            ");
                __builder2.AddMarkupContent(5, "<label>First name:</label>\r\n            ");
                __builder2.OpenElement(6, "input");
                __builder2.AddAttribute(7, "type", "text");
                __builder2.AddAttribute(8, "placeholder", "First name");
                __builder2.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Register.razor"
                                                                     firstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.AddMarkupContent(15, "<label>Last name:</label>\r\n            ");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "type", "text");
                __builder2.AddAttribute(18, "placeholder", "Last name");
                __builder2.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Register.razor"
                                                                    lastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastName = __value, lastName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.AddMarkupContent(25, "<label>Email address:</label>\r\n            ");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "type", "email");
                __builder2.AddAttribute(28, "placeholder", "Email address");
                __builder2.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Register.razor"
                                                                         email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.AddMarkupContent(35, "<label>Username:</label>\r\n            ");
                __builder2.OpenElement(36, "input");
                __builder2.AddAttribute(37, "type", "username");
                __builder2.AddAttribute(38, "placeholder", "Username");
                __builder2.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Register.razor"
                                                                       username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n        \r\n        ");
                __builder2.OpenElement(43, "div");
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.AddMarkupContent(45, "<label>Password</label>\r\n            ");
                __builder2.OpenElement(46, "input");
                __builder2.AddAttribute(47, "type", "password");
                __builder2.AddAttribute(48, "placeholder", "Password");
                __builder2.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Register.razor"
                                                                       password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "style", "color:red");
                __builder2.AddContent(55, 
#nullable restore
#line 34 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Register.razor"
                                errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\r\n        ");
                __builder2.OpenElement(57, "a");
                __builder2.AddAttribute(58, "href", "");
                __builder2.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Register.razor"
                             PerformRegister

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(60, "\r\n            Register\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Register.razor"
       
    private string email;
    private string firstName;
    private string lastName;
    private string username;
    private string password;
    private string errorMessage;
    
    public async Task PerformRegister()
    {
        errorMessage = "";
        try
        {
            await ((CustomAuthenticationStateProvider)AuthenticationStateProvider).ValidateRegistration(new User()
            {
                Email = email,
                FirstName =  firstName,
                Password = password,
                SecondName = lastName,
                UserName = username
            });
            email = "";
            password = "";
        }
        catch (Exception e)
        {
            Console.Write($"logine xception: {e.Message}");
            errorMessage = e.Message;
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
