/*Instituto Tecnologico Superior de Cintalapa
Alan Rafael Trinidad Arellano
Ingenieria Informatica 2F
Programacion Orientada a Objetos
Jorge Ivan Bermudez Rodriguez
Herencia Simple
*/
using System;
namespace AgenciaInmobilaria
{
    public class Inmueble
    {
        //Atributos /Por defecto son privados
        //Los atributos deberian ser privados
        protected string TipoInmueble;
        protected string Ubicacion;
        protected int Area;
        protected string Dormitorios;
        protected double Precio;
        //Propiedades set y get / modificadores de acceso
        public string _TipoInmueble { get => TipoInmueble; set => TipoInmueble = value; }
        public string _Ubicacion { get => Ubicacion; set => Ubicacion = value; }
        public int _Area { get => Area; set => Area = value; }
        public string _Dormitorios { get => Dormitorios; set => Dormitorios = value; }
        public double _Precio { get => Precio; set => Precio = value; }
        //Metodos 
        public void Registrar() { }
        public void Vender()
        {
            Console.WriteLine(TipoInmueble + "Ha sido vendido por el precio" + Precio);
        }
        public void Alquilar()
        {
            Console.WriteLine(TipoInmueble + "Ha sido adquirida por el precio" + Precio);
        }
        public void VerDatos()
        {
            Console.WriteLine(TipoInmueble + "\n"
            + Area + "\n"
            + Ubicacion + "\n"
            );
        }
        //Constructores con parametros
        public Inmueble(string tipo, double precio)
        {
            TipoInmueble = tipo;
            Precio = precio;
        }
        //Construtor por defecto- vacio
        public Inmueble(){ }
    }
}
