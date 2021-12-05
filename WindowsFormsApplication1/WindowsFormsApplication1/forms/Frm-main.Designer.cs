namespace WindowsFormsApplication1.forms
{
    partial class انبارداری
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
            this.advPropertyGrid1 = new DevComponents.DotNetBar.AdvPropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // advPropertyGrid1
            // 
            this.advPropertyGrid1.GridLinesColor = System.Drawing.Color.WhiteSmoke;
            this.advPropertyGrid1.Location = new System.Drawing.Point(644, 118);
            this.advPropertyGrid1.Name = "advPropertyGrid1";
            this.advPropertyGrid1.Size = new System.Drawing.Size(46, 31);
            this.advPropertyGrid1.TabIndex = 0;
            this.advPropertyGrid1.Text = "advPropertyGrid1";
            // 
            // انبارداری
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 725);
            this.Controls.Add(this.advPropertyGrid1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "انبارداری";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انبارداری";
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.AdvPropertyGrid advPropertyGrid1;
    }
}