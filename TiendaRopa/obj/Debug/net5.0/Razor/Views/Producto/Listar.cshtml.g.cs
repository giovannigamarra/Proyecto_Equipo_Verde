#pragma checksum "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06e4e7e967965b19d0cc422c05ae398b0ca2e5ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Listar), @"mvc.1.0.view", @"/Views/Producto/Listar.cshtml")]
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
#line 1 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\_ViewImports.cshtml"
using TiendaRopa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\_ViewImports.cshtml"
using TiendaRopa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06e4e7e967965b19d0cc422c05ae398b0ca2e5ae", @"/Views/Producto/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d1bdf0d949c0491370ba4b469a0250dc5d178f", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TiendaRopa.Models.Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
  
    ViewData["Title"] = "Productos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <script src=""https://cdn.jsdelivr.net/npm/sweetalert2@10""></script>

<br>
<br>
<div class=""section-title"">
          <h2 >Ropas Registrados</h2>
          <p>Visualiza todos los ropas registrados de nuestra tienda de ropas Topitop</p>
</div>
<p>
    <button class=""btn btn-success""class=""btn btn-success""");
            BeginWriteAttribute("onclick", " onclick=\"", 410, "\"", 470, 3);
            WriteAttributeValue("", 420, "window.location=\'", 420, 17, true);
#nullable restore
#line 15 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
WriteAttributeValue("", 437, Url.Action("Index", "Producto"), 437, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 469, "\'", 469, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Registrar</button>
</p>
<div class=""container"" >
<table class=""table table-hover"">
    <thead class=""tables"">
        <tr class=""center"">
                <th scope=""col"">
                    #
                </th>
                <th scope=""col"">
                    ");
#nullable restore
#line 25 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
               Write(Html.DisplayNameFor(model => model.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
               Write(Html.DisplayNameFor(model => model.modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 31 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
               Write(Html.DisplayNameFor(model => model.precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
               Write(Html.DisplayNameFor(model => model.imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 41 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"center\">\r\n            <th scope=\"row\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06e4e7e967965b19d0cc422c05ae398b0ca2e5ae7314", async() => {
                WriteLiteral("Modificar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
                                       WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("| \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06e4e7e967965b19d0cc422c05ae398b0ca2e5ae9506", async() => {
                WriteLiteral("Borrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
                                         WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n               <div class=\"card img\" style=\"width: 12rem;\">\r\n               <img");
            BeginWriteAttribute("src", " src=\"", 1903, "\"", 1921, 1);
#nullable restore
#line 59 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
WriteAttributeValue("", 1909, item.imagen, 1909, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"  alt=\"...\">\r\n               <div class=\"card-body\">\r\n\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 65 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
    }        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>    \r\n</table>\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 71 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
 if ((String)TempData["prueba"] == "prueba01")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input value=\"hola\" id=\"hola01\" type=\"hidden\">\r\n");
#nullable restore
#line 74 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 76 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
 if ((String)TempData["prueba02"] == "prueba02") 
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input value=\"hola\" id=\"prueba02\" type=\"hidden\">\r\n");
#nullable restore
#line 79 "C:\Users\jhon\Documents\PROGRAMACION PROYECTO FINAL\Ropas2021\TiendaRopa\Views\Producto\Listar.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <script>
        
        var x = document.getElementById('hola01').value;

        if(x == ""hola"") {
        
            Swal.fire(
                'Registro exitoso',
                'La ropa ha sido registrado exitosamente',
                'success'
            )
  
        }

       

    </script>

   <script>
        
        var y = document.getElementById('prueba02').value;

        if(y == ""hola"") {

            Swal.fire(
                'Editado correctamente',
                'La ropa se ha editado correctamente',
                'success'
            )
        }
   </script> 

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TiendaRopa.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591