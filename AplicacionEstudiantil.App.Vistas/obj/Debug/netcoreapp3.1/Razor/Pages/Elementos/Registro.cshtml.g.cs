#pragma checksum "C:\Users\dlote\Documents\GitHub\Grupo-1-DS\AplicacionEstudiantil.App.Vistas\Pages\Elementos\Registro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c09f16b605be33a59d1cb2c3e9fff86bd2f52c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AplicacionEstudiantil.App.Vistas.Pages.Elementos.Pages_Elementos_Registro), @"mvc.1.0.razor-page", @"/Pages/Elementos/Registro.cshtml")]
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
#line 1 "C:\Users\dlote\Documents\GitHub\Grupo-1-DS\AplicacionEstudiantil.App.Vistas\Pages\_ViewImports.cshtml"
using AplicacionEstudiantil.App.Vistas;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c09f16b605be33a59d1cb2c3e9fff86bd2f52c5", @"/Pages/Elementos/Registro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"723b31d729457c62aeffd5da2a497ad73f34e084", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Elementos_Registro : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\dlote\Documents\GitHub\Grupo-1-DS\AplicacionEstudiantil.App.Vistas\Pages\Elementos\Registro.cshtml"
  
    ViewData["Title"] = "Registro";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"tab-content\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c09f16b605be33a59d1cb2c3e9fff86bd2f52c53514", async() => {
                WriteLiteral(@"

        
<!-- e validacion del rol con el codigo unico-->

        <h3>Validacion de Rol</h3>
        <div class=""input-group"">
            <input type=""search"" class=""form-control rounded"" placeholder=""Ingrese el codigo de usuario Suministrado""
                aria-label=""Codigo suministrado"" aria-describedby=""search-addon"" />
            <button type=""button"" class=""btn btn-outline-primary"">Validar</button>
        </div>

<!-- etiqueda donde se mostrara el resultado de la validacion del rol con el codigo unico-->
        <div>
            <br>
            <p class=""text-center"">El rol asignado con este codigo de usuario es </p>
            </h4>
            <label class=""form-label"" for=""rol""> Estudiante/profesor</label>
        </div>


        <br><br><h3>Formulario de Registro</h3>

        <!-- input  nombre y apellidos-->
        <div class=""row mb-4"">
            <div class=""col"">
                <div class=""form-outline"">
                    <label class=""form-label"" for");
                WriteLiteral(@"=""registrarNombres"">Nombres</label>
                    <input type=""text"" id=""registrarNombres"" class=""form-control"" />
                </div>
            </div>
            <div class=""col"">
                <div class=""form-outline"">
                    <label class=""form-label"" for=""registrarApellidos"">Apellidos</label>
                    <input type=""text"" id=""registrarApellidos"" class=""form-control"" />
                </div>
            </div>
        </div>

        <!-- input correo -->

        <div class=""row mb-4"">
            <div class=""col"">
                <div class=""form-outline"">
                    <label class=""form-label"" for=""registrarCorreo"">Correo</label>
                    <input type=""email"" id=""registrarCorreo"" class=""form-control"" />
                </div>
            </div>
            <div class=""col"">
                <div class=""form-outline"">
                    <label class=""form-label"" for=""fechanacimiento"">Fecha de nacimiento</label>
                ");
                WriteLiteral(@"    <input type=""date"" id=""fechanacimiento"" class=""form-control"" />
                </div>
            </div>
        </div>

        <!-- input direccion y telefono-->
        <div class=""row mb-4"">
            <div class=""col"">
                <div class=""form-outline"">
                    <label class=""form-label"" for=""registrarApellidos"">Direccion</label>
                    <input type=""text"" id=""registrarApellidos"" class=""form-control"" />
                </div>
            </div>
            <div class=""col"">
                <div class=""form-outline"">
                    <label class=""form-label"" for=""registrarApellidos"">Telefono</label>
                    <input type=""text"" id=""registrarApellidos"" class=""form-control"" />
                </div>
            </div>
        </div>

        <!-- input contraseña-->
        <div class=""row mb-4"">
            <div class=""col"">
                <div class=""form-outline"">
                    <label class=""form-label"" for=""registerPasswo");
                WriteLiteral(@"rd"">Contraseña</label>
                    <input type=""password"" id=""registerPassword"" class=""form-control"" />
                </div>
            </div>
            <div class=""col"">
                <div class=""form-outline"">
                    <label class=""form-label"" for=""registerRepeatPassword"">Repita la contraseña</label>
                    <input type=""password"" id=""registerRepeatPassword"" class=""form-control"" />
                </div>
            </div>
        </div>

        <!-- boton de registro -->
        <a href=""AdminEstudiante"" class=""btn btn-primary btn-block mb-3""> Registrar</a>
    ");
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
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AplicacionEstudiantil.App.Vistas.Pages.RegistroModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AplicacionEstudiantil.App.Vistas.Pages.RegistroModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AplicacionEstudiantil.App.Vistas.Pages.RegistroModel>)PageContext?.ViewData;
        public AplicacionEstudiantil.App.Vistas.Pages.RegistroModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
