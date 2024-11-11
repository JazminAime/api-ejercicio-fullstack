namespace DolarApi.EjemploInterfaz
{
    public class Auto : IVehiculo
    {
        public string Acelerar()
        {
            return "El auto aceleró";
        }
        public string Frenar()
        {
            return "El auto frenó";
        }
    }
}
