namespace WindowsFormsApplication1.forms
{
    partial class frm_gozaresh_kalaye_mayob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_gozaresh_kalaye_mayob));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonX1 = new BehComponents.ButtonX();
            this.data_grid_gozaresh_mayob = new BehComponents.DataGridViewX(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.RichTextBox();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_gozaresh_mayob)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonX1);
            this.groupBox1.Controls.Add(this.data_grid_gozaresh_mayob);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(0, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 523);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
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
            this.buttonX1.Location = new System.Drawing.Point(20, 448);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.PushedAlways = false;
            this.buttonX1.SecondBorderColor = System.Drawing.Color.Red;
            this.buttonX1.SecondBorderDistanceToEdge = 3F;
            this.buttonX1.SecondBorderWidth = 3F;
            this.buttonX1.ShowFirstBorder = true;
            this.buttonX1.ShowSecondBorder = false;
            this.buttonX1.Size = new System.Drawing.Size(51, 52);
            this.buttonX1.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.buttonX1.TabIndex = 2;
            this.buttonX1.TrailingForeColor = System.Drawing.Color.LightGray;
            this.buttonX1.UseVisualStyleBackColor = true;
            // 
            // data_grid_gozaresh_mayob
            // 
            this.data_grid_gozaresh_mayob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_gozaresh_mayob.Columns_EnglishDate = ((System.Collections.Generic.List<string>)(resources.GetObject("data_grid_gozaresh_mayob.Columns_EnglishDate")));
            this.data_grid_gozaresh_mayob.Columns_PersianDate = ((System.Collections.Generic.List<string>)(resources.GetObject("data_grid_gozaresh_mayob.Columns_PersianDate")));
            this.data_grid_gozaresh_mayob.Location = new System.Drawing.Point(20, 180);
            this.data_grid_gozaresh_mayob.Name = "data_grid_gozaresh_mayob";
            this.data_grid_gozaresh_mayob.Size = new System.Drawing.Size(717, 250);
            this.data_grid_gozaresh_mayob.TabIndex = 1;
            this.data_grid_gozaresh_mayob.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_gozaresh_mayob_CellContentClick);
            this.data_grid_gozaresh_mayob.Click += new System.EventHandler(this.data_grid_gozaresh_mayob_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.cmb_search);
            this.groupBox2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 115);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(564, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "گزارش برحسب";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_search.Location = new System.Drawing.Point(133, 50);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(121, 32);
            this.txt_search.TabIndex = 9;
            this.txt_search.Text = "";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // cmb_search
            // 
            this.cmb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_search.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Items.AddRange(new object[] {
            "گروه کالا",
            "نام کالا",
            "مدل کالا"});
            this.cmb_search.Location = new System.Drawing.Point(372, 50);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(121, 32);
            this.cmb_search.TabIndex = 2;
            // 
            // frm_gozaresh_kalaye_mayob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 523);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_gozaresh_kalaye_mayob";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش کالای معیوب";
            this.Load += new System.EventHandler(this.frm_gozaresh_kalaye_mayob_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_gozaresh_mayob)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BehComponents.DataGridViewX data_grid_gozaresh_mayob;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_search;
        private System.Windows.Forms.RichTextBox txt_search;
        private BehComponents.ButtonX buttonX1;
        private System.Windows.Forms.Label label1;
    }
}