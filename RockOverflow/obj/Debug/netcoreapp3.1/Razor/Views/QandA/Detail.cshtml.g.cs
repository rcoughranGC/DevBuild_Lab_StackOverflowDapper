#pragma checksum "C:\Dev\RockOverflow\RockOverflow\Views\QandA\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "369686f447f474a7bd28accc3cd18ffe41a21063"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_Detail), @"mvc.1.0.view", @"/Views/QandA/Detail.cshtml")]
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
#line 1 "C:\Dev\RockOverflow\RockOverflow\Views\_ViewImports.cshtml"
using RockOverflow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\RockOverflow\RockOverflow\Views\_ViewImports.cshtml"
using RockOverflow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"369686f447f474a7bd28accc3cd18ffe41a21063", @"/Views/QandA/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9094e1d3bf0b5fd65c011a8cbfbbec06989bd44a", @"/Views/_ViewImports.cshtml")]
    public class Views_QandA_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionAnswers>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Dev\RockOverflow\RockOverflow\Views\QandA\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Question Detail</h1>\r\n<div>\r\n    Title: ");
#nullable restore
#line 8 "C:\Dev\RockOverflow\RockOverflow\Views\QandA\Detail.cshtml"
      Write(Model.ques.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    User: ");
#nullable restore
#line 9 "C:\Dev\RockOverflow\RockOverflow\Views\QandA\Detail.cshtml"
     Write(Model.ques.username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    Detail: ");
#nullable restore
#line 10 "C:\Dev\RockOverflow\RockOverflow\Views\QandA\Detail.cshtml"
       Write(Model.ques.detail);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /><br /><br />\r\n    Answers: \r\n");
#nullable restore
#line 12 "C:\Dev\RockOverflow\RockOverflow\Views\QandA\Detail.cshtml"
     foreach (var answer in Model.quesAnswers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <br />\r\n        User: ");
#nullable restore
#line 16 "C:\Dev\RockOverflow\RockOverflow\Views\QandA\Detail.cshtml"
         Write(answer.username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        Answer: ");
#nullable restore
#line 17 "C:\Dev\RockOverflow\RockOverflow\Views\QandA\Detail.cshtml"
           Write(answer.detail);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        Upvotes: ");
#nullable restore
#line 18 "C:\Dev\RockOverflow\RockOverflow\Views\QandA\Detail.cshtml"
            Write(answer.upvotes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Dev\RockOverflow\RockOverflow\Views\QandA\Detail.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionAnswers> Html { get; private set; }
    }
}
#pragma warning restore 1591