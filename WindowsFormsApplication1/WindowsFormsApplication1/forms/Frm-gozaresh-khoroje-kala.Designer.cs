namespace WindowsFormsApplication1.forms
{
    partial class Frm_gozaresh_khoroje_kala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_gozaresh_khoroje_kala));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data_grid_gozaresh_khoroj = new BehComponents.DataGridViewX(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_date_az = new System.Windows.Forms.RichTextBox();
            this.txt_date_ta = new System.Windows.Forms.RichTextBox();
            this.txt_search = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.com_search = new System.Windows.Forms.ComboBox();
            this.rdb_barhasb = new System.Windows.Forms.RadioButton();
            this.rdb_date = new System.Windows.Forms.RadioButton();
            this.buttonX1 = new BehComponents.ButtonX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_gozaresh_khoroj)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonX1);
            this.groupBox1.Controls.Add(this.data_grid_gozaresh_khoroj);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(-8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 518);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // data_grid_gozaresh_khoroj
            // 
            this.data_grid_gozaresh_khoroj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_gozaresh_khoroj.Columns_EnglishDate = ((System.Collections.Generic.List<string>)(resources.GetObject("data_grid_gozaresh_khoroj.Columns_EnglishDate")));
            this.data_grid_gozaresh_khoroj.Columns_PersianDate = ((System.Collections.Generic.List<string>)(resources.GetObject("data_grid_gozaresh_khoroj.Columns_PersianDate")));
            this.data_grid_gozaresh_khoroj.Location = new System.Drawing.Point(21, 198);
            this.data_grid_gozaresh_khoroj.Name = "data_grid_gozaresh_khoroj";
            this.data_grid_gozaresh_khoroj.Size = new System.Drawing.Size(717, 250);
            this.data_grid_gozaresh_khoroj.TabIndex = 1;
            this.data_grid_gozaresh_khoroj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_personel_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_date_az);
            this.groupBox2.Controls.Add(this.txt_date_ta);
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.com_search);
            this.groupBox2.Controls.Add(this.rdb_barhasb);
            this.groupBox2.Controls.Add(this.rdb_date);
            this.groupBox2.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(6, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 128);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txt_date_az
            // 
            this.txt_date_az.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_date_az.Location = new System.Drawing.Point(400, 22);
            this.txt_date_az.Name = "txt_date_az";
            this.txt_date_az.Size = new System.Drawing.Size(121, 27);
            this.txt_date_az.TabIndex = 10;
            this.txt_date_az.Text = "";
            // 
            // txt_date_ta
            // 
            this.txt_date_ta.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_date_ta.Location = new System.Drawing.Point(161, 22);
            this.txt_date_ta.Name = "txt_date_ta";
            this.txt_date_ta.Size = new System.Drawing.Size(121, 27);
            this.txt_date_ta.TabIndex = 9;
            this.txt_date_ta.Text = "";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_search.Location = new System.Drawing.Point(161, 83);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(121, 27);
            this.txt_search.TabIndex = 8;
            this.txt_search.Text = "";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "از";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "تا";
            // 
            // com_search
            // 
            this.com_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_search.FormattingEnabled = true;
            this.com_search.Items.AddRange(new object[] {
            "گروه کالا",
            "نام کالا",
            "مدل کالا"});
            this.com_search.Location = new System.Drawing.Point(400, 83);
            this.com_search.Name = "com_search";
            this.com_search.Size = new System.Drawing.Size(121, 31);
            this.com_search.TabIndex = 2;
            // 
            // rdb_barhasb
            // 
            this.rdb_barhasb.AutoSize = true;
            this.rdb_barhasb.Location = new System.Drawing.Point(641, 87);
            this.rdb_barhasb.Name = "rdb_barhasb";
            this.rdb_barhasb.Size = new System.Drawing.Size(69, 27);
            this.rdb_barhasb.TabIndex = 1;
            this.rdb_barhasb.TabStop = true;
            this.rdb_barhasb.Text = "برحسب";
            this.rdb_barhasb.UseVisualStyleBackColor = true;
            // 
            // rdb_date
            // 
            this.rdb_date.AutoSize = true;
            this.rdb_date.Location = new System.Drawing.Point(608, 29);
            this.rdb_date.Name = "rdb_date";
            this.rdb_date.Size = new System.Drawing.Size(102, 27);
            this.rdb_date.TabIndex = 0;
            this.rdb_date.TabStop = true;
            this.rdb_date.Text = "برحسب تاریخ";
            this.rdb_date.UseVisualStyleBackColor = true;
            // 
            // buttonX1
            // 
            this.buttonX1.BoldedForeColor = System.Drawing.Color.Blue;
            this.buttonX1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX1.HolidayForeColor = System.Drawing.Color.Red;
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.buttonX1.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.buttonX1.IsBolded = false;
            this.buttonX1.IsHoliday = false;
            this.buttonX1.IsTrailing = false;
            this.buttonX1.Location = new System.Drawing.Point(21, 466);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.PushedAlways = false;
            this.buttonX1.SecondBorderColor = System.Drawing.Color.Red;
            this.buttonX1.SecondBorderDistanceToEdge = 3F;
            this.buttonX1.SecondBorderWidth = 3F;
            this.buttonX1.ShowFirstBorder = true;
            this.buttonX1.ShowSecondBorder = false;
            this.buttonX1.Size = new System.Drawing.Size(51, 52);
            this.buttonX1.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.buttonX1.TabIndex = 5;
            this.buttonX1.TrailingForeColor = System.Drawing.Color.LightGray;
            this.buttonX1.UseVisualStyleBackColor = true;
            // 
            // Frm_gozaresh_khoroje_kala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 530);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_gozaresh_khoroje_kala";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش کالای خارج شده";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_gozaresh_khoroj)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BehComponents.DataGridViewX data_grid_gozaresh_khoroj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox com_search;
        private System.Windows.Forms.RadioButton rdb_barhasb;
        private System.Windows.Forms.RadioButton rdb_date;
        private System.Windows.Forms.RichTextBox txt_date_az;
        private System.Windows.Forms.RichTextBox txt_date_ta;
        private System.Windows.Forms.RichTextBox txt_search;
        private BehComponents.ButtonX buttonX1;
    }
}