// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
<<<<<<< HEAD
#line 10 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\_Imports.razor"
=======
#line 10 "C:\Users\agnie\OneDrive\Pulpit\projektraim-main\PROJEKT\_Imports.razor"
>>>>>>> 389e3153588c1c8329ee1c3a9b0871de3afc2804
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\Pages\Index.razor"
=======
#line 3 "C:\Users\agnie\OneDrive\Pulpit\projektraim-main\PROJEKT\Pages\Index.razor"
>>>>>>> 389e3153588c1c8329ee1c3a9b0871de3afc2804
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
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 65 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\Pages\Index.razor"
=======
#line 183 "C:\Users\agnie\OneDrive\Pulpit\projektraim-main\PROJEKT\Pages\Index.razor"
>>>>>>> 389e3153588c1c8329ee1c3a9b0871de3afc2804
       
    protected string AnswerHistory;
    protected string AnswerOpinion;

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
#pragma warning restore 1591
