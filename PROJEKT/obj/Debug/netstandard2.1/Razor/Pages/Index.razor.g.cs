#pragma checksum "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fa1894e0be92a3da031605b9d5c1f50fd66a17f"
// <auto-generated/>
#pragma warning disable 1591
namespace PROJEKT.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\_Imports.razor"
using PROJEKT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\_Imports.razor"
using PROJEKT.Share;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\Pages\Index.razor"
using Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\Pages\Index.razor"
                  rUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\Pages\Index.razor"
                                         HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "p");
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.AddMarkupContent(8, "<label for=\"age\">Wiek:</label>\r\n        ");
                __Blazor.PROJEKT.Pages.Index.TypeInference.CreateInputSelect_0(__builder2, 9, 10, "age", 11, 
#nullable restore
#line 12 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\Pages\Index.razor"
                                           rUser.Age

#line default
#line hidden
#nullable disable
                , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => rUser.Age = __value, rUser.Age)), 13, () => rUser.Age, 14, (__builder3) => {
                    __builder3.AddMarkupContent(15, "\r\n            ");
                    __builder3.AddMarkupContent(16, "<option value=\"15-21\">15-21</option>\r\n            ");
                    __builder3.AddMarkupContent(17, "<option value=\"22-39\">22-39</option>\r\n            ");
                    __builder3.AddMarkupContent(18, "<option value=\"40-65\">40-65</option>\r\n            ");
                    __builder3.AddMarkupContent(19, "<option value=\">65\">>65</option>\r\n        ");
                }
                );
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.OpenElement(22, "p");
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.AddMarkupContent(24, "<label for=\"gender\">\r\n            Płeć:\r\n        </label>\r\n        ");
                __Blazor.PROJEKT.Pages.Index.TypeInference.CreateInputSelect_1(__builder2, 25, 26, "gender", 27, 
#nullable restore
#line 23 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\Pages\Index.razor"
                                              rUser.Gender

#line default
#line hidden
#nullable disable
                , 28, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => rUser.Gender = __value, rUser.Gender)), 29, () => rUser.Gender, 30, (__builder3) => {
                    __builder3.AddMarkupContent(31, "\r\n            ");
                    __builder3.AddMarkupContent(32, "<option value=\"M\">Mężczyzną</option>\r\n            ");
                    __builder3.AddMarkupContent(33, "<option value=\"K\">Kobietą</option>\r\n            ");
                    __builder3.AddMarkupContent(34, "<option value=\"I\">Inne</option>\r\n        ");
                }
                );
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.OpenElement(37, "p");
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenElement(39, "label");
                __builder2.AddMarkupContent(40, "\r\n            Czy jesteś studentem eti?\r\n            ");
                __Blazor.PROJEKT.Pages.Index.TypeInference.CreateInputSelect_2(__builder2, 41, 42, 
#nullable restore
#line 32 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\Pages\Index.razor"
                                      rUser.Student_eti

#line default
#line hidden
#nullable disable
                , 43, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => rUser.Student_eti = __value, rUser.Student_eti)), 44, () => rUser.Student_eti, 45, (__builder3) => {
                    __builder3.AddMarkupContent(46, "\r\n                ");
                    __builder3.AddMarkupContent(47, "<option value=\"true\">Tak</option>\r\n                ");
                    __builder3.AddMarkupContent(48, "<option value=\"false\">Nie</option>\r\n            ");
                }
                );
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.OpenElement(52, "p");
                __builder2.AddMarkupContent(53, "\r\n        ");
                __builder2.OpenElement(54, "label");
                __builder2.AddMarkupContent(55, "\r\n            Wykształcenie:\r\n            ");
                __Blazor.PROJEKT.Pages.Index.TypeInference.CreateInputSelect_3(__builder2, 56, 57, 
#nullable restore
#line 41 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\Pages\Index.razor"
                                      rUser.Education

#line default
#line hidden
#nullable disable
                , 58, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => rUser.Education = __value, rUser.Education)), 59, () => rUser.Education, 60, (__builder3) => {
                    __builder3.AddMarkupContent(61, "\r\n                ");
                    __builder3.AddMarkupContent(62, "<option value=\"student\">Student</option>\r\n                ");
                    __builder3.AddMarkupContent(63, "<option value=\"srednie\">Średnie</option>\r\n                ");
                    __builder3.AddMarkupContent(64, "<option value=\"wyzsze\">Wyższe</option>\r\n            ");
                }
                );
                __builder2.AddMarkupContent(65, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n\r\n    ");
                __builder2.AddMarkupContent(68, "<button type=\"submit\">Wyślij do bazy danych</button>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n\r\n\r\n");
            __builder.OpenElement(70, "div");
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.OpenElement(72, "p");
            __builder.AddAttribute(73, "class", "alert-info");
            __builder.AddContent(74, 
#nullable restore
#line 54 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\Pages\Index.razor"
                           message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\LudwigVanWanna\source\repos\Projekt\PROJEKT\Pages\Index.razor"
       

    private User rUser = new User();
    string message = "";

    protected override void OnInitialized()
    {
        rUser.Started_at = DateTime.Now;
    }



    private async Task HandleValidSubmit()
    {
        try
        {
            rUser.Completed_at = DateTime.Now;
            message = "Sending the feedback";
            var response = await Http.PostAsJsonAsync("http://localhost:7071/api/AddUser", rUser);
            message = "Feedback stored in the destination";
        }
        catch (Exception ex)
        {
            message = "Failed to store your feedback";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.PROJEKT.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
