#pragma checksum "C:\Users\AAIO\My Private Documents\Curso-MVC\TreinoMVC\Views\Contatos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5504d67722ae7c792aaf98ef92a5d03533760fa7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contatos_Index), @"mvc.1.0.view", @"/Views/Contatos/Index.cshtml")]
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
#line 1 "C:\Users\AAIO\My Private Documents\Curso-MVC\TreinoMVC\Views\_ViewImports.cshtml"
using TreinoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AAIO\My Private Documents\Curso-MVC\TreinoMVC\Views\_ViewImports.cshtml"
using TreinoMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5504d67722ae7c792aaf98ef92a5d03533760fa7", @"/Views/Contatos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23b9fcceae2ea85f4853a68f70e424e2c282d711", @"/Views/_ViewImports.cshtml")]
    public class Views_Contatos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TreinoMVC.Models.Contato>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    \n    <h2>Todos os contatos</h2>\n    <a href=\"/Contatos/Cadastrar\" class=\"btn btn-primary\" type=\"submit\">Novo Contato</a>\n    <a href=\"/Contatos/Categoria\" class=\"btn btn-primary\" type=\"submit\">Categorias</a>\n   <hr>\n    \n   \n");
#nullable restore
#line 9 "C:\Users\AAIO\My Private Documents\Curso-MVC\TreinoMVC\Views\Contatos\Index.cshtml"
   foreach (var contato in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Nome: ");
#nullable restore
#line 11 "C:\Users\AAIO\My Private Documents\Curso-MVC\TreinoMVC\Views\Contatos\Index.cshtml"
        Write(contato.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Categoria: ");
#nullable restore
#line 12 "C:\Users\AAIO\My Private Documents\Curso-MVC\TreinoMVC\Views\Contatos\Index.cshtml"
             Write(contato.Categoria.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Email: ");
#nullable restore
#line 13 "C:\Users\AAIO\My Private Documents\Curso-MVC\TreinoMVC\Views\Contatos\Index.cshtml"
         Write(contato.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Telefone: ");
#nullable restore
#line 14 "C:\Users\AAIO\My Private Documents\Curso-MVC\TreinoMVC\Views\Contatos\Index.cshtml"
            Write(contato.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 466, "\"", 508, 2);
            WriteAttributeValue("", 473, "/Contatos/EditarContato/", 473, 24, true);
#nullable restore
#line 16 "C:\Users\AAIO\My Private Documents\Curso-MVC\TreinoMVC\Views\Contatos\Index.cshtml"
WriteAttributeValue("", 497, contato.Id, 497, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Editar</a>\n    <a");
            BeginWriteAttribute("href", " href=\"", 551, "\"", 587, 2);
            WriteAttributeValue("", 558, "/Contatos/Deletar/", 558, 18, true);
#nullable restore
#line 17 "C:\Users\AAIO\My Private Documents\Curso-MVC\TreinoMVC\Views\Contatos\Index.cshtml"
WriteAttributeValue("", 576, contato.Id, 576, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Deletar</a>\n    <hr>\n");
#nullable restore
#line 19 "C:\Users\AAIO\My Private Documents\Curso-MVC\TreinoMVC\Views\Contatos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TreinoMVC.Models.Contato>> Html { get; private set; }
    }
}
#pragma warning restore 1591
