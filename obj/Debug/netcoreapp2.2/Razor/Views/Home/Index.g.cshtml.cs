#pragma checksum "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db59026ca3c6b61aa97b60c8b06d102ae6278979"
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
#line 1 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\_ViewImports.cshtml"
using SampleASPCore;

#line default
#line hidden
#line 2 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\_ViewImports.cshtml"
using SampleASPCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db59026ca3c6b61aa97b60c8b06d102ae6278979", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26753fabc27feb7accb4d4ca79c9e9c5c3ddb510", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 59, true);
            WriteLiteral("\n <h1>Selamat Datang di Home Page</h1>\n \n<div class=\"row\">\n");
            EndContext();
#line 8 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Home\Index.cshtml"
 if(ViewData["pesan"]!=null){
    

#line default
#line hidden
            BeginContext(123, 27, false);
#line 9 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Home\Index.cshtml"
Write(Html.Raw(ViewData["pesan"]));

#line default
#line hidden
            EndContext();
#line 9 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Home\Index.cshtml"
                                
}else {

#line default
#line hidden
            BeginContext(159, 47, true);
            WriteLiteral("    <p>Selamat Datang di Halaman Home Page</p>\n");
            EndContext();
#line 12 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\dosen\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(208, 12, true);
            WriteLiteral("<br/>\n</div>");
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
