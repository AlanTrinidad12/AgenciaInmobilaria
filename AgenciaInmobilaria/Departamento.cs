using System;

namespace AgenciaInmobilaria
{
    public class Departamento : Inmueble
    {
        //Atributos Propios
        //Metodos Propios
        public Departamento(string tipo, double precio)
        {
            _TipoInmueble = tipo;
            Precio = precio;
        }
    }
}


