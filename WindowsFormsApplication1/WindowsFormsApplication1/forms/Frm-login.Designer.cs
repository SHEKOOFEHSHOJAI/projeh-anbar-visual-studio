namespace WindowsFormsApplication1.forms
{
    partial class Frm_login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_khoroj = new BehComponents.ButtonX();
            this.btn_vorod = new BehComponents.ButtonX();
            this.txt_ramz_obor = new System.Windows.Forms.TextBox();
            this.txt_usename = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_usename);
            this.groupBox1.Controls.Add(this.txt_ramz_obor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(359, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "رمز عبور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(359, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام کاربری";
            // 
            // btn_khoroj
            // 
            this.btn_khoroj.BoldedForeColor = System.Drawing.Color.Blue;
            this.btn_khoroj.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_khoroj.HolidayForeColor = System.Drawing.Color.Red;
            this.btn_khoroj.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btn_khoroj.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btn_khoroj.IsBolded = false;
            this.btn_khoroj.IsHoliday = false;
            this.btn_khoroj.IsTrailing = false;
            this.btn_khoroj.Location = new System.Drawing.Point(362, 218);
            this.btn_khoroj.Name = "btn_khoroj";
            this.btn_khoroj.PushedAlways = false;
            this.btn_khoroj.SecondBorderColor = System.Drawing.Color.Red;
            this.btn_khoroj.SecondBorderDistanceToEdge = 3F;
            this.btn_khoroj.SecondBorderWidth = 3F;
            this.btn_khoroj.ShowFirstBorder = true;
            this.btn_khoroj.ShowSecondBorder = false;
            this.btn_khoroj.Size = new System.Drawing.Size(75, 35);
            this.btn_khoroj.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btn_khoroj.TabIndex = 1;
            this.btn_khoroj.Text = "خروج";
            this.btn_khoroj.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btn_khoroj.UseVisualStyleBackColor = true;
            this.btn_khoroj.Click += new System.EventHandler(this.btn_khoroj_Click);
            // 
            // btn_vorod
            // 
            this.btn_vorod.BoldedForeColor = System.Drawing.Color.Blue;
            this.btn_vorod.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_vorod.HolidayForeColor = System.Drawing.Color.Red;
            this.btn_vorod.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btn_vorod.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btn_vorod.IsBolded = false;
            this.btn_vorod.IsHoliday = false;
            this.btn_vorod.IsTrailing = false;
            this.btn_vorod.Location = new System.Drawing.Point(203, 218);
            this.btn_vorod.Name = "btn_vorod";
            this.btn_vorod.PushedAlways = false;
            this.btn_vorod.SecondBorderColor = System.Drawing.Color.Red;
            this.btn_vorod.SecondBorderDistanceToEdge = 3F;
            this.btn_vorod.SecondBorderWidth = 3F;
            this.btn_vorod.ShowFirstBorder = true;
            this.btn_vorod.ShowSecondBorder = false;
            this.btn_vorod.Size = new System.Drawing.Size(75, 35);
            this.btn_vorod.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btn_vorod.TabIndex = 2;
            this.btn_vorod.Text = "ورود";
            this.btn_vorod.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btn_vorod.UseVisualStyleBackColor = true;
            this.btn_vorod.Click += new System.EventHandler(this.btn_vorod_Click);
            // 
            // txt_ramz_obor
            // 
            this.txt_ramz_obor.Location = new System.Drawing.Point(125, 87);
            this.txt_ramz_obor.Multiline = true;
            this.txt_ramz_obor.Name = "txt_ramz_obor";
            this.txt_ramz_obor.PasswordChar = '*';
            this.txt_ramz_obor.Size = new System.Drawing.Size(209, 36);
            this.txt_ramz_obor.TabIndex = 2;
            // 
            // txt_usename
            // 
            this.txt_usename.Location = new System.Drawing.Point(125, 19);
            this.txt_usename.Multiline = true;
            this.txt_usename.Name = "txt_usename";
            this.txt_usename.Size = new System.Drawing.Size(209, 36);
            this.txt_usename.TabIndex = 1;
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 284);
            this.Controls.Add(this.btn_vorod);
            this.Controls.Add(this.btn_khoroj);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود کاربر";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BehComponents.ButtonX btn_khoroj;
        private BehComponents.ButtonX btn_vorod;
        private System.Windows.Forms.TextBox txt_usename;
        private System.Windows.Forms.TextBox txt_ramz_obor;
    }
}