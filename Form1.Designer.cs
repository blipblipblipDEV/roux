namespace roux
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRoux = new System.Windows.Forms.Label();
            this.numRoux = new System.Windows.Forms.NumericUpDown();
            this.btnMakeRoux = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRoux)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(98, 43);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(230, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(13, 43);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblRoux
            // 
            this.lblRoux.AutoSize = true;
            this.lblRoux.Location = new System.Drawing.Point(16, 102);
            this.lblRoux.Name = "lblRoux";
            this.lblRoux.Size = new System.Drawing.Size(99, 17);
            this.lblRoux.TabIndex = 2;
            this.lblRoux.Text = "Roux To Make";
            // 
            // numRoux
            // 
            this.numRoux.Location = new System.Drawing.Point(130, 102);
            this.numRoux.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numRoux.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoux.Name = "numRoux";
            this.numRoux.Size = new System.Drawing.Size(120, 22);
            this.numRoux.TabIndex = 3;
            this.numRoux.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnMakeRoux
            // 
            this.btnMakeRoux.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeRoux.Location = new System.Drawing.Point(29, 159);
            this.btnMakeRoux.Name = "btnMakeRoux";
            this.btnMakeRoux.Size = new System.Drawing.Size(205, 96);
            this.btnMakeRoux.TabIndex = 4;
            this.btnMakeRoux.Text = "Make Roux";
            this.btnMakeRoux.UseVisualStyleBackColor = true;
            this.btnMakeRoux.Click += new System.EventHandler(this.btnMakeRoux_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(399, 37);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(355, 333);
            this.txtConsole.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btnMakeRoux);
            this.Controls.Add(this.numRoux);
            this.Controls.Add(this.lblRoux);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "roux reward";
            ((System.ComponentModel.ISupportInitialize)(this.numRoux)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRoux;
        private System.Windows.Forms.NumericUpDown numRoux;
        private System.Windows.Forms.Button btnMakeRoux;
        private System.Windows.Forms.TextBox txtConsole;
    }
}

