namespace WindowsFormsApplication1.forms
{
    partial class Frm_personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_personel));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new BehComponents.ButtonX();
            this.btn_close = new BehComponents.ButtonX();
            this.btn_edit = new BehComponents.ButtonX();
            this.btn_add = new BehComponents.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_adress = new System.Windows.Forms.RichTextBox();
            this.txt_job = new System.Windows.Forms.RichTextBox();
            this.txt_tell = new System.Windows.Forms.RichTextBox();
            this.txt_code_meli = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_namfamily = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.data_grid_personel = new BehComponents.DataGridViewX(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_personel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_close);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Location = new System.Drawing.Point(-2, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 56);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BoldedForeColor = System.Drawing.Color.Blue;
            this.btn_delete.Font = new System.Drawing.Font("B Nazanin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete.HolidayForeColor = System.Drawing.Color.Red;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_delete.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btn_delete.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btn_delete.IsBolded = false;
            this.btn_delete.IsHoliday = false;
            this.btn_delete.IsTrailing = false;
            this.btn_delete.Location = new System.Drawing.Point(236, 18);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.PushedAlways = false;
            this.btn_delete.SecondBorderColor = System.Drawing.Color.Red;
            this.btn_delete.SecondBorderDistanceToEdge = 3F;
            this.btn_delete.SecondBorderWidth = 3F;
            this.btn_delete.ShowFirstBorder = true;
            this.btn_delete.ShowSecondBorder = false;
            this.btn_delete.Size = new System.Drawing.Size(110, 30);
            this.btn_delete.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "حذف";
            this.btn_delete.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_close
            // 
            this.btn_close.BoldedForeColor = System.Drawing.Color.Blue;
            this.btn_close.Font = new System.Drawing.Font("B Nazanin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_close.HolidayForeColor = System.Drawing.Color.Red;
            this.btn_close.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btn_close.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btn_close.IsBolded = false;
            this.btn_close.IsHoliday = false;
            this.btn_close.IsTrailing = false;
            this.btn_close.Location = new System.Drawing.Point(101, 18);
            this.btn_close.Name = "btn_close";
            this.btn_close.PushedAlways = false;
            this.btn_close.SecondBorderColor = System.Drawing.Color.Red;
            this.btn_close.SecondBorderDistanceToEdge = 3F;
            this.btn_close.SecondBorderWidth = 3F;
            this.btn_close.ShowFirstBorder = true;
            this.btn_close.ShowSecondBorder = false;
            this.btn_close.Size = new System.Drawing.Size(110, 30);
            this.btn_close.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "خروج";
            this.btn_close.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BoldedForeColor = System.Drawing.Color.Blue;
            this.btn_edit.Font = new System.Drawing.Font("B Nazanin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_edit.HolidayForeColor = System.Drawing.Color.Red;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_edit.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btn_edit.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btn_edit.IsBolded = false;
            this.btn_edit.IsHoliday = false;
            this.btn_edit.IsTrailing = false;
            this.btn_edit.Location = new System.Drawing.Point(362, 21);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.PushedAlways = false;
            this.btn_edit.SecondBorderColor = System.Drawing.Color.Red;
            this.btn_edit.SecondBorderDistanceToEdge = 3F;
            this.btn_edit.SecondBorderWidth = 3F;
            this.btn_edit.ShowFirstBorder = true;
            this.btn_edit.ShowSecondBorder = false;
            this.btn_edit.Size = new System.Drawing.Size(110, 30);
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
            this.btn_add.Font = new System.Drawing.Font("B Nazanin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_add.HolidayForeColor = System.Drawing.Color.Red;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_add.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btn_add.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btn_add.IsBolded = false;
            this.btn_add.IsHoliday = false;
            this.btn_add.IsTrailing = false;
            this.btn_add.Location = new System.Drawing.Point(488, 21);
            this.btn_add.Name = "btn_add";
            this.btn_add.PushedAlways = false;
            this.btn_add.SecondBorderColor = System.Drawing.Color.Red;
            this.btn_add.SecondBorderDistanceToEdge = 3F;
            this.btn_add.SecondBorderWidth = 3F;
            this.btn_add.ShowFirstBorder = true;
            this.btn_add.ShowSecondBorder = false;
            this.btn_add.Size = new System.Drawing.Size(110, 30);
            this.btn_add.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "ثبت اطلاعات";
            this.btn_add.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_adress);
            this.groupBox1.Controls.Add(this.txt_job);
            this.groupBox1.Controls.Add(this.txt_tell);
            this.groupBox1.Controls.Add(this.txt_code_meli);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_namfamily);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(-2, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 183);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات را وارد کنید";
            // 
            // txt_adress
            // 
            this.txt_adress.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adress.Location = new System.Drawing.Point(24, 89);
            this.txt_adress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(159, 26);
            this.txt_adress.TabIndex = 6;
            this.txt_adress.Text = "";
            // 
            // txt_job
            // 
            this.txt_job.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_job.Location = new System.Drawing.Point(250, 85);
            this.txt_job.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_job.Name = "txt_job";
            this.txt_job.Size = new System.Drawing.Size(159, 26);
            this.txt_job.TabIndex = 5;
            this.txt_job.Text = "";
            // 
            // txt_tell
            // 
            this.txt_tell.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tell.Location = new System.Drawing.Point(512, 85);
            this.txt_tell.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_tell.Name = "txt_tell";
            this.txt_tell.Size = new System.Drawing.Size(159, 26);
            this.txt_tell.TabIndex = 4;
            this.txt_tell.Text = "";
            // 
            // txt_code_meli
            // 
            this.txt_code_meli.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code_meli.Location = new System.Drawing.Point(24, 33);
            this.txt_code_meli.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_code_meli.Name = "txt_code_meli";
            this.txt_code_meli.Size = new System.Drawing.Size(159, 26);
            this.txt_code_meli.TabIndex = 3;
            this.txt_code_meli.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(193, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "ادرس";
            // 
            // txt_namfamily
            // 
            this.txt_namfamily.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_namfamily.Location = new System.Drawing.Point(250, 36);
            this.txt_namfamily.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_namfamily.Name = "txt_namfamily";
            this.txt_namfamily.Size = new System.Drawing.Size(159, 26);
            this.txt_namfamily.TabIndex = 2;
            this.txt_namfamily.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(193, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "کد ملی";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(689, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(672, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "شماره تلفن";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(512, 36);
            this.txt_name.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(159, 25);
            this.txt_name.TabIndex = 1;
            this.txt_name.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(433, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "شغل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(417, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام خانوادگی";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.data_grid_personel);
            this.groupBox3.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(-8, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(757, 279);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // data_grid_personel
            // 
            this.data_grid_personel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_personel.Columns_EnglishDate = ((System.Collections.Generic.List<string>)(resources.GetObject("data_grid_personel.Columns_EnglishDate")));
            this.data_grid_personel.Columns_PersianDate = ((System.Collections.Generic.List<string>)(resources.GetObject("data_grid_personel.Columns_PersianDate")));
            this.data_grid_personel.Location = new System.Drawing.Point(18, 19);
            this.data_grid_personel.Name = "data_grid_personel";
            this.data_grid_personel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_grid_personel.Size = new System.Drawing.Size(719, 260);
            this.data_grid_personel.TabIndex = 0;
            this.data_grid_personel.Click += new System.EventHandler(this.data_grid_personel_Click);
            // 
            // Frm_personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 537);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_personel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پرسنل";
            this.Load += new System.EventHandler(this.Frm_personel_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_personel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private BehComponents.ButtonX btn_delete;
        private BehComponents.ButtonX btn_close;
        private BehComponents.ButtonX btn_edit;
        private BehComponents.ButtonX btn_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txt_adress;
        private System.Windows.Forms.RichTextBox txt_job;
        private System.Windows.Forms.RichTextBox txt_tell;
        private System.Windows.Forms.RichTextBox txt_code_meli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txt_namfamily;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private BehComponents.DataGridViewX data_grid_personel;
    }
}