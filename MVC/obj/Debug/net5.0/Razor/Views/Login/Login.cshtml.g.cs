#pragma checksum "C:\Users\kubra\Desktop\DemoCore\MVC\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "891d53006cc6de3682d8cc4e216cfa3786909781"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
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
#line 1 "C:\Users\kubra\Desktop\DemoCore\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kubra\Desktop\DemoCore\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"891d53006cc6de3682d8cc4e216cfa3786909781", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\kubra\Desktop\DemoCore\MVC\Views\Login\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/BlogLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"main-content-w3layouts-agileits\">\r\n\t<div class=\"container\">\r\n\t\t<h3 class=\"tittle\">Giriş Yap</h3>\r\n\t\t<div class=\"row inner-sec\">\r\n\t\t\t<div class=\"login p-5 bg-light mx-auto mw-100\">\r\n");
#nullable restore
#line 12 "C:\Users\kubra\Desktop\DemoCore\MVC\Views\Login\Login.cshtml"
                 using (Html.BeginForm("Login","Login",FormMethod.Post))
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t<label for=\"exampleInputEmail1 mb-2\">Email</label>\r\n\t\t\t\t\t<input type=\"email\" class=\"form-control\" id=\"exampleInputEmail1\" aria-describedby=\"emailHelp\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 547, "\"", 561, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 562, "\"", 573, 0);
            EndWriteAttribute();
            WriteLiteral(@">
					<small id=""emailHelp"" class=""form-text text-muted"">Mailini kimseyle paylaşmayacağız.</small>
					</div>
					<div class=""form-group"">
						<label for=""exampleInputPassword1 mb-2"">Şifre</label>
						<input type=""password"" class=""form-control"" id=""exampleInputPassword1""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 857, "\"", 871, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 872, "\"", 883, 0);
            EndWriteAttribute();
            WriteLiteral(@">
					</div>
					<div class=""form-check mb-2"">
						<input type=""checkbox"" class=""form-check-input"" id=""exampleCheck1"">
						<label class=""form-check-label"" for=""exampleCheck1"">Check me out</label>
					</div>
					<button type=""submit"" class=""btn btn-primary submit mb-4"">Sign In</button>
					<p><a href=""/Register/Register""> Hesabın yok mu?</a></p>
");
#nullable restore
#line 29 "C:\Users\kubra\Desktop\DemoCore\MVC\Views\Login\Login.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
