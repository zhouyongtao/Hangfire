﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web
{
    
    #line 2 "..\..\LayoutPage.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 3 "..\..\LayoutPage.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class LayoutPage : WebTemplateBase
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");




WriteLiteral("<!DOCTYPE html>\r\n\r\n<html lang=\"ru\">\r\n<head>\r\n    <title>");


            
            #line 9 "..\..\LayoutPage.cshtml"
      Write(Title);

            
            #line default
            #line hidden
WriteLiteral(" - HangFire</title>\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" cont" +
"ent=\"width=device-width, initial-scale=1.0\">\r\n    <link rel=\"stylesheet\" href=\"");


            
            #line 12 "..\..\LayoutPage.cshtml"
                            Write(Request.LinkTo("css"));

            
            #line default
            #line hidden
WriteLiteral(@""" />
</head>
<body>
    <!-- Wrap all page content here -->
    <div id=""wrap"">

        <!-- Fixed navbar -->
        <div class=""navbar navbar-fixed-top"">
            <div class=""container"">
                <div class=""navbar-header"">
                    <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                    </button>
                    <a class=""navbar-brand"" href=""");


            
            #line 27 "..\..\LayoutPage.cshtml"
                                             Write(Request.LinkTo("/"));

            
            #line default
            #line hidden
WriteLiteral("\">HangFire Monitor</a>\r\n                </div>\r\n                <div class=\"colla" +
"pse navbar-collapse\">\r\n                    <ul class=\"nav navbar-nav\">\r\n        " +
"                <li class=\"");


            
            #line 31 "..\..\LayoutPage.cshtml"
                               Write(Request.PathInfo.Equals("/") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <a href=\"");


            
            #line 32 "..\..\LayoutPage.cshtml"
                                Write(Request.LinkTo("/"));

            
            #line default
            #line hidden
WriteLiteral("\">Dashboard</a>\r\n                        </li>\r\n                        <li class" +
"=\"");


            
            #line 34 "..\..\LayoutPage.cshtml"
                               Write(Request.PathInfo.Equals("/queues") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <a href=\"");


            
            #line 35 "..\..\LayoutPage.cshtml"
                                Write(Request.LinkTo("/queues"));

            
            #line default
            #line hidden
WriteLiteral("\">Queues</a>\r\n                        </li>\r\n                        <li class=\"");


            
            #line 37 "..\..\LayoutPage.cshtml"
                               Write(Request.PathInfo.Equals("/schedule") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <a href=\"");


            
            #line 38 "..\..\LayoutPage.cshtml"
                                Write(Request.LinkTo("/schedule"));

            
            #line default
            #line hidden
WriteLiteral("\">Schedule</a>\r\n                        </li>\r\n                        <li class=" +
"\"");


            
            #line 40 "..\..\LayoutPage.cshtml"
                               Write(Request.PathInfo.Equals("/dispatchers") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <a href=\"");


            
            #line 41 "..\..\LayoutPage.cshtml"
                                Write(Request.LinkTo("/dispatchers"));

            
            #line default
            #line hidden
WriteLiteral(@""">Dispatchers</a>
                        </li>
                    </ul>
                </div>
                <!--/.nav-collapse -->
            </div>
        </div>

        <!-- Begin page content -->

        <div class=""container"">
            <div class=""col-md-3"">
                <ul class=""list-group"">
                    <li class=""list-group-item"">
                        <span class=""label label-success pull-right"">
                            ");


            
            #line 56 "..\..\LayoutPage.cshtml"
                       Write(String.Format("{0:n0}", Storage.SucceededCount()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span>\r\n                        Completed\r\n           " +
"         </li>\r\n                    <li class=\"list-group-item\">\r\n              " +
"          <span class=\"label label-danger pull-right\">\r\n                        " +
"    ");


            
            #line 62 "..\..\LayoutPage.cshtml"
                       Write(String.Format("{0:n0}", Storage.FailedCount()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span>\r\n                        Failed\r\n              " +
"      </li>\r\n                    <li class=\"list-group-item\">\r\n                 " +
"       <span class=\"label label-warning pull-right\">\r\n                          " +
"  ");


            
            #line 68 "..\..\LayoutPage.cshtml"
                       Write(String.Format("{0:n0}", Storage.Dispatchers().Count()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span>\r\n                        Processing\r\n          " +
"          </li>\r\n                    <li class=\"list-group-item\">\r\n             " +
"           <span class=\"label label-primary pull-right\">\r\n                      " +
"      ");


            
            #line 74 "..\..\LayoutPage.cshtml"
                       Write(String.Format("{0:n0}", Storage.ScheduledCount()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span>\r\n                        Scheduled\r\n           " +
"         </li>\r\n                    <li class=\"list-group-item\">\r\n              " +
"          <span class=\"label label-default pull-right\">\r\n                       " +
"     ");


            
            #line 80 "..\..\LayoutPage.cshtml"
                       Write(String.Format("{0:n0}", Storage.EnqueuedCount()));

            
            #line default
            #line hidden
WriteLiteral(@"
                        </span>
                        Enqueued
                    </li>
                </ul>

                <label>Test jobs</label>
                <div class=""input-group"">
                    <input type=""text"" class=""form-control"">
                    <span class=""input-group-btn"">
                        <button class=""btn btn-default"" type=""button"">Go</button>
                    </span>
                </div>
            </div>
            <div class=""col-md-9"">
                <h1 class=""page-header"">");


            
            #line 95 "..\..\LayoutPage.cshtml"
                                   Write(Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n                ");


            
            #line 96 "..\..\LayoutPage.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral(@"
            </div>
        </div>
    </div>

    <div id=""footer"">
        <div class=""container"">
            <ul class=""list-inline credit"">
                <li>
                    <a href=""http://github.io/odinserj/hangfire"" target=""_blank"">HangFire 0.1.3
                    </a>
                </li>
                <li>Redis: 
                    ");


            
            #line 109 "..\..\LayoutPage.cshtml"
               Write(String.Format("{0}:{1}/{2}", Configuration.Instance.RedisHost, Configuration.Instance.RedisPort, Configuration.Instance.RedisDb));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li>Time: ");


            
            #line 111 "..\..\LayoutPage.cshtml"
                     Write(DateTime.UtcNow.ToString());

            
            #line default
            #line hidden
WriteLiteral(" UTC\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</bod" +
"y>\r\n</html>\r\n");


        }
    }
}
#pragma warning restore 1591
