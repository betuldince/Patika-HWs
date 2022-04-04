 
namespace yeni
{
    class yeni{
        static void Main(string[] args){

            string[] renkler = new string[5];
            string[] hayvanlar={"ceren","erman","falan"};
            int[] dizi;
            dizi= new int[5];

            int dizi_uzunlugu=int.Parse(Console.ReadLine());
            int[] sayı_dizi= new int[dizi_uzunlugu];
            for(int i=0;i<dizi_uzunlugu;i++){
                Console.Write(dizi_uzunlugu+"gir");
                sayı_dizi[i]=int.Parse(Console.ReadLine());
            }

            int toplam=0;
            foreach(var sayı in sayı_dizi){
                toplam+=sayı;
            }
            Console.Write(toplam);
            
        }

    }
}


// See https://aka.ms/new-console-template for more information
