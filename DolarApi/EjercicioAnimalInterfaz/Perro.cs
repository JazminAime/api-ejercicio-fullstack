namespace DolarApi.EjercicioAnimalInterfaz
{
    public class Perro : IAnimal
    {
        public string Comer()
        {
            return "El perro come.";
        }
        public string Dormir()
        {
            return "El perro duerme";
        }
    }
}
