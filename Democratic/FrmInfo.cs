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
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();
        }

        void VerificarIdioma()
        {
            switch (VarSession.idioma)
            {
                case 1:
                    BtnOK.Text = Idiomas.English.btncontinuar;
                    lblinfo.Text = Idiomas.English.lblinfomation;
                    lbltext1.Text = Idiomas.English.lbltexto1;
                    lbltext2.Text = Idiomas.English.lbltexto2;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void FrmInfo_Load(object sender, EventArgs e)
        {
            Esclarecer.ShowAsyc(this);
            VerificarIdioma();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void Frminfo()
        {
            FrmInfo info = new FrmInfo();
            info.ShowDialog(); 
        }
    }
}
