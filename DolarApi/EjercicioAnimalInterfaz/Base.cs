using DolarApi.EjemploDeHerencia;

namespace DolarApi.EjercicioAnimalInterfaz
{
    public class Base
    {
        public string Comer(IAnimal animal)
        {
            return animal.Comer();
        }
    }
}
