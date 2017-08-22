using System;
using System.Net.Mail;
using System.Net;
namespace Program
{
	
	public class Class1
	{	
		public String araci_adres;
		public String araci_sifre;
    		public String gonderen_mail;
		public String gonderen_ad_soyad;
		public String alici_mail;
		public String konu;
    		public String icerik;
			
			public static void mailgonder(String araci_adres , String araci_sifre , String gonderen_mail , String gonderen_ad_soyad , String alici_mail , String konu , String icerik){
			
			Class1 temp = new Class1();
			
			temp.araci_adres = araci_adres;
			temp.araci_sifre = araci_sifre; 
			temp.gonderen_mail = gonderen_mail;			
			temp.gonderen_ad_soyad=gonderen_ad_soyad;
			temp.alici_mail=alici_mail;
			temp.konu=konu;
			temp.icerik=icerik;
			
			SmtpClient sc = new SmtpClient();
        		sc.Port = 587;
        		sc.Host = "smtp.gmail.com";
        		sc.EnableSsl = true;

        		sc.Credentials = new NetworkCredential(temp.araci_adres, temp.araci_sifre);

        		MailMessage mail = new MailMessage();

       	 		mail.From = new MailAddress(temp.gonderen_mail, temp.gonderen_ad_soyad);

        		mail.To.Add(temp.alici_mail);

        		mail.Subject = temp.konu; mail.IsBodyHtml = true; mail.Body = temp.icerik;

        		sc.Send(mail);	
		
			}
		
	}
}
