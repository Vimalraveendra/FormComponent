#pragma checksum "/Users/vimalraveendran/Projects/FormComponent/FormComponent/Pages/Main.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ad537cb6db7dfab4535c1b95219c0383bd50eee"
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
            __builder.OpenElement(0, "form");
            __builder.AddAttribute(1, "class", "credentials");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "fieldset");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.AddMarkupContent(5, "<legend>Account Details:</legend>\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "first");
            __builder.AddMarkupContent(8, "\n            ");
            __builder.AddMarkupContent(9, "<div class=\"image\">\n                <img src alt>\n            </div>\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "mixed");
            __builder.AddMarkupContent(12, "\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "last");
            __builder.AddMarkupContent(15, "\n                    ");
            __builder.AddMarkupContent(16, "<label for=\"fname\">Nazwisko:</label><br>\n                    ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "text");
            __builder.AddAttribute(19, "id", "fname");
            __builder.AddAttribute(20, "name", "fname");
            __builder.AddAttribute(21, "value", 
#nullable restore
#line 15 "/Users/vimalraveendran/Projects/FormComponent/FormComponent/Pages/Main.razor"
                                                                       Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "class", "nazwisko");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "<br>\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "last");
            __builder.AddMarkupContent(27, "\n                    ");
            __builder.AddMarkupContent(28, "<label for=\"fname\">Nazwisko:</label><br>\n                    ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "type", "text");
            __builder.AddAttribute(31, "id", "fname");
            __builder.AddAttribute(32, "name", "fname");
            __builder.AddAttribute(33, "value", 
#nullable restore
#line 19 "/Users/vimalraveendran/Projects/FormComponent/FormComponent/Pages/Main.razor"
                                                                       Value1

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "class", "nazwisko1");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "<br>\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n                ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "last");
            __builder.AddMarkupContent(39, "\n                    ");
            __builder.AddMarkupContent(40, "<label for=\"fname\">Nazwisko:</label><br>\n                    ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "text");
            __builder.AddAttribute(43, "id", "fname");
            __builder.AddAttribute(44, "name", "fname");
            __builder.AddAttribute(45, "value", 
#nullable restore
#line 23 "/Users/vimalraveendran/Projects/FormComponent/FormComponent/Pages/Main.razor"
                                                                       Value2

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(46, "class", "nazwisko2");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "<br>\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n                ");
            __builder.AddMarkupContent(49, "<div class=\"last\">\n                    <label for=\"fname\">Nazwisko:</label><br>\n                    <input type=\"text\" id=\"fname\" name=\"fname\" value=\"John\"><br>\n                </div>\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n    ");
            __builder.AddMarkupContent(53, @"<fieldset>
        <legend>Account Details:</legend>
        <div class=""first"">
            <label for=""fname"">Nazwisko:</label><br>
            <input type=""text"" id=""fname"" name=""fname"" value=""John""><br>
        </div>
        <div class=""second"">

            <div class=""name"">
                <label for=""lname"">Imię1:</label><br>
                <input type=""text"" id=""lname"" name=""lname"" value=""Doe"">
            </div>

            <div class=""name"">
                <label class=""lname2"" for=""lname"">Imię2:</label><br>
                <input type=""text"" id=""lname    "" name=""lname"" value=""Doe"">
            </div>

        </div>
        <div class=""first"">
            <label for=""ulica"">Nazwisko Rodzica:</label><br>
            <input type=""text"" id=""fname"" name=""nazwisko"" value=""Select""><br>
        </div>
        <div class=""first"">
            <label for=""ulica"">Ulica:</label><br>
            <input type=""text"" id=""fname"" name=""ulica"" value=""Select""><br>
        </div>
        <div class=""first"">
            <label for=""ulica"">Miasto:</label><br>
            <input type=""text"" id=""fname"" name=""miasto"" value=""Select""><br>
        </div>
        <div class=""rodzina""></div>
        <button class=""show"">ShowPatientList</button>

    </fieldset>





");
            __builder.CloseElement();
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

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            Value = await JS.InvokeAsync<string>("setText");
            StateHasChanged();

        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
