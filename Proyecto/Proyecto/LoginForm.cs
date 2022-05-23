using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto
{
    public partial class LoginForm : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String email = this.txtEmail.Text.Trim().ToString();
            String password = this.txtPassword.Text.Trim().ToString();

            if(email == "test@mail.com" && password == "admin")
            {
                this.Hide();
                MainForm frmMainForm = new MainForm();

                frmMainForm.Show();
            }
            else
            {
                MessageBox.Show("Revise su correo y contraseña", "FALLO DE INICIO DE SESIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //try
            //{
            //    this.cmd.Connection = this.conn;
            //    this.cmd.CommandType = CommandType.StoredProcedure;
            //    this.cmd.CommandText = "usp_ObtenerUsuario";
            //    this.cmd.Parameters.Clear();

            //    this.cmd.Parameters.AddWithValue("@email", email);
            //    this.cmd.Parameters.AddWithValue("@password", password);

            //    this.conn.Open();

            //    this.dr = this.cmd.ExecuteReader();

            //    while (this.dr.Read())
            //    {
            //        String userEmail = this.dr["email"].ToString().Trim();
            //        String userPassword = this.dr["password"].ToString().Trim();

            //        if(userEmail == email && userPassword == password)
            //        {
            //            this.Close();
            //            MainForm frmMainForm = new MainForm();
            //        }
            //        else
            //        {
            //            MessageBox.Show("FALLO DE INICIO DE SESIÓN", "Revise su correo y contraseña", MessageBoxButtons.OK);
            //        }
            //    }
            //}catch(SqlException ex)
            //{
            //    throw new Exception(ex.Message);
            //}
            //finally
            //{
            //    if(this.conn.State == ConnectionState.Open)
            //    {
            //        this.conn.Close();
            //    }
            //}
        }
    }
}
