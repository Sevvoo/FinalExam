
namespace FinalExam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListProduct = new System.Windows.Forms.ListBox();
            this.TreeFilters = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // ListProduct
            // 
            this.ListProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListProduct.FormattingEnabled = true;
            this.ListProduct.ItemHeight = 15;
            this.ListProduct.Location = new System.Drawing.Point(514, 0);
            this.ListProduct.Name = "ListProduct";
            this.ListProduct.Size = new System.Drawing.Size(656, 887);
            this.ListProduct.TabIndex = 0;
            // 
            // TreeFilters
            // 
            this.TreeFilters.Dock = System.Windows.Forms.DockStyle.Left;
            this.TreeFilters.Location = new System.Drawing.Point(0, 0);
            this.TreeFilters.Name = "TreeFilters";
            this.TreeFilters.Size = new System.Drawing.Size(515, 887);
            this.TreeFilters.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 887);
            this.Controls.Add(this.TreeFilters);
            this.Controls.Add(this.ListProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListProduct;
        private System.Windows.Forms.TreeView TreeFilters;
    }
}

