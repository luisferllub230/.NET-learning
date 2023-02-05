namespace MyNavegador
{
    partial class MyNavegador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyNavegador));
            this.menu = new System.Windows.Forms.ToolStrip();
            this.rButton = new System.Windows.Forms.ToolStripButton();
            this.aButton = new System.Windows.Forms.ToolStripButton();
            this.recargarButton = new System.Windows.Forms.ToolStripButton();
            this.homeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtUrl = new System.Windows.Forms.ToolStripTextBox();
            this.buscarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.favoritosCB = new System.Windows.Forms.ToolStripComboBox();
            this.favoritosButton = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rButton,
            this.aButton,
            this.recargarButton,
            this.homeButton,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.txtUrl,
            this.buscarButton,
            this.toolStripSeparator3,
            this.favoritosCB,
            this.favoritosButton});
            this.menu.Location = new System.Drawing.Point(0, 9);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(924, 25);
            this.menu.TabIndex = 0;
            this.menu.Text = "toolStrip1";
            // 
            // rButton
            // 
            this.rButton.AccessibleDescription = "go back";
            this.rButton.AccessibleName = "back button";
            this.rButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rButton.Image = ((System.Drawing.Image)(resources.GetObject("rButton.Image")));
            this.rButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rButton.Name = "rButton";
            this.rButton.Size = new System.Drawing.Size(23, 22);
            this.rButton.Text = "toolStripButton1";
            this.rButton.Click += new System.EventHandler(this.rButton_Click);
            // 
            // aButton
            // 
            this.aButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aButton.Image = ((System.Drawing.Image)(resources.GetObject("aButton.Image")));
            this.aButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(23, 22);
            this.aButton.Text = "toolStripButton1";
            this.aButton.Click += new System.EventHandler(this.aButton_Click);
            // 
            // recargarButton
            // 
            this.recargarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recargarButton.Image = ((System.Drawing.Image)(resources.GetObject("recargarButton.Image")));
            this.recargarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.recargarButton.Name = "recargarButton";
            this.recargarButton.Size = new System.Drawing.Size(23, 22);
            this.recargarButton.Text = "toolStripButton1";
            this.recargarButton.Click += new System.EventHandler(this.recargarButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(23, 22);
            this.homeButton.Text = "toolStripButton1";
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(600, 25);
            // 
            // buscarButton
            // 
            this.buscarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buscarButton.Image = ((System.Drawing.Image)(resources.GetObject("buscarButton.Image")));
            this.buscarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(23, 22);
            this.buscarButton.Text = "toolStripButton1";
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // favoritosCB
            // 
            this.favoritosCB.Name = "favoritosCB";
            this.favoritosCB.Size = new System.Drawing.Size(121, 25);
            this.favoritosCB.SelectedIndexChanged += new System.EventHandler(this.favoritosCB_SelectedIndexChanged);
            // 
            // favoritosButton
            // 
            this.favoritosButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.favoritosButton.Image = ((System.Drawing.Image)(resources.GetObject("favoritosButton.Image")));
            this.favoritosButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.favoritosButton.Name = "favoritosButton";
            this.favoritosButton.Size = new System.Drawing.Size(23, 22);
            this.favoritosButton.Text = "toolStripButton1";
            this.favoritosButton.Click += new System.EventHandler(this.favoritosButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 38);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(924, 412);
            this.webBrowser1.TabIndex = 1;
            // 
            // MyNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menu);
            this.Name = "MyNavegador";
            this.Text = "MyNavegador";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton rButton;
        private System.Windows.Forms.ToolStripButton aButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripButton recargarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton homeButton;
        private System.Windows.Forms.ToolStripTextBox txtUrl;
        private System.Windows.Forms.ToolStripButton buscarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton favoritosButton;
        private System.Windows.Forms.ToolStripComboBox favoritosCB;
    }
}

