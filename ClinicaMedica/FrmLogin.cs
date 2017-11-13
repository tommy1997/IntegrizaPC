﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        ClaseLogin procesos = new ClaseLogin(); 
        FrameBD TablaMedico = new FrameBD("localhost", 3306, "root", "admin", "clinica");
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
           
            procesos.ExistenciaUsuarios(CmbExiste);


            string se = "SELECT nombre FROM pacientes";
            TablaMedico.sqlreader(se);

          /*  if (Convert.ToInt32(CmbExiste.SelectedItem) > 0)
            {

            }
            else
            {
                this.Hide();
               FrmRegistroClinica abrir = new FrmRegistroClinica();
               abrir.Show();
                
            }*/

            
        }

     

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            
        }

        private void TxtUser_Click(object sender, EventArgs e)
        {
            
           
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            Auth user = new Auth("usuario", "nickname", "password", TxtUser.Text, TxtPass.Text, "medico");

            user.DatosUser();

            if (user.ExisteUsuario == true)
            {
                if (user.PassOk)
                {
                   // MessageBox.Show("Acceso Correcto");

                    /*if (user.QueNivelUsuarioAccede == "Administrador")
                    {
                        MessageBox.Show("soy administrador");
                    }*/

                    Agenda ab = new Agenda();

                    ab.DatosAcceso(user.QueUsuarioAccede, user.QueNivelUsuarioAccede);
                    ab.Show();
                    this.Hide();


                    //FrmAgenda entrar = new FrmAgenda();
                    // entrar.DatosAcceso(user.QueUsuarioAccede,user.QueNivelUsuarioAccede);
                    // entrar.Show();
                    // this.Hide();


                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("El Usuario No Existe");
            }
            
        }
    }
}
