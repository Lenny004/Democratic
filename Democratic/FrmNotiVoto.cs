using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Democratic
{
    public partial class FrmNotiVoto : Form
    {
        public FrmNotiVoto()
        {
            InitializeComponent();
        }

        private void FrmNotiVoto_Load(object sender, EventArgs e)
        {
            if (VarSession.idioma == 1)
            {
                lblingresado.Text = Idiomas.EnglishMessage.msjvtin2;
                lblinfo.Text = Idiomas.EnglishMessage.msjprocom;
            }
            else
            {
                lblingresado.Text = Idiomas.MensajesEspanol.msjvtin2;
                lblinfo.Text = Idiomas.MensajesEspanol.msjprocom;
            }
        }

        public static void Frmnotivoto()
        {
            FrmNotiVoto voto = new FrmNotiVoto();
            voto.ShowDialog();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
