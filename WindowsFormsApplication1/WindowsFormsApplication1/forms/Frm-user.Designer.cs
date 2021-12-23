namespace WindowsFormsApplication1.forms
{
    partial class Frm_user
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_user));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new BehComponents.ButtonX();
            this.btn_close = new BehComponents.ButtonX();
            this.btn_edit = new BehComponents.ButtonX();
            this.btn_add = new BehComponents.ButtonX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.data_grid_user = new BehComponents.DataGridViewX(this.components);
            this.cmb_sath_karbari = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.txt_namfamily = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_tekrar_pass = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_user)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "سطح کاربری";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(685, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "نام کاربری";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "رمز عبور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام خانوادگی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tekrar_pass);
            this.groupBox1.Controls.Add(this.txt_pass);
            this.groupBox1.Controls.Add(this.txt_namfamily);
            this.groupBox1.Controls.Add(this.txt_user_name);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.cmb_sath_karbari);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 154);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات را وارد کنید";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(169, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "تکرار رمز عبور";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_close);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 56);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BoldedForeColor = System.Drawing.Color.Blue;
            this.btn_delete.HolidayForeColor = System.Drawing.Color.Red;
            this.btn_delete.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btn_delete.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btn_delete.IsBolded = false;
            this.btn_delete.IsHoliday = false;
            this.btn_delete.IsTrailing = false;
            this.btn_delete.Location = new System.Drawing.Point(212, 21);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.PushedAlways = false;
            this.btn_delete.SecondBorderColor = System.Drawing.Color.Red;
            this.btn_delete.SecondBorderDistanceToEdge = 3F;
            this.btn_delete.SecondBorderWidth = 3F;
            this.btn_delete.ShowFirstBorder = true;
            this.btn_delete.ShowSecondBorder = false;
            this.btn_delete.Size = new System.Drawing.Size(97, 30);
            this.btn_delete.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "حذف";
            this.btn_delete.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.BoldedForeColor = System.Drawing.Color.Blue;
            this.btn_close.HolidayForeColor = System.Drawing.Color.Red;
            this.btn_close.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btn_close.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btn_close.IsBolded = false;
            this.btn_close.IsHoliday = false;
            this.btn_close.IsTrailing = false;
            this.btn_close.Location = new System.Drawing.Point(91, 21);
            this.btn_close.Name = "btn_close";
            this.btn_close.PushedAlways = false;
            this.btn_close.SecondBorderColor = System.Drawing.Color.Red;
            this.btn_close.SecondBorderDistanceToEdge = 3F;
            this.btn_close.SecondBorderWidth = 3F;
            this.btn_close.ShowFirstBorder = true;
            this.btn_close.ShowSecondBorder = false;
            this.btn_close.Size = new System.Drawing.Size(97, 30);
            this.btn_close.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "خروج";
            this.btn_close.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BoldedForeColor = System.Drawing.Color.Blue;
            this.btn_edit.HolidayForeColor = System.Drawing.Color.Red;
            this.btn_edit.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btn_edit.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btn_edit.IsBolded = false;
            this.btn_edit.IsHoliday = false;
            this.btn_edit.IsTrailing = false;
            this.btn_edit.Location = new System.Drawing.Point(337, 21);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.PushedAlways = false;
            this.btn_edit.SecondBorderColor = System.Drawing.Color.Red;
            this.btn_edit.SecondBorderDistanceToEdge = 3F;
            this.btn_edit.SecondBorderWidth = 3F;
            this.btn_edit.ShowFirstBorder = true;
            this.btn_edit.ShowSecondBorder = false;
            this.btn_edit.Size = new System.Drawing.Size(93, 30);
            this.btn_edit.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "ویرایش";
            this.btn_edit.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BoldedForeColor = System.Drawing.Color.Blue;
            this.btn_add.HolidayForeColor = System.Drawing.Color.Red;
            this.btn_add.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btn_add.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btn_add.IsBolded = false;
            this.btn_add.IsHoliday = false;
            this.btn_add.IsTrailing = false;
            this.btn_add.Location = new System.Drawing.Point(478, 21);
            this.btn_add.Name = "btn_add";
            this.btn_add.PushedAlways = false;
            this.btn_add.SecondBorderColor = System.Drawing.Color.Red;
            this.btn_add.SecondBorderDistanceToEdge = 3F;
            this.btn_add.SecondBorderWidth = 3F;
            this.btn_add.ShowFirstBorder = true;
            this.btn_add.ShowSecondBorder = false;
            this.btn_add.Size = new System.Drawing.Size(88, 30);
            this.btn_add.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "ثبت اطلاعات";
            this.btn_add.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.data_grid_user);
            this.groupBox3.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(757, 235);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // data_grid_user
            // 
            this.data_grid_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_user.Columns_EnglishDate = ((System.Collections.Generic.List<string>)(resources.GetObject("data_grid_user.Columns_EnglishDate")));
            this.data_grid_user.Columns_PersianDate = ((System.Collections.Generic.List<string>)(resources.GetObject("data_grid_user.Columns_PersianDate")));
            this.data_grid_user.Location = new System.Drawing.Point(34, 19);
            this.data_grid_user.Name = "data_grid_user";
            this.data_grid_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_grid_user.Size = new System.Drawing.Size(669, 210);
            this.data_grid_user.TabIndex = 0;
            // 
            // cmb_sath_karbari
            // 
            this.cmb_sath_karbari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sath_karbari.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sath_karbari.FormattingEnabled = true;
            this.cmb_sath_karbari.Items.AddRange(new object[] {
            "مدیر",
            "انباردار",
            "حسابدار",
            "پروسنل"});
            this.cmb_sath_karbari.Location = new System.Drawing.Point(9, 42);
            this.cmb_sath_karbari.Name = "cmb_sath_karbari";
            this.cmb_sath_karbari.Size = new System.Drawing.Size(159, 30);
            this.cmb_sath_karbari.TabIndex = 8;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(507, 49);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(161, 29);
            this.txt_name.TabIndex = 4;
            // 
            // txt_user_name
            // 
            this.txt_user_name.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_name.Location = new System.Drawing.Point(507, 97);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(161, 29);
            this.txt_user_name.TabIndex = 9;
            // 
            // txt_namfamily
            // 
            this.txt_namfamily.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_namfamily.Location = new System.Drawing.Point(266, 42);
            this.txt_namfamily.Name = "txt_namfamily";
            this.txt_namfamily.Size = new System.Drawing.Size(161, 29);
            this.txt_namfamily.TabIndex = 10;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(266, 100);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(161, 29);
            this.txt_pass.TabIndex = 11;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // txt_tekrar_pass
            // 
            this.txt_tekrar_pass.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tekrar_pass.Location = new System.Drawing.Point(7, 94);
            this.txt_tekrar_pass.Name = "txt_tekrar_pass";
            this.txt_tekrar_pass.PasswordChar = '*';
            this.txt_tekrar_pass.Size = new System.Drawing.Size(161, 29);
            this.txt_tekrar_pass.TabIndex = 12;
            // 
            // Frm_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 475);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_user";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کاربر";
            this.Load += new System.EventHandler(this.Frm_user_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private BehComponents.ButtonX btn_delete;
        private BehComponents.ButtonX btn_close;
        private BehComponents.ButtonX btn_edit;
        private BehComponents.ButtonX btn_add;
        private System.Windows.Forms.GroupBox groupBox3;
        private BehComponents.DataGridViewX data_grid_user;
        private System.Windows.Forms.ComboBox cmb_sath_karbari;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_tekrar_pass;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_namfamily;
        private System.Windows.Forms.TextBox txt_user_name;
    }
}