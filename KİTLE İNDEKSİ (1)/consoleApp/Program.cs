//VUCUT KİTLE ENDEKSİ HESAPLAYAN PROGRAM 
Console.WriteLine("VUCUT KİTLE ENDEKSİ HESAPLAMA");

Console.WriteLine("-----------------------------");

Console.WriteLine("LÜTFEN KİLONUZU GİRİNİZ (KG CİNSİNDEN )");

double kilo=Convert.ToInt32( Console.ReadLine());

Console.WriteLine("LÜTFEN BOYUNUZU GİRİNİZ (CM CİNSİNDEN )");

double boy=Convert.ToInt32( Console.ReadLine());
//kullanıcıdan aldığımız boy değerini metreye çevirmek için
 double cmBoy=boy/100;
 
double sonuc= kilo / (cmBoy*cmBoy )  ;

if(sonuc<=18.5){
    Console.WriteLine("VUCUT KİTLE İNDEKSİNE GÖRE ZAYIFSINIZ ");
}else if(sonuc>18.5 && sonuc<=24.9){
    Console.WriteLine("VUCUT KİTLE İNDEKSİNE GÖRE NORMALSİNİZ ");

}else if(sonuc>25 && sonuc<=29.9){
    Console.WriteLine("VUCUT KİTLE İNDEKSİNE GÖRE FAZLA KİLOLUSUNUZ");}

else if(sonuc>30 && sonuc<=34.9){
    Console.WriteLine("VUCUT KİTLE İNDEKSİNE GÖRE 1.DERCEDEN OBEZİTESİNİZ");}

 else if(sonuc>35 && sonuc<=39.9){
    Console.WriteLine("VUCUT KİTLE İNDEKSİNE GÖRE 2.DERCEDEN OBEZİTESİNİZ");}

 else if(sonuc>=40){
    Console.WriteLine("VUCUT KİTLE İNDEKSİNE GÖRE 3.DERCEDEN OBEZİTESİNİZ");}
    Console.WriteLine(cmBoy);
     Console.WriteLine(sonuc);