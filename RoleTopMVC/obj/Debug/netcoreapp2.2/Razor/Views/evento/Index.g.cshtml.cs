#pragma checksum "C:\Users\36591349880\Desktop\MVC\MVCSenai\RoleTopMVC\Views\evento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "668b2cd54c63134ed1eaeef047987c1b263a6ea5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_evento_Index), @"mvc.1.0.view", @"/Views/evento/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/evento/Index.cshtml", typeof(AspNetCore.Views_evento_Index))]
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
#line 1 "C:\Users\36591349880\Desktop\MVC\MVCSenai\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\36591349880\Desktop\MVC\MVCSenai\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"668b2cd54c63134ed1eaeef047987c1b263a6ea5", @"/Views/evento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_evento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.ServicosViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Casamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Aniversário de Debutante", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Festa de empresas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Festa de Aniversário", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Balada", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fcontato"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 68, true);
            WriteLiteral("\r\n<main style=\"padding-bottom: 10em;\">\r\n    <h2>Faça seu pedido, Sr.");
            EndContext();
            BeginContext(117, 17, false);
#line 4 "C:\Users\36591349880\Desktop\MVC\MVCSenai\RoleTopMVC\Views\evento\Index.cshtml"
                       Write(Model.NomeUsuario);

#line default
#line hidden
            EndContext();
            BeginContext(134, 64, true);
            WriteLiteral("!</h2>\r\n    <div class=\"evento\">Cadastro do evento</div>\r\n\r\n    ");
            EndContext();
            BeginContext(198, 2073, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "668b2cd54c63134ed1eaeef047987c1b263a6ea56144", async() => {
                BeginContext(277, 403, true);
                WriteLiteral(@"
        <fieldset>

            <p>
                <label for=""cevento""> Nome do Evento:</label>
                <input type=""text"" name=""NomeEvento"" id=""cevento"" placeholder=""ex:Senai confraternização"">
            </p>

            <p>
                <label for=""ctevento""> Tipo do evento:</label>
                <select type=""text"" name=""tipoevento"" id=""ctevento"">
                    ");
                EndContext();
                BeginContext(680, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "668b2cd54c63134ed1eaeef047987c1b263a6ea56945", async() => {
                    BeginContext(706, 9, true);
                    WriteLiteral("Casamento");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(724, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(746, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "668b2cd54c63134ed1eaeef047987c1b263a6ea58430", async() => {
                    BeginContext(787, 9, true);
                    WriteLiteral("Debutante");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(805, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(827, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "668b2cd54c63134ed1eaeef047987c1b263a6ea59915", async() => {
                    BeginContext(861, 11, true);
                    WriteLiteral("Corporativo");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(881, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(903, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "668b2cd54c63134ed1eaeef047987c1b263a6ea511403", async() => {
                    BeginContext(940, 11, true);
                    WriteLiteral("Aniversário");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(960, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(982, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "668b2cd54c63134ed1eaeef047987c1b263a6ea512892", async() => {
                    BeginContext(1005, 6, true);
                    WriteLiteral("Balada");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1020, 801, true);
                WriteLiteral(@"
                </select>

                </select>

            </p>

            <p>
                <label for=""cdate""> Data do evento:</label>
                <input type=""date"" name=""dataevento"" id=""cdate"" placeholder=""exemplo: 25/05/2002"">
            </p>

            <p>
                <label for=""cnumber"">Número de convidados</label>
                <input type=""number"" name=""numeroconvidado"" id=""cnumber"" placeholder=""nº de convidados"">
            </p>
            <p>
                <label for=""cobservacoes"">Obs:</label>
                <input type=""text"" name=""observacoes"" id=""cobservacoes"">
            </p>
            <div>
                <label for=""servicos"">Valor de locaçâo do Rolê Top(R$10.000)</label>
                </p>
                <p>

");
                EndContext();
#line 47 "C:\Users\36591349880\Desktop\MVC\MVCSenai\RoleTopMVC\Views\evento\Index.cshtml"
                     foreach (var servico in @Model.servicos) {

#line default
#line hidden
                BeginContext(1886, 26, true);
                WriteLiteral("                    <input");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1912, "\"", 1939, 2);
                WriteAttributeValue("", 1917, "pacote-", 1917, 7, true);
#line 48 "C:\Users\36591349880\Desktop\MVC\MVCSenai\RoleTopMVC\Views\evento\Index.cshtml"
WriteAttributeValue("", 1924, servico.Nome, 1924, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1940, 16, true);
                WriteLiteral(" type=\"checkbox\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1956, "", 1976, 1);
#line 48 "C:\Users\36591349880\Desktop\MVC\MVCSenai\RoleTopMVC\Views\evento\Index.cshtml"
WriteAttributeValue("", 1963, servico.Nome, 1963, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1976, 43, true);
                WriteLiteral(" name=\"pacote\">\r\n                    <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 2019, "\"", 2047, 2);
                WriteAttributeValue("", 2025, "pacote-", 2025, 7, true);
#line 49 "C:\Users\36591349880\Desktop\MVC\MVCSenai\RoleTopMVC\Views\evento\Index.cshtml"
WriteAttributeValue("", 2032, servico.Nome, 2032, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2048, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2050, 12, false);
#line 49 "C:\Users\36591349880\Desktop\MVC\MVCSenai\RoleTopMVC\Views\evento\Index.cshtml"
                                                   Write(servico.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(2062, 7, true);
                WriteLiteral(" por R$");
                EndContext();
                BeginContext(2070, 13, false);
#line 49 "C:\Users\36591349880\Desktop\MVC\MVCSenai\RoleTopMVC\Views\evento\Index.cshtml"
                                                                       Write(servico.Preco);

#line default
#line hidden
                EndContext();
                BeginContext(2083, 10, true);
                WriteLiteral("</label>\r\n");
                EndContext();
#line 50 "C:\Users\36591349880\Desktop\MVC\MVCSenai\RoleTopMVC\Views\evento\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(2116, 148, true);
                WriteLiteral("                    </select>\r\n\r\n                </p>\r\n\r\n        </fieldset>\r\n\r\n        <input class=\'center\' type=\"submit\" value=\"Entrar!\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 7 "C:\Users\36591349880\Desktop\MVC\MVCSenai\RoleTopMVC\Views\evento\Index.cshtml"
AddHtmlAttributeValue("", 240, Url.Action("Registrar", "evento"), 240, 34, false);

#line default
#line hidden
            AddHtmlAttributeValue(" ", 274, "", 275, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2271, 25, true);
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.ServicosViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
