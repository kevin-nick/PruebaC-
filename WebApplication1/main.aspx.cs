using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
namespace WebApplication1
{
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //cadena de coneccion con mysqlworbench de forma local
            string conection = "Server=localhost;Database=nick;Uid=root;Pwd=qwerty1234;";
            //instancia de coneccion
            using (var con = new MySqlConnection(conection))
            {
                con.Open();//abrimos la coneccion
                //creamos el query de la tabla usuarios
                using (var cmd = new MySqlCommand("select * from nick.menu", con))
                {   //instancia de ejecucion 
                    using (var reader = cmd.ExecuteReader())
                    {
                        DropDownList1.DataSource = reader; //pasando los datos al dropdow
                        DropDownList1.DataValueField = "idmenu"; //id
                        DropDownList1.DataTextField = "menuName";//nombre
                        DropDownList1.DataBind();//vinculacion de datos
                    }
                }
            }
        }
        //esta funcion se ejecuta cuando se activa el onClick o (OnSelectedIndexChanged) del dropdown1
        protected void ddlLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cadena de coneccion con mysqlworbench de forma local
            string conection = "Server=localhost;Database=nick;Uid=root;Pwd=qwerty1234;";
            //instancia de coneccion
            using (var con = new MySqlConnection(conection))
            {
                con.Open();//abrimos la coneccion
                //creamos el query de la tabla usuarios
                using (var cmd = new MySqlCommand("select * from nick.menu where padreID = "+DropDownList1.SelectedValue.ToString()+"", con))
                {   //instancia de ejecucion 
                    using (var reader = cmd.ExecuteReader())
                    {
                        DropDownList2.DataSource = reader; //pasando los datos al dropdow
                        DropDownList2.DataValueField = "idmenu"; //id
                        DropDownList2.DataTextField = "menuName";//nombre
                        DropDownList2.DataBind();//vinculacion de datos
                    }
                }
            }
        }
    }
}