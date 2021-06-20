using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;//libreria conevtora con mysql
using System.Data;

namespace WebApplication1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            //cadena de coneccion con mysqlworbench de forma local
            string conection = "Server=localhost;Database=nick;Uid=root;Pwd=qwerty1234;";
            //instancia de coneccion
            using (var con = new MySqlConnection(conection))
            {
                con.Open();//abrimos la coneccion
                //creamos el query de la tabla usuarios
                using (var cmd = new MySqlCommand("select usuarioId,Pass from nick.usuarios", con))
                {
                    var reader = cmd.ExecuteReader();//instancia de ejecucion 
                    while (reader.Read())//leyendo....
                    {   //comparacion con cada usuario de la tabla usuario
                        if (reader["usuarioId"].ToString() == tbUsuario.Text && reader["Pass"].ToString() == tbPassword.Text)
                        {   //redirecionando la pagina principal si existe el usuario
                            Response.Redirect("main.aspx");
                        }
                    }  
                }
                con.Close();//cerrando conexion con base de datos mysql.
            }
        }
    }
}