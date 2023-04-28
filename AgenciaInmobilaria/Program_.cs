using System;
namespace AgenciaInmobilaria
{
    class Program : Inmueble
    {
        static void Main(string[] args)
        {
            //Creamos objeto/instancia
            Inmueble Casa = new Inmueble();
            Casa._TipoInmueble = "Casa de Campo";
            Casa._Area = 120;
            Casa._Ubicacion = "Avenida los rios";
            Casa.Vender();

            Inmueble Departamento = new Inmueble("Departamento Duplex", 3200);
            Departamento.Alquilar();
        }
    }
}
