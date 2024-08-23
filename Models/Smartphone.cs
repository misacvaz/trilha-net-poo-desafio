namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo{ get; set;}

        public string IMAI{get; set;}
        public int Memoria{get; set;}

        public Smartphone(string numero, string modelo, string imai, int memoria)
        {
            Numero = numero;
           
            Modelo = modelo;
            IMAI = imai;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nome);
    }
}