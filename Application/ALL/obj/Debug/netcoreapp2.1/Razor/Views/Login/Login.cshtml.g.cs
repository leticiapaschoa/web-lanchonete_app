#pragma checksum "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48e7b419365c77c584c29ff6f86bace14c19b46f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Login.cshtml", typeof(AspNetCore.Views_Login_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48e7b419365c77c584c29ff6f86bace14c19b46f", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90597326e78a91b250c66ab392edcec7e0539320", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/login.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("txt1 bo1 hov1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(62, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 75, "\"", 121, 1);
#line 7 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 81, Url.Content("~/js/jquery-3.2.1.min.js"), 81, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(122, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 145, "\"", 185, 1);
#line 8 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 151, Url.Content("~/js/popper.min.js"), 151, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(186, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 209, "\"", 252, 1);
#line 9 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 215, Url.Content("~/js/bootstrap.min.js"), 215, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(253, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 276, "\"", 322, 1);
#line 10 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 282, Url.Content("~/js/owl.carousel.min.js"), 282, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(323, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 346, "\"", 396, 1);
#line 11 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 352, Url.Content("~/js/jquery.waypoints.min.js"), 352, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(397, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 420, "\"", 453, 1);
#line 12 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 426, Url.Content("~/js/aos.js"), 426, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(454, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 477, "\"", 532, 1);
#line 13 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 483, Url.Content("~/js/jquery.magnific-popup.min.js"), 483, 49, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(533, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 556, "\"", 608, 1);
#line 14 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 562, Url.Content("~/js/magnific-popup-options.js"), 562, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(609, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 632, "\"", 666, 1);
#line 15 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 638, Url.Content("~/js/main.js"), 638, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(667, 16, true);
                WriteLiteral("></script>\r\n    ");
                EndContext();
                BeginContext(683, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cc8f0fabec124919b6c738a3b7017958", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(731, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(736, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 21 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
 if (ViewBag.Usuario == null || ViewBag.UsuarioInvalido == true)
{

#line default
#line hidden
            BeginContext(811, 668, true);
            WriteLiteral(@"    <div>
        <section>
            <div style=""background-image: url('https://www.foodiesfeed.com/wp-content/uploads/2019/02/messy-pizza-on-a-black-table.jpg'); background-repeat: no-repeat; background-position: center; background-size: cover"">
                <div class=""container"">
                    <div class=""row slider-text align-items-center justify-content-center"">
                        <div class=""col-md-8 text-center col-sm-12 "">
                            <div class=""limiter"">
                                <div class=""container-login100"">
                                    <div class=""wrap-login100 p-l-50 p-r-50 p-t-77 p-b-30"">
");
            EndContext();
#line 32 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
                                         if (ViewBag.UsuarioInvalido == true)
                                        {

#line default
#line hidden
            BeginContext(1601, 199, true);
            WriteLiteral("                                            <div>\r\n                                                Usuário e/ou senha inválidos. Tente novamente.\r\n                                            </div>\r\n");
            EndContext();
#line 37 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
                                        }

#line default
#line hidden
            BeginContext(1843, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(1879, 2278, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8129bbff086740e3a42c99fd6dee822d", async() => {
                BeginContext(1935, 1945, true);
                WriteLiteral(@"

                                        <div class=""wrap-input100 validate-input m-b-16"">
                                            <input class=""input100"" type=""text"" name=""Login"" placeholder=""Digite o login"" required>
                                            <span class=""focus-input100""></span>
                                            <span class=""symbol-input100"">
                                                <span class=""lnr lnr-envelope""></span>
                                            </span>
                                        </div>

                                        <div class=""wrap-input100 validate-input m-b-16"">
                                            <input class=""input100"" type=""password"" name=""Senha"" placeholder=""Digite a senha"" required>
                                            <span class=""focus-input100""></span>
                                            <span class=""symbol-input100"">
                                                <span class=""");
                WriteLiteral(@"lnr lnr-lock""></span>
                                            </span>
                                        </div>
                                        <br /><br /><br /><br />
                                        <div class=""container-login100-form-btn p-t-25"">
                                            <button class=""login100-form-btn"">
                                                Login
                                            </button>
                                        </div>
                                        <br /><br /><br /><br />
                                        <div class=""text-center w-full p-t-115"" style=""padding-left:5%"">
                                            <span class=""txt1"">
                                                Não é cadastrado?
                                            </span>

                                            ");
                EndContext();
                BeginContext(3880, 184, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abda3aef17114cef9793fa80e230ff42", async() => {
                    BeginContext(3953, 107, true);
                    WriteLiteral("\r\n                                                Cadastre-se\r\n                                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4064, 86, true);
                WriteLiteral("\r\n                                        </div>\r\n                                    ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4157, 287, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- END slider -->
    </div>
");
            EndContext();
#line 82 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
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
