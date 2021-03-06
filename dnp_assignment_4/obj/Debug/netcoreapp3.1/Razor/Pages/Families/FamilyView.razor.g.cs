#pragma checksum "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\FamilyView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d02920d7d0b6b9a5a2ba6a26ebc9345f5204f18b"
// <auto-generated/>
#pragma warning disable 1591
namespace dnp_assignment_4.Pages.Families
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
#line 2 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\FamilyView.razor"
using dnp_assignment_4.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\FamilyView.razor"
using dnp_assignment_4.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FamilyView")]
    public partial class FamilyView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n");
                __builder2.AddMarkupContent(3, "<h3>FamilyView</h3>\r\n");
                __builder2.OpenElement(4, "button");
                __builder2.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\FamilyView.razor"
                  AddFamily

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(6, "Add");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\r\n");
#nullable restore
#line 15 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\FamilyView.razor"
 foreach (Family family in families)
{
    if (!family.Equals(null))
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(8, "        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "style", "border:1px solid gainsboro");
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.AddContent(12, 
#nullable restore
#line 20 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\FamilyView.razor"
             family.StreetName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(13, " + ");
                __builder2.AddContent(14, 
#nullable restore
#line 20 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\FamilyView.razor"
                                  family.HouseNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenElement(16, "a");
                __builder2.AddAttribute(17, "href", "/family/" + (
#nullable restore
#line 21 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\FamilyView.razor"
                              family.Id

#line default
#line hidden
#nullable disable
                ) + "/edit");
                __builder2.AddContent(18, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenElement(20, "a");
                __builder2.AddAttribute(21, "href", "/family/" + (
#nullable restore
#line 22 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\FamilyView.razor"
                              family.Id

#line default
#line hidden
#nullable disable
                ) + "/delete");
                __builder2.AddContent(22, "Delete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n");
#nullable restore
#line 24 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\FamilyView.razor"
    }
}

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(25, "\r\n<div></div>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\FamilyView.razor"
       
    private IList<Family> families = new List<Family>();
    
    
    [Parameter]
    public string userId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        userId = user.FindFirst(claim => claim.Type.Equals("Id")).Value;
        int id = Int32.Parse(userId);
        families = await FamilyServiceImpl.GetCurrentUserFamilies(id);
    }
    
    
    private void AddFamily()
    {
        NavigationManager.NavigateTo("/{userId}/FamilyView/add");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyServiceImpl { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
