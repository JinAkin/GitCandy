﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using GitCandy;
    using GitCandy.Base;
    using GitCandy.Configuration;
    using GitCandy.Extensions;
    using GitCandy.Models;
    using GitCandy.Web;
    using GitCandy.Web.App_GlobalResources;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Serialization;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/DisplayTemplates/Members.cshtml")]
    public partial class _Views_Shared_DisplayTemplates_Members_cshtml_ : System.Web.Mvc.WebViewPage<String[]>
    {
        public _Views_Shared_DisplayTemplates_Members_cshtml_()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\DisplayTemplates\Members.cshtml"
  
    var controller = ViewData.ModelMetadata.AdditionalValues["Controller"] as String;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 7 "..\..\Views\Shared\DisplayTemplates\Members.cshtml"
 for (var i = 0; i < Model.Length; i++)
{
    var ss = Model[i].Split("@");
    if (i != 0)
    {
            
            #line default
            #line hidden
WriteLiteral(" , ");

            
            #line 11 "..\..\Views\Shared\DisplayTemplates\Members.cshtml"
                     }
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Shared\DisplayTemplates\Members.cshtml"
Write(Html.ActionLink(ss[1], "Tree", controller, new { owner = ss[0], name = ss[1] }, null));

            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Shared\DisplayTemplates\Members.cshtml"
                                                                                          
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
