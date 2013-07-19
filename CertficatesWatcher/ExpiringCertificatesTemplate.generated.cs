﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18213
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CertficatesWatcher
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class ExpiringCertificatesTemplate : RazorGenerator.Templating.RazorTemplateBase
    {
#line hidden

        #line 5 "..\..\ExpiringCertificatesTemplate.cshtml"

    public string Title { get { return "Список устаривающих сертификатов"; } }

    public string ServerName { get; set; }

    public ICollection<X509Certificate2> ExpiringCertificates { get; set; }

        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");



WriteLiteral("\r\n");


WriteLiteral("\r\n<p>Внимание!</p>\r\n\r\n<p>На сервере ");


            
            #line 14 "..\..\ExpiringCertificatesTemplate.cshtml"
         Write(ServerName);

            
            #line default
            #line hidden
WriteLiteral(" устаривают следующие сертификаты:</p>\r\n\r\n<div class=\"certificates\"> \r\n");


            
            #line 17 "..\..\ExpiringCertificatesTemplate.cshtml"
 foreach (var cert in ExpiringCertificates)
{

            
            #line default
            #line hidden
WriteLiteral("    <p>\r\n        ");


            
            #line 20 "..\..\ExpiringCertificatesTemplate.cshtml"
   Write(cert.GetOrganization());

            
            #line default
            #line hidden
WriteLiteral(" (");


            
            #line 20 "..\..\ExpiringCertificatesTemplate.cshtml"
                            Write(cert.GetNameInfo(X509NameType.SimpleName, false));

            
            #line default
            #line hidden
WriteLiteral(") — ");


            
            #line 20 "..\..\ExpiringCertificatesTemplate.cshtml"
                                                                                 Write(cert.NotAfter.ToString("dd.MM.yyyy HH:mm"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n");


            
            #line 22 "..\..\ExpiringCertificatesTemplate.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n<p>Это автоматическое сообщение сгенерированно сервисом отслеживания се" +
"ртфикатов.</p>");


        }
    }
}
#pragma warning restore 1591
