#pragma checksum "C:\Users\36591349880\Desktop\MVCSenai\RoleTopMVC\Views\programação\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f15bcc8b94f5bc26a5efa38d6b32a679350e09f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_programação_Index), @"mvc.1.0.view", @"/Views/programação/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/programação/Index.cshtml", typeof(AspNetCore.Views_programação_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f15bcc8b94f5bc26a5efa38d6b32a679350e09f", @"/Views/programação/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_programação_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4058, true);
            WriteLiteral(@"<main>
        <!-- Calendario-->
        <div class=""letra"">
        <h1>Programação de eventos</h1>
    </div>
        <div id=""calendario"">

        <table>

            <caption class=""mes"">Setembro 2019</caption>

            <thead>

                <tr>

                    <td class=""dia"">
                        <div class=""semana"">D</td>
                    <td class=""dia"">
                        <div class=""semana"">S</td>
                    <td class=""dia"">
                        <div class=""semana"">T</td>
                    <td class=""dia"">
                        <div class=""semana"">Q</td>
                    <td class=""dia"">
                        <div class=""semana"">Q</td>
                    <td class=""dia"">
                        <div class=""semana"">S</td>
                    <td class=""dia"">
                        <div class=""semana"">S</td>

                </tr>

            </thead>     
            
            <tbody>

                <tr>

  ");
            WriteLiteral(@"                  <td class=""dia"">1<span class=""evento""><img src=""img/logo.png"" style=""width: 50px;border-top-style: solid;border-top-width: 0px;""></span></td>
                    <td class=""dia"">2<span class=""evento""></span></td>
                    <td class=""dia"">3<span class=""evento""></span></td>
                    <td class=""dia"">4</td>
                    <td class=""dia"">5<span class=""evento""><img src=""img/logo.png"" style=""width: 50px;border-top-style: solid;border-top-width: 0px;""></span></td>
                    <td class=""dia"">6</td>
                    <td class=""dia"">7</td>

                </tr>

                <tr>

                    <td class=""dia"">8<span class=""evento""></span></td>
                    <td class=""dia"">9</td>
                    <td class=""dia"">10</td>
                    <td class=""dia"">11<span class=""evento""><img src=""img/logo.png"" style=""width: 50px;border-top-style: solid;border-top-width: 0px;""></span></td>
                    <td class=""dia"">12</td>
   ");
            WriteLiteral(@"                 <td class=""dia"">13<span class=""evento""></span></td>
                    <td class=""dia"">14</td>

                </tr>

                <tr>

                    <td class=""dia"">15<span class=""evento""><img src=""img/logo.png"" style=""width: 50px;border-top-style: solid;border-top-width: 0px;""></span></td>
                    <td class=""dia"">16</td>
                    <td class=""dia"">17</td>
                    <td class=""dia"">18<span class=""evento""><img src=""img/logo.png"" style=""width: 50px;border-top-style: solid;border-top-width: 0px;""></span></td>
                    <td class=""dia"">19</td>
                    <td class=""dia"">50<span class=""evento""></span></td>
                    <td class=""dia"">21</td>

                </tr>

                <tr>

                    <td class=""dia"">22<span class=""evento""><img src=""img/logo.png"" style=""width: 50px;border-top-style: solid;border-top-width: 0px;""></span></td>
                    <td class=""dia"">23</td>
                 ");
            WriteLiteral(@"   <td class=""dia"">24</td>
                    <td class=""dia"">25<span class=""evento""></span></td>
                    <td class=""dia"">26</td>
                    <td class=""dia"">27<span class=""evento""></span></td>
                    <td class=""dia"">28</td>

                </tr>

            </tbody>

        </table>

    </div>
     <div id=""shows"">
        

        
        <ul>
                
            <li> Dia 01/09 </li>
            <p> Show do Juscelino da pisadinha</p>
            
            
            <li> Dia 05/09 </li>
            <p> Show do Bona do arrocha</p>
            
            <li> Dia 11/09 </li>
                <p> Festa do João</p>
                
                
                <li> Dia 15/09 </li>
                <p> Show do Travis Scott</p>
                
                
                <li> Dia 18/09 </li>
                <p> Evento privado </p>
            </ul>
        </div>
    </main> ");
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
