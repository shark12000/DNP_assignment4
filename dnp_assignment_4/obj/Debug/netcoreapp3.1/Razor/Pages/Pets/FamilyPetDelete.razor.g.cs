#pragma checksum "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Pets\FamilyPetDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "490d7aa8c7719bdde5b9c363d216252b55b86ff3"
// <auto-generated/>
#pragma warning disable 1591
namespace dnp_assignment_4.Pages.Pets
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
#line 2 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Pets\FamilyPetDelete.razor"
using dnp_assignment_4.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/family/{familyId}/pet/{petId}/delete")]
    public partial class FamilyPetDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Family Pet Delete</h3>\r\n\r\nAre you sure you want to delete the pet with id ");
            __builder.AddContent(1, 
#nullable restore
#line 9 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Pets\FamilyPetDelete.razor"
                                                 petId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(2, " from family ");
            __builder.AddContent(3, 
#nullable restore
#line 9 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Pets\FamilyPetDelete.razor"
                                                                    familyId

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "?\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Pets\FamilyPetDelete.razor"
                  DeletePet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Yes");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Pets\FamilyPetDelete.razor"
                  Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "No");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Pets\FamilyPetDelete.razor"
       
    [Parameter]
    public string familyId { get; set; }
    [Parameter]
    public string petId { get; set; }
    
    public async Task DeletePet()
    {
        await PetService.RemovePet(Int32.Parse(petId));
        NavigationManager.NavigateTo($"family/{familyId}/edit");
    }

    public async Task Cancel()
    {
        NavigationManager.NavigateTo($"family/{familyId}/edit");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPetService PetService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyServiceImpl { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
