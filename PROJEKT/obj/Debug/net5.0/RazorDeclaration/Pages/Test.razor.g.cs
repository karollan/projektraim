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
#line 3 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\Pages\Test.razor"
using Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/test")]
    public partial class Test : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\LudwigVanWanna\source\repos\PROJEKT - kopia\PROJEKT\Pages\Test.razor"
        User rUser = new User();

            private ElementReference container;

            private async Task prev()
            {
                await js.InvokeVoidAsync("nextPrev", -1, container);
            }

            private async Task next()
            {
                await js.InvokeVoidAsync("nextPrev", 1, container);
            }

            protected async override Task OnAfterRenderAsync(bool firstRender)
            {
                if (firstRender)
                {
                    await js.InvokeVoidAsync("initializeComponent", container);
                }
            }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
