#pragma checksum "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f555be85c9826efa23675bf0697a8103d2d6e9ed"
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
#line 1 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\_ViewImports.cshtml"
using ALL;

#line default
#line hidden
#line 2 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\_ViewImports.cshtml"
using ALL.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f555be85c9826efa23675bf0697a8103d2d6e9ed", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90597326e78a91b250c66ab392edcec7e0539320", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/lanche1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(66, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 79, "\"", 125, 1);
#line 7 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Home\Index.cshtml"
WriteAttributeValue("", 85, Url.Content("~/js/jquery-3.2.1.min.js"), 85, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(126, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 149, "\"", 189, 1);
#line 8 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Home\Index.cshtml"
WriteAttributeValue("", 155, Url.Content("~/js/popper.min.js"), 155, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(190, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 213, "\"", 256, 1);
#line 9 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Home\Index.cshtml"
WriteAttributeValue("", 219, Url.Content("~/js/bootstrap.min.js"), 219, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(257, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 280, "\"", 326, 1);
#line 10 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Home\Index.cshtml"
WriteAttributeValue("", 286, Url.Content("~/js/owl.carousel.min.js"), 286, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(327, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 350, "\"", 400, 1);
#line 11 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Home\Index.cshtml"
WriteAttributeValue("", 356, Url.Content("~/js/jquery.waypoints.min.js"), 356, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(401, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 424, "\"", 457, 1);
#line 12 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Home\Index.cshtml"
WriteAttributeValue("", 430, Url.Content("~/js/aos.js"), 430, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(458, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 481, "\"", 536, 1);
#line 13 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Home\Index.cshtml"
WriteAttributeValue("", 487, Url.Content("~/js/jquery.magnific-popup.min.js"), 487, 49, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(537, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 560, "\"", 612, 1);
#line 14 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Home\Index.cshtml"
WriteAttributeValue("", 566, Url.Content("~/js/magnific-popup-options.js"), 566, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(613, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 636, "\"", 670, 1);
#line 15 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Home\Index.cshtml"
WriteAttributeValue("", 642, Url.Content("~/js/main.js"), 642, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(671, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            BeginContext(686, 1769, true);
            WriteLiteral(@"

<div class=""slider-wrap"">
    <section class=""home-slider owl-carousel"">


        <div class=""slider-item"" style=""background-image: url('https://images.unsplash.com/photo-1477617722074-45613a51bf6d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=750&q=80');"">
            <div class=""container"">
                <div class=""row slider-text align-items-center justify-content-center"">
                    <div class=""col-md-8 text-center col-sm-12 "">
                        <h1 data-aos=""fade-up mb-5"">A sua lanchonete online</h1>
                        <p data-aos=""fade-up"" data-aos-delay=""200""><a href=""#"" class=""btn btn-white btn-outline-white"">Login</a></p>
                    </div>
                </div>
            </div>
        </div>

        <div class=""slider-item"" style=""background-image: url('https://images.unsplash.com/photo-1466978913421-dad2ebd01d17?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=667&q=80');"">
            <div class=""container"">
            WriteLiteral(@"
                <div class=""row slider-text align-items-center justify-content-center"">
                    <div class=""col-md-8 text-center col-sm-12 "">
                        <h1 data-aos=""fade-up mb-5"">Não tem nada melhor, do que fazer outra pessoa feliz com comida</h1>
                        <p data-aos=""fade-up"" data-aos-delay=""200""><a href=""#"" class=""btn btn-white btn-outline-white"">Login</a></p>
                    </div>
                </div>
            </div>
        </div>

    </section>
    <!-- END slider -->
</div>


<section class=""section bg-light py-5  bottom-slant-gray"">
    <div class=""container"">
        <div class=""row align-items-center"">

            <div class=""col-lg-6"">
                ");
            EndContext();
            BeginContext(2455, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a23b8923d46442d08a2beea4d8df6575", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2517, 2824, true);
            WriteLiteral(@"
            </div>
            <div class=""col-lg-5 ml-auto"">
                <div class=""text-left heading-wrap"">
                    <h2 data-aos=""fade-up"">ALL - Lanchonete</h2>
                </div>
                <p>O grupo ALL apresenta um novo conceito de lanchonete. Escolha o seu lanche antes de chegar ao nosso estabelecimento e evite filas.</p>
                <p>O pagamento poderá ser realizado no estabelecimento, após o seu consumo. Convide os amigos, estamos te esperando! </p>
            </div>

        </div>
    </div>
</section>

<section class=""section relative-higher"">

    <div class=""clearfix mb-5 pb-5"">
        <div class=""container-fluid"">
            <div class=""row"" data-aos=""fade"">
                <div class=""col-md-12 text-center heading-wrap"">
                    <h2>Comentários</h2>
                </div>
            </div>
        </div>
    </div>

    <div class=""container"">

        <div class=""row justify-content-center"">
            <div class=""");
            WriteLiteral(@"col-lg-7"">
                <div class=""owl-carousel centernonloop2"">
                    <div class=""slide"" data-aos=""fade-left"" data-aos-delay=""100"">
                        <blockquote class=""testimonial"">
                            <p>&ldquo; ALL é a melhor lanchonete que já frequentei. O ambiente é lindo, super aconchegante, funcionários muito atenciosos! &rdquo;</p>
                            <div class=""d-flex author"">
                                <div class=""author-info"">
                                    <h4>Luiz Felipe Duarte</h4>
                                    <p>Estudante</p>
                                </div>
                            </div>
                        </blockquote>
                    </div>
                    <div class=""slide"" data-aos=""fade-left"" data-aos-delay=""200"">
                        <blockquote class=""testimonial"">
                            <p>
                                &ldquo; Boa opção para um jantar entre amigos ou família.
 ");
            WriteLiteral(@"                               Cardápio com opções variadas para todos os gostos. Atendimento excelente e muito atencioso.
                                Vale a pedida dos burgues que são bem preparados e servidos.
                                Para conhecer, vale a pena!&rdquo;
                            </p>
                            <div class=""d-flex author"">
                                <div class=""author-info"">
                                    <h4>Augusto Mateus</h4>
                                    <p>Estudante</p>
                                </div>
                            </div>
                        </blockquote>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>");
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