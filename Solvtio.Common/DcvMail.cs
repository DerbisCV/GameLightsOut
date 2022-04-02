using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Solvtio.Common
{
    public class DcvMail
    {
        private LoggingRegister LogRegister;
        private IConfigReader ConfigReader;
        private IList<KeyValue> ListKeyValue;
        private SmtpClient Smtp;

        #region Constructors

        public DcvMail(LoggingRegister logRegister, IConfigReader configReader)
        {
            this.LogRegister = logRegister;
            this.ConfigReader = configReader;
            createBase();
        }

        public DcvMail(IConfigReader configReader)
        {
            //this.LogRegister = logRegister;
            this.ConfigReader = configReader;
            createBase();
        }

        public DcvMail(IList<KeyValue> lstKeyValue)
        {
            this.ListKeyValue = lstKeyValue;
            createBase();
        }

        private void createBase()
        {
            bool useDefaultCredentials = string.IsNullOrWhiteSpace(getClaveValue("MailCredentialUser"));
            createBase(
                getClaveValue("MailHost"),
                getClaveValue("MailPort").ToIntegerOrDefault(25),
                useDefaultCredentials,
                getClaveValue("MailCredentialUser"),
                getClaveValue("MailCredentialPass"),
                getClaveValue("MailEnableSSL").ToLower() == "true"
                );
        }

        private void createBase(string SMTPHost, int SMTPPort, bool useDefaultCredentials, string usuarioSMTP, string pwdSMTP, bool enableSsl)
        {
            Smtp = new SmtpClient()
            {
                UseDefaultCredentials = useDefaultCredentials,
                Host = SMTPHost,
                Port = SMTPPort,
                EnableSsl = enableSsl,
            };

            if (!useDefaultCredentials)
                Smtp.Credentials = new NetworkCredential(usuarioSMTP, pwdSMTP);
        }
        #endregion

        #region Methods

        public bool SendBase(string sSubject, string sBody, IList<string> lstDestinatarios, bool sendAsync = false, List<string> lstCC = null)
        {
            MailMessage oEmail = CreateMailMessageBase(lstDestinatarios, lstCC);

            if (LogRegister != null)
            {
                LogRegister.Register("sBody: " + sBody);
                LogRegister.Register("sSubject: " + sSubject);
            }

            oEmail.Subject = sSubject;
            oEmail.Body = sBody;

            if (sendAsync)
                this.Smtp.SendAsync(oEmail, null);
            else
                this.Smtp.Send(oEmail);

            return true;
        }


        private MailMessage CreateMailMessageBase(IList<string> lstDestinatarios, List<string> lstCC = null)
        {
            MailMessage mailMessage = new MailMessage()
            {
                BodyEncoding = System.Text.Encoding.UTF8,
                IsBodyHtml = true,
                From = new MailAddress(
                    getClaveValue("MailAddressFrom"),
                    getClaveValue("MailDisplayNameFrom"))
            };

            foreach (string nDestinatario in lstDestinatarios.Where(x => !string.IsNullOrEmpty(x)))
                mailMessage.To.Add(new MailAddress(nDestinatario.Trim()));

            if (lstCC.IsNotEmpty())
            {
                foreach (var cc in lstCC)
                {
                    if (!string.IsNullOrWhiteSpace(cc))
                        mailMessage.CC.Add(new MailAddress(cc.Trim()));
                }
            }

            return mailMessage;
        }

        public List<string> GetListDestinatariosFromClave(string claveName)
        {
            var destinatariosPuntoYComaSeparados = getClaveValue(claveName);
            return GetListDestinatarios(destinatariosPuntoYComaSeparados);
        }
        public List<string> GetListDestinatarios(string destinatariosPuntoYComaSeparados)
        {
            var result = new List<string>();
            foreach (var item in destinatariosPuntoYComaSeparados.Split(';'))
            {
                if (!string.IsNullOrWhiteSpace(item))
                    result.Add(item.Trim());
            }

            return result;
        }
        #endregion

        private string getClaveValue(string clave)
        {
            string result = "";

            if (this.ConfigReader != null)
                result = this.ConfigReader.GetKeyToString(clave.Trim());
            else if (this.ListKeyValue != null)
                result = this.ListKeyValue.First(x => x.Key.Equals(clave.Trim())).Value;

            return result;
        }

    }
}
