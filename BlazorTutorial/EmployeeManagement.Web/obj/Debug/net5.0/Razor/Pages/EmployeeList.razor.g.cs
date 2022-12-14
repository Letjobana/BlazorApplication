#pragma checksum "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "262f4703116a61000cdb524f6773ccdb33d329b4"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class EmployeeList : EmployeeListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Employee List</h3>");
#nullable restore
#line 6 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"spinner\"></div>");
#nullable restore
#line 9 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-deck");
#nullable restore
#line 13 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
         foreach (var employee in Employees)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card m-3");
            __builder.AddAttribute(6, "style", "min-width: 18rem; max-width:30.5%;");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-header");
            __builder.OpenElement(9, "h3");
            __builder.AddContent(10, 
#nullable restore
#line 17 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                         employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " ");
            __builder.AddContent(12, 
#nullable restore
#line 17 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                             employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 19 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                                               employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card-footer text-center");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", 
#nullable restore
#line 21 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                               $"employeedetails/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "class", "btn btn-primary m-1");
            __builder.AddContent(23, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n                    ");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 23 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                               $"editemployee/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "class", "btn btn-primary m-1");
            __builder.AddContent(28, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n                    ");
            __builder.AddMarkupContent(30, "<a href=\"#\" class=\"btn btn-danger m-1\">Delete</a>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\Developer 2\Documents\Document\Blazor Project\Blazor Tutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
