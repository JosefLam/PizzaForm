namespace PizzaForm
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
            this.margheritaBTN = new System.Windows.Forms.Button();
            this.pepperoniBTN = new System.Windows.Forms.Button();
            this.lbl_out = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // margheritaBTN
            // 
            this.margheritaBTN.Location = new System.Drawing.Point(12, 12);
            this.margheritaBTN.Name = "margheritaBTN";
            this.margheritaBTN.Size = new System.Drawing.Size(188, 207);
            this.margheritaBTN.TabIndex = 0;
            this.margheritaBTN.Text = "Margherita";
            this.margheritaBTN.UseVisualStyleBackColor = true;
            // 
            // pepperoniBTN
            // 
            this.pepperoniBTN.Location = new System.Drawing.Point(12, 225);
            this.pepperoniBTN.Name = "pepperoniBTN";
            this.pepperoniBTN.Size = new System.Drawing.Size(188, 213);
            this.pepperoniBTN.TabIndex = 1;
            this.pepperoniBTN.Text = "Pepperoni";
            this.pepperoniBTN.UseVisualStyleBackColor = true;
            // 
            // lbl_out
            // 
            this.lbl_out.AutoSize = true;
            this.lbl_out.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_out.Location = new System.Drawing.Point(425, 19);
            this.lbl_out.Name = "lbl_out";
            this.lbl_out.Size = new System.Drawing.Size(0, 55);
            this.lbl_out.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_out);
            this.Controls.Add(this.pepperoniBTN);
            this.Controls.Add(this.margheritaBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button margheritaBTN;
        private Button pepperoniBTN;
        private Label lbl_out;
    }
}