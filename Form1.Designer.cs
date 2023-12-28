namespace primerfromulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleNombre = new System.Windows.Forms.Label();
            this.TitleEdad = new System.Windows.Forms.Label();
            this.TextNombre = new System.Windows.Forms.TextBox();
            this.TextEdad = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.TitleSexo = new System.Windows.Forms.Label();
            this.TextSexo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleNombre
            // 
            this.TitleNombre.AutoSize = true;
            this.TitleNombre.Location = new System.Drawing.Point(116, 47);
            this.TitleNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleNombre.Name = "TitleNombre";
            this.TitleNombre.Size = new System.Drawing.Size(52, 16);
            this.TitleNombre.TabIndex = 0;
            this.TitleNombre.Text = "Nombre";
            this.TitleNombre.UseWaitCursor = true;
            // 
            // TitleEdad
            // 
            this.TitleEdad.AutoSize = true;
            this.TitleEdad.Location = new System.Drawing.Point(116, 110);
            this.TitleEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleEdad.Name = "TitleEdad";
            this.TitleEdad.Size = new System.Drawing.Size(33, 16);
            this.TitleEdad.TabIndex = 1;
            this.TitleEdad.Text = "Edad";
            this.TitleEdad.UseWaitCursor = true;
            this.TitleEdad.Click += new System.EventHandler(this.TitleEdad_Click);
            // 
            // TextNombre
            // 
            this.TextNombre.Location = new System.Drawing.Point(61, 77);
            this.TextNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(162, 21);
            this.TextNombre.TabIndex = 2;
            this.TextNombre.UseWaitCursor = true;
            this.TextNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextEdad
            // 
            this.TextEdad.Location = new System.Drawing.Point(88, 129);
            this.TextEdad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextEdad.Name = "TextEdad";
            this.TextEdad.Size = new System.Drawing.Size(80, 21);
            this.TextEdad.TabIndex = 3;
            this.TextEdad.UseWaitCursor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(38, 247);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(78, 44);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.UseWaitCursor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(147, 247);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(88, 44);
            this.BtnLimpiar.TabIndex = 5;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.UseWaitCursor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // grilla
            // 
            this.grilla.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(297, 12);
            this.grilla.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(333, 279);
            this.grilla.TabIndex = 6;
            this.grilla.UseWaitCursor = true;
            this.grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TitleSexo
            // 
            this.TitleSexo.AutoSize = true;
            this.TitleSexo.Location = new System.Drawing.Point(116, 163);
            this.TitleSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleSexo.Name = "TitleSexo";
            this.TitleSexo.Size = new System.Drawing.Size(33, 16);
            this.TitleSexo.TabIndex = 9;
            this.TitleSexo.Text = "Sexo";
            this.TitleSexo.UseWaitCursor = true;
            // 
            // TextSexo
            // 
            this.TextSexo.Location = new System.Drawing.Point(81, 182);
            this.TextSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextSexo.Name = "TextSexo";
            this.TextSexo.Size = new System.Drawing.Size(108, 21);
            this.TextSexo.TabIndex = 10;
            this.TextSexo.UseWaitCursor = true;
            this.TextSexo.TextChanged += new System.EventHandler(this.TextSexo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingrese sus Datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(643, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextSexo);
            this.Controls.Add(this.TitleSexo);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TextEdad);
            this.Controls.Add(this.TextNombre);
            this.Controls.Add(this.TitleEdad);
            this.Controls.Add(this.TitleNombre);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleNombre;
        private System.Windows.Forms.Label TitleEdad;
        private System.Windows.Forms.TextBox TextNombre;
        private System.Windows.Forms.TextBox TextEdad;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Label TitleSexo;
        private System.Windows.Forms.TextBox TextSexo;
        private System.Windows.Forms.Label label1;
    }
}

