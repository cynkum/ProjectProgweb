#pragma checksum "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Pengguna\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "356f1add6fed4e299f18ed3f6734f2c2d6a2df8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pengguna_Index), @"mvc.1.0.view", @"/Views/Pengguna/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pengguna/Index.cshtml", typeof(AspNetCore.Views_Pengguna_Index))]
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
#line 1 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\_ViewImports.cshtml"
using SampleASPCore;

#line default
#line hidden
#line 2 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\_ViewImports.cshtml"
using SampleASPCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"356f1add6fed4e299f18ed3f6734f2c2d6a2df8b", @"/Views/Pengguna/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26753fabc27feb7accb4d4ca79c9e9c5c3ddb510", @"/Views/_ViewImports.cshtml")]
    public class Views_Pengguna_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SampleASPCore.Models.Pengguna>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registrasi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Pengguna\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(83, 38, true);
            WriteLiteral(" <h2>Form Registrasi</h2><br/><br/>\r\n ");
            EndContext();
            BeginContext(121, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "356f1add6fed4e299f18ed3f6734f2c2d6a2df8b4074", async() => {
                BeginContext(172, 11, true);
                WriteLiteral("Tambah Data");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(187, 29, true);
            WriteLiteral("\r\n <br/>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 9 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Pengguna\Index.cshtml"
 if(ViewData["pesan"]!=null){
    

#line default
#line hidden
            BeginContext(252, 27, false);
#line 10 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Pengguna\Index.cshtml"
Write(Html.Raw(ViewData["pesan"]));

#line default
#line hidden
            EndContext();
#line 10 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Pengguna\Index.cshtml"
                                
}

#line default
#line hidden
            BeginContext(284, 225, true);
            WriteLiteral("<br/><br/>\r\n</div>\r\n<div class=\"row\">\r\n\r\n<table class=\"table table-stripped\">\r\n    <tr>\r\n        <th>Username</th>\r\n        <th>Password</th>\r\n        <th>Aturan</th>\r\n        <th>Nama</th>\r\n        <th>Telp</th>\r\n    </tr>\r\n");
            EndContext();
#line 24 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Pengguna\Index.cshtml"
     foreach(var data in Model){

#line default
#line hidden
            BeginContext(543, 26, true);
            WriteLiteral("        <tr>\r\n        <td>");
            EndContext();
            BeginContext(570, 13, false);
#line 26 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Pengguna\Index.cshtml"
       Write(data.Username);

#line default
#line hidden
            EndContext();
            BeginContext(583, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(603, 13, false);
#line 27 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Pengguna\Index.cshtml"
       Write(data.Password);

#line default
#line hidden
            EndContext();
            BeginContext(616, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(636, 11, false);
#line 28 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Pengguna\Index.cshtml"
       Write(data.Aturan);

#line default
#line hidden
            EndContext();
            BeginContext(647, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(667, 9, false);
#line 29 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Pengguna\Index.cshtml"
       Write(data.Nama);

#line default
#line hidden
            EndContext();
            BeginContext(676, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(696, 9, false);
#line 30 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Pengguna\Index.cshtml"
       Write(data.Telp);

#line default
#line hidden
            EndContext();
            BeginContext(705, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 32 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Pengguna\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(734, 16, true);
            WriteLiteral("</table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SampleASPCore.Models.Pengguna>> Html { get; private set; }
    }
}
#pragma warning restore 1591