#pragma checksum "C:\Users\36591349880\Desktop\MVCSenai\MVC2\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e0b502054d26134bcb74a242948953d1e18f139"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\Users\36591349880\Desktop\MVCSenai\MVC2\Views\_ViewImports.cshtml"
using MVC2;

#line default
#line hidden
#line 2 "C:\Users\36591349880\Desktop\MVCSenai\MVC2\Views\_ViewImports.cshtml"
using MVC2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e0b502054d26134bcb74a242948953d1e18f139", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f29d135cc71deb2edc8d6b3a6cb1ab3f95ba2ade", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC2.ViewModels.RespostaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 16, true);
            WriteLiteral("<main>\r\n    <h2>");
            EndContext();
            BeginContext(59, 14, false);
#line 3 "C:\Users\36591349880\Desktop\MVCSenai\MVC2\Views\Shared\Error.cshtml"
   Write(Model.NomeView);

#line default
#line hidden
            EndContext();
            BeginContext(73, 60, true);
            WriteLiteral(" Dados inválidos, reveja os blocos! </h2>\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(134, 14, false);
#line 5 "C:\Users\36591349880\Desktop\MVCSenai\MVC2\Views\Shared\Error.cshtml"
   Write(Model.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(148, 19, true);
            WriteLiteral("\r\n    </p>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC2.ViewModels.RespostaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591