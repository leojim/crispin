﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace crispin.ExampleReportLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 10 "..\..\StaticTest1.cshtml"
    using crispin.ExampleReportLibrary;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    public partial class StaticTest1 : RazorGenerator.Templating.RazorTemplateBase
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>\r\n<!DOCTYPE report [\r\n    <!ENTITY nbsp \"&" +
"#160;\">\r\n    <!ENTITY ldquo \"&#8220;\">\r\n    <!ENTITY lsquo \"&#8216;\">\r\n    <!ENT" +
"ITY rdquo \"&#8221;\">\r\n    <!ENTITY rsquo \"&#8217;\">\r\n    <!ENTITY quot \"&#34;\">\r" +
"\n]>\r\n");



            
            #line 11 "..\..\StaticTest1.cshtml"
  
    var header = new Header1 { Title = "Static test 1", Subtitle = "" };
    var footer = new Footer1();


            
            #line default
            #line hidden
WriteLiteral("<report font-size=\"7pt\">\r\n\t<title>Static test 1</title>\r\n    <content>\r\n        <" +
"pageSequence orientation=\"portrait\">\r\n            ");


            
            #line 19 "..\..\StaticTest1.cshtml"
       Write(header.TransformText());

            
            #line default
            #line hidden
WriteLiteral(@"

            <contentBlock>
                <table type=""DataGrid"">
                    <col width=""30%"" />
                    <col width=""70%"" />
                    <thead>
                        <tr>
                            <th align=""left"">ID</th>
                            <th align=""left"">Name</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr><td>123</td><td>Ben</td></tr>
                        <tr><td>456</td><td>Justine</td></tr>
                        <tr><td>445</td><td>Ann</td></tr>
                    </tbody>
                </table>
            </contentBlock>

            ");


            
            #line 39 "..\..\StaticTest1.cshtml"
       Write(footer.TransformText());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </pageSequence>\r\n    </content>\r\n</report>");


        }
    }
}
#pragma warning restore 1591
