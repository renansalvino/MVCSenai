#pragma checksum "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c363e03f93cafc62d61034f6008441c5f699950"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Administrador), @"mvc.1.0.view", @"/Views/Administrador/Administrador.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Administrador.cshtml", typeof(AspNetCore.Views_Administrador_Administrador))]
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
#line 1 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c363e03f93cafc62d61034f6008441c5f699950", @"/Views/Administrador/Administrador.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Administrador : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 272, true);
            WriteLiteral(@"  <main>
        <h2>Dashboard</h2>
        <section id=""status-pedidos"">
            <h3>Status dos pedidos</h3>
            <div id=""painel"">
                <div class=""box-status-pedidos aprovados"">
                    <h4>Aprovados</h4>
                    <p>");
            EndContext();
            BeginContext(322, 23, false);
#line 9 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
                  Write(Model.ServicosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(345, 153, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"box-status-pedidos pendentes\">\r\n                    <h4>Pendentes</h4>\r\n                    <p>");
            EndContext();
            BeginContext(499, 23, false);
#line 13 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
                  Write(Model.ServicosPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(522, 155, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"box-status-pedidos reprovados\">\r\n                    <h4>Reprovados</h4>\r\n                    <p>");
            EndContext();
            BeginContext(678, 24, false);
#line 17 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
                  Write(Model.ServicosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(702, 777, true);
            WriteLiteral(@"</p>
                </div>
            </div>
        </section>

        <section id=""lista-pedidos"">
            <h3>Lista de pedidos</h3>
            <table>
                <thead>
                    <tr>
                        <th rowspan=""2"">Nome</th>
                        <th rowspan=""2"">Endereço</th>
                        <th colspan=""2"">Pedido</th>
                        <th colspan=""2"" rowspan=""2"">Aprovar/Recusar</th>
                    </tr>
                    <tr>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <td colspan=""6"">
                            <p>Pedidos atualizados em ");
            EndContext();
            BeginContext(1480, 12, false);
#line 40 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
                                                 Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(1492, 115, true);
            WriteLiteral("</p>\r\n                        </td>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 45 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
                     foreach(var pedido in Model.Pedidos )
                    {

#line default
#line hidden
            BeginContext(1690, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1753, 19, false);
#line 48 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
                           Write(pedido.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1772, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1796, 18, false);
#line 49 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
           Write(pedido.Cliente.CPF);

#line default
#line hidden
            EndContext();
            BeginContext(1814, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1838, 23, false);
#line 50 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
           Write(pedido.Cliente.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(1861, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1885, 29, false);
#line 51 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
           Write(pedido.Cliente.DataNascimento);

#line default
#line hidden
            EndContext();
            BeginContext(1914, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1938, 17, false);
#line 52 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
           Write(pedido.TipoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(1955, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1979, 22, false);
#line 53 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
           Write(pedido.ListaDeProdutos);

#line default
#line hidden
            EndContext();
            BeginContext(2001, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2025, 10, false);
#line 54 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
           Write(pedido.Obs);

#line default
#line hidden
            EndContext();
            BeginContext(2035, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2059, 17, false);
#line 55 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
           Write(pedido.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(2076, 25, true);
            WriteLiteral("</td>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2101, "\'", 2163, 1);
#line 56 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
WriteAttributeValue("", 2108, Url.Action("Aprovar", "Pedido", new {id = @pedido.Id}), 2108, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2164, 58, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2222, "\'", 2285, 1);
#line 57 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
WriteAttributeValue("", 2229, Url.Action("Reprovar", "Pedido", new {id = @pedido.Id}), 2229, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2286, 71, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\r\n                        </tr>\r\n");
            EndContext();
#line 59 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
                    }

#line default
#line hidden
            BeginContext(2380, 602, true);
            WriteLiteral(@"                </tbody>
            </table>
        </section>

    </main>
        
        <!-- <table>
          
          <caption class=""adimin"">Pedidos</caption>
          
              
          <tr>
            <th>Nome Completo</th>
            <th>CPF ou CNPJ</th>
            <th>Telefone</th>
            <th>Data de nascimento</th>
            <th>Tipos de evento</th>
            <th>Serviços Adicionais</th>
            <th>Observações do pedido</th>
            <th>Valor Total</th>
            <th>Aprovar</th>
            <th>Reprovar</th>
          </tr>
");
            EndContext();
#line 83 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
           foreach (var pedido in @Model.Pedidos)
          {
              

#line default
#line hidden
            BeginContext(3062, 32, true);
            WriteLiteral("          <tr>\r\n            <td>");
            EndContext();
            BeginContext(3095, 19, false);
#line 87 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
           Write(pedido.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3114, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(3138, 18, false);
#line 88 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
           Write(pedido.Cliente.CPF);

#line default
#line hidden
            EndContext();
            BeginContext(3156, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(3180, 23, false);
#line 89 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
           Write(pedido.Cliente.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(3203, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(3227, 29, false);
#line 90 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
           Write(pedido.Cliente.DataNascimento);

#line default
#line hidden
            EndContext();
            BeginContext(3256, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(3280, 17, false);
#line 91 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
           Write(pedido.TipoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(3297, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(3321, 22, false);
#line 92 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
           Write(pedido.ListaDeProdutos);

#line default
#line hidden
            EndContext();
            BeginContext(3343, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(3367, 10, false);
#line 93 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
           Write(pedido.Obs);

#line default
#line hidden
            EndContext();
            BeginContext(3377, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(3401, 17, false);
#line 94 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
           Write(pedido.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(3418, 25, true);
            WriteLiteral("</td>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 3443, "\'", 3505, 1);
#line 95 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
WriteAttributeValue("", 3450, Url.Action("Aprovar", "Pedido", new {id = @pedido.Id}), 3450, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3506, 58, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 3564, "\'", 3627, 1);
#line 96 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
WriteAttributeValue("", 3571, Url.Action("Reprovar", "Pedido", new {id = @pedido.Id}), 3571, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3628, 244, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\r\n\r\n            <td>\r\n\r\n              <div id=\"imagex\"><img src=\"img/fotox.png\"></div>\r\n              \r\n              <div id=\"imagev\"><img src=\"img/correto.png\"></div>\r\n            </td>\r\n          </tr>\r\n");
            EndContext();
#line 105 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\Administrador\Administrador.cshtml"
          }

#line default
#line hidden
            BeginContext(3885, 476, true);
            WriteLiteral(@"          <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td>

                <div id=""imagex""><img src=""img/fotox.png""></div>
                
                <div id=""imagev""><img src=""img/correto.png""></div>
              </td>
          </tr>
        </table> -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
