using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APP_TrabajoRegistro
{
    public class ClsControlador
    {
        private String id, nombre, contacto, correo, msn;

        public ClsControlador(String i, String n, String c, String email)
        {
            id = i;
            nombre = n;
            contacto = c;
            correo = email;
            fnt_registrar();
        }


        public void fnt_registrar()
        {

            if(this.id=="" || this.nombre==""||this.contacto == "" || this.correo == "")
            {

                msn = "debe diligencia toda la información";

            }
            else
            {
                ClsConexion objconect = new ClsConexion();
                SqlCommand con = new SqlCommand("SP_GuardarRegistro", objconect.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@id", id);
                con.Parameters.AddWithValue("@nombre", nombre);
                con.Parameters.AddWithValue("@contacto", contacto);
                con.Parameters.AddWithValue("@correo", correo);
                objconect.connection.Open();
                con.ExecuteNonQuery();
                objconect.connection.Close();
                msn = nombre + " se registró correctamente";
            }

 
        }   
        public String getMensaje()
        {
            return msn;
        }

    }
}