using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Democratic
{
    public partial class FrmRegistrar : Form
    {

        public FrmRegistrar()
        {
            InitializeComponent();
        }

        private void FrmRegistrar_Load(object sender, EventArgs e)
        {

        }

        //void EnvioDatosReg()
        //{
        //    AtributosRegister.DUI = mskDUI.Text;
        //    bool buscardui = RegisterController.BuscarDUI_Controller();
        //    if (buscardui == true)
        //    {
        //        FrmRegistrar main = new FrmRegistrar();
        //    }
        //    else
        //    {
        //        MessageBox.Show("DUI no registrado, verifique", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }

        //}

        //private void BtnBuscar_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(mskDUI.Text.Trim()))
        //    {
        //        MessageBox.Show("Espacios en blanco, verifique", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    else
        //    {
        //        EnvioDatosReg();
        //        TxtCorreoElectronico.Enabled = true;
        //    }
        //}

        public static string contra;

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int a = rdn.Next(1000, 9999);
            int b = rdn.Next(1000, 9999);
            int c = rdn.Next(1000, 9999);
            contra = a.ToString() + "-" + b.ToString() + "-" + c.ToString();

            var fromAddress = new MailAddress("eduvargashdez@gmail.com");
            var fromPassword = "PARTY2015";
            var toAddress = new MailAddress("eduvargashdez@hotmail.com");

            string subject = "Prueba 324";
            string body = "La contraseña para ingresar es: " + contra;


            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })


                smtp.Send(message);

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
