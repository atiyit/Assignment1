#pragma checksum "E:\project\Assignment\Pages\ManagerPerson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "963c273fca1c0eb5ea1eaf3def080f247d1cf754"
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
#line 2 "E:\project\Assignment\Pages\ManagerPerson.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\project\Assignment\Pages\ManagerPerson.razor"
using Assignment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\project\Assignment\Pages\ManagerPerson.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\project\Assignment\Pages\ManagerPerson.razor"
using System.Data.Common;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ManagerPerson")]
    public partial class ManagerPerson : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ManagerPerson</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.AddMarkupContent(4, "<p>You don\'t have permission to access!</p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Policy", "Guest");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<p>You don\'t have permission to access!</p>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(12);
            __builder.AddAttribute(13, "Policy", "Manager");
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n    \r\n    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.AddMarkupContent(19, "<label>Firstname：</label>\r\n        ");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "type", "text");
                __builder2.AddAttribute(22, "placeholder", "firstname");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                                firstname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstname = __value, firstname));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n    \r\n    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.AddMarkupContent(30, "<label>Lastname：</label>\r\n        ");
                __builder2.OpenElement(31, "input");
                __builder2.AddAttribute(32, "type", "text");
                __builder2.AddAttribute(33, "placeholder", "lastname");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                               lastname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastname = __value, lastname));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.AddMarkupContent(41, "<label>Age:</label>\r\n        ");
                __builder2.OpenElement(42, "input");
                __builder2.AddAttribute(43, "type", "text");
                __builder2.AddAttribute(44, "placeholder", "age");
                __builder2.AddAttribute(45, "oninput", "value=value.replace(/[^\\d]/g,\'\')");
                __builder2.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                                                                     age

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => age = __value, age));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n    \r\n    ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group");
                __builder2.AddMarkupContent(52, "\r\n                ");
                __builder2.AddMarkupContent(53, "<label>Sex:</label>\r\n                ");
                __builder2.OpenElement(54, "input");
                __builder2.AddAttribute(55, "type", "text");
                __builder2.AddAttribute(56, "placeholder", "sex");
                __builder2.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                                  sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sex = __value, sex));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n        \r\n        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group");
                __builder2.AddMarkupContent(63, "\r\n                     ");
                __builder2.AddMarkupContent(64, "<label>Haircolor:</label>\r\n                     ");
                __builder2.OpenElement(65, "input");
                __builder2.AddAttribute(66, "type", "text");
                __builder2.AddAttribute(67, "placeholder", "haircolor");
                __builder2.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                                             hairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => hairColor = __value, hairColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                 ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n        \r\n        \r\n         ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group");
                __builder2.AddMarkupContent(74, "\r\n                         ");
                __builder2.AddMarkupContent(75, "<label>Eyecolor:</label>\r\n                         ");
                __builder2.OpenElement(76, "input");
                __builder2.AddAttribute(77, "type", "text");
                __builder2.AddAttribute(78, "placeholder", "eyecolor");
                __builder2.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                                                eyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => eyeColor = __value, eyeColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                     ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n    \r\n    ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "form-group");
                __builder2.AddMarkupContent(85, "\r\n        ");
                __builder2.AddMarkupContent(86, "<label>Height:</label>\r\n        ");
                __builder2.OpenElement(87, "input");
                __builder2.AddAttribute(88, "type", "text");
                __builder2.AddAttribute(89, "placeholder", "height");
                __builder2.AddAttribute(90, "oninput", "value=value.replace(/[^\\d]/g,\'\')");
                __builder2.AddAttribute(91, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                                                                        height

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => height = __value, height));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n    ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "form-group");
                __builder2.AddMarkupContent(97, "\r\n        ");
                __builder2.AddMarkupContent(98, "<label>Weight:</label>\r\n        ");
                __builder2.OpenElement(99, "input");
                __builder2.AddAttribute(100, "type", "text");
                __builder2.AddAttribute(101, "placeholder", "weight");
                __builder2.AddAttribute(102, "oninput", "value=value.replace(/[^\\d.]/g,\'\')");
                __builder2.AddAttribute(103, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                                                                         weight

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(104, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => weight = __value, weight));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n    \r\n    ");
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "form-group");
                __builder2.AddMarkupContent(109, "\r\n        ");
                __builder2.AddMarkupContent(110, "<label>Job:</label>\r\n        ");
                __builder2.OpenElement(111, "input");
                __builder2.AddAttribute(112, "type", "text");
                __builder2.AddAttribute(113, "placeholder", "job");
                __builder2.AddAttribute(114, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                          job

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(115, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => job = __value, job));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n    \r\n    ");
                __builder2.OpenElement(118, "button");
                __builder2.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "E:\project\Assignment\Pages\ManagerPerson.razor"
                      addPerson

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(120, "\r\n        add\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n    ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "style", "color:red");
                __builder2.AddContent(124, 
#nullable restore
#line 67 "E:\project\Assignment\Pages\ManagerPerson.razor"
                            message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(126, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(127);
            __builder.AddAttribute(128, "Policy", "Admin");
            __builder.AddAttribute(129, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(130, "\r\n    \r\n    ");
                __builder2.OpenElement(131, "div");
                __builder2.AddAttribute(132, "class", "form-group");
                __builder2.AddMarkupContent(133, "\r\n        ");
                __builder2.AddMarkupContent(134, "<label>Firstname：</label>\r\n        ");
                __builder2.OpenElement(135, "input");
                __builder2.AddAttribute(136, "type", "text");
                __builder2.AddAttribute(137, "placeholder", "firstname");
                __builder2.AddAttribute(138, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                                firstname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(139, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstname = __value, firstname));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n    \r\n    ");
                __builder2.OpenElement(142, "div");
                __builder2.AddAttribute(143, "class", "form-group");
                __builder2.AddMarkupContent(144, "\r\n                    ");
                __builder2.AddMarkupContent(145, "<label>Lastname：</label>\r\n                    ");
                __builder2.OpenElement(146, "input");
                __builder2.AddAttribute(147, "type", "text");
                __builder2.AddAttribute(148, "placeholder", "lastname");
                __builder2.AddAttribute(149, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                                           lastname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(150, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastname = __value, lastname));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(151, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n    ");
                __builder2.OpenElement(153, "div");
                __builder2.AddAttribute(154, "class", "form-group");
                __builder2.AddMarkupContent(155, "\r\n        ");
                __builder2.AddMarkupContent(156, "<label>Age:</label>\r\n        ");
                __builder2.OpenElement(157, "input");
                __builder2.AddAttribute(158, "type", "text");
                __builder2.AddAttribute(159, "placeholder", "age");
                __builder2.AddAttribute(160, "oninput", "value=value.replace(/[^\\d]/g,\'\')");
                __builder2.AddAttribute(161, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                                                                     age

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(162, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => age = __value, age));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(163, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(164, "\r\n    \r\n    ");
                __builder2.OpenElement(165, "div");
                __builder2.AddAttribute(166, "class", "form-group");
                __builder2.AddMarkupContent(167, "\r\n            ");
                __builder2.AddMarkupContent(168, "<label>Sex:</label>\r\n            ");
                __builder2.OpenElement(169, "input");
                __builder2.AddAttribute(170, "type", "text");
                __builder2.AddAttribute(171, "placeholder", "sex");
                __builder2.AddAttribute(172, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 88 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                              sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(173, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sex = __value, sex));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(174, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(175, "\r\n    \r\n    ");
                __builder2.OpenElement(176, "div");
                __builder2.AddAttribute(177, "class", "form-group");
                __builder2.AddMarkupContent(178, "\r\n                 ");
                __builder2.AddMarkupContent(179, "<label>Haircolor:</label>\r\n                 ");
                __builder2.OpenElement(180, "input");
                __builder2.AddAttribute(181, "type", "text");
                __builder2.AddAttribute(182, "placeholder", "haircolor");
                __builder2.AddAttribute(183, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 93 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                                         hairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(184, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => hairColor = __value, hairColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(185, "\r\n             ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(186, "\r\n    \r\n    \r\n     ");
                __builder2.OpenElement(187, "div");
                __builder2.AddAttribute(188, "class", "form-group");
                __builder2.AddMarkupContent(189, "\r\n                     ");
                __builder2.AddMarkupContent(190, "<label>Eyecolor:</label>\r\n                     ");
                __builder2.OpenElement(191, "input");
                __builder2.AddAttribute(192, "type", "text");
                __builder2.AddAttribute(193, "placeholder", "eyecolor");
                __builder2.AddAttribute(194, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 99 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                                            eyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(195, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => eyeColor = __value, eyeColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(196, "\r\n                 ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(197, "\r\n    \r\n    ");
                __builder2.OpenElement(198, "div");
                __builder2.AddAttribute(199, "class", "form-group");
                __builder2.AddMarkupContent(200, "\r\n        ");
                __builder2.AddMarkupContent(201, "<label>Height:</label>\r\n        ");
                __builder2.OpenElement(202, "input");
                __builder2.AddAttribute(203, "type", "text");
                __builder2.AddAttribute(204, "placeholder", "height");
                __builder2.AddAttribute(205, "oninput", "value=value.replace(/[^\\d]/g,\'\')");
                __builder2.AddAttribute(206, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 104 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                                                                        height

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(207, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => height = __value, height));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(208, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(209, "\r\n    ");
                __builder2.OpenElement(210, "div");
                __builder2.AddAttribute(211, "class", "form-group");
                __builder2.AddMarkupContent(212, "\r\n        ");
                __builder2.AddMarkupContent(213, "<label>Weight:</label>\r\n        ");
                __builder2.OpenElement(214, "input");
                __builder2.AddAttribute(215, "type", "text");
                __builder2.AddAttribute(216, "placeholder", "weight");
                __builder2.AddAttribute(217, "oninput", "value=value.replace(/[^\\d.]/g,\'\')");
                __builder2.AddAttribute(218, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 108 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                                                                         weight

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(219, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => weight = __value, weight));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(220, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(221, "\r\n    \r\n    ");
                __builder2.OpenElement(222, "div");
                __builder2.AddAttribute(223, "class", "form-group");
                __builder2.AddMarkupContent(224, "\r\n        ");
                __builder2.AddMarkupContent(225, "<label>Job:</label>\r\n        ");
                __builder2.OpenElement(226, "input");
                __builder2.AddAttribute(227, "type", "text");
                __builder2.AddAttribute(228, "placeholder", "job");
                __builder2.AddAttribute(229, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 113 "E:\project\Assignment\Pages\ManagerPerson.razor"
                                                          job

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(230, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => job = __value, job));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(231, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(232, "\r\n    \r\n    ");
                __builder2.OpenElement(233, "button");
                __builder2.AddAttribute(234, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 116 "E:\project\Assignment\Pages\ManagerPerson.razor"
                      addPerson

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(235, "\r\n        add\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(236, "\r\n     ");
                __builder2.OpenElement(237, "div");
                __builder2.AddAttribute(238, "style", "color:red");
                __builder2.AddContent(239, 
#nullable restore
#line 119 "E:\project\Assignment\Pages\ManagerPerson.razor"
                             message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(240, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "E:\project\Assignment\Pages\ManagerPerson.razor"
       
    private string firstname;
    private string lastname;
    private string sex;
    private int age;
    private string hairColor;
    private string eyeColor;
    private int height;
    private float weight;
    private string message;
    private string job;
    public async Task addPerson() {
        message = "";
        try
        {
            Person person = new Person();
            Adult adult = new Adult();
            FileContext fileContext = new FileContext();
            IList<Adult> adults = fileContext.Adults;
            person.Id = adults.Count + 1;
            person.FirstName = firstname;
            person.LastName = lastname;
            person.Sex = sex;
            person.Age = age;
            person.EyeColor = eyeColor;
            person.HairColor = hairColor;
            person.Height = height;
            person.Weight = weight;
            adult.JobTitle = job;
            adult.Update(person);
            adults.Add(adult);
            fileContext.SaveChanges();
            message = "Add succeed!";
            MessageModel.getInstance().messageManage = message;
        } catch (Exception e) {
            MessageModel.getInstance().messageManage = e.Message;
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
