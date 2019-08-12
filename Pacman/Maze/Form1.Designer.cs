namespace Maze
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.eZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hard4MeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSANEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.איטיToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.נורמליToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מהירToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מהירמאודToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.פורמולהאחתToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eZToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.hard4MeToolStripMenuItem,
            this.iNSANEToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(59, 22);
            this.toolStripDropDownButton1.Text = "רמה";
            // 
            // eZToolStripMenuItem
            // 
            this.eZToolStripMenuItem.Name = "eZToolStripMenuItem";
            this.eZToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eZToolStripMenuItem.Text = "2EZ";
            this.eZToolStripMenuItem.Click += new System.EventHandler(this.eZToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // hard4MeToolStripMenuItem
            // 
            this.hard4MeToolStripMenuItem.Name = "hard4MeToolStripMenuItem";
            this.hard4MeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hard4MeToolStripMenuItem.Text = "2Hard4Me";
            this.hard4MeToolStripMenuItem.Click += new System.EventHandler(this.hard4MeToolStripMenuItem_Click);
            // 
            // iNSANEToolStripMenuItem
            // 
            this.iNSANEToolStripMenuItem.Name = "iNSANEToolStripMenuItem";
            this.iNSANEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iNSANEToolStripMenuItem.Text = "INSANE!!";
            this.iNSANEToolStripMenuItem.Click += new System.EventHandler(this.iNSANEToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.איטיToolStripMenuItem,
            this.נורמליToolStripMenuItem,
            this.מהירToolStripMenuItem,
            this.מהירמאודToolStripMenuItem,
            this.פורמולהאחתToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(75, 22);
            this.toolStripDropDownButton2.Text = "מהירות";
            // 
            // איטיToolStripMenuItem
            // 
            this.איטיToolStripMenuItem.Name = "איטיToolStripMenuItem";
            this.איטיToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.איטיToolStripMenuItem.Text = "איטי";
            this.איטיToolStripMenuItem.Click += new System.EventHandler(this.איטיToolStripMenuItem_Click);
            // 
            // נורמליToolStripMenuItem
            // 
            this.נורמליToolStripMenuItem.Name = "נורמליToolStripMenuItem";
            this.נורמליToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.נורמליToolStripMenuItem.Text = "נורמלי";
            this.נורמליToolStripMenuItem.Click += new System.EventHandler(this.נורמליToolStripMenuItem_Click);
            // 
            // מהירToolStripMenuItem
            // 
            this.מהירToolStripMenuItem.Name = "מהירToolStripMenuItem";
            this.מהירToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.מהירToolStripMenuItem.Text = "מהיר";
            this.מהירToolStripMenuItem.Click += new System.EventHandler(this.מהירToolStripMenuItem_Click);
            // 
            // מהירמאודToolStripMenuItem
            // 
            this.מהירמאודToolStripMenuItem.Name = "מהירמאודToolStripMenuItem";
            this.מהירמאודToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.מהירמאודToolStripMenuItem.Text = "מהיר מאוד";
            this.מהירמאודToolStripMenuItem.Click += new System.EventHandler(this.מהירמאודToolStripMenuItem_Click);
            // 
            // פורמולהאחתToolStripMenuItem
            // 
            this.פורמולהאחתToolStripMenuItem.Name = "פורמולהאחתToolStripMenuItem";
            this.פורמולהאחתToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.פורמולהאחתToolStripMenuItem.Text = "פורמולה אחת";
            this.פורמולהאחתToolStripMenuItem.Click += new System.EventHandler(this.פורמולהאחתToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(728, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // timer2
            // 
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 300;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(205, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Press any key to start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(724, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(379, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Welcome to my Pacman game";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(728, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(471, 62);
            this.label4.TabIndex = 4;
            this.label4.Text = "Try to avoid those ghosts and get all\r\n these yellow points to win the game !!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(728, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(525, 62);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tip: Ghosts can\'t move through each other\r\nso try to make it an advantage.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(728, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(480, 62);
            this.label6.TabIndex = 6;
            this.label6.Text = "You can change the level of the ghosts\r\nAnd you can even change your speed!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(728, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(446, 62);
            this.label7.TabIndex = 7;
            this.label7.Text = "Be careful, ghosts can take the dots\r\nand put them in other places";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 802);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pacman Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem eZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hard4MeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem איטיToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem נורמליToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מהירToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מהירמאודToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem פורמולהאחתToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem iNSANEToolStripMenuItem;
    }
}

