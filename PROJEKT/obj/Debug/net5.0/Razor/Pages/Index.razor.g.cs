#pragma checksum "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a950b81f7a96c03e3b6b8583f1b278eab9db36f"
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
#line 1 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\_Imports.razor"
using PROJEKT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\_Imports.razor"
using PROJEKT.Share;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\_Imports.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\_Imports.razor"
using C5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\Pages\Index.razor"
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
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\n\nWelcome to your new app.\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\Pages\Index.razor"
                  rUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\Pages\Index.razor"
                                         HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenElement(6, "p");
                __builder2.AddMarkupContent(7, "\n        ");
                __builder2.AddMarkupContent(8, "<label for=\"age\">Wiek:</label>\n        ");
                __Blazor.PROJEKT.Pages.Index.TypeInference.CreateInputSelect_0(__builder2, 9, 10, "age", 11, 
#nullable restore
#line 12 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\Pages\Index.razor"
                                           rUser.Age

#line default
#line hidden
#nullable disable
                , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => rUser.Age = __value, rUser.Age)), 13, () => rUser.Age, 14, (__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.AddMarkupContent(16, "<option value=\"< 18\"> &lt; 18 </option>\n            ");
                    __builder3.AddMarkupContent(17, "<option value=\"18-26\">18-26</option>\n            ");
                    __builder3.AddMarkupContent(18, "<option value=\"27-35\">27-35</option>\n            ");
                    __builder3.AddMarkupContent(19, "<option value=\"36-65\">36-65</option>\n            ");
                    __builder3.AddMarkupContent(20, "<option value=\">65\">&gt; 65</option>\n        ");
                }
                );
                __builder2.AddMarkupContent(21, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\n    ");
                __builder2.OpenElement(23, "p");
                __builder2.AddMarkupContent(24, "\n        ");
                __builder2.AddMarkupContent(25, "<label for=\"gender\"> Płeć:</label>\n        ");
                __Blazor.PROJEKT.Pages.Index.TypeInference.CreateInputSelect_1(__builder2, 26, 27, "gender", 28, 
#nullable restore
#line 22 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\Pages\Index.razor"
                                              rUser.Gender

#line default
#line hidden
#nullable disable
                , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => rUser.Gender = __value, rUser.Gender)), 30, () => rUser.Gender, 31, (__builder3) => {
                    __builder3.AddMarkupContent(32, "\n            ");
                    __builder3.AddMarkupContent(33, "<option value=\"M\">Mężczyzna</option>\n            ");
                    __builder3.AddMarkupContent(34, "<option value=\"K\">Kobieta</option>\n            ");
                    __builder3.AddMarkupContent(35, "<option value=\"I\">Nie chcę odpowiadać na to pytanie</option>\n        ");
                }
                );
                __builder2.AddMarkupContent(36, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\n    ");
                __builder2.OpenElement(38, "p");
                __builder2.AddMarkupContent(39, "\n        ");
                __builder2.OpenElement(40, "label");
                __builder2.AddMarkupContent(41, "\n            Czy jesteś studentem?\n            ");
                __Blazor.PROJEKT.Pages.Index.TypeInference.CreateInputSelect_2(__builder2, 42, 43, 
#nullable restore
#line 31 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\Pages\Index.razor"
                                      rUser.Student_eti

#line default
#line hidden
#nullable disable
                , 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => rUser.Student_eti = __value, rUser.Student_eti)), 45, () => rUser.Student_eti, 46, (__builder3) => {
                    __builder3.AddMarkupContent(47, "\n                ");
                    __builder3.AddMarkupContent(48, "<option value=\"NS\">Nie studiuję</option>\n                ");
                    __builder3.AddMarkupContent(49, "<option value=\"SETI\">Jestem studentem ETI na PG</option>\n                ");
                    __builder3.AddMarkupContent(50, "<option value=\"SPG\">Jestem studentem innego wydziału PG</option>\n                ");
                    __builder3.AddMarkupContent(51, "<option vale=\"SNPG\">Jestem studentem innej uczelni</option>\n            ");
                }
                );
                __builder2.AddMarkupContent(52, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n    ");
                __builder2.OpenElement(55, "p");
                __builder2.AddMarkupContent(56, "\n        ");
                __builder2.OpenElement(57, "label");
                __builder2.AddMarkupContent(58, "\n            Wykształcenie:\n            ");
                __Blazor.PROJEKT.Pages.Index.TypeInference.CreateInputSelect_3(__builder2, 59, 60, 
#nullable restore
#line 42 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\Pages\Index.razor"
                                      rUser.Education

#line default
#line hidden
#nullable disable
                , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => rUser.Education = __value, rUser.Education)), 62, () => rUser.Education, 63, (__builder3) => {
                    __builder3.AddMarkupContent(64, "\n                ");
                    __builder3.AddMarkupContent(65, "<option value=\"podstawowe\">Podstawowe</option>\n                ");
                    __builder3.AddMarkupContent(66, "<option value=\"zasadnicze\">Zasadnicze zawodowe</option>\n                ");
                    __builder3.AddMarkupContent(67, "<option value=\"srednie\">Średnie</option>\n                ");
                    __builder3.AddMarkupContent(68, "<option value=\"wyzsze\">Wyższe</option>\n            ");
                }
                );
                __builder2.AddMarkupContent(69, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\n\n    ");
                __builder2.AddMarkupContent(72, "<p>\n        <label>\n            Pytania o historię szczepień:\n        </label>\n    </p>\n\n    ");
                __builder2.AddMarkupContent(73, "<button type=\"submit\">Wyślij do bazy danych</button>\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\n\n\n");
            __builder.OpenElement(75, "div");
            __builder.AddMarkupContent(76, "\n    ");
            __builder.OpenElement(77, "p");
            __builder.AddAttribute(78, "class", "alert-info");
            __builder.AddContent(79, 
#nullable restore
#line 62 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\Pages\Index.razor"
                           message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\Pages\Index.razor"
       

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
            var response = await Http.PostAsJsonAsync("/api/AddUser", rUser);
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
