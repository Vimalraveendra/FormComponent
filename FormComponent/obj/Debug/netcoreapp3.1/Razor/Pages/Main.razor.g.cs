#pragma checksum "/Users/vimalraveendran/Projects/FormComponent/FormComponent/Pages/Main.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73136afa3176cd8b4b5df44ed52eeb4831ece552"
// <auto-generated/>
#pragma warning disable 1591
namespace FormComponent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/vimalraveendran/Projects/FormComponent/FormComponent/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/vimalraveendran/Projects/FormComponent/FormComponent/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/vimalraveendran/Projects/FormComponent/FormComponent/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/vimalraveendran/Projects/FormComponent/FormComponent/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/vimalraveendran/Projects/FormComponent/FormComponent/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/vimalraveendran/Projects/FormComponent/FormComponent/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/vimalraveendran/Projects/FormComponent/FormComponent/_Imports.razor"
using FormComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/vimalraveendran/Projects/FormComponent/FormComponent/_Imports.razor"
using FormComponent.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/vimalraveendran/Projects/FormComponent/FormComponent/Pages/Main.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class Main : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<form class=\"credentials\">\n    <fieldset>\n        <legend>Account Details:</legend>\n        <div class=\"first\">\n            <div class=\"image\">\n                <img src alt>\n            </div>\n            <div class=\"mixed\">\n                <div class=\"last\">\n                    <label for=\"fname\">Nazwisko:</label><br>\n                    <input type=\"text\" id=\"fname\" name=\"fname\" value class=\"nazwisko\"><br>\n                </div>\n                <div class=\"last\">\n                    <label for=\"fname\">Nazwisko:</label><br>\n                    <input type=\"text\" id=\"fname\" name=\"fname\" value class=\"nazwisko1\"><br>\n                </div>\n                <div class=\"last\">\n                    <label for=\"fname\">Nazwisko:</label><br>\n                    <input type=\"text\" id=\"fname\" name=\"fname\" value class=\"nazwisko2\"><br>\n                </div>\n                <div class=\"last\">\n                    <label for=\"fname\">Nazwisko:</label><br>\n                    <input type=\"text\" id=\"fname\" name=\"fname\" value=\"John\"><br>\n                </div>\n            </div>\n\n        </div>\n\n    </fieldset>\n    <fieldset>\n        <legend>Account Details:</legend>\n        <div class=\"first\">\n            <label for=\"fname\">Nazwisko:</label><br>\n            <input type=\"text\" id=\"fname\" name=\"fname\" value=\"John\"><br>\n        </div>\n        <div class=\"second\">\n\n            <div class=\"name\">\n                <label for=\"lname\">Imię1:</label><br>\n                <input type=\"text\" id=\"lname\" name=\"lname\" value=\"Doe\">\n            </div>\n\n            <div class=\"name\">\n                <label class=\"lname2\" for=\"lname\">Imię2:</label><br>\n                <input type=\"text\" id=\"lname    \" name=\"lname\" value=\"Doe\">\n            </div>\n\n        </div>\n        <div class=\"first\">\n            <label for=\"ulica\">Nazwisko Rodzica:</label><br>\n            <input type=\"text\" id=\"fname\" name=\"nazwisko\" value=\"Select\"><br>\n        </div>\n        <div class=\"first\">\n            <label for=\"ulica\">Ulica:</label><br>\n            <input type=\"text\" id=\"fname\" name=\"ulica\" value=\"Select\"><br>\n        </div>\n        <div class=\"first\">\n            <label for=\"ulica\">Miasto:</label><br>\n            <input type=\"text\" id=\"fname\" name=\"miasto\" value=\"Select\"><br>\n        </div>\n        <div class=\"rodzina\"></div>\n        <button class=\"show\">ShowPatientList</button>\n\n    </fieldset>\n\n\n\n\n\n</form>");
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "/Users/vimalraveendran/Projects/FormComponent/FormComponent/Pages/Main.razor"
                   
    public string Value { get; set; }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "/Users/vimalraveendran/Projects/FormComponent/FormComponent/Pages/Main.razor"
                   
    public string Value1 { get; set; }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "/Users/vimalraveendran/Projects/FormComponent/FormComponent/Pages/Main.razor"
                   
    public string Value2 { get; set; }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
