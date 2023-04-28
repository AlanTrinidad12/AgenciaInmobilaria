using System;
namespace AgenciaInmobilaria
{
    public class Program
    {
       
    static void Main(string[] args)
    {
            //Creamos objeto/instancia
            //Inmueble Casa=new Inmueble();
            //Casa._TipoInmueble="Casa de Campo";
            //Casa._Area=120;
            //Casa._Ubicacion="Avenida los rios";
            //Casa.VerDatos();

            Inmueble Departamento = new Inmueble("Departamento");
        Departamento.Alquilar();

        //Creamos objeto/instancia
        Casa ObjetoCasa=new casa("Casa de Campo", 350005);
        ObjetoCasa.Vender();
    }
}