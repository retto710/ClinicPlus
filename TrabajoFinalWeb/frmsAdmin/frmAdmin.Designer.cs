namespace TrabajoFinalWeb
{
    partial class frmAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doctoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeOfUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorSpecialitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctoresToolStripMenuItem,
            this.solicitudesToolStripMenuItem,
            this.lToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doctoresToolStripMenuItem
            // 
            this.doctoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.modifyToolStripMenuItem});
            this.doctoresToolStripMenuItem.Name = "doctoresToolStripMenuItem";
            this.doctoresToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.doctoresToolStripMenuItem.Text = "Accounts";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.specialityToolStripMenuItem,
            this.typeOfUserToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.agregarToolStripMenuItem.Text = "Add";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // specialityToolStripMenuItem
            // 
            this.specialityToolStripMenuItem.Name = "specialityToolStripMenuItem";
            this.specialityToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.specialityToolStripMenuItem.Text = "Speciality";
            this.specialityToolStripMenuItem.Click += new System.EventHandler(this.specialityToolStripMenuItem_Click);
            // 
            // typeOfUserToolStripMenuItem
            // 
            this.typeOfUserToolStripMenuItem.Name = "typeOfUserToolStripMenuItem";
            this.typeOfUserToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.typeOfUserToolStripMenuItem.Text = "User";
            this.typeOfUserToolStripMenuItem.Click += new System.EventHandler(this.typeOfUserToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.buscarToolStripMenuItem.Text = "List";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorSpecialitiesToolStripMenuItem});
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.modifyToolStripMenuItem.Text = "Modify";
            // 
            // doctorSpecialitiesToolStripMenuItem
            // 
            this.doctorSpecialitiesToolStripMenuItem.Name = "doctorSpecialitiesToolStripMenuItem";
            this.doctorSpecialitiesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.doctorSpecialitiesToolStripMenuItem.Text = "Doctor Specialities";
            this.doctorSpecialitiesToolStripMenuItem.Click += new System.EventHandler(this.doctorSpecialitiesToolStripMenuItem_Click);
            // 
            // solicitudesToolStripMenuItem
            // 
            this.solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            this.solicitudesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.solicitudesToolStripMenuItem.Text = "Solicitudes";
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            this.lToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.lToolStripMenuItem.Text = "LogOut";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 552);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doctoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeOfUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorSpecialitiesToolStripMenuItem;
    }
}