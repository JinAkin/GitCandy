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
    using GitCandy.App_GlobalResources;
    using GitCandy.Base;
    using GitCandy.Configuration;
    using GitCandy.Extensions;
    using GitCandy.Models;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Serialization;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Login.cshtml")]
    public partial class _Views_Account_Login_cshtml : System.Web.Mvc.WebViewPage<GitCandy.Models.LoginModel>
    {
        public _Views_Account_Login_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Account\Login.cshtml"
  
    ViewBag.Title = string.Format(SR.Shared_TitleFormat, SR.Account_LoginTitle);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h3>");

            
            #line 7 "..\..\Views\Account\Login.cshtml"
Write(SR.Account_LoginTitle);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n");

            
            #line 9 "..\..\Views\Account\Login.cshtml"
 using (Html.BeginForm("Login", "Account", new { ViewBag.ReturnUrl }, FormMethod.Post))
{

            
            #line default
            #line hidden
WriteLiteral("    <dl");

WriteLiteral(" class=\"dl-horizontal col-md-8\"");

WriteLiteral(">\r\n        <dt>");

            
            #line 12 "..\..\Views\Account\Login.cshtml"
       Write(Html.DisplayNameFor(s => s.ID));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 13 "..\..\Views\Account\Login.cshtml"
       Write(Html.TextBoxFor(s => s.ID, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt>");

            
            #line 15 "..\..\Views\Account\Login.cshtml"
       Write(Html.DisplayNameFor(s => s.Password));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 16 "..\..\Views\Account\Login.cshtml"
       Write(Html.PasswordFor(s => s.Password, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt></dt>\r\n        <dd>");

            
            #line 19 "..\..\Views\Account\Login.cshtml"
       Write(Html.ValidationSummary(true, SR.Account_LoginFailed, new { @class = "alert alert-dismissable alert-danger" }));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt></dt>\r\n        <dd>\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 23 "..\..\Views\Account\Login.cshtml"
                                                     Write(SR.Shared_Login);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

WriteLiteral("            ");

            
            #line 24 "..\..\Views\Account\Login.cshtml"
       Write(Html.ActionLink(SR.Account_ForgotPassword, "Forgot"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n");

            
            #line 27 "..\..\Views\Account\Login.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
