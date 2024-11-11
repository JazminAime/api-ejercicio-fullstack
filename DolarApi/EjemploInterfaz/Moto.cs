namespace DolarApi.EjemploInterfaz
{
    public class Moto : IVehiculo
    {
        public string Acelerar()
        {
            return "La moto aceleró";
        }
        public string Frenar()
        {
            return "La moto frenó";
        }
    }
}
