namespace MiCalculadora
{
    partial class FormCalculadora
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
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.lblReesultado = new System.Windows.Forms.Label();
			this.cmbOperador = new System.Windows.Forms.ComboBox();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.btnOperar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnConvertirABinario = new System.Windows.Forms.Button();
			this.btnConvertirADecimal = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNumero1
			// 
			this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero1.Location = new System.Drawing.Point(141, 84);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(124, 38);
			this.txtNumero1.TabIndex = 9;
			// 
			// lblReesultado
			// 
			this.lblReesultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblReesultado.AutoSize = true;
			this.lblReesultado.BackColor = System.Drawing.SystemColors.Control;
			this.lblReesultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReesultado.Location = new System.Drawing.Point(332, 23);
			this.lblReesultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblReesultado.Name = "lblReesultado";
			this.lblReesultado.Size = new System.Drawing.Size(0, 38);
			this.lblReesultado.TabIndex = 1;
			this.lblReesultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// cmbOperador
			// 
			this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbOperador.FormattingEnabled = true;
			this.cmbOperador.ItemHeight = 31;
			this.cmbOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
			this.cmbOperador.Location = new System.Drawing.Point(297, 83);
			this.cmbOperador.Margin = new System.Windows.Forms.Padding(4);
			this.cmbOperador.Name = "cmbOperador";
			this.cmbOperador.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbOperador.Size = new System.Drawing.Size(129, 39);
			this.cmbOperador.TabIndex = 2;

			// 
			// txtNumero2
			// 
			this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero2.Location = new System.Drawing.Point(461, 83);
			this.txtNumero2.Margin = new System.Windows.Forms.Padding(4);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(123, 38);
			this.txtNumero2.TabIndex = 3;
			// 
			// btnOperar
			// 
			this.btnOperar.Location = new System.Drawing.Point(141, 135);
			this.btnOperar.Margin = new System.Windows.Forms.Padding(4);
			this.btnOperar.Name = "btnOperar";
			this.btnOperar.Size = new System.Drawing.Size(124, 60);
			this.btnOperar.TabIndex = 4;
			this.btnOperar.Text = "Operar";
			this.btnOperar.UseVisualStyleBackColor = true;
			this.btnOperar.Click += new System.EventHandler(this.BtnOperar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(297, 138);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(124, 58);
			this.btnLimpiar.TabIndex = 5;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(460, 137);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(124, 59);
			this.btnCerrar.TabIndex = 6;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
			// 
			// btnConvertirABinario
			// 
			this.btnConvertirABinario.Location = new System.Drawing.Point(141, 225);
			this.btnConvertirABinario.Margin = new System.Windows.Forms.Padding(4);
			this.btnConvertirABinario.Name = "btnConvertirABinario";
			this.btnConvertirABinario.Size = new System.Drawing.Size(205, 55);
			this.btnConvertirABinario.TabIndex = 7;
			this.btnConvertirABinario.Text = "Convertir a Binario";
			this.btnConvertirABinario.UseVisualStyleBackColor = true;
			this.btnConvertirABinario.Click += new System.EventHandler(this.BtnABinario_Click);
			// 
			// btnConvertirADecimal
			// 
			this.btnConvertirADecimal.Location = new System.Drawing.Point(379, 226);
			this.btnConvertirADecimal.Margin = new System.Windows.Forms.Padding(4);
			this.btnConvertirADecimal.Name = "btnConvertirADecimal";
			this.btnConvertirADecimal.Size = new System.Drawing.Size(205, 54);
			this.btnConvertirADecimal.TabIndex = 8;
			this.btnConvertirADecimal.Text = "Convertir a Decimal";
			this.btnConvertirADecimal.UseVisualStyleBackColor = true;
			this.btnConvertirADecimal.Click += new System.EventHandler(this.BtnADecimal_Click);
			// 
			// FormCalculadora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScrollMargin = new System.Drawing.Size(10, 0);
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(681, 397);
			this.Controls.Add(this.btnConvertirADecimal);
			this.Controls.Add(this.btnConvertirABinario);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnOperar);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.cmbOperador);
			this.Controls.Add(this.lblReesultado);
			this.Controls.Add(this.txtNumero1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormCalculadora";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculadora de Eliseo Luquez del curso 2D";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label lblReesultado;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.Button btnConvertirADecimal;
    }
}

