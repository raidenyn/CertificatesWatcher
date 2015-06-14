﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CertificatesWatcher
{
    using System;
    
    #line 2 "..\..\ExpiringCertificatesTemplate.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    
    #line 3 "..\..\ExpiringCertificatesTemplate.cshtml"
    using System.Security.Cryptography.X509Certificates;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 4 "..\..\ExpiringCertificatesTemplate.cshtml"
    using CertificatesWatcher;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class ExpiringCertificatesTemplate : RazorGenerator.Templating.RazorTemplateBase
    {
#line hidden

        #line 6 "..\..\ExpiringCertificatesTemplate.cshtml"

    public string Title { get { return "Some certificates are expiring."; } }

    public string ServerName { get; set; }

    public ICollection<X509Certificate2> ExpiringCertificates { get; set; }

        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");




WriteLiteral("\r\n");


WriteLiteral("\r\n<p>Attention!</p>\r\n\r\n<p>On server ");


            
            #line 15 "..\..\ExpiringCertificatesTemplate.cshtml"
        Write(ServerName);

            
            #line default
            #line hidden
WriteLiteral(" is expiring following certificates:</p>\r\n\r\n<div class=\"certificates\"> \r\n");


            
            #line 18 "..\..\ExpiringCertificatesTemplate.cshtml"
 foreach (var cert in ExpiringCertificates)
{

            
            #line default
            #line hidden
WriteLiteral("    <p>\r\n        ");


            
            #line 21 "..\..\ExpiringCertificatesTemplate.cshtml"
   Write(cert.GetOrganization());

            
            #line default
            #line hidden
WriteLiteral(" (");


            
            #line 21 "..\..\ExpiringCertificatesTemplate.cshtml"
                            Write(cert.GetNameInfo(X509NameType.SimpleName, false));

            
            #line default
            #line hidden
WriteLiteral(") — ");


            
            #line 21 "..\..\ExpiringCertificatesTemplate.cshtml"
                                                                                 Write(cert.NotAfter.ToString("dd.MM.yyyy HH:mm"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n");


            
            #line 23 "..\..\ExpiringCertificatesTemplate.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n<p>This message was auto generated by certificates watcher service.</p>" +
"");


        }
    }
}
#pragma warning restore 1591