namespace DolarApi.EjemploDeHerencia
{
    public class Delfin : Animal
    {
        public Delfin(string nombre) : base(nombre)
        {
        }

        public int Edad { get; set; }
   
        public override string Comer()
        {
            return "El delfin come";
        }
    }
}
