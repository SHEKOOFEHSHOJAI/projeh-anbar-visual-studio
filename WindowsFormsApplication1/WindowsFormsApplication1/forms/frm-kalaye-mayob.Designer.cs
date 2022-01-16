namespace WindowsFormsApplication1.forms
{
    partial class frm_kalaye_mayob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_kalaye_mayob));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_discription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.como_model_kala = new System.Windows.Forms.ComboBox();
            this.como_name_kala = new System.Windows.Forms.ComboBox();
            this.como_goroh_kala = new System.Windows.Forms.ComboBox();
            this.txt_tedad = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new BehComponents.ButtonX();
            this.btn_close = new BehComponents.ButtonX();
            this.btn_edit = new BehComponents.ButtonX();
            this.btn_add = new BehComponents.ButtonX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.data_grid_mayob = new BehComponents.DataGridViewX(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_mayob)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_discription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.como_model_kala);
            this.groupBox1.Controls.Add(this.como_name_kala);
            this.groupBox1.Controls.Add(this.como_goroh_kala);
            this.groupBox1.Controls.Add(this.txt_tedad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(-8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 183);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات را وارد کنید";
            // 
            // txt_discription
            // 
            this.txt_discription.Location = new System.Drawing.Point(31, 85);
            this.txt_discription.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_discription.Name = "txt_discription";
            this.txt_discription.Size = new System.Drawing.Size(383, 26);
            this.txt_discription.TabIndex = 9;
            this.txt_discription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(424, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "توضیحات";
            // 
            // como_model_kala
            // 
            this.como_model_kala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.como_model_kala.FormattingEnabled = true;
            this.como_model_kala.Location = new System.Drawing.Point(31, 41);
            this.como_model_kala.Name = "como_model_kala";
            this.como_model_kala.Size = new System.Drawing.Size(153, 21);
            this.como_model_kala.TabIndex = 8;
            this.como_model_kala.SelectedIndexChanged += new System.EventHandler(this.como_model_kala_SelectedIndexChanged);
            // 
            // como_name_kala
            // 
            this.como_name_kala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.como_name_kala.FormattingEnabled = true;
            this.como_name_kala.Location = new System.Drawing.Point(289, 35);
            this.como_name_kala.Name = "como_name_kala";
            this.como_name_kala.Size = new System.Drawing.Size(153, 21);
            this.como_name_kala.TabIndex = 7;
            this.como_name_kala.SelectedIndexChanged += new System.EventHandler(this.como_name_kala_SelectedIndexChanged);
            // 
            // como_goroh_kala
            // 
            this.como_goroh_kala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.como_goroh_kala.FormattingEnabled = true;
            this.como_goroh_kala.Items.AddRange(new object[] {
            "لوازم خانگی",
            "لوازم منزل",
            "لوازم اداری",
            " لوازم کشاورزی"});
            this.como_goroh_kala.Location = new System.Drawing.Point(526, 37);
            this.como_goroh_kala.Name = "como_goroh_kala";
            this.como_goroh_kala.Size = new System.Drawing.Size(153, 21);
            this.como_goroh_kala.TabIndex = 2;
            this.como_goroh_kala.SelectedIndexChanged += new System.EventHandler(this.como_goroh_kala_SelectedIndexChanged);
            // 
            // txt_tedad
            // 
            this.txt_tedad.Location = new System.Drawing.Point(526, 90);
            this.txt_tedad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_tedad.Name = "txt_tedad";
            this.txt_tedad.Size = new System.Drawing.Size(159, 26);
            this.txt_tedad.TabIndex = 5;
            this.txt_tedad.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(450, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "نام کالا";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(180, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "مدل کالا";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(692, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "تعداد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(682, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "گروه کالا";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_close);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Location = new System.Drawing.Point(2, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 56);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BoldedForeColor = System.Drawing.Color.Blue;
            this.btn_delete.Font = new System.Drawing.Font("B Nazanin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete.HolidayForeColor = System.Drawing.Color.Red;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btn_delete.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btn_delete.IsBolded = false;
            this.btn_delete.IsHoliday = false;
            this.btn_delete.IsTrailing = false;
            this.btn_delete.Location = new System.Drawing.Point(266, 16);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.PushedAlways = false;
            this.btn_delete.SecondBorderColor = System.Drawing.Color.Red;
            this.btn_delete.SecondBorderDistanceToEdge = 3F;
            this.btn_delete.SecondBorderWidth = 3F;
            this.btn_delete.ShowFirstBorder = true;
            this.btn_delete.ShowSecondBorder = false;
            this.btn_delete.Size = new System.Drawing.Size(104, 30);
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
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btn_close.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btn_close.IsBolded = false;
            this.btn_close.IsHoliday = false;
            this.btn_close.IsTrailing = false;
            this.btn_close.Location = new System.Drawing.Point(120, 15);
            this.btn_close.Name = "btn_close";
            this.btn_close.PushedAlways = false;
            this.btn_close.SecondBorderColor = System.Drawing.Color.Red;
            this.btn_close.SecondBorderDistanceToEdge = 3F;
            this.btn_close.SecondBorderWidth = 3F;
            this.btn_close.ShowFirstBorder = true;
            this.btn_close.ShowSecondBorder = false;
            this.btn_close.Size = new System.Drawing.Size(104, 30);
            this.btn_close.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "خروج";
            this.btn_close.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btn_close.UseVisualStyleBackColor = true;
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
            this.btn_edit.Location = new System.Drawing.Point(389, 15);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.PushedAlways = false;
            this.btn_edit.SecondBorderColor = System.Drawing.Color.Red;
            this.btn_edit.SecondBorderDistanceToEdge = 3F;
            this.btn_edit.SecondBorderWidth = 3F;
            this.btn_edit.ShowFirstBorder = true;
            this.btn_edit.ShowSecondBorder = false;
            this.btn_edit.Size = new System.Drawing.Size(104, 31);
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
            this.btn_add.Location = new System.Drawing.Point(508, 15);
            this.btn_add.Name = "btn_add";
            this.btn_add.PushedAlways = false;
            this.btn_add.SecondBorderColor = System.Drawing.Color.Red;
            this.btn_add.SecondBorderDistanceToEdge = 3F;
            this.btn_add.SecondBorderWidth = 3F;
            this.btn_add.ShowFirstBorder = true;
            this.btn_add.ShowSecondBorder = false;
            this.btn_add.Size = new System.Drawing.Size(104, 31);
            this.btn_add.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "ثبت اطلاعات";
            this.btn_add.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.data_grid_mayob);
            this.groupBox3.Location = new System.Drawing.Point(-8, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(757, 261);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // data_grid_mayob
            // 
            this.data_grid_mayob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_mayob.Columns_EnglishDate = ((System.Collections.Generic.List<string>)(resources.GetObject("data_grid_mayob.Columns_EnglishDate")));
            this.data_grid_mayob.Columns_PersianDate = ((System.Collections.Generic.List<string>)(resources.GetObject("data_grid_mayob.Columns_PersianDate")));
            this.data_grid_mayob.Location = new System.Drawing.Point(20, 5);
            this.data_grid_mayob.Name = "data_grid_mayob";
            this.data_grid_mayob.Size = new System.Drawing.Size(717, 250);
            this.data_grid_mayob.TabIndex = 0;
            this.data_grid_mayob.Click += new System.EventHandler(this.data_grid_mayob_Click);
            // 
            // frm_kalaye_mayob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 522);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_kalaye_mayob";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کالاهای معیوب";
            this.Load += new System.EventHandler(this.frm_kalaye_mayob_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_mayob)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox como_goroh_kala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private BehComponents.ButtonX btn_delete;
        private BehComponents.ButtonX btn_close;
        private BehComponents.ButtonX btn_edit;
        private BehComponents.ButtonX btn_add;
        private System.Windows.Forms.RichTextBox txt_discription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox como_model_kala;
        private System.Windows.Forms.ComboBox como_name_kala;
        private System.Windows.Forms.RichTextBox txt_tedad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private BehComponents.DataGridViewX data_grid_mayob;
    }
}