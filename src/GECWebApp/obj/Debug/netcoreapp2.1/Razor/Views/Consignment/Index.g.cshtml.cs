#pragma checksum "C:\repositorio\GEC2.1\src\GECWebApp\Views\Consignment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fa0bdbac040d48cc2a34e61992fdba0a33637a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consignment_Index), @"mvc.1.0.view", @"/Views/Consignment/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consignment/Index.cshtml", typeof(AspNetCore.Views_Consignment_Index))]
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
#line 1 "C:\repositorio\GEC2.1\src\GECWebApp\Views\_ViewImports.cshtml"
using GECWebApp;

#line default
#line hidden
#line 2 "C:\repositorio\GEC2.1\src\GECWebApp\Views\_ViewImports.cshtml"
using GECWebApp.Models;

#line default
#line hidden
#line 1 "C:\repositorio\GEC2.1\src\GECWebApp\Views\Consignment\Index.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
#line 2 "C:\repositorio\GEC2.1\src\GECWebApp\Views\Consignment\Index.cshtml"
using GECApi.Entities;

#line default
#line hidden
#line 3 "C:\repositorio\GEC2.1\src\GECWebApp\Views\Consignment\Index.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fa0bdbac040d48cc2a34e61992fdba0a33637a5", @"/Views/Consignment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"834512f6ff5c9dc8a878a502f08bd0733ea6d90c", @"/Views/_ViewImports.cshtml")]
    public class Views_Consignment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/App/consignment/crudFirebase.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/App/consignment/consignmentFirebase.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/App/consignment/startFirebase.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\repositorio\GEC2.1\src\GECWebApp\Views\Consignment\Index.cshtml"
  
  ViewData["Title"] = "Remesas";

#line default
#line hidden
            BeginContext(125, 7340, true);
            WriteLiteral(@"<script src=""https://www.gstatic.com/firebasejs/4.12.1/firebase.js""></script>
<script src=""https://www.gstatic.com/firebasejs/4.12.1/firebase-firestore.js""></script>

<h2>Remesas</h2>
<div class=""container"">
  <div class=""row"">
    <div class=""col-md-4 form-group mb-0""><input type=""text"" disabled value=""Venezuela"" id=""ciudad"" class=""form-control"" /></div>
    <div class=""col-md-4""></div>
    <div class=""col-md-4""></div>

    <div class=""col-md-12"">
      <div class=""card"">
        <div class=""card-body"">
          <!-- Primera fila -->
          <div class=""row"">
            <div class=""col-md-3"">
              <div class=""form-group"">
                <label class=""col-form-label"">Cantidad BTC</label>
                <input type=""number"" min=""1"" max=""8"" id=""cantidadBtc"" placeholder=""044303"" class=""form-control"" />
              </div>
            </div>
            <div class=""col-md-3"">
              <div class=""form-group"">
                <label class=""col-form-label"">Monto Remesas</");
            WriteLiteral(@"label>
                <input type=""number"" min=""1"" id=""montoRemesas"" placeholder=""044303"" class=""form-control"" />
              </div>
            </div>
            <div class=""col-md-3"">
              <div class=""form-group"">
                <label class=""col-form-label"">Tasas Remesas</label>
                <input type=""number"" min=""1"" id=""tasasRemesas"" placeholder=""044303"" class=""form-control"" />
              </div>
            </div>
            <div class=""col-md-3"">
              <div class=""form-group"">
                <label class=""col-form-label"">Monto Total</label>
                <input type=""number"" min=""1"" id=""montoTotal"" placeholder=""99999$"" disabled class=""form-control"" />
              </div>
            </div>
          </div>
          <!-- Fin de la Primera fila -->
          <!-- Segunda fila -->
          <div class=""row"">
            <div class=""col-md-7"">
              <div class=""form-group"">
                <label class=""form-label"">Tasas Ventas BTC</label>
 ");
            WriteLiteral(@"               <input type=""number"" min=""1"" id=""tasasVentasBtc"" placeholder=""044303"" class=""form-control"" />
              </div>
            </div>
          </div>
          <!-- Fin de la Primera fila -->
          <!-- Segunda fila -->
          <div class=""row"">
            <div class=""col-md-4"">
            </div>

            <div class=""col-md-4"">
              <div class=""form-group"">
                <label class=""form-text text-center""> Nuestro Contacto</label>
                <input type=""checkbox"" id=""contacto"" class=""form-control"" />
              </div>
            </div>

            <div class=""col-md-4"">
            </div>
          </div>

          <!-- Fin de la Segunda fila -->
          <!-- Tercera fila -->

          <div class=""row"" id=""estadoContacto"">
            <div class=""col-md-4"">
              <div class=""form-group"">
                <label class=""col-form-label"">Ganancia Contacto</label>
                <input type=""number"" min=""1"" id=""gananciaC"" p");
            WriteLiteral(@"laceholder=""99999$"" disabled class=""form-control"" />
              </div>
            </div>

            <div class=""col-md-4"">
              <div class=""form-group"">
                <label class=""col-form-label"">Ganancia Enlace</label>
                <input type=""number"" min=""1"" id=""gananciaE"" placeholder=""99999$"" disabled class=""form-control"" />
              </div>
            </div>

            <div class=""col-md-4"">
              <div class=""form-group"">
                <label class=""col-form-label"">Ganancia GEC</label>
                <input type=""number"" min=""1"" id=""gananciaGEC"" placeholder=""99999$"" disabled class=""form-control"" />
              </div>
            </div>
          </div>

          <!-- Fin de la Tercera fila -->
          <!-- Cuarta fila -->

          <div class=""row"">
            <div class=""col-md-4"">
              <div class=""form-group"">
                <label class=""col-form-label"">Monto Entrega</label>
                <input type=""number"" min=""1"" i");
            WriteLiteral(@"d=""montoEntrega"" placeholder=""99999$"" disabled class=""form-control"" />
              </div>
            </div>

            <div class=""col-md-4"">
            </div>

            <div class=""col-md-4"">
              <div class=""form-group"">
                <label class=""col-form-label"">Ganancia</label>
                <input type=""number"" min=""1"" id=""gananciaNeta"" placeholder=""99999$"" disabled class=""form-control"" />
              </div>
            </div>
          </div>
        </div>
      </div>

      <div>
        <input type=""button"" class=""btn btn-lg btn-danger float-right"" value=""Cancelar"" id=""botonCancel"" onclick=""Cancelremittances()"" />
        <input type=""button"" class=""btn btn-lg btn-success float-right"" value=""Guardar"" id=""botonGuardar"" onclick=""saveRemittances()"" />
      </div>
      <!--Mensaje de Error y fin del Card-->
      <div class=""row"">
        <divv class=""col-md-12"">
          <div id=""mensajeError""></div>
        </divv>
      </div>
    </div>
  </div");
            WriteLiteral(@">
</div>

<!--Tabla de datos de Remesas-->

<div class=""container mt-5"">
  <div class=""row"">
    <div class=""col-md-5"">
      <button class=""btn btn-primary btn-block"" type=""button"" data-toggle=""collapse"" data-target=""#collapseExample"" aria-expanded=""false"" aria-controls=""collapseExample"">
        filtros
      </button>
      <div class=""collapse"" id=""collapseExample"">
        <div class=""card card-body"">
          <div class=""form-group"">
            <label for=""eleccionFiltro"" class=""form-label"">Fecha</label>
            <input type=""radio"" name=""eleccionFiltro"" id=""filtrofecha"" class=""radio mr-lg-5"" checked />

            <label for=""eleccionFiltro"" class=""form-label"">Pais</label>
            <input type=""radio"" name=""eleccionFiltro"" id=""filtroPais"" class=""radio mr-lg-5"" />

            <label for=""eleccionFiltro"" class=""form-label"">Monto</label>
            <input type=""radio"" name=""eleccionFiltro"" id=""filtroMonto"" class=""radio"" />
          </div>
        </div>
      </div>
  ");
            WriteLiteral(@"  </div>

    <div class=""col-md-4"">
      <div class=""form-group"">
        <input type=""search"" name=""buscaRemesa"" id=""buscaRemesa"" class=""form-control"" placeholder=""Search.."" />
      </div>
    </div>

    <div class=""col-md-3"">
      <div class=""form-group"">
        <button type=""button"" name=""botonBuscar"" id=""botonBuscar"" class=""btn btn-primary"" onclick=""look()""><i class=""cui-magnifying-glass"" aria-hidden=""true""></i> Search</button>
      </div>
    </div>
  </div>

  <div class=""row"">
    <div class=""col-md-12"">
      <table class=""table"">
        <thead class=""thead-dark"">
          <tr>
            <th scope=""col"">Fecha</th>
            <th scope=""col"">Pais</th>
            <th scope=""col"">Ganancia Contacto</th>
            <th scope=""col"">Ganancia Enlace</th>
            <th scope=""col"">Ganancia GEC</th>
            <th scope=""col"">Monto Entrega</th>
            <th scope=""col"">Ganancia</th>
            <th scope=""col"">Monto Total</th>
          </tr>
        </thead>
  ");
            WriteLiteral("      <tbody id=\"datosTabla\"></tbody>\r\n      </table>\r\n    </div>\r\n\r\n    <div class=\"col-md-12\">\r\n      <div id=\"errorFiltro\"></div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7483, 605, true);
                WriteLiteral(@"
  <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
  <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js"" integrity=""sha384-wHAiFfRlMFy6i5SRaxvfOCifBUQy1xHdJ/yoi7FRNXMRBu5WHdZYu1hA6ZOblgut"" crossorigin=""anonymous""></script>
  <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js"" integrity=""sha384-B0UglyR+jN6CkvvICOB2joaf5I4l3gm9GU6Hc1og6Ls7i6U/mkkaduKaBhlAXv9k"" crossorigin=""anonymous""></script>

  ");
                EndContext();
                BeginContext(8088, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd879e3a2c04409d88d3fcbb074f673d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8148, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(8152, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55205266dfb94636adad3a1cb7565362", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8219, 6, true);
                WriteLiteral("\r\n\r\n  ");
                EndContext();
                BeginContext(8225, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9a410473ba4455bace1e0f8c368f965", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8286, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(8291, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
