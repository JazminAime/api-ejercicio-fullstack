namespace DolarApi.EjemploDeHerencia
{
    public class Jirafa : Animal
    {
        public Jirafa(string nombre) : base(nombre)
        {
        }

        public double Altura { get; set; }

        public override string Comer()
        {
            return "La jirafa come";
        }
    }
}
