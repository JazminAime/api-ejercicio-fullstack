namespace DolarApi.EjercicioAnimalInterfaz
{
    public class Gato : IAnimal
    {
        public string Comer() 
        {
            return "El gato come.";
        }
        public string Dormir()
        {
            return "El gato duerme";
        }
    }
}
