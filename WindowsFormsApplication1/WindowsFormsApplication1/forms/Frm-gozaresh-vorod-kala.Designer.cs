namespace WindowsFormsApplication1.forms
{
    partial class Frm_gozaresh_vorod_kala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_gozaresh_vorod_kala));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_print = new BehComponents.ButtonX();
            this.data_gozaresh_vorod = new BehComponents.DataGridViewX(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.RichTextBox();
            this.txt_date_ta = new System.Windows.Forms.RichTextBox();
            this.txt_date_az = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.radb_barhasb = new System.Windows.Forms.RadioButton();
            this.radb_date = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gozaresh_vorod)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_print);
            this.groupBox1.Controls.Add(this.data_gozaresh_vorod);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 518);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_print
            // 
            this.btn_print.BoldedForeColor = System.Drawing.Color.Blue;
            this.btn_print.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_print.HolidayForeColor = System.Drawing.Color.Red;
            this.btn_print.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btn_print.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btn_print.IsBolded = false;
            this.btn_print.IsHoliday = false;
            this.btn_print.IsTrailing = false;
            this.btn_print.Location = new System.Drawing.Point(12, 451);
            this.btn_print.Name = "btn_print";
            this.btn_print.PushedAlways = false;
            this.btn_print.SecondBorderColor = System.Drawing.Color.Red;
            this.btn_print.SecondBorderDistanceToEdge = 3F;
            this.btn_print.SecondBorderWidth = 3F;
            this.btn_print.ShowFirstBorder = true;
            this.btn_print.ShowSecondBorder = false;
            this.btn_print.Size = new System.Drawing.Size(80, 32);
            this.btn_print.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btn_print.TabIndex = 3;
            this.btn_print.Text = "پرینت";
            this.btn_print.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // data_gozaresh_vorod
            // 
            this.data_gozaresh_vorod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gozaresh_vorod.Columns_EnglishDate = ((System.Collections.Generic.List<string>)(resources.GetObject("data_gozaresh_vorod.Columns_EnglishDate")));
            this.data_gozaresh_vorod.Columns_PersianDate = ((System.Collections.Generic.List<string>)(resources.GetObject("data_gozaresh_vorod.Columns_PersianDate")));
            this.data_gozaresh_vorod.Location = new System.Drawing.Point(12, 183);
            this.data_gozaresh_vorod.Name = "data_gozaresh_vorod";
            this.data_gozaresh_vorod.Size = new System.Drawing.Size(717, 250);
            this.data_gozaresh_vorod.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.txt_date_ta);
            this.groupBox2.Controls.Add(this.txt_date_az);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmb_search);
            this.groupBox2.Controls.Add(this.radb_barhasb);
            this.groupBox2.Controls.Add(this.radb_date);
            this.groupBox2.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(6, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 128);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_search.Location = new System.Drawing.Point(161, 83);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(121, 27);
            this.txt_search.TabIndex = 9;
            this.txt_search.Text = "";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // txt_date_ta
            // 
            this.txt_date_ta.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_date_ta.Location = new System.Drawing.Point(161, 22);
            this.txt_date_ta.Name = "txt_date_ta";
            this.txt_date_ta.Size = new System.Drawing.Size(121, 27);
            this.txt_date_ta.TabIndex = 8;
            this.txt_date_ta.Text = "";
            // 
            // txt_date_az
            // 
            this.txt_date_az.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_date_az.Location = new System.Drawing.Point(400, 25);
            this.txt_date_az.Name = "txt_date_az";
            this.txt_date_az.Size = new System.Drawing.Size(121, 27);
            this.txt_date_az.TabIndex = 7;
            this.txt_date_az.Text = "";
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
            // cmb_search
            // 
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Items.AddRange(new object[] {
            "گروه کالا",
            "نام کالا",
            "مدل کالا"});
            this.cmb_search.Location = new System.Drawing.Point(400, 83);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(121, 31);
            this.cmb_search.TabIndex = 2;
            // 
            // radb_barhasb
            // 
            this.radb_barhasb.AutoSize = true;
            this.radb_barhasb.Location = new System.Drawing.Point(628, 86);
            this.radb_barhasb.Name = "radb_barhasb";
            this.radb_barhasb.Size = new System.Drawing.Size(69, 27);
            this.radb_barhasb.TabIndex = 1;
            this.radb_barhasb.TabStop = true;
            this.radb_barhasb.Text = "برحسب";
            this.radb_barhasb.UseVisualStyleBackColor = true;
            // 
            // radb_date
            // 
            this.radb_date.AutoSize = true;
            this.radb_date.Location = new System.Drawing.Point(608, 29);
            this.radb_date.Name = "radb_date";
            this.radb_date.Size = new System.Drawing.Size(102, 27);
            this.radb_date.TabIndex = 0;
            this.radb_date.TabStop = true;
            this.radb_date.Text = "برحسب تاریخ";
            this.radb_date.UseVisualStyleBackColor = true;
            // 
            // Frm_gozaresh_vorod_kala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 523);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_gozaresh_vorod_kala";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش ورود کالا";
            this.Load += new System.EventHandler(this.Frm_gozaresh_vorod_kala_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_gozaresh_vorod)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private BehComponents.DataGridViewX data_gozaresh_vorod;
        private System.Windows.Forms.ComboBox cmb_search;
        private System.Windows.Forms.RadioButton radb_barhasb;
        private System.Windows.Forms.RadioButton radb_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_search;
        private System.Windows.Forms.RichTextBox txt_date_ta;
        private System.Windows.Forms.RichTextBox txt_date_az;
        private BehComponents.ButtonX btn_print;
    }
}