using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Democratic
{
    public partial class FrmNoti : Form
    {
        public FrmNoti(string mensaje, string title)
        {
            InitializeComponent();
            lbltext1.Text = title;
            lbltext2.Text = mensaje;
        }

        private void FrmNoti_Load(object sender, EventArgs e)
        {
            
        }

        public static void Noti(string mensaje, string title)
        {
            FrmNoti noti = new FrmNoti(mensaje, title);
            noti.ShowDialog();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
