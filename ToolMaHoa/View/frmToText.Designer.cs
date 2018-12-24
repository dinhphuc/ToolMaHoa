namespace ToolMaHoa.View
{
    partial class frmToText
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToText));
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.btnSelectall = new System.Windows.Forms.Button();
            this.lblCoppy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(429, 12);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(274, 251);
            this.rtbOutput.TabIndex = 34;
            this.rtbOutput.Text = "";
            this.rtbOutput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtbOutput_MouseClick);
            this.rtbOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbOutput_KeyPress);
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(296, 41);
            this.txtkey.MaxLength = 100;
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(125, 20);
            this.txtkey.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Key";
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(11, 12);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(267, 251);
            this.rtbInput.TabIndex = 31;
            this.rtbInput.Text = "";
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Location = new System.Drawing.Point(314, 77);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(75, 23);
            this.btnMaHoa.TabIndex = 29;
            this.btnMaHoa.Text = "Mã Hóa";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Location = new System.Drawing.Point(314, 106);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btnGiaiMa.TabIndex = 29;
            this.btnGiaiMa.Text = "Giải Mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // btnSelectall
            // 
            this.btnSelectall.Location = new System.Drawing.Point(314, 201);
            this.btnSelectall.Name = "btnSelectall";
            this.btnSelectall.Size = new System.Drawing.Size(75, 23);
            this.btnSelectall.TabIndex = 35;
            this.btnSelectall.Text = "Coppy KQ";
            this.btnSelectall.UseVisualStyleBackColor = true;
            this.btnSelectall.Click += new System.EventHandler(this.btnSelectall_Click);
            // 
            // lblCoppy
            // 
            this.lblCoppy.AutoSize = true;
            this.lblCoppy.Location = new System.Drawing.Point(395, 206);
            this.lblCoppy.Name = "lblCoppy";
            this.lblCoppy.Size = new System.Drawing.Size(0, 13);
            this.lblCoppy.TabIndex = 37;
            // 
            // frmToText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 290);
            this.Controls.Add(this.lblCoppy);
            this.Controls.Add(this.btnSelectall);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.txtkey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.btnMaHoa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmToText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tool Mã Hóa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.Button btnSelectall;
        private System.Windows.Forms.Label lblCoppy;
    }
}