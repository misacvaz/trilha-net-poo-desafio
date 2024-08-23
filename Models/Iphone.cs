namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public Iphone(string numero, string modelo, string imei, int memoria) : base("3354", modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nome)
        {
          Console.WriteLine($"Instalando o aplicativo {nome} no Iphone");
        }
    }
}