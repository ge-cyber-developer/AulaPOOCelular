using System;

namespace celular
{
    class celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado = true;
        public celular(string _cor, string _modelo, string _tamanho){
            this.cor = _cor;
            this.modelo = _modelo;
            this.tamanho = _tamanho;
        }

        public void ligar(){
            this.ligado = true;
        }

        public void desligar(){
            this.ligado = false;
        }

        public void fazendoLigacao(string pessoa){
            Console.WriteLine("Fazendo ligação para: "+pessoa);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            celular celularDaGeorgia = new celular("verde neon","iphone 11", "grande");
            Console.WriteLine(celularDaGeorgia.cor);
        }
    }
}
