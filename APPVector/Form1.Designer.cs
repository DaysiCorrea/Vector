namespace APPVector
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
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.basicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantDeParesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarMenorAMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarElementoPoscPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirCadaElementoVectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantElementoCapicuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantElementoPrimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(64, 95);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(130, 88);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(259, 85);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(80, 139);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(119, 187);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicaToolStripMenuItem,
            this.avanzadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // basicaToolStripMenuItem
            // 
            this.basicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.mostrarToolStripMenuItem});
            this.basicaToolStripMenuItem.Name = "basicaToolStripMenuItem";
            this.basicaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.basicaToolStripMenuItem.Text = "Basica";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // avanzadoToolStripMenuItem
            // 
            this.avanzadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertirToolStripMenuItem,
            this.cantDeParesToolStripMenuItem,
            this.ordenarMenorAMayorToolStripMenuItem,
            this.eliminarElementoPoscPToolStripMenuItem,
            this.invertirCadaElementoVectorToolStripMenuItem,
            this.cantElementoCapicuaToolStripMenuItem,
            this.cantElementoPrimoToolStripMenuItem});
            this.avanzadoToolStripMenuItem.Name = "avanzadoToolStripMenuItem";
            this.avanzadoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.avanzadoToolStripMenuItem.Text = "Avanzado";
            // 
            // invertirToolStripMenuItem
            // 
            this.invertirToolStripMenuItem.Name = "invertirToolStripMenuItem";
            this.invertirToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.invertirToolStripMenuItem.Text = "Invertir";
            this.invertirToolStripMenuItem.Click += new System.EventHandler(this.invertirToolStripMenuItem_Click);
            // 
            // cantDeParesToolStripMenuItem
            // 
            this.cantDeParesToolStripMenuItem.Name = "cantDeParesToolStripMenuItem";
            this.cantDeParesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.cantDeParesToolStripMenuItem.Text = "Cant.De Pares";
            this.cantDeParesToolStripMenuItem.Click += new System.EventHandler(this.cantDeParesToolStripMenuItem_Click);
            // 
            // ordenarMenorAMayorToolStripMenuItem
            // 
            this.ordenarMenorAMayorToolStripMenuItem.Name = "ordenarMenorAMayorToolStripMenuItem";
            this.ordenarMenorAMayorToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.ordenarMenorAMayorToolStripMenuItem.Text = "Ordenar Menor a Mayor";
            this.ordenarMenorAMayorToolStripMenuItem.Click += new System.EventHandler(this.ordenarMenorAMayorToolStripMenuItem_Click);
            // 
            // eliminarElementoPoscPToolStripMenuItem
            // 
            this.eliminarElementoPoscPToolStripMenuItem.Name = "eliminarElementoPoscPToolStripMenuItem";
            this.eliminarElementoPoscPToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.eliminarElementoPoscPToolStripMenuItem.Text = "Eliminar Elemento Posc. P";
            this.eliminarElementoPoscPToolStripMenuItem.Click += new System.EventHandler(this.eliminarElementoPoscPToolStripMenuItem_Click);
            // 
            // invertirCadaElementoVectorToolStripMenuItem
            // 
            this.invertirCadaElementoVectorToolStripMenuItem.Name = "invertirCadaElementoVectorToolStripMenuItem";
            this.invertirCadaElementoVectorToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.invertirCadaElementoVectorToolStripMenuItem.Text = "Invertir Cada Elemento Vector";
            this.invertirCadaElementoVectorToolStripMenuItem.Click += new System.EventHandler(this.invertirCadaElementoVectorToolStripMenuItem_Click);
            // 
            // cantElementoCapicuaToolStripMenuItem
            // 
            this.cantElementoCapicuaToolStripMenuItem.Name = "cantElementoCapicuaToolStripMenuItem";
            this.cantElementoCapicuaToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.cantElementoCapicuaToolStripMenuItem.Text = "Cant.Elemento Capicua";
            this.cantElementoCapicuaToolStripMenuItem.Click += new System.EventHandler(this.cantElementoCapicuaToolStripMenuItem_Click);
            // 
            // cantElementoPrimoToolStripMenuItem
            // 
            this.cantElementoPrimoToolStripMenuItem.Name = "cantElementoPrimoToolStripMenuItem";
            this.cantElementoPrimoToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.cantElementoPrimoToolStripMenuItem.Text = "Cant.Elemento Primo";
            this.cantElementoPrimoToolStripMenuItem.Click += new System.EventHandler(this.cantElementoPrimoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 261);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem basicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantDeParesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarMenorAMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarElementoPoscPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertirCadaElementoVectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantElementoCapicuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantElementoPrimoToolStripMenuItem;
    }
}

