namespace WindowsFormsApplication1.forms
{
    partial class frm_taghir_pass
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt__pass = new System.Windows.Forms.RichTextBox();
            this.txt_user_name = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_pass_new = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tekrar_pass_new = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new BehComponents.ButtonX();
            this.btn_edit = new BehComponents.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(495, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 79);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt__pass);
            this.groupBox1.Controls.Add(this.txt_user_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txt__pass
            // 
            this.txt__pass.Location = new System.Drawing.Point(8, 23);
            this.txt__pass.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt__pass.Name = "txt__pass";
            this.txt__pass.Size = new System.Drawing.Size(135, 26);
            this.txt__pass.TabIndex = 16;
            this.txt__pass.Text = "";
            // 
            // txt_user_name
            // 
            this.txt_user_name.Location = new System.Drawing.Point(256, 23);
            this.txt_user_name.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(135, 26);
            this.txt_user_name.TabIndex = 17;
            this.txt_user_name.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "رمز عبور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "نام کاربری";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_pass_new);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_tekrar_pass_new);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txt_pass_new
            // 
            this.txt_pass_new.Location = new System.Drawing.Point(306, 34);
            this.txt_pass_new.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_pass_new.Name = "txt_pass_new";
            this.txt_pass_new.Size = new System.Drawing.Size(135, 26);
            this.txt_pass_new.TabIndex = 20;
            this.txt_pass_new.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "رمز عبور جدید";
            // 
            // txt_tekrar_pass_new
            // 
            this.txt_tekrar_pass_new.Location = new System.Drawing.Point(32, 33);
            this.txt_tekrar_pass_new.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_tekrar_pass_new.Name = "txt_tekrar_pass_new";
            this.txt_tekrar_pass_new.Size = new System.Drawing.Size(135, 26);
            this.txt_tekrar_pass_new.TabIndex = 18;
            this.txt_tekrar_pass_new.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "تکرار رمز عبور جدید";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_edit);
            this.groupBox3.Location = new System.Drawing.Point(112, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 77);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
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
            this.btn_delete.Location = new System.Drawing.Point(81, 23);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.PushedAlways = false;
            this.btn_delete.SecondBorderColor = System.Drawing.Color.Red;
            this.btn_delete.SecondBorderDistanceToEdge = 3F;
            this.btn_delete.SecondBorderWidth = 3F;
            this.btn_delete.ShowFirstBorder = true;
            this.btn_delete.ShowSecondBorder = false;
            this.btn_delete.Size = new System.Drawing.Size(112, 30);
            this.btn_delete.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "حذف";
            this.btn_delete.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.btn_edit.Location = new System.Drawing.Point(222, 23);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.PushedAlways = false;
            this.btn_edit.SecondBorderColor = System.Drawing.Color.Red;
            this.btn_edit.SecondBorderDistanceToEdge = 3F;
            this.btn_edit.SecondBorderWidth = 3F;
            this.btn_edit.ShowFirstBorder = true;
            this.btn_edit.ShowSecondBorder = false;
            this.btn_edit.Size = new System.Drawing.Size(107, 30);
            this.btn_edit.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "ویرایش";
            this.btn_edit.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // frm_taghir_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 351);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_taghir_pass";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغییر رمز ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txt__pass;
        private System.Windows.Forms.RichTextBox txt_user_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txt_pass_new;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_tekrar_pass_new;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private BehComponents.ButtonX btn_delete;
        private BehComponents.ButtonX btn_edit;
    }
}