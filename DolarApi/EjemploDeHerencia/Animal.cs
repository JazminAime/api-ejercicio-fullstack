namespace DolarApi.EjemploDeHerencia
{
    public class Animal
    {
        public string Nombre { get; set; }

        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        public virtual string Comer()
        {
            return "El animal está comiendo.";
        }
    }
}
