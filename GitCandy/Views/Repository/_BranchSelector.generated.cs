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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Repository/_BranchSelector.cshtml")]
    public partial class _Views_Repository__BranchSelector_cshtml : System.Web.Mvc.WebViewPage<GitCandy.Models.BranchSelectorModel>
    {
        public _Views_Repository__BranchSelector_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Repository\_BranchSelector.cshtml"
  
    var values = ViewContext.RouteData.Values;
    var action = values["action"] as string;
    var noLink = Model.Path == null;
    var identity = Html.GetRootViewBag().Identity++;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"dropdown btn-group\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral("><i");

WriteAttribute("class", Tuple.Create(" class=\"", 327), Tuple.Create("\"", 427)
            
            #line 9 "..\..\Views\Repository\_BranchSelector.cshtml"
, Tuple.Create(Tuple.Create("", 335), Tuple.Create<System.Object, System.Int32>(Model.CurrentIsBranch.ToFlagString("glyphicon glyphicon-random", "glyphicon glyphicon-tag")
            
            #line default
            #line hidden
, 335), false)
);

WriteLiteral("></i><span");

WriteLiteral(" class=\"branch-name\"");

WriteLiteral("> ");

            
            #line 9 "..\..\Views\Repository\_BranchSelector.cshtml"
                                                                                                                                                                                        Write(Model.Current);

            
            #line default
            #line hidden
WriteLiteral("</span></a>\r\n    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"btn btn-default dropdown-toggle\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral("><span");

WriteLiteral(" class=\"caret\"");

WriteLiteral("></span></a>\r\n    <div");

WriteLiteral(" class=\"dropdown-menu\"");

WriteLiteral(">\r\n        <form>\r\n            <ul");

WriteLiteral(" class=\"nav nav-tabs nav-justified\"");

WriteLiteral(">\r\n                <li");

WriteAttribute("class", Tuple.Create(" class=\"", 720), Tuple.Create("\"", 777)
            
            #line 14 "..\..\Views\Repository\_BranchSelector.cshtml"
, Tuple.Create(Tuple.Create("", 728), Tuple.Create<System.Object, System.Int32>(Model.CurrentIsBranch.ToFlagString("active", "")
            
            #line default
            #line hidden
, 728), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 781), Tuple.Create("\"", 810)
, Tuple.Create(Tuple.Create("", 788), Tuple.Create("#branch-pane-", 788), true)
            
            #line 14 "..\..\Views\Repository\_BranchSelector.cshtml"
                     , Tuple.Create(Tuple.Create("", 801), Tuple.Create<System.Object, System.Int32>(identity
            
            #line default
            #line hidden
, 801), false)
);

WriteLiteral(" data-toggle=\"tab\"");

WriteLiteral(">");

            
            #line 14 "..\..\Views\Repository\_BranchSelector.cshtml"
                                                                                                                            Write(SR.Repository_Branches);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n                <li");

WriteAttribute("class", Tuple.Create(" class=\"", 883), Tuple.Create("\"", 940)
            
            #line 15 "..\..\Views\Repository\_BranchSelector.cshtml"
, Tuple.Create(Tuple.Create("", 891), Tuple.Create<System.Object, System.Int32>(Model.CurrentIsBranch.ToFlagString("", "active")
            
            #line default
            #line hidden
, 891), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 944), Tuple.Create("\"", 970)
, Tuple.Create(Tuple.Create("", 951), Tuple.Create("#tag-pane-", 951), true)
            
            #line 15 "..\..\Views\Repository\_BranchSelector.cshtml"
                  , Tuple.Create(Tuple.Create("", 961), Tuple.Create<System.Object, System.Int32>(identity
            
            #line default
            #line hidden
, 961), false)
);

WriteLiteral(" data-toggle=\"tab\"");

WriteLiteral(">");

            
            #line 15 "..\..\Views\Repository\_BranchSelector.cshtml"
                                                                                                                         Write(SR.Repository_Tags);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            </ul>\r\n            <div");

WriteLiteral(" class=\"tab-content\"");

WriteLiteral(">\r\n                <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1098), Tuple.Create("\"", 1180)
, Tuple.Create(Tuple.Create("", 1106), Tuple.Create("tab-pane", 1106), true)
            
            #line 18 "..\..\Views\Repository\_BranchSelector.cshtml"
, Tuple.Create(Tuple.Create(" ", 1114), Tuple.Create<System.Object, System.Int32>(Model.CurrentIsBranch.ToFlagString("active", "")
            
            #line default
            #line hidden
, 1115), false)
, Tuple.Create(Tuple.Create(" ", 1164), Tuple.Create("branch-selector", 1165), true)
);

WriteAttribute("id", Tuple.Create(" id=\"", 1181), Tuple.Create("\"", 1207)
, Tuple.Create(Tuple.Create("", 1186), Tuple.Create("branch-pane-", 1186), true)
            
            #line 18 "..\..\Views\Repository\_BranchSelector.cshtml"
                                        , Tuple.Create(Tuple.Create("", 1198), Tuple.Create<System.Object, System.Int32>(identity
            
            #line default
            #line hidden
, 1198), false)
);

WriteLiteral(">\r\n                    <ul");

WriteLiteral(" class=\"nav nav-list\"");

WriteLiteral(">\r\n");

            
            #line 20 "..\..\Views\Repository\_BranchSelector.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Repository\_BranchSelector.cshtml"
                         foreach (var branch in Model.Branches)
                        {
                            if (noLink)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">");

            
            #line 24 "..\..\Views\Repository\_BranchSelector.cshtml"
                                           Write(branch);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 25 "..\..\Views\Repository\_BranchSelector.cshtml"
                            }
                            else if (branch == Model.Current)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li");

WriteLiteral(" class=\"active\"");

WriteLiteral("><a>");

            
            #line 28 "..\..\Views\Repository\_BranchSelector.cshtml"
                                                 Write(branch);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 29 "..\..\Views\Repository\_BranchSelector.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li>");

            
            #line 32 "..\..\Views\Repository\_BranchSelector.cshtml"
                               Write(Html.ActionLink(branch, action, Html.OverRoute(new { path = branch + "/" + Model.Path })));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 33 "..\..\Views\Repository\_BranchSelector.cshtml"
                            }
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </ul>\r\n                </div>\r\n                <div");

WriteAttribute("class", Tuple.Create(" class=\"", 2043), Tuple.Create("\"", 2125)
, Tuple.Create(Tuple.Create("", 2051), Tuple.Create("tab-pane", 2051), true)
            
            #line 37 "..\..\Views\Repository\_BranchSelector.cshtml"
, Tuple.Create(Tuple.Create(" ", 2059), Tuple.Create<System.Object, System.Int32>(Model.CurrentIsBranch.ToFlagString("", "active")
            
            #line default
            #line hidden
, 2060), false)
, Tuple.Create(Tuple.Create(" ", 2109), Tuple.Create("branch-selector", 2110), true)
);

WriteAttribute("id", Tuple.Create(" id=\"", 2126), Tuple.Create("\"", 2149)
, Tuple.Create(Tuple.Create("", 2131), Tuple.Create("tag-pane-", 2131), true)
            
            #line 37 "..\..\Views\Repository\_BranchSelector.cshtml"
                                     , Tuple.Create(Tuple.Create("", 2140), Tuple.Create<System.Object, System.Int32>(identity
            
            #line default
            #line hidden
, 2140), false)
);

WriteLiteral(">\r\n                    <ul");

WriteLiteral(" class=\"nav nav-list\"");

WriteLiteral(">\r\n");

            
            #line 39 "..\..\Views\Repository\_BranchSelector.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Repository\_BranchSelector.cshtml"
                         foreach (var tag in Model.Tags)
                        {
                            if (noLink)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Repository\_BranchSelector.cshtml"
                                           Write(tag);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 44 "..\..\Views\Repository\_BranchSelector.cshtml"
                            }
                            else if (tag == Model.Current)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li");

WriteLiteral(" class=\"active\"");

WriteLiteral("><a>");

            
            #line 47 "..\..\Views\Repository\_BranchSelector.cshtml"
                                                 Write(tag);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 48 "..\..\Views\Repository\_BranchSelector.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li>");

            
            #line 51 "..\..\Views\Repository\_BranchSelector.cshtml"
                               Write(Html.ActionLink(tag, action, Html.OverRoute(new { path = tag + "/" + Model.Path })));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 52 "..\..\Views\Repository\_BranchSelector.cshtml"
                            }
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </" +
"form>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
