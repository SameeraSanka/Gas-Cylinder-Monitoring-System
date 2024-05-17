using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class OKMsgBox : Form
    {
        public OKMsgBox()
        {
            InitializeComponent();
        }

        #region Variables
        public static OKMsgBox MgBox;
        public static DialogResult results;
        #endregion

        public static DialogResult Show(string text, string title)
        {
            MgBox = new OKMsgBox();
            MgBox.lblMessage.Text = text;
            MgBox.lblTitle.Text = title;
            MgBox.pictureBox1.Image = SystemIcons.Information.ToBitmap();

            MgBox.ShowDialog();
            return results;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .2;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                timer2.Stop();
                this.Dispose();
            }
            Opacity -= .2;
        }
    }
}
