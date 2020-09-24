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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.visit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.getRouxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fortniteIsCringeTiktokIsCringierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.numRoux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.btnMakeRoux.Location = new System.Drawing.Point(64, 158);
            this.btnMakeRoux.Name = "btnMakeRoux";
            this.btnMakeRoux.Size = new System.Drawing.Size(205, 96);
            this.btnMakeRoux.TabIndex = 4;
            this.btnMakeRoux.Text = "Make Roux";
            this.btnMakeRoux.UseVisualStyleBackColor = true;
            this.btnMakeRoux.Click += new System.EventHandler(this.btnMakeRoux_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.ForeColor = System.Drawing.Color.Lime;
            this.txtConsole.Location = new System.Drawing.Point(388, 87);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(470, 333);
            this.txtConsole.TabIndex = 5;
            this.txtConsole.TextChanged += new System.EventHandler(this.txtConsole_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Console";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(388, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 38);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // visit
            // 
            this.visit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visit.Location = new System.Drawing.Point(181, 364);
            this.visit.Name = "visit";
            this.visit.Size = new System.Drawing.Size(174, 74);
            this.visit.TabIndex = 10;
            this.visit.Text = "Visit ROBLOX";
            this.visit.UseVisualStyleBackColor = true;
            this.visit.Click += new System.EventHandler(this.visit_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(12, 364);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(147, 74);
            this.clear.TabIndex = 8;
            this.clear.Text = "Clear Console";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getRouxToolStripMenuItem,
            this.fortniteIsCringeTiktokIsCringierToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // getRouxToolStripMenuItem
            // 
            this.getRouxToolStripMenuItem.Name = "getRouxToolStripMenuItem";
            this.getRouxToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.getRouxToolStripMenuItem.Text = "Get Secret Roux";
            this.getRouxToolStripMenuItem.Click += new System.EventHandler(this.getRouxToolStripMenuItem_Click);
            // 
            // fortniteIsCringeTiktokIsCringierToolStripMenuItem
            // 
            this.fortniteIsCringeTiktokIsCringierToolStripMenuItem.Name = "fortniteIsCringeTiktokIsCringierToolStripMenuItem";
            this.fortniteIsCringeTiktokIsCringierToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fortniteIsCringeTiktokIsCringierToolStripMenuItem.Text = "Get V-Bucks";
            this.fortniteIsCringeTiktokIsCringierToolStripMenuItem.Click += new System.EventHandler(this.fortniteIsCringeTiktokIsCringierToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(907, 27);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 547);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.visit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btnMakeRoux);
            this.Controls.Add(this.numRoux);
            this.Controls.Add(this.lblRoux);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "roux reward";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRoux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button visit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem getRouxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fortniteIsCringeTiktokIsCringierToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

