using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllVtnorton.Email
{
    public class BodyEn
    {
        /// <summary>
        /// Início padrão de um e-mail vindo de um formulário de contato
        /// </summary>
        public static String Start = "<style>body{font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif !important}#contato{font-size:33px; font-weight:300; color:#2572EB}#body {border-top: 1px solid #2572EB; margin: 10px 0; padding: 20px 10px}#footer {width: 100%;border-top:1px solid #ddd;padding: 5px 0; color:#808080}#footer a{color:#2572EB !important}#footer p {font-size: 12px; font-weight: 300; margin-bottom:10px}.contact {float:left; margin-top:10px}.contact p{font-size:16px !important; margin:0; font-weight:600 !important}.contact p a{text-decoration:none}.logo{float:right; margin-top:15px}.info{background:#e8f1ff; margin:5px 10px; border-top:1px solid #2572EB; margin-bottom:10px; border-bottom:1px solid #2572EB}.info p{font-size:14px}</style><div id='contato'>Contact</div><div id='body'>";
        /// <summary>
        /// Início padrão de um e-mail, sem cabeçalho
        /// </summary>
        public static String StartForSenddingEmail = "<style>body{font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif !important}#body {border-top: 1px solid #2572EB; margin: 10px 0; padding: 20px 10px}#footer {width: 100%;border-top:1px solid #ddd;padding: 5px 0; color:#808080}#footer a{color:#2572EB !important}#footer p {font-size: 12px; font-weight: 300; margin-bottom:10px}.contact {float:left; margin-top:10px}.contact p{font-size:16px !important; margin:0; font-weight:600 !important}.contact p a{text-decoration:none}.logo{float:right; margin-top:15px}.info{background:#e8f1ff; padding:5px 10px; border-top:1px solid #2572EB; margin-bottom:10px; border-bottom:1px solid #2572EB}.info p{font-size:14px}</style><div id='body'>";

        /// <summary>
        /// Início para encaminhamento de e-mail
        /// </summary>
        public static String StartSendFoward = "<style>body{font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif !important}#contato{font-size:33px; font-weight:300; color:#2572EB}#body {border-top: 1px solid #2572EB; margin: 10px 0; padding: 20px 10px}#footer {width: 100%;border-top:1px solid #ddd;padding: 5px 0; color:#808080}#footer a{color:#2572EB !important}#footer p {font-size: 12px; font-weight: 300; margin-bottom:10px}.contact {float:left; margin-top:10px}.contact p{font-size:16px !important; margin:0; font-weight:600 !important}.contact p a{text-decoration:none}.logo{float:right; margin-top:15px}.info{background:#e8f1ff; margin:5px 10px; border-top:1px solid #2572EB; margin-bottom:10px; border-bottom:1px solid #2572EB}.info p{font-size:14px}</style><div id='contato'>Foward e-mail</div><div id='body'>";
        /// <summary>
        /// Final padrão de um e-mail, com informações para não ser respondido pelo endereço do remetente
        /// </summary>
        public static String End = "</div><div id='footer'><p>You are reciving this e-mail for get in touch with me.</p><p>This email was send by a not monitored account. Do not replay this menssage. Use the links in this e-mail to get more information.</p><p>I respect your privice and, in transparent terms, I foward to you the same information that were shared with me. To learn more, please read my online <a href='#'>Political privacy</a>.</p><div class='contact'><p>Facebook: <a href='#'>Vítor Norton</a><br />Twitter: <a href='https://www.twitter.com/vt_norton'>@vt_norton</a><br />Instagram: <a href='https://www.instagram.com/vt_norton'>@vt_norton</a><br />Skype: <a href='#'>vtnorton</a><br />Site: <a href='http://www.vtnorton.com'>www.vtnorton.com</a></p></div><div class='logo'><img src='http://www.vtnorton.com/images/logos/logo.vtnorton.email.png' /></div><div style='clear:both'></div></div>";
        /// <summary>
        /// Final de um e-mail padrão.
        /// </summary>
        public static String EndForSenddingEmail = "</div><div id='footer'><p>You can reply to this email by sending to contato@vtnorton.com or by clicking in 'Reply'. This was send by Vítor Norton.</p><p>If you suspect that this email was not send by Vitor Norton, get in touch with this email address: norton@vtnorton.com, or Skyping in (vtnorton).</p><div class='contact'><p>+55 (28) 9 9972-2490</p><p>vitor@vtnorton.com</p><p>Facebook: <a href='#'>Vítor Norton</a><br />Twitter: <a href='https://www.twitter.com/vt_norton'>@vt_norton</a><br />Instagram: <a href='https://www.instagram.com/vt_norton'>@vt_norton</a><br />Skype: <a href='#'>vtnorton</a><br />Site: <a href='http://www.vtnorton.com'>www.vtnorton.com</a></p></div><div class='logo'><img src='http://www.vtnorton.com/images/logos/logo.vtnorton.email.png' /></div><div style='clear:both'></div></div>";
        /// <summary>
        /// Menssagem para os usuários sobre transparência e encaminhamento de e-mail para eles.
        /// </summary>
        public static String IncludeForUsers = "<div class='info'><p>You are reciving this e-mail for get in touch with me. Here are your informations that are shared with me. If you are not okay with that, please, let me know.</p></div>";
    }
}
