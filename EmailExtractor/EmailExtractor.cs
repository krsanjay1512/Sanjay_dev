using Limilabs.Client.IMAP;
using Limilabs.Mail;
using Limilabs.Mail.MIME;
using System;
using System.Collections.Generic;

namespace GmailRead.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Imap imap = new Imap())
            {
                imap.ConnectSSL("imap.gmail.com");
                imap.Login("example@gmail.com","P@ssword");
                imap.SelectInbox();
                List<long> uids = imap.SearchFlag(Flag.Unseen);
                foreach (long uid in uids)
                {
                    string eml = imap.GetMessageByUID(uid).ToString();//dowanload message
                    IMail email = new MailBuilder().CreateFromEml(eml);
                    Console.WriteLine(email.Subject);
                    Console.WriteLine(email.TextDataString);
                    foreach (MimeData attachement in email.Attachments)
                    {
                        Console.WriteLine(attachement.FileName);
                        attachement.Save("c:\\Attachments\\" + attachement.FileName);
                    }
                }

                imap.Close(true);
            }
            Console.ReadLine();
        }
    }
}

