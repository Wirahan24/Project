#pragma checksum "E:\Project\Asp.Net\MyProject\MyProject\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44e8a0c4051c768b23f5b6a4f88db80359310430"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Index.cshtml", typeof(AspNetCore.Views_Login_Index))]
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
#line 1 "E:\Project\Asp.Net\MyProject\MyProject\Views\_ViewImports.cshtml"
using MyProject;

#line default
#line hidden
#line 2 "E:\Project\Asp.Net\MyProject\MyProject\Views\_ViewImports.cshtml"
using MyProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e8a0c4051c768b23f5b6a4f88db80359310430", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6fe18bfd33a53b99196e5f743c625163e36f2af", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Project\Asp.Net\MyProject\MyProject\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 292, true);
            WriteLiteral(@"
<h2>Index</h2>

<table border=""1"" width=""100%"">
    <tr>
        <th width=""50%"">test1</th>
        <th width=""50%"">test2</th>
    </tr>
    <tr>
        <td>TEST 1</td>
        <td>TEST 2</td>
    </tr>    
</table>

<input type=""button"" onclick=""save()"" value=""Button"" />

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(352, 815, true);
                WriteLiteral(@" 
<script type=""text/javascript"">
    $(document).ready(function () {
            alert(""Hello world!"");
    });


    var Login = {
        Username: ""Wira"",
        Password: ""Wira""
    };
    function save() {
        debugger;
        $.ajax({
            url: ""https://localhost:44352/Login/insert"",
            type: ""POST"",
            contentType: ""application/json;charset=utf-8"",
            dataType: ""json"",
            data: JSON.stringify(Login),
            success: function (result) {
                alert(""success"");
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        }).done(function () {
            window.location.replace(""http://www.w3schools.com"");
        });
    }
</script>

");
                EndContext();
            }
            );
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
