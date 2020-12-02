#pragma checksum "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ad723377ff3677e15662b6b0531f8580639adaf"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace dnp_assignment_4.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\_Imports.razor"
using dnp_assignment_4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\_Imports.razor"
using dnp_assignment_4.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Login.razor"
using dnp_assignment_4.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Login.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Login.razor"
       
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