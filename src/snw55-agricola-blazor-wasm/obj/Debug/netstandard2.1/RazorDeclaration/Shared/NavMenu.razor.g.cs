#pragma checksum "d:\projects\snw55-agricola-blazor\src\snw55-agricola-blazor-wasm\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "114141d68b913afec7affc1816c4fe93293b1922"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace snw55_agricola_blazor_wasm.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "d:\projects\snw55-agricola-blazor\src\snw55-agricola-blazor-wasm\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\projects\snw55-agricola-blazor\src\snw55-agricola-blazor-wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\projects\snw55-agricola-blazor\src\snw55-agricola-blazor-wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\projects\snw55-agricola-blazor\src\snw55-agricola-blazor-wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\projects\snw55-agricola-blazor\src\snw55-agricola-blazor-wasm\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\projects\snw55-agricola-blazor\src\snw55-agricola-blazor-wasm\_Imports.razor"
using snw55_agricola_blazor_wasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\projects\snw55-agricola-blazor\src\snw55-agricola-blazor-wasm\_Imports.razor"
using snw55_agricola_blazor_wasm.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "d:\projects\snw55-agricola-blazor\src\snw55-agricola-blazor-wasm\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591