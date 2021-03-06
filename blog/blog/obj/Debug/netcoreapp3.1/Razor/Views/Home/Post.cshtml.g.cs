#pragma checksum "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fa6c795bc4e198f970bb409ab6684b61d9f67e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
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
#line 2 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\_ViewImports.cshtml"
using blog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\_ViewImports.cshtml"
using blog.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\_ViewImports.cshtml"
using blog.Models.Comments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fa6c795bc4e198f970bb409ab6684b61d9f67e2", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88818350cff396ac37e9ef1b6a88c9535c2893b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sublinhado"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavBar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/nav.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
  
    ViewBag.Title = Model.Title;
    ViewBag.Description = Model.Description;
    ViewBag.Keywords = $"{Model.Tags?.Replace(",", " ")} {Model.Category}";
    var data = Model.Created.ToString("d MMMM, yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"progress-container\">\r\n    <div class=\"progress-bar\" id=\"myBar\"></div>\r\n</div>\r\n<article>\r\n    <article>\r\n        <div class=\"titulo\">");
#nullable restore
#line 13 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"sub-titulo\">");
#nullable restore
#line 14 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
                           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"data\"><em>");
#nullable restore
#line 15 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
                         Write(data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em></div>\r\n    </article>\r\n");
#nullable restore
#line 17 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
     if (!String.IsNullOrEmpty(Model.Image))
    {
        var img_path = $"/Image/{Model.Image}";


#line default
#line hidden
#nullable disable
            WriteLiteral("        <figure class=\"size-4\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 717, "\"", 732, 1);
#nullable restore
#line 22 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
WriteAttributeValue("", 723, img_path, 723, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </figure>\r\n");
#nullable restore
#line 24 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
        if (!String.IsNullOrEmpty(Model.Legend))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <figcaption>\r\n                <div class=\"legenda\"><p>");
#nullable restore
#line 27 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
                                   Write(Model.Legend);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n            </figcaption>\r\n");
#nullable restore
#line 29 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <article class=\"texto\">\r\n        <p>\r\n            <div class=\"post-body\">\r\n                ");
#nullable restore
#line 34 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
           Write(Html.Raw(@Model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </p>
        <div class=""redes-sociais"">
            <a href=""https://www.facebook.com/sharer/sharer.php?u=#""><i class=""fab fa-facebook-square""></i></a>
            <a href=""https://api.whatsapp.com/send?text=""><i class=""fab fa-whatsapp-square""></i></a>
            <a href=""https://www.linkedin.com/shareArticle?mini=true&url=#""><i class=""fab fa-linkedin""></i></a>
        </div>

        <div class=""coment-titulo"">Coment??rios</div>
");
#nullable restore
#line 44 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"comment-section\">\r\n");
#nullable restore
#line 47 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
                  
                    await Html.RenderPartialAsync("_MainComment", new CommentViewModel { Postid = Model.id, MainCommentId = 0 });
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
                 foreach (var c in Model.MainComments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"margin-bottom: 2rem\">\r\n                        <p class=\"main-coment\">\r\n                            ");
#nullable restore
#line 54 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
                       Write(c.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ----- ");
#nullable restore
#line 54 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
                                        Write(c.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <div style=\"margin-left: 30px !important\">\r\n");
#nullable restore
#line 57 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
                              
                                await Html.RenderPartialAsync("_MainComment", new CommentViewModel { Postid = Model.id, MainCommentId = c.Id });
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
                             foreach (var sc in c.SubComments)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p sub-coment>\r\n                                    ");
#nullable restore
#line 63 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
                               Write(sc.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ----- ");
#nullable restore
#line 63 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
                                                 Write(sc.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n");
#nullable restore
#line 65 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 68 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 71 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fa6c795bc4e198f970bb409ab6684b61d9f67e213062", async() => {
                WriteLiteral("Entre na sua conta");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" para comentar\r\n            </div>\r\n");
#nullable restore
#line 77 "C:\Users\Usuario\Documents\blog\blog-.net\blog\blog\Views\Home\Post.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </article>\r\n</article>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2fa6c795bc4e198f970bb409ab6684b61d9f67e214789", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fa6c795bc4e198f970bb409ab6684b61d9f67e215906", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fa6c795bc4e198f970bb409ab6684b61d9f67e216946", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
