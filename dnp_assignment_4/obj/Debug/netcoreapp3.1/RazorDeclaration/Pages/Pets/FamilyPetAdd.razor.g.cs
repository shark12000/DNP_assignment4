#pragma checksum "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Pets\FamilyPetAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80dec8c5a752fbc829d6e818090eb6bef28e218b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Pets\FamilyPetAdd.razor"
using dnp_assignment_4.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Pets\FamilyPetAdd.razor"
using dnp_assignment_4.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/family/{familyId}/pets/add")]
    public partial class FamilyPetAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Pets\FamilyPetAdd.razor"
       

    [Parameter]
    public string familyId { get; set; }

    Pet myPet = new Pet();

    private string species;
    private string name;
    private int age;

    public async Task AddFamilyPet()
    {
        await PetService.CreatePet(myPet);
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
