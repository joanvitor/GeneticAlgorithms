#pragma checksum "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e27c4ac7f2a38789eb1f363f15629ff39356562a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Horario_Index), @"mvc.1.0.view", @"/Views/Horario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Horario/Index.cshtml", typeof(AspNetCore.Views_Horario_Index))]
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
#line 1 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\_ViewImports.cshtml"
using WEB;

#line default
#line hidden
#line 2 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\_ViewImports.cshtml"
using WEB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27c4ac7f2a38789eb1f363f15629ff39356562a", @"/Views/Horario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1a2867d427831583d00e3f9ae1a2cabe8b362bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Horario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Horario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Horario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(79, 9, true);
            WriteLiteral("<p>\r\n    ");
            EndContext();
            BeginContext(88, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e27c4ac7f2a38789eb1f363f15629ff39356562a4660", async() => {
                BeginContext(163, 12, true);
                WriteLiteral("Novo Horário");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(179, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
#line 9 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml"
 if (Model == null)
{

#line default
#line hidden
            BeginContext(211, 45, true);
            WriteLiteral("    <p> Não existe horário cadastrado !</p>\r\n");
            EndContext();
#line 12 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(268, 104, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(373, 38, false);
#line 19 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(411, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(479, 46, false);
#line 22 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Disciplina));

#line default
#line hidden
            EndContext();
            BeginContext(525, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(593, 56, false);
#line 25 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Disciplina.Professor));

#line default
#line hidden
            EndContext();
            BeginContext(649, 186, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Ano / Periodo\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 34 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(892, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(965, 37, false);
#line 38 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1082, 50, false);
#line 41 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Disciplina.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1132, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1212, 60, false);
#line 44 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Disciplina.Professor.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1352, 46, false);
#line 47 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Ano.Periodo));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 28, true);
            WriteLiteral(" /\r\n                        ");
            EndContext();
            BeginContext(1427, 53, false);
#line 48 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Disciplina.Periodo));

#line default
#line hidden
            EndContext();
            BeginContext(1480, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1560, 65, false);
#line 51 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1625, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1654, 71, false);
#line 52 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1725, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1754, 69, false);
#line 53 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1823, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 56 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1890, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 59 "D:\JOAN VITOR\UFS\8º PERIODO\INTELIGENCIA ARTIFICIAL\2º UNIDADE\PROJETO\GeneticAlgorithms\AlgoritmoGenetico\WEB\Views\Horario\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Horario>> Html { get; private set; }
    }
}
#pragma warning restore 1591