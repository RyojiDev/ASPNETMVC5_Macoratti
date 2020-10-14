using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace Mvc_ConfirmarEmail.Servicos
{
    public class ServicoEmail
    {
        public static Task EnviaEmailAsync(string email,string assunto, string mensagem)
        {
            //servico para enviar email
            SendGridMessage minhaMensagem = new SendGridMessage();
            minhaMensagem.AddTo(email);
            minhaMensagem.From = new System.Net.Mail.MailAddress("ryojikitanodev@gmail.com", "Ryoji . net");
            minhaMensagem.Subject = assunto;
            minhaMensagem.Text = mensagem;
            minhaMensagem.Html = mensagem;
            NetworkCredential credenciais = new NetworkCredential("ryojikitanodev@gmail.com", "7Jacque7@");
            // Cria um transporte web para enviar o email
            Web transporteWeb = new Web(credenciais);
            //Envia o email
            if(transporteWeb != null)
            {
                return transporteWeb.DeliverAsync(minhaMensagem);
            }
            else
            {
                return Task.FromResult(0);
            }
        }
    }
}