using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

public class Program 
{
    public static void Main(string[] args)
    {

         var nokia = new Nokia("12345","Nokia 34334", "54588", 123);
         Console.WriteLine($" Smartphone Nokia \n Numero: {nokia.Numero}\n Modelo: {nokia.Modelo}\n IMEI: {nokia.IMAI}\n Memoria: {nokia.Memoria}");
         nokia.Ligar();
         nokia.ReceberLigacao();
         nokia.InstalarAplicativo("Facebock");

         Console.WriteLine("\n\n");


        var iphone = new Iphone("5456768", "iphone 15", "3245687", 556);

        Console.WriteLine($" Smartphone Iphone \n Numero: {iphone.Numero}\n Modelo: {iphone.Modelo}\n IMEI: {iphone.IMAI}\n Memoria: {iphone.Memoria}");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");


       
       


    }
}