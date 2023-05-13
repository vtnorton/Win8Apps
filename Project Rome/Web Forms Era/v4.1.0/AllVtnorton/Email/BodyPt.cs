using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllVtnorton.Email.Portuguese
{
    public class BodyPt
    {
        /// <summary>
        /// Início padrão de um e-mail vindo de um formulário de contato
        /// </summary>
        public static String Start = "<style>body{font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif !important}#contato{font-size:33px; font-weight:300; color:#2572EB}#body {border-top: 1px solid #2572EB; margin: 10px 0; padding: 20px 10px}#footer {width: 100%;border-top:1px solid #ddd;padding: 5px 0; color:#808080}#footer a{color:#2572EB !important}#footer p {font-size: 12px; font-weight: 300; margin-bottom:10px}.contact {float:left; margin-top:10px}.contact p{font-size:16px !important; margin:0; font-weight:600 !important}.contact p a{text-decoration:none}.logo{float:right; margin-top:15px}.info{background:#e8f1ff; margin:5px 10px; border-top:1px solid #2572EB; margin-bottom:10px; border-bottom:1px solid #2572EB}.info p{font-size:14px}</style><div id='contato'>E-mail de contato</div><div id='body'>";
        /// <summary>
        /// Início padrão de um e-mail, sem cabeçalho
        /// </summary>
        public static String StartForSenddingEmail = "<style>body{font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif !important}#body {border-top: 1px solid #2572EB; margin: 10px 0; padding: 20px 10px}#footer {width: 100%;border-top:1px solid #ddd;padding: 5px 0; color:#808080}#footer a{color:#2572EB !important}#footer p {font-size: 12px; font-weight: 300; margin-bottom:10px}.contact {float:left; margin-top:10px}.contact p{font-size:16px !important; margin:0; font-weight:600 !important}.contact p a{text-decoration:none}.logo{float:right; margin-top:15px}.info{background:#e8f1ff; padding:5px 10px; border-top:1px solid #2572EB; margin-bottom:10px; border-bottom:1px solid #2572EB}.info p{font-size:14px}</style><div id='body'>";
        /// <summary>
        /// Início para encaminhamento de e-mail
        /// </summary>
        public static String StartSendFoward = "<style>body{font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif !important}#contato{font-size:33px; font-weight:300; color:#2572EB}#body {border-top: 1px solid #2572EB; margin: 10px 0; padding: 20px 10px}#footer {width: 100%;border-top:1px solid #ddd;padding: 5px 0; color:#808080}#footer a{color:#2572EB !important}#footer p {font-size: 12px; font-weight: 300; margin-bottom:10px}.contact {float:left; margin-top:10px}.contact p{font-size:16px !important; margin:0; font-weight:600 !important}.contact p a{text-decoration:none}.logo{float:right; margin-top:15px}.info{background:#e8f1ff; margin:5px 10px; border-top:1px solid #2572EB; margin-bottom:10px; border-bottom:1px solid #2572EB}.info p{font-size:14px}</style><div id='contato'>E-mail encaminhado</div><div id='body'>";
        /// <summary>
        /// Final padrão de um e-mail, com informações para não ser respondido pelo endereço do remetente
        /// </summary>
        public static String End = "</div><div id='footer'><p>Você está recebendo este email porque você entrou em contato com Vítor Norton.</p><p>Este email foi enviado por um endereço não monitorado. Não responda esta mensagem. Use os links embutidos no e-mail para obter mais informações.</p><p>Respeito a sua privacidade, e em termos de transparência encaminhei à você as mesmas informações que foram compartilhadas comigo. Para saber mais, leia a <a href='#'>Política de Privacidade</a> online.</p><div class='contact'><p>Facebook: <a href='#'>Vítor Norton</a><br />Twitter: <a href='https://www.twitter.com/vt_norton'>@vt_norton</a><br />Instagram: <a href='https://www.instagram.com/vt_norton'>@vt_norton</a><br />Skype: <a href='#'>vtnorton</a><br />Site: <a href='http://www.vtnorton.com'>www.vtnorton.com</a></p></div><div class='logo'><img src='http://www.vtnorton.com/images/logos/logo.vtnorton.email.png' /></div><div style='clear:both'></div></div>";
        /// <summary>
        /// Final de um e-mail padrão.
        /// </summary>
        public static String EndForSenddingEmail = "</div><div id='footer'><p>Você pode responder a este email via contato@vtnorton.com ou simplesmente clicando em responder. Este foi um e-mail enviado diretamente por Vítor Norton.</p><p>Se você suspeita de que este e-mail não foi enviado por Vítor Norton entre em contato, impresindivelmente, através do e-mail norton@vtnorton.com ou pelo telefone +55 (28) 9 9972-2490</p><div class='contact'><p>+55 (28) 9 9972-2490</p><p>vitor@vtnorton.com</p><p>Facebook: <a href='#'>Vítor Norton</a><br />Twitter: <a href='https://www.twitter.com/vt_norton'>@vt_norton</a><br />Instagram: <a href='https://www.instagram.com/vt_norton'>@vt_norton</a><br />Skype: <a href='#'>vtnorton</a><br />Site: <a href='http://www.vtnorton.com'>www.vtnorton.com</a></p></div><div class='logo'><img src='http://www.vtnorton.com/images/logos/logo.vtnorton.email.png' /></div><div style='clear:both'></div></div>";
        /// <summary>
        /// Menssagem para os usuários sobre transparência e encaminhamento de e-mail para eles.
        /// </summary>
        public static String IncludeForUsers = "<div class='info'><p>Você está recebendo esse e-mail por ter entrado em contato comigo. Aqui estão as mesmas informações das quais eu estou recebendo de você. Se você não concorda com o compartilhamento dessas informações, entre em contato para a remoção dos mesmos de meu sistema.</p></div>";
    }
}