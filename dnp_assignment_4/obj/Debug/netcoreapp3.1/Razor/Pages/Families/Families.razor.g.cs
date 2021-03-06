#pragma checksum "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\Families.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70acffdde8f2a256a0abcdd274587b7340fe0908"
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
#line 2 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\Families.razor"
using dnp_assignment_4.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\Families.razor"
using dnp_assignment_4.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\Families.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/families")]
    public partial class Families : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    * {\r\n        padding: 0;\r\n        margin: 0;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", " display: grid; grid-template-columns: 1fr 1fr; box-sizing: border-box; padding: 10%; grid-gap: 10em");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 19 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\Families.razor"
     foreach (Family family in families)
    {
        if (!family.Equals(null))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "            ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "style", "justify-content: space-between; box-sizing: border-box; display: flex; flex-direction: column; border-radius: 10px; padding: 3% 6%; box-shadow: 0 4px 6px rgba(32,33,36,.08);");
            __builder.AddMarkupContent(7, "\r\n                ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "style", "margin-bottom: 30px;");
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, 
#nullable restore
#line 25 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\Families.razor"
                        family.StreetName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " ");
            __builder.AddContent(14, 
#nullable restore
#line 25 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\Families.razor"
                                           family.HouseNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 28 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\Families.razor"
        }
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Families\Families.razor"
       
    private IList<Family> families = new List<Family>();
    
    protected override async Task OnInitializedAsync()
    {
        families = await FamilyServiceImpl.GetAllFamilies();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyServiceImpl { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
