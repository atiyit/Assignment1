#pragma checksum "E:\project\Assignment\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "979e432cdfc304ca1d8babf549c9e74f1157eb6d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
