using System;

namespace TP_Padron_Blaser_Garber.Models
{
    public class Persona{
        private int _Dni;
        private string _Nombre;
        private string _Apellido;
        private int _NumeroTramite;
        private int _IdEstablecimiento;
        private bool _Voto;
        private DateTime _FechaVoto;

        public int DNI{
            get{
                return _Dni;
            }
            set{
                _Dni=value;
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

        public string Apellido{
            get{
                return _Apellido;
            }
            set{
                _Apellido=value;
            }
        }

        public int NumeroTramite{
            get{
                return _NumeroTramite;
            }
            set{
                _NumeroTramite=value;
            }
        }

        public int IdEstablecimiento{
            get{
                return _IdEstablecimiento;
            }
            set{
                _IdEstablecimiento=value;
            }
        }

        public bool Voto{
            get{
                return _Voto;
            }
            set{
                _Voto=value;
            }
        }

        public DateTime FechaVoto{
            get{
                return _FechaVoto;
            }
            set{
                _FechaVoto=value;
            }
        }
        

        public Persona(){

        }
    }
}
