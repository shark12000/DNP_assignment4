#pragma checksum "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae8d05d57c2acd04905c8cf84e83ffa00bc5c874"
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
#line 2 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Counter.razor"
using dnp_assignment_4.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Counter.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Counter.razor"
using dnp_assignment_4.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Counter.razor"
       
    private IList<User> users = new List<User>();
    private string firstName;
    private string secondName;
    
    protected override async Task OnInitializedAsync()
    {
      
    }

    public async Task addUser()
    {
        User user = new User()
        {
            FirstName = firstName,
            SecondName = secondName
        };
        await UserService.RegisterUser(user);
        users.Add(user);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
    }
}
#pragma warning restore 1591