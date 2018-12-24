using ToolMaHoa.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ToolMaHoa.View
{
    public partial class frmToText : Form
    {
        public frmToText()
        {
            InitializeComponent();
        } 

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            if(rtbInput.Text == "")
            {
                MessageBox.Show("Nhập Dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtkey.Text!="")
            {
                string Input = rtbInput.Text;
                MaHoaString.key = txtkey.Text;
                rtbOutput.Text =MaHoaString.Encrypt(Input);
            }else
            {
                MessageBox.Show("Nhập key", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            if (rtbInput.Text == "")
            {
                MessageBox.Show("Nhập Dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtkey.Text != "")
            {
                string Input = rtbInput.Text;
                MaHoaString.key = txtkey.Text;
                rtbOutput.Text = MaHoaString.Decrypt(Input);
            }
            else
            {
                MessageBox.Show("Nhập key", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void rtbOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; 
        }

        private void rtbOutput_MouseClick(object sender, MouseEventArgs e)
        {
            rtbOutput.SelectAll();   
        }
        private void btnSelectall_Click(object sender, EventArgs e)
        {
            if(rtbOutput.Text!="")
            {
                Clipboard.SetText(rtbOutput.Text);
                lblCoppy.Text = "✓";
            }else
                lblCoppy.Text = "Null";

        }
    }
}
