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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Repository/Contributors.cshtml")]
    public partial class _Views_Repository_Contributors_cshtml : System.Web.Mvc.WebViewPage<GitCandy.Models.ContributorsModel>
    {
        public _Views_Repository_Contributors_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Repository\Contributors.cshtml"
  
    ViewBag.Title = string.Format(SR.Shared_TitleFormat, string.Format(SR.Repository_ContributorsTitle, Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h4>");

            
            #line 7 "..\..\Views\Repository\Contributors.cshtml"
Write(string.Format(SR.Repository_ContributorsTitle, ""));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 7 "..\..\Views\Repository\Contributors.cshtml"
                                                   Write(Html.ActionLink(Model.RepositoryName, "Tree", Html.OverRoute(new { path = "" })));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n\r\n<div");

WriteLiteral(" class=\"col-md-5\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\Repository\Contributors.cshtml"
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Repository\Contributors.cshtml"
     foreach (var item in Model.Statistics.Current.OrderedCommits)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"border-area\"");

WriteLiteral(">\r\n                <div>");

            
            #line 14 "..\..\Views\Repository\Contributors.cshtml"
                Write(item.Author);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div>");

            
            #line 15 "..\..\Views\Repository\Contributors.cshtml"
                Write(item.CommitsCount);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 15 "..\..\Views\Repository\Contributors.cshtml"
                                   Write(SR.Repository_Commits);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n");

            
            #line 18 "..\..\Views\Repository\Contributors.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n<div");

WriteLiteral(" class=\"col-md-5 offset1 pull-right\"");

WriteLiteral(">\r\n    <table");

WriteLiteral(" class=\"table\"");

WriteLiteral(">\r\n        <caption>");

            
            #line 22 "..\..\Views\Repository\Contributors.cshtml"
            Write(SR.Repository_Statistics);

            
            #line default
            #line hidden
WriteLiteral("</caption>\r\n        <tbody>\r\n");

            
            #line 24 "..\..\Views\Repository\Contributors.cshtml"
            
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Repository\Contributors.cshtml"
             if (Model.Statistics.Default != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr><td>");

            
            #line 26 "..\..\Views\Repository\Contributors.cshtml"
                   Write(SR.Repository_DefaultBranch);

            
            #line default
            #line hidden
WriteLiteral("</td><td>");

            
            #line 26 "..\..\Views\Repository\Contributors.cshtml"
                                                        Write(Model.Statistics.Default.Branch);

            
            #line default
            #line hidden
WriteLiteral("</td></tr>\r\n");

WriteLiteral("                <tr><td>");

            
            #line 27 "..\..\Views\Repository\Contributors.cshtml"
                   Write(SR.Repository_DefaultCommits);

            
            #line default
            #line hidden
WriteLiteral("</td><td>");

            
            #line 27 "..\..\Views\Repository\Contributors.cshtml"
                                                         Write(Model.Statistics.Default.NumberOfCommits);

            
            #line default
            #line hidden
WriteLiteral("</td></tr>\r\n");

WriteLiteral("                <tr><td>");

            
            #line 28 "..\..\Views\Repository\Contributors.cshtml"
                   Write(SR.Repository_DefaultContributors);

            
            #line default
            #line hidden
WriteLiteral("</td><td>");

            
            #line 28 "..\..\Views\Repository\Contributors.cshtml"
                                                              Write(Model.Statistics.Default.NumberOfContributors);

            
            #line default
            #line hidden
WriteLiteral("</td></tr>\r\n");

WriteLiteral("                <tr><td>");

            
            #line 29 "..\..\Views\Repository\Contributors.cshtml"
                   Write(SR.Repository_DefaultFiles);

            
            #line default
            #line hidden
WriteLiteral("</td><td>");

            
            #line 29 "..\..\Views\Repository\Contributors.cshtml"
                                                       Write(Model.Statistics.Default.NumberOfFiles);

            
            #line default
            #line hidden
WriteLiteral("</td></tr>\r\n");

WriteLiteral("                <tr><td>");

            
            #line 30 "..\..\Views\Repository\Contributors.cshtml"
                   Write(SR.Repository_DefaultSourceSize);

            
            #line default
            #line hidden
WriteLiteral("</td><td>");

            
            #line 30 "..\..\Views\Repository\Contributors.cshtml"
                                                            Write(FileHelper.GetSizeString(Model.Statistics.Default.SizeOfSource));

            
            #line default
            #line hidden
WriteLiteral("</td></tr>\r\n");

WriteLiteral("                <tr><td></td><td></td></tr>\r\n");

            
            #line 32 "..\..\Views\Repository\Contributors.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <tr><td>");

            
            #line 33 "..\..\Views\Repository\Contributors.cshtml"
               Write(SR.Repository_CurrentBranch);

            
            #line default
            #line hidden
WriteLiteral("</td><td>");

            
            #line 33 "..\..\Views\Repository\Contributors.cshtml"
                                                    Write(Model.Statistics.Current.Branch);

            
            #line default
            #line hidden
WriteLiteral("</td></tr>\r\n            <tr><td>");

            
            #line 34 "..\..\Views\Repository\Contributors.cshtml"
               Write(SR.Repository_CurrentCommits);

            
            #line default
            #line hidden
WriteLiteral("</td><td>");

            
            #line 34 "..\..\Views\Repository\Contributors.cshtml"
                                                     Write(Model.Statistics.Current.NumberOfCommits);

            
            #line default
            #line hidden
WriteLiteral("</td></tr>\r\n            <tr><td>");

            
            #line 35 "..\..\Views\Repository\Contributors.cshtml"
               Write(SR.Repository_CurrentContributors);

            
            #line default
            #line hidden
WriteLiteral("</td><td>");

            
            #line 35 "..\..\Views\Repository\Contributors.cshtml"
                                                          Write(Model.Statistics.Current.NumberOfContributors);

            
            #line default
            #line hidden
WriteLiteral("</td></tr>\r\n            <tr><td>");

            
            #line 36 "..\..\Views\Repository\Contributors.cshtml"
               Write(SR.Repository_CurrentFiles);

            
            #line default
            #line hidden
WriteLiteral("</td><td>");

            
            #line 36 "..\..\Views\Repository\Contributors.cshtml"
                                                   Write(Model.Statistics.Current.NumberOfFiles);

            
            #line default
            #line hidden
WriteLiteral("</td></tr>\r\n            <tr><td>");

            
            #line 37 "..\..\Views\Repository\Contributors.cshtml"
               Write(SR.Repository_CurrentSourceSize);

            
            #line default
            #line hidden
WriteLiteral("</td><td>");

            
            #line 37 "..\..\Views\Repository\Contributors.cshtml"
                                                        Write(FileHelper.GetSizeString(Model.Statistics.Current.SizeOfSource));

            
            #line default
            #line hidden
WriteLiteral("</td></tr>\r\n            <tr><td></td><td></td></tr>\r\n            <tr><td>");

            
            #line 39 "..\..\Views\Repository\Contributors.cshtml"
               Write(SR.Repository_RepositorySize);

            
            #line default
            #line hidden
WriteLiteral("</td><td>");

            
            #line 39 "..\..\Views\Repository\Contributors.cshtml"
                                                     Write(FileHelper.GetSizeString(Model.Statistics.RepositorySize));

            
            #line default
            #line hidden
WriteLiteral("</td></tr>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591