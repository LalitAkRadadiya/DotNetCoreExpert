#pragma checksum "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d802a1cb748817c9b4797f39f8def175c0e0034"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDoList_Index), @"mvc.1.0.view", @"/Views/ToDoList/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\DotNetCoreExpert\DNC.MVC\Views\_ViewImports.cshtml"
using DNC.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DotNetCoreExpert\DNC.MVC\Views\_ViewImports.cshtml"
using DNC.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d802a1cb748817c9b4797f39f8def175c0e0034", @"/Views/ToDoList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f156253073edc02029067af9f26668df5c7262f", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDoList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DNC.Model.ToDoListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
 if (@hostingEnv.EnvironmentName == @conf.Value.dev)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>White</h1>\r\n");
#nullable restore
#line 11 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Blue</h1>\r\n");
#nullable restore
#line 15 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Index</h1>\r\n\r\n<p>\r\n");
#nullable restore
#line 19 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
     if (hostingEnv.EnvironmentName == conf.Value.dev)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
         if (Model.Count() < 3)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d802a1cb748817c9b4797f39f8def175c0e00344582", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 24 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>In Dev Environment you can\'t create more then 3 ToDo list</p>\r\n");
#nullable restore
#line 29 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
         


    }
    else if (hostingEnv.EnvironmentName == conf.Value.prod)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
         if (Model.Count() < 5)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d802a1cb748817c9b4797f39f8def175c0e00346635", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 39 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"

        }
        else
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>In Prod Environment you can\'t create more then % ToDo list</p>\r\n");
#nullable restore
#line 45 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <a> Total Number : ");
#nullable restore
#line 48 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
                  Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th> \r\n                ");
#nullable restore
#line 54 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 57 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 60 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsCompleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 66 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsCompleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 80 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.ID }, new { onclick = "return confirm('are you sure? ')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 83 "D:\DotNetCoreExpert\DNC.MVC\Views\ToDoList\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Options.IOptions<ConfigurationOfcolour> conf { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnv { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DNC.Model.ToDoListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
