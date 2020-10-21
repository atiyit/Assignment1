#pragma checksum "E:\project\Assignment\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "979e432cdfc304ca1d8babf549c9e74f1157eb6d"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\project\Assignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\project\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\project\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\project\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\project\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\project\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\project\Assignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\project\Assignment\_Imports.razor"
using Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\project\Assignment\_Imports.razor"
using Assignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\project\Assignment\Pages\Search.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\project\Assignment\Pages\Search.razor"
using global::Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>View and search person</h3>\n\n");
            __builder.AddMarkupContent(1, "<div> Min age </div> ");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "oninput", "value=value.replace(/[^\\d]/g,\'\')");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "E:\project\Assignment\Pages\Search.razor"
                                                                                                minAge

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => minAge = __value, minAge));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n");
            __builder.AddMarkupContent(8, "<div> Max age </div> ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "oninput", "value=value.replace(/[^\\d]/g,\'\')");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "E:\project\Assignment\Pages\Search.razor"
                                                                                                maxAge

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => maxAge = __value, maxAge));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n");
            __builder.AddMarkupContent(15, "<div> LastName </div> ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "E:\project\Assignment\Pages\Search.razor"
                                                      lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastName = __value, lastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n");
            __builder.AddMarkupContent(21, "<div> FirstName </div> ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "text");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "E:\project\Assignment\Pages\Search.razor"
                                                       firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
            __builder.AddMarkupContent(27, "<div> Sex </div> ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "text");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "E:\project\Assignment\Pages\Search.razor"
                                                 sex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sex = __value, sex));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n");
            __builder.OpenElement(33, "div");
            __builder.AddMarkupContent(34, "\n    ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "E:\project\Assignment\Pages\Search.razor"
                      search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, " search ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n    ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "E:\project\Assignment\Pages\Search.razor"
                      next

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, " next ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n    ");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "E:\project\Assignment\Pages\Search.razor"
                      clear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, " clear ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n");
            __builder.OpenElement(48, "div");
            __builder.OpenElement(49, "label");
            __builder.AddContent(50, " ");
            __builder.AddContent(51, 
#nullable restore
#line 17 "E:\project\Assignment\Pages\Search.razor"
              output

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n\n\n}");
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "E:\project\Assignment\Pages\Search.razor"
       
    private int minAge;
    private int maxAge;
    private string lastName;
    private string firstName;
    private string sex;
    List<Adult> result = new List<Adult>();
    private string output;
    private int count;


    public async Task search()
    {
        FileContext fileContext = new FileContext();
        IList<Adult> adults = fileContext.Adults;
        
        for (int i = 0; i < adults.Count; i++)
        {
            if (lastName ==null && firstName ==null)
            {
                if (adults[i].Age >= minAge && adults[i].Age <= maxAge && adults[i].Sex == sex)
                {
                    Adult adult = adults[i];
                    result.Add(adult);
                }
            }
            else if (lastName == null)
            {
                if (adults[i].Age >= minAge && adults[i].Age <= maxAge && adults[i].Sex == sex && adults[i].FirstName==firstName)
                {
                    Adult adult = adults[i];
                    result.Add(adult);
                }
            }
            else if (firstName == null)
            {
                if (adults[i].Age >= minAge && adults[i].Age <= maxAge && adults[i].Sex == sex && adults[i].LastName==lastName)
                {
                    Adult adult = adults[i];
                    result.Add(adult);
                }
            }
            else
            {
                if (adults[i].Age >= minAge && adults[i].Age <= maxAge && adults[i].Sex == sex && adults[i].FirstName==firstName && adults[i].LastName==lastName)
                {
                    Adult adult = adults[i];
                    result.Add(adult);
                }
            }
            
        }
        
        if (result.Count == 0)
        {
            output = "No match!";
        }

        else
        {
            count = 0;
            output = "ID:" + result[count].Id + "Firstname:" + result[count].FirstName + " Lastname:" + result[count].LastName + " Sex:" + result[count].Sex + " Job:" + result[count].JobTitle + " Height:" + result[count].Height + " Weight:" + result[count].Weight + " Age:" + result[count].Age + " HairColor:" + result[count].HairColor + " EyeColor:" + result[count].EyeColor;
            count = 1;
        }
    }

    public async Task next()
    {
        if (result.Count == 0) 
        {
            output = "No match!";
        }
        else if (count <  result.Count)
        {
            output = "ID:" + result[count].Id + "Firstname:" + result[count].FirstName + " Lastname:" + result[count].LastName + " Sex:" + result[count].Sex + " Job:" + result[count].JobTitle + " Height:" + result[count].Height + " Weight:" + result[count].Weight + " Age:" + result[count].Age + " HairColor:" + result[count].HairColor + " EyeColor:" + result[count].EyeColor;
            count = count + 1;
        }
        else
        {
            count = 0;
            output = "ID:" + result[count].Id + "Firstname:" + result[count].FirstName + " Lastname:" + result[count].LastName + " Sex:" + result[count].Sex + " Job:" + result[count].JobTitle + " Height:" + result[count].Height + " Weight:" + result[count].Weight + " Age:" + result[count].Age + " HairColor:" + result[count].HairColor + " EyeColor:" + result[count].EyeColor;

            
        }
        
        
    }
    
    public async Task clear()
    {
        count = 0;
        result.Clear();
        output = "";
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591