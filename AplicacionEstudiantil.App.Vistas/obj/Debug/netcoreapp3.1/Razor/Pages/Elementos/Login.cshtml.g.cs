#pragma checksum "C:\Users\dlote\Documents\Mision TIC2022\Ciclo 3\Grupo-1-DS\AplicacionEstudiantil.App.Vistas\Pages\Elementos\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03d73be80d46784e113ef7eef26131f9cfbfdc35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AplicacionEstudiantil.App.Vistas.Pages.Elementos.Pages_Elementos_Login), @"mvc.1.0.razor-page", @"/Pages/Elementos/Login.cshtml")]
namespace AplicacionEstudiantil.App.Vistas.Pages.Elementos
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
#line 1 "C:\Users\dlote\Documents\Mision TIC2022\Ciclo 3\Grupo-1-DS\AplicacionEstudiantil.App.Vistas\Pages\_ViewImports.cshtml"
using AplicacionEstudiantil.App.Vistas;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03d73be80d46784e113ef7eef26131f9cfbfdc35", @"/Pages/Elementos/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"723b31d729457c62aeffd5da2a497ad73f34e084", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Elementos_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\dlote\Documents\Mision TIC2022\Ciclo 3\Grupo-1-DS\AplicacionEstudiantil.App.Vistas\Pages\Elementos\Login.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""vh-100"">
  <div class=""container-fluid h-custom"">
    <div class=""row d-flex justify-content-center align-items-center h-100"">
      <div class=""col-md-9 col-lg-6 col-xl-5"">
        <img
          src=""https://thumbs.dreamstime.com/b/redes-de-computaci%C3%B3n-en-nube-con-estilo-m%C3%ADnimo-abstracto-azul-y-blanco-estructura-dise%C3%B1o-concepto-telecomunicaciones-conexiones-190102239.jpg""
          class=""img-fluid"" alt=""Sample image"">
      </div>
      <div class=""col-md-8 col-lg-6 col-xl-4 offset-xl-1"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03d73be80d46784e113ef7eef26131f9cfbfdc354070", async() => {
                WriteLiteral(@"
          <div class=""d-flex flex-row align-items-center justify-content-center justify-content-lg-start"">
            <!-- <p class=""lead fw-normal mb-0 me-3"">Inicio de Sesion</p> -->
          </div>

          <!--  input de  correo -->
          <div class=""form-outline mb-4"">
            <input type=""email"" id=""form3Example3"" class=""form-control form-control-lg""
              placeholder=""Ingrese el correo electronico"" />
            <label class=""form-label"" for=""form3Example3"">Correo Electronico</label>
          </div>

          <!-- input de contraseña -->
          <div class=""form-outline mb-3"">
            <input type=""password"" id=""form3Example4"" class=""form-control form-control-lg""
              placeholder=""ingrese una contraseña"" />
            <label class=""form-label"" for=""form3Example4"">Contraseña</label>
          </div>

          <div class=""d-grid gap-2 d-md-flex justify-content-md-end"">
            <!---<button class=""btn btn-primary me-md-2"" type=""button"">Ingresa");
                WriteLiteral("r</button>-->\r\n            <a href=\"Materia\" class=\"btn btn-primary\"> Inicio</a>\r\n            <a class=\"btn btn-primary\" href=\"Registro\" role=\"button\">Registrarse</a>\r\n          </div>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n      </div>\r\n    </div>\r\n  </div>\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ejemplo.Pages.LoginModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ejemplo.Pages.LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ejemplo.Pages.LoginModel>)PageContext?.ViewData;
        public Ejemplo.Pages.LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
