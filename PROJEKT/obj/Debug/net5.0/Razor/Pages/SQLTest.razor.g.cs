#pragma checksum "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\Pages\SQLTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b06afd55dabfc6a3bc69172b26555685a00ab9"
// <auto-generated/>
#pragma warning disable 1591
namespace PROJEKT.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\_Imports.razor"
using PROJEKT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\_Imports.razor"
using PROJEKT.Share;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\_Imports.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\_Imports.razor"
using Blazorise.Icons.FontAwesome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\_Imports.razor"
using C5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\Pages\SQLTest.razor"
using Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\Pages\SQLTest.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sqltest")]
    public partial class SQLTest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>SQLTest</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn-success");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\Pages\SQLTest.razor"
                                       addToDB

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Dodaj info do bazy");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n\r\n");
            __builder.OpenComponent<Blazorise.Button>(6);
            __builder.AddAttribute(7, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 13 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\Pages\SQLTest.razor"
                   async () => await showResults()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "Pokaż wykres");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "container mt-5");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenComponent<Blazorise.Charts.BarChart<int>>(14);
            __builder.AddAttribute(15, "OptionsObject", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\Pages\SQLTest.razor"
                                                          barChartOptions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(16, (__value) => {
#nullable restore
#line 16 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\Pages\SQLTest.razor"
                    barChart = (Blazorise.Charts.BarChart<int>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(19, "p");
            __builder.AddContent(20, 
#nullable restore
#line 22 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\Pages\SQLTest.razor"
    message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\LudwigVanWanna\source\repos\PROJEKT\PROJEKT\Pages\SQLTest.razor"
       
    
    //przykladowe dane z ankiety
    User rUser = new User
    {
        Age = "27-35",
        Gender = "K",
        Student_eti = "false",
        Education = "wyzsze",
        Started_at = DateTime.Now,
        Result = new Result
        {
            Score = 13
        },
        KnowledgeSource = new KnowledgeSource
        {
            Source = "ksiazki"
        },
        Opinion = new Opinion
        {
            CompulsoryVaccination = "D",
            OptionalVaccination = "SA",
            CovidVaccination = "NS",
            CovidVacSafety = "A",
            DiseaseOrVaccine = "SD",
            InformationTrust = "D"
        },
        History = new History
        {
            Chickenpox = "tak",
            Flu = "tak",
            HPV = "nie"
        }

    };
    string message = "";
    bool show = false;

    //przy zatwierdzaniu ankiety wywolujesz taka funkcje

    private async Task addToDB()
    {

        try
        {
            rUser.Completed_at = DateTime.Now;
            message = "Sending the feedback";
            var response = await Http.PostAsJsonAsync("http://localhost:7071/api/SubmitSurvey", rUser);
            message = "Feedback stored in the destination";
        }
        catch (Exception ex)
        {
            message = "Failed to store your feedback";
        }
    }

    //pokazujemy wyniki
    //wystarczy skopiować wszystko poniżej i ustalic liczbe pytan w quizie w zmiennej maxScore

    BarChart<int> barChart;

    List<Data> Scores = new List<Data>();

    int maxScore = 16;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await showResults();
        }
    }

    async Task showResults()
    {
        show = true;
        try
        {
            message = "Getting test scores";
            Scores = await Http.GetFromJsonAsync<List<Data>>("http://localhost:7071/api/GetTestScores");
            message = "Scores displayed";
        }
        catch (Exception ex)
        {
            message = "Failed to store your feedback";
        }

        await barChart.Clear();
        await barChart.AddLabelsDatasetsAndUpdate(generateLabels(maxScore), GetBarChartDataset());
    }

    BarChartDataset<int> GetBarChartDataset()
    {
        return new BarChartDataset<int>
        {
            Label = "Wyniki",
            Data = getDistribution(Scores, maxScore),
            BackgroundColor = generateColors(maxScore, 0.6f),
            BorderColor = generateColors(maxScore, 1f),
            BorderWidth = 1,

        };
    }

    object barChartOptions = new
    {
        Title = new
        {
            Display = true,
            Text = "Wyniki testu"
        },

        Scales = new
        {
            YAxes = new object[]
            {
                new
                {
                    ScaleLabel = new
                    {
                        Display = true, LabelString = "Liczba ankietowanych"
                    }
                }
                    },
            XAxes = new object[]
            {
                new
                {
                    ScaleLabel = new
                    {
                        Display = true, LabelString = "Ilość punktów"
                    }
                }
                    }
        }
    };

    private List<int> getDistribution(List<Data> data, int range)
    {
        List<int> result = new List<int>();

        var hash = new HashBag<int>();
        hash.AddAll(data.Select(c => c.Y).ToList());
        var mults = hash.ItemMultiplicities();


        for (int i = 0; i <= range; i++)
        {
            result.Add(0);
        }

        foreach (C5.KeyValuePair<int, int> kvp in mults)
        {
            result[kvp.Key] = kvp.Value;
        }

        return result;
    }

    private string[] generateLabels(int colNumber)
    {
        string[] Labels = new string[colNumber + 1];

        for (int i = 0; i <= colNumber; i++)
        {
            Labels[i] = i.ToString();
        }
        return Labels;
    }

    private List<string> generateColors(int colNumber, float a)
    {
        List<string> result = new List<string>();

        for (int i = 0; i <= colNumber; i++)
        {

            result.Add(ChartColor.FromRgba(255, 111, 145, a));
        }

        return result;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
