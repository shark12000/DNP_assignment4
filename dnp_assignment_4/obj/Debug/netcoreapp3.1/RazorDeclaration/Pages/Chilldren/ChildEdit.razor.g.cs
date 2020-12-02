#pragma checksum "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Chilldren\ChildEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40fa465bfae8b334c4a7deb8f478130b2363b2e4"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace dnp_assignment_4.Pages.Chilldren
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
#line 2 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Chilldren\ChildEdit.razor"
using dnp_assignment_4.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Chilldren\ChildEdit.razor"
using dnp_assignment_4.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/family/{familyId}/children/{childId}/edit")]
    public partial class ChildEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "C:\Users\themr\RiderProjects\DNP4\dnp_assignment_4\Pages\Chilldren\ChildEdit.razor"
       
    [Parameter]
    public string familyId { get; set; }

    [Parameter]
    public string childId { get; set; }

    Child myChild = new Child();
    Hobby myHobby = new Hobby();
    Pet myPet = new Pet();
    
    IList<Hobby> _hobbies = new List<Hobby>();
    IList<Hobby> myHobbies = new List<Hobby>();
    IList<Pet> myPets = new List<Pet>(); 

    protected override async Task OnInitializedAsync()
    {
        _hobbies = await ChildService.GetAllHobbies();
        myChild = await ChildService.GetChild(Int32.Parse(childId));
        myPets = await ChildService.GetPets(Int32.Parse(childId));
        myHobbies = await ChildService.GetHobbies(Int32.Parse(childId));
        myPet.ChildId = Int32.Parse(childId);
        myPet.FamilyId = Int32.Parse(familyId);
        myHobby.ChildId = Int32.Parse(childId);
    }

    public async Task Save()
    {
        await ChildService.Update(myChild);
        NavigationManager.NavigateTo($"/family/{familyId}/edit");
    }
    
    public async Task AddChildInterest(Hobby hobby)
    {
        await ChildService.CreateHobby(hobby);
    }

    public async Task DeleteInterest(Hobby hobby)
    {
        await ChildService.RemoveHobby(hobby.HobbyId, myChild.ChildId);
    }

    public async Task AddHobby()
    {
        await AddChildInterest(myHobby);
    }
    
    public async Task AddPet()
    {
        await ChildService.CreatePet(myPet);
    }

    public async Task DeletePet(Pet pet)
    {
        await ChildService.RemovePet(pet.PetId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IChildService ChildService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyServiceImpl { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591