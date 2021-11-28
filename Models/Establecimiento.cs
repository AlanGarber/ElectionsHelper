using System;


namespace TP_Padron_Blaser_Garber.Models
{
    public class Establecimiento{
        private static int _IdEstablecimiento;
        private static string _Nombre;
        private static string _Direccion;
        private static string _Localidad;

        public int IdEstablecimiento{
            get{
                return _IdEstablecimiento;
            }
            set{
                _IdEstablecimiento=value;
            }
        }

        public string Nombre{
            get{
                return _Nombre;
            }
            set{
                _Nombre=value;
            }
        }

        public string Direccion{
            get{
                return _Direccion;
            }
            set{
                _Direccion=value;
            }
        }

        public string Localidad{
            get{
                return _Localidad;
            }
            set{
                _Localidad=value;
            }
        }


        public Establecimiento(int IdEstablecimiento ,string Nombre, string Direccion, string Localidad){
            _IdEstablecimiento=IdEstablecimiento;
            _Nombre=Nombre;
            _Direccion=Direccion;
            _Localidad=Localidad;
        }
    }
}
