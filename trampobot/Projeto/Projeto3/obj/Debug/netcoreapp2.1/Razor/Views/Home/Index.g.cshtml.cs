#pragma checksum "C:\Users\11720472\Desktop\trampobot\Projeto\Projeto3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae5deda6c8b87e9d710a6474685aeca0c001f02c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\11720472\Desktop\trampobot\Projeto\Projeto3\Views\_ViewImports.cshtml"
using Projeto3;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae5deda6c8b87e9d710a6474685aeca0c001f02c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36e14127b1a680bde2a920d6016a167927e9bc00", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\11720472\Desktop\trampobot\Projeto\Projeto3\Views\Home\Index.cshtml"
  
	ViewBag.Titulo = "Projeto 3";

#line default
#line hidden
            BeginContext(39, 67, true);
            WriteLiteral("\r\n<h1>Um título</h1>\r\n<p>Oi mundo! Recebemos a seguinte descrição: ");
            EndContext();
            BeginContext(107, 17, false);
#line 6 "C:\Users\11720472\Desktop\trampobot\Projeto\Projeto3\Views\Home\Index.cshtml"
                                        Write(ViewBag.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(124, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\11720472\Desktop\trampobot\Projeto\Projeto3\Views\Home\Index.cshtml"
 if (ViewBag.Liberado == true) {

#line default
#line hidden
            BeginContext(166, 35, true);
            WriteLiteral("\t<p>Seu acesso está liberado!</p>\r\n");
            EndContext();
#line 10 "C:\Users\11720472\Desktop\trampobot\Projeto\Projeto3\Views\Home\Index.cshtml"
} else {

#line default
#line hidden
            BeginContext(211, 26, true);
            WriteLiteral("\t<p>Acesso proibido!</p>\r\n");
            EndContext();
#line 12 "C:\Users\11720472\Desktop\trampobot\Projeto\Projeto3\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(240, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\11720472\Desktop\trampobot\Projeto\Projeto3\Views\Home\Index.cshtml"
 for (int contador = 0; contador < ViewBag.QuantidadeDeRepeticoes; contador++) {
	// Essa região é código em C#, repararam que até o comentário mudou?
	// Para efetivamente escrever algo no HTML, devemos uma uma tag qualquer, como p ou div
	// Mas, professor, e se eu realmente quisesse escrever algo que não fosse uma tag...?!?!
	// Bem... aí você precisaria utilizar uma tag especial ;)

	

#line default
#line hidden
            BeginContext(645, 19, true);
            WriteLiteral("Isso não é uma tag!");
            EndContext();
#line 20 "C:\Users\11720472\Desktop\trampobot\Projeto\Projeto3\Views\Home\Index.cshtml"
                                    

	if (contador % 2 == 0) {

#line default
#line hidden
            BeginContext(702, 9, true);
            WriteLiteral("\t\t<p>Par ");
            EndContext();
            BeginContext(712, 8, false);
#line 23 "C:\Users\11720472\Desktop\trampobot\Projeto\Projeto3\Views\Home\Index.cshtml"
          Write(contador);

#line default
#line hidden
            EndContext();
            BeginContext(720, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 24 "C:\Users\11720472\Desktop\trampobot\Projeto\Projeto3\Views\Home\Index.cshtml"
	} else {

#line default
#line hidden
            BeginContext(737, 11, true);
            WriteLiteral("\t\t<p>Ímpar ");
            EndContext();
            BeginContext(749, 8, false);
#line 25 "C:\Users\11720472\Desktop\trampobot\Projeto\Projeto3\Views\Home\Index.cshtml"
            Write(contador);

#line default
#line hidden
            EndContext();
            BeginContext(757, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 26 "C:\Users\11720472\Desktop\trampobot\Projeto\Projeto3\Views\Home\Index.cshtml"
	}
}

#line default
#line hidden
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