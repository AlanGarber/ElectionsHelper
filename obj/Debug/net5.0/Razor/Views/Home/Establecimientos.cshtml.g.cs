#pragma checksum "C:\Users\46024452\Desktop\TP_Padron_Blaser_Garber\Views\Home\Establecimientos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e34cb6a569d18c021d40c8f5830764b9d133a11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Establecimientos), @"mvc.1.0.view", @"/Views/Home/Establecimientos.cshtml")]
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
#line 1 "C:\Users\46024452\Desktop\TP_Padron_Blaser_Garber\Views\_ViewImports.cshtml"
using TP_Padron_Blaser_Garber;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\46024452\Desktop\TP_Padron_Blaser_Garber\Views\_ViewImports.cshtml"
using TP_Padron_Blaser_Garber.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e34cb6a569d18c021d40c8f5830764b9d133a11", @"/Views/Home/Establecimientos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec853d8d338d2b16a43d976d9df7ca242ab98669", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Establecimientos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\46024452\Desktop\TP_Padron_Blaser_Garber\Views\Home\Establecimientos.cshtml"
  
    ViewData["Title"] = "Establecimientos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e34cb6a569d18c021d40c8f5830764b9d133a113352", async() => {
                WriteLiteral(@"
    <div class=""container-fluid"">
        <div style=""margin-top: 20%;"">
            <div class=""row row-cols-1 row-cols-md-2"">
                    <div class=""col-md-3"">
                        <div class=""card"">
                            <img src=""/media/ort.jpg"" class=""card-img-top"" alt=""..."" style=""width: 15.30rem; height:12rem;"">
                                <div class=""card-body"">
                                    <h5 class=""card-title"" style=""text-align: center;"">Escuela Tecnica<br>ORT</h5>
                                    <p style=""text-align: center;"">Yatay 240</p>
                                    <p style=""text-align: center;""><a");
                BeginWriteAttribute("href", " href=\'", 731, "\'", 791, 1);
#nullable restore
#line 15 "C:\Users\46024452\Desktop\TP_Padron_Blaser_Garber\Views\Home\Establecimientos.cshtml"
WriteAttributeValue("", 738, Url.Action("VXE","Home", new {IdEstablecimiento=1} ), 738, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""button"" class=""btn btn-primary"">Ver votantes</a></p>
                                </div>
                        </div>
                    </div>
                <div class=""col-md-3"">
                    <div class=""card"">
                        <img src=""/media/belgrano.jpg"" class=""card-img-top"" alt=""..."" style=""width: 15.30rem; height:12rem;"">
                            <div class=""card-body"">
                                <h5 class=""card-title"" style=""text-align: center;"">Colegio Manuel Belgrano</h5>
                                <p style=""text-align: center;"">Lavalle 759</p>
                                <p style=""text-align: center;""><a");
                BeginWriteAttribute("href", " href=\'", 1471, "\'", 1529, 1);
#nullable restore
#line 25 "C:\Users\46024452\Desktop\TP_Padron_Blaser_Garber\Views\Home\Establecimientos.cshtml"
WriteAttributeValue("", 1478, Url.Action("VXE","Home", new{IdEstablecimiento=2}), 1478, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""button"" class=""btn btn-primary"">Ver votantes</a></p>
                            </div>
                    </div>
                </div>
                <div class=""col-md-3"">
                    <div class=""card"">
                        <img src=""/media/fausto.jpg"" class=""card-img-top"" alt=""..."" style=""width: 15.30rem; height:12rem;"">
                            <div class=""card-body"">
                                <h5 class=""card-title"" style=""text-align: center;"">Escuela Domingo Faustino Sarmiento</h5>
                                <p style=""text-align: center;"">Nazca 1122</p>
                                <p style=""text-align: center;""><a");
                BeginWriteAttribute("href", " href=\'", 2205, "\'", 2263, 1);
#nullable restore
#line 35 "C:\Users\46024452\Desktop\TP_Padron_Blaser_Garber\Views\Home\Establecimientos.cshtml"
WriteAttributeValue("", 2212, Url.Action("VXE","Home", new{IdEstablecimiento=3}), 2212, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""button"" class=""btn btn-primary"">Ver votantes</a></p>
                            </div>
                    </div>
                </div>
                <div class=""col-md-3"">
                    <div class=""card"">
                        <img src=""/media/mise.jpg"" class=""card-img-top"" alt=""..."" style=""width: 15.30rem; height:12rem;"">
                            <div class=""card-body"">
                                <h5 class=""card-title"" style=""text-align: center;"">Colegio Nuestra Sra Misericordia</h5>
                                <p style=""text-align: center;"">Sanabria 2900</p>
                                <p style=""text-align: center;""><a");
                BeginWriteAttribute("href", " href=\'", 2938, "\'", 2996, 1);
#nullable restore
#line 45 "C:\Users\46024452\Desktop\TP_Padron_Blaser_Garber\Views\Home\Establecimientos.cshtml"
WriteAttributeValue("", 2945, Url.Action("VXE","Home", new{IdEstablecimiento=4}), 2945, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"button\" class=\"btn btn-primary\">Ver votantes</a></p>\r\n                            </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591