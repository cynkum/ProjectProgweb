#pragma checksum "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Registrasi\Tampil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b26fccc568c7a97a14f726c171d917df7f6d5e20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registrasi_Tampil), @"mvc.1.0.view", @"/Views/Registrasi/Tampil.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Registrasi/Tampil.cshtml", typeof(AspNetCore.Views_Registrasi_Tampil))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b26fccc568c7a97a14f726c171d917df7f6d5e20", @"/Views/Registrasi/Tampil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26753fabc27feb7accb4d4ca79c9e9c5c3ddb510", @"/Views/_ViewImports.cshtml")]
    public class Views_Registrasi_Tampil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Registrasi\Tampil.cshtml"
  
   Layout = "_Layout"; 

   string nama = "Erick";
   string alamat = "Jl Mangga 11";

   int bil1 = 11;
   int bil2 = 12;
   int hasil = bil1+bil2;

#line default
#line hidden
            BeginContext(154, 29, true);
            WriteLiteral("\n<h2>Detail Anggota</h2>\n\n<p>");
            EndContext();
            BeginContext(184, 4, false);
#line 14 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Registrasi\Tampil.cshtml"
Write(nama);

#line default
#line hidden
            EndContext();
            BeginContext(188, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(190, 6, false);
#line 14 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Registrasi\Tampil.cshtml"
    Write(alamat);

#line default
#line hidden
            EndContext();
            BeginContext(196, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(205, 4, false);
#line 15 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Registrasi\Tampil.cshtml"
Write(bil1);

#line default
#line hidden
            EndContext();
            BeginContext(209, 3, true);
            WriteLiteral(" + ");
            EndContext();
            BeginContext(213, 4, false);
#line 15 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Registrasi\Tampil.cshtml"
      Write(bil2);

#line default
#line hidden
            EndContext();
            BeginContext(217, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(221, 5, false);
#line 15 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Registrasi\Tampil.cshtml"
              Write(hasil);

#line default
#line hidden
            EndContext();
            BeginContext(226, 15, true);
            WriteLiteral("</p>\n<p>Name : ");
            EndContext();
            BeginContext(242, 15, false);
#line 16 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Registrasi\Tampil.cshtml"
     Write(Model.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(257, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(259, 14, false);
#line 16 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Registrasi\Tampil.cshtml"
                      Write(Model.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(273, 18, true);
            WriteLiteral("</p>\n<p>Address : ");
            EndContext();
            BeginContext(292, 13, false);
#line 17 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Registrasi\Tampil.cshtml"
        Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(305, 15, true);
            WriteLiteral("</p>\n<p>Telp : ");
            EndContext();
            BeginContext(321, 10, false);
#line 18 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Registrasi\Tampil.cshtml"
     Write(Model.Telp);

#line default
#line hidden
            EndContext();
            BeginContext(331, 4, true);
            WriteLiteral("</p>");
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
