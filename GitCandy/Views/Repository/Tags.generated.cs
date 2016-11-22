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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Repository/Tags.cshtml")]
    public partial class _Views_Repository_Tags_cshtml : System.Web.Mvc.WebViewPage<GitCandy.Models.TagsModel>
    {
        public _Views_Repository_Tags_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Repository\Tags.cshtml"
  
    ViewBag.Title = string.Format(SR.Shared_TitleFormat, string.Format(SR.Repository_TagsTitle, Model.RepositoryName));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h4>");

            
            #line 7 "..\..\Views\Repository\Tags.cshtml"
Write(string.Format(SR.Repository_TagsTitle, ""));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 7 "..\..\Views\Repository\Tags.cshtml"
                                           Write(Html.ActionLink(Model.RepositoryName, "Tree", Html.OverRoute(new { path = "" })));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n\r\n<div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\Repository\Tags.cshtml"
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Repository\Tags.cshtml"
     if (Model.HasTags)
    {
        foreach (var tag in Model.Tags)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"row border-area\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"pull-right\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 16 "..\..\Views\Repository\Tags.cshtml"
               Write(Html.Partial("_ZipButton", tag.ReferenceName));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 17 "..\..\Views\Repository\Tags.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Repository\Tags.cshtml"
                     if (Model.CanDelete)
                    {
            
            #line default
            #line hidden
WriteLiteral(" <a");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" data-tag=\"");

            
            #line 18 "..\..\Views\Repository\Tags.cshtml"
                                                      Write(tag.ReferenceName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">");

            
            #line 18 "..\..\Views\Repository\Tags.cshtml"
                                                                                   Write(SR.Shared_Delete);

            
            #line default
            #line hidden
WriteLiteral("</a>");

            
            #line 18 "..\..\Views\Repository\Tags.cshtml"
                                                                                                             }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n                <div>");

            
            #line 20 "..\..\Views\Repository\Tags.cshtml"
                Write(Html.ActionLink(tag.ReferenceName, "Tree", Html.OverRoute(new { path = tag.ReferenceName ?? tag.Sha })));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteAttribute("title", Tuple.Create(" title=\"", 897), Tuple.Create("\"", 914)
            
            #line 21 "..\..\Views\Repository\Tags.cshtml"
, Tuple.Create(Tuple.Create("", 905), Tuple.Create<System.Object, System.Int32>(tag.When
            
            #line default
            #line hidden
, 905), false)
);

WriteLiteral(">");

            
            #line 21 "..\..\Views\Repository\Tags.cshtml"
                                  Write(tag.When.LocalDateTime.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div>");

            
            #line 22 "..\..\Views\Repository\Tags.cshtml"
                Write(tag.MessageShort);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div>");

            
            #line 23 "..\..\Views\Repository\Tags.cshtml"
                Write(Html.ActionLink(tag.Sha, "Commit", Html.OverRoute(new { path = tag.ReferenceName ?? tag.Sha })));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n");

            
            #line 25 "..\..\Views\Repository\Tags.cshtml"
        }
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <div>");

            
            #line 29 "..\..\Views\Repository\Tags.cshtml"
        Write(SR.Repository_NoTags);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 30 "..\..\Views\Repository\Tags.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    var deleteTag_params = {\r\n        words: \'");

            
            #line 35 "..\..\Views\Repository\Tags.cshtml"
           Write(Html.Raw(SR.Repository_TagDeletionWords));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n        url: \'");

            
            #line 36 "..\..\Views\Repository\Tags.cshtml"
         Write(Url.Action("Tags", "Repository"));

            
            #line default
            #line hidden
WriteLiteral("\'\r\n    };\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
