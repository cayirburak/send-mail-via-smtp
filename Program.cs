using System;

namespace Program
{
	class Program
	{
		public static void Main(string[] args){
		
		String araci_adres;
		String araci_sifre;
    		String gonderen_mail;
		String gonderen_ad_soyad;
		String alici_mail;
		String konu;
    		String icerik;
    	
    		araci_adres="mysupermail@mail.com";
    		araci_sifre="my_super_password";
    		gonderen_mail="mysupermail@mail.com";
    		gonderen_ad_soyad="Burak Çayır";
    		alici_mail="mysupermail@mail.com";
		konu="Subject of my super mail";
		icerik="Content of my super mail";		
		
    		Class1.mailgonder(araci_adres , araci_sifre , gonderen_mail , gonderen_ad_soyad , alici_mail , konu , icerik );
		
		}
	}
}