#pragma checksum "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\login\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db88186261270536bc012c92579dfde9d2aa0bee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_login_Historico), @"mvc.1.0.view", @"/Views/login/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/login/Historico.cshtml", typeof(AspNetCore.Views_login_Historico))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db88186261270536bc012c92579dfde9d2aa0bee", @"/Views/login/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_login_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.HistoricoViewModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\login\Historico.cshtml"
  
    ViewData["Title"] = "Eventos-RoleTop";
    ViewData["H2"] = "Histórico de eventos";

#line default
#line hidden
            BeginContext(147, 427, true);
            WriteLiteral(@"<main>

    <div id=""dash""> 
        
    <table>
        
        <caption class=""pedidos"">Seu pedido</caption>
        <tr>
            <th>Nome Completo</th>
            <th>Telefone</th>
            <th>Tipos de Pedidos</th>
            <th>Serviços adcionais</th>
            <th>Observações do pedido</th>
            <th>Valor Total</th>
            <!-- <th>Aprovar</th> -->
            
        </tr>
");
            EndContext();
#line 23 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\login\Historico.cshtml"
     foreach (var pedido in Model.pedidos)
    {

#line default
#line hidden
            BeginContext(625, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(656, 19, false);
#line 26 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\login\Historico.cshtml"
           Write(pedido.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(675, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(699, 23, false);
#line 27 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\login\Historico.cshtml"
           Write(pedido.Cliente.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(722, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(746, 17, false);
#line 28 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\login\Historico.cshtml"
           Write(pedido.TipoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(763, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(787, 22, false);
#line 29 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\login\Historico.cshtml"
           Write(pedido.ListaDeProdutos);

#line default
#line hidden
            EndContext();
            BeginContext(809, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(833, 10, false);
#line 30 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\login\Historico.cshtml"
           Write(pedido.Obs);

#line default
#line hidden
            EndContext();
            BeginContext(843, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(867, 17, false);
#line 31 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\login\Historico.cshtml"
           Write(pedido.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(884, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 33 "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\login\Historico.cshtml"
    }

#line default
#line hidden
            BeginContext(913, 250, true);
            WriteLiteral("                <!-- <div id=\"imagex\"><img src=\"img/fotox.png\"></div>\r\n                \r\n                <div id=\"imagev\"><img src=\"img/correto.png\"></div> -->\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n\r\n    </div>\r\n</section>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.HistoricoViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
