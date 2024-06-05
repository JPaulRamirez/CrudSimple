namespace WinFormCRUD
{
    partial class FrmCRUD
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
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lstVisor = new ListBox();
            menuDesarializar = new MenuStrip();
            desarializarToolStripMenuItem = new ToolStripMenuItem();
            xMLToolStripMenuItem = new ToolStripMenuItem();
            jSONToolStripMenuItem = new ToolStripMenuItem();
            menuDesarializar.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 239);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 40);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(182, 239);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(139, 40);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(353, 239);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 40);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstVisor
            // 
            lstVisor.FormattingEnabled = true;
            lstVisor.ItemHeight = 15;
            lstVisor.Location = new Point(12, 34);
            lstVisor.Name = "lstVisor";
            lstVisor.Size = new Size(480, 199);
            lstVisor.TabIndex = 3;
            // 
            // menuDesarializar
            // 
            menuDesarializar.Items.AddRange(new ToolStripItem[] { desarializarToolStripMenuItem });
            menuDesarializar.Location = new Point(0, 0);
            menuDesarializar.Name = "menuDesarializar";
            menuDesarializar.Size = new Size(504, 24);
            menuDesarializar.TabIndex = 4;
            menuDesarializar.Text = "menuStrip1";
            // 
            // desarializarToolStripMenuItem
            // 
            desarializarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xMLToolStripMenuItem, jSONToolStripMenuItem });
            desarializarToolStripMenuItem.Name = "desarializarToolStripMenuItem";
            desarializarToolStripMenuItem.Size = new Size(78, 20);
            desarializarToolStripMenuItem.Text = "Desarializar";
            // 
            // xMLToolStripMenuItem
            // 
            xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            xMLToolStripMenuItem.Size = new Size(180, 22);
            xMLToolStripMenuItem.Text = "XML";
            xMLToolStripMenuItem.Click += xMLToolStripMenuItem_Click;
            // 
            // jSONToolStripMenuItem
            // 
            jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            jSONToolStripMenuItem.Size = new Size(180, 22);
            jSONToolStripMenuItem.Text = "JSON";
            jSONToolStripMenuItem.Click += jSONToolStripMenuItem_Click;
            // 
            // FrmCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 311);
            Controls.Add(lstVisor);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(menuDesarializar);
            Name = "FrmCRUD";
            Text = "Form1";
            menuDesarializar.ResumeLayout(false);
            menuDesarializar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private ListBox lstVisor;
        private MenuStrip menuDesarializar;
        private ToolStripMenuItem desarializarToolStripMenuItem;
        private ToolStripMenuItem xMLToolStripMenuItem;
        private ToolStripMenuItem jSONToolStripMenuItem;
    }
}