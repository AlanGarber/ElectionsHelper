using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace TP_Padron_Blaser_Garber.Models
{
    public static class BD{
        private static string _connectionString=@"Server=A-CAM-07; DataBase=BDPadron; Trusted_Connection=True;";
        private static List<Persona> _EXP =new List<Persona>();

         
        public static Persona ConsultaPadron(int DNI){
            Persona MiPersona=null;
            string sql="SELECT * FROM Personas WHERE DNI=@pDNI";
            using(SqlConnection BD=new SqlConnection(_connectionString)){
                MiPersona=BD.QueryFirstOrDefault<Persona>(sql,new{pDNI=DNI});
            }
            return MiPersona;
        }

        public static Establecimiento ConsultaEstablecimiento(int IdEstablecimiento){
            Establecimiento MiEstablecimiento=null;
            string sql="SELECT * FROM Establecimiento WHERE IdEstablecimiento=@pId";
            using(SqlConnection BD=new SqlConnection(_connectionString)){
                MiEstablecimiento=BD.QueryFirstOrDefault<Establecimiento>(sql,new{pId=IdEstablecimiento});
            }
            return MiEstablecimiento;
        }

        public static List<Persona> DevolverPersonasXEstablecimiento(int IdEstablecimiento){
            string sql="SELECT * FROM Personas WHERE IdEstablecimiento=@pId ORDER BY Apellido";
            using(SqlConnection BD=new SqlConnection(_connectionString)){
                _EXP=BD.Query<Persona>(sql,new{pId=IdEstablecimiento}).ToList();
            }
            return _EXP;
        }

        public static bool Votar(int DNI,int NumeroTramite){
            int votosRealizados=0;bool voto=false;
            string sql="UPDATE Personas SET Voto=1, FechaVoto=@pFecha WHERE DNI=@pDNI AND NumeroTramite=@pNum";
            using(SqlConnection BD=new SqlConnection(_connectionString)){
                votosRealizados=BD.Execute(sql,new{pDNI=DNI,pNum=NumeroTramite,pFecha=DateTime.Today});
            }
            if(votosRealizados==1){
                voto=true;
            }
            return voto;
        }
    }
}
