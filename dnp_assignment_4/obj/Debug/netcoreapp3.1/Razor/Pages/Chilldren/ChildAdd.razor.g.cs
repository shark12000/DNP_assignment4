#pragma checksum "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Chilldren\ChildAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6e8b76592f242f52f348748b0c1259bb3168e26"
// <auto-generated/>
#pragma warning disable 1591
namespace dnp_assignment_4.Pages.Chilldren
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
#line 2 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Chilldren\ChildAdd.razor"
using dnp_assignment_4.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Chilldren\ChildAdd.razor"
using dnp_assignment_4.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/family/{familyId}/children/add")]
    public partial class ChildAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ChildAdd</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Chilldren\ChildAdd.razor"
                 myChild

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    \r\n    First name ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(5);
                __builder2.AddAttribute(6, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Chilldren\ChildAdd.razor"
                                       myChild.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => myChild.FirstName = __value, myChild.FirstName))));
                __builder2.AddAttribute(8, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => myChild.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    \r\n    <br><br>\r\n    Last name ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Chilldren\ChildAdd.razor"
                                      myChild.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => myChild.LastName = __value, myChild.LastName))));
                __builder2.AddAttribute(13, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => myChild.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n    \r\n    <br><br>\r\n    Hair color ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Chilldren\ChildAdd.razor"
                                       myChild.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => myChild.HairColor = __value, myChild.HairColor))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => myChild.HairColor));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n    \r\n    <br><br>\r\n    Eye color");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Chilldren\ChildAdd.razor"
                                     myChild.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => myChild.EyeColor = __value, myChild.EyeColor))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => myChild.EyeColor));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n    \r\n    <br><br>\r\n    Gender\r\n    ");
                __Blazor.dnp_assignment_4.Pages.Chilldren.ChildAdd.TypeInference.CreateInputSelect_0(__builder2, 25, 26, 
#nullable restore
#line 25 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Chilldren\ChildAdd.razor"
                              myChild.Sex

#line default
#line hidden
#nullable disable
                , 27, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => myChild.Sex = __value, myChild.Sex)), 28, () => myChild.Sex, 29, (__builder3) => {
                    __builder3.AddMarkupContent(30, "\r\n        ");
                    __builder3.AddMarkupContent(31, "<option value=\"male\">male</option>\r\n        ");
                    __builder3.AddMarkupContent(32, "<option value=\"female\">female</option>\r\n    ");
                }
                );
                __builder2.AddMarkupContent(33, "\r\n    \r\n    <br><br>\r\n    Age ");
                __Blazor.dnp_assignment_4.Pages.Chilldren.ChildAdd.TypeInference.CreateInputNumber_1(__builder2, 34, 35, 
#nullable restore
#line 31 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Chilldren\ChildAdd.razor"
                                  myChild.Age

#line default
#line hidden
#nullable disable
                , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => myChild.Age = __value, myChild.Age)), 37, () => myChild.Age);
                __builder2.AddMarkupContent(38, "\r\n    \r\n    <br><br>\r\n    Height ");
                __Blazor.dnp_assignment_4.Pages.Chilldren.ChildAdd.TypeInference.CreateInputNumber_2(__builder2, 39, 40, 
#nullable restore
#line 34 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Chilldren\ChildAdd.razor"
                                     myChild.Height

#line default
#line hidden
#nullable disable
                , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => myChild.Height = __value, myChild.Height)), 42, () => myChild.Height);
                __builder2.AddMarkupContent(43, "\r\n    \r\n    <br><br>\r\n    Weight ");
                __Blazor.dnp_assignment_4.Pages.Chilldren.ChildAdd.TypeInference.CreateInputNumber_3(__builder2, 44, 45, 
#nullable restore
#line 37 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Chilldren\ChildAdd.razor"
                                     myChild.Weight

#line default
#line hidden
#nullable disable
                , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => myChild.Weight = __value, myChild.Weight)), 47, () => myChild.Weight);
                __builder2.AddMarkupContent(48, "\r\n    \r\n   ");
                __builder2.OpenElement(49, "button");
                __builder2.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Chilldren\ChildAdd.razor"
                     AddChild

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(51, "Add");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\themr\RiderProjects\DNP_assignment4\dnp_assignment_4\Pages\Chilldren\ChildAdd.razor"
       
    [Parameter]
    public string familyId { get; set; }
    
    Child myChild = new Child();

    protected override async Task OnInitializedAsync()
    {
        myChild.FamilyId = Int32.Parse(familyId);
    }

    public async Task AddChild()
    {
        await ChildService.CreateChild(myChild);
        Console.WriteLine(myChild.ChildId + " " + myChild.FamilyId + " " + myChild.Age + " " + myChild.Height + " " + myChild.Sex + " " + myChild.Weight + " " + myChild.EyeColor + " " + myChild.FirstName + " " + myChild.HairColor + " " + myChild.LastName);
        NavigationManager.NavigateTo($"family/{familyId}/edit");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IChildService ChildService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyServiceImpl { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.dnp_assignment_4.Pages.Chilldren.ChildAdd
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
