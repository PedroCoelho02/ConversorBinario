namespace ConversorBinario {
    partial class Conversor {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            txtNumero = new TextBox();
            label1 = new Label();
            btnConverter = new Button();
            label2 = new Label();
            lblResultado = new Label();
            grpTipoConversor = new GroupBox();
            rdnHexaDecimal = new RadioButton();
            rdnDecimalHexa = new RadioButton();
            rdnBinarioHaxa = new RadioButton();
            rdnHexadecimalBinario = new RadioButton();
            rdnDecimalBinario = new RadioButton();
            rdnBinarioDecimal = new RadioButton();
            grpTipoConversor.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(156, 12);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 1;
            label1.Text = "Numero a ser convertido";
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(12, 260);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(244, 23);
            btnConverter.TabIndex = 2;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 228);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 3;
            label2.Text = "Resultado:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(145, 228);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(13, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "0";
            lblResultado.Click += lblResultado_Click;
            // 
            // grpTipoConversor
            // 
            grpTipoConversor.AutoSize = true;
            grpTipoConversor.Controls.Add(rdnHexaDecimal);
            grpTipoConversor.Controls.Add(rdnDecimalHexa);
            grpTipoConversor.Controls.Add(rdnBinarioHaxa);
            grpTipoConversor.Controls.Add(rdnHexadecimalBinario);
            grpTipoConversor.Controls.Add(rdnDecimalBinario);
            grpTipoConversor.Controls.Add(rdnBinarioDecimal);
            grpTipoConversor.Location = new Point(12, 41);
            grpTipoConversor.Name = "grpTipoConversor";
            grpTipoConversor.Size = new Size(244, 184);
            grpTipoConversor.TabIndex = 5;
            grpTipoConversor.TabStop = false;
            grpTipoConversor.Text = "Tipo de Conversor";
            // 
            // rdnHexaDecimal
            // 
            rdnHexaDecimal.AutoSize = true;
            rdnHexaDecimal.Location = new Point(12, 143);
            rdnHexaDecimal.Name = "rdnHexaDecimal";
            rdnHexaDecimal.Size = new Size(166, 19);
            rdnHexaDecimal.TabIndex = 5;
            rdnHexaDecimal.TabStop = true;
            rdnHexaDecimal.Text = "Hexadecimal para Decimal";
            rdnHexaDecimal.UseVisualStyleBackColor = true;
            // 
            // rdnDecimalHexa
            // 
            rdnDecimalHexa.AutoSize = true;
            rdnDecimalHexa.Location = new Point(12, 96);
            rdnDecimalHexa.Name = "rdnDecimalHexa";
            rdnDecimalHexa.Size = new Size(166, 19);
            rdnDecimalHexa.TabIndex = 4;
            rdnDecimalHexa.TabStop = true;
            rdnDecimalHexa.Text = "Decimal para Hexadecimal";
            rdnDecimalHexa.UseVisualStyleBackColor = true;
            // 
            // rdnBinarioHaxa
            // 
            rdnBinarioHaxa.AutoSize = true;
            rdnBinarioHaxa.Location = new Point(12, 46);
            rdnBinarioHaxa.Name = "rdnBinarioHaxa";
            rdnBinarioHaxa.Size = new Size(160, 19);
            rdnBinarioHaxa.TabIndex = 3;
            rdnBinarioHaxa.TabStop = true;
            rdnBinarioHaxa.Text = "Binário para Hexadecimal";
            rdnBinarioHaxa.UseVisualStyleBackColor = true;
            // 
            // rdnHexadecimalBinario
            // 
            rdnHexadecimalBinario.AutoSize = true;
            rdnHexadecimalBinario.Location = new Point(12, 118);
            rdnHexadecimalBinario.Name = "rdnHexadecimalBinario";
            rdnHexadecimalBinario.Size = new Size(160, 19);
            rdnHexadecimalBinario.TabIndex = 2;
            rdnHexadecimalBinario.TabStop = true;
            rdnHexadecimalBinario.Text = "Hexadecimal para Binário";
            rdnHexadecimalBinario.UseVisualStyleBackColor = true;
            // 
            // rdnDecimalBinario
            // 
            rdnDecimalBinario.AutoSize = true;
            rdnDecimalBinario.Location = new Point(12, 22);
            rdnDecimalBinario.Name = "rdnDecimalBinario";
            rdnDecimalBinario.Size = new Size(134, 19);
            rdnDecimalBinario.TabIndex = 1;
            rdnDecimalBinario.TabStop = true;
            rdnDecimalBinario.Text = "Binário para Decimal";
            rdnDecimalBinario.UseVisualStyleBackColor = true;
            // 
            // rdnBinarioDecimal
            // 
            rdnBinarioDecimal.AutoSize = true;
            rdnBinarioDecimal.Location = new Point(12, 71);
            rdnBinarioDecimal.Name = "rdnBinarioDecimal";
            rdnBinarioDecimal.Size = new Size(134, 19);
            rdnBinarioDecimal.TabIndex = 0;
            rdnBinarioDecimal.TabStop = true;
            rdnBinarioDecimal.Text = "Decimal para Binário";
            rdnBinarioDecimal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 295);
            Controls.Add(grpTipoConversor);
            Controls.Add(lblResultado);
            Controls.Add(label2);
            Controls.Add(btnConverter);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Conversor de Binários";
            grpTipoConversor.ResumeLayout(false);
            grpTipoConversor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Label label1;
        private Button btnConverter;
        private Label label2;
        private Label lblResultado;
        private GroupBox grpTipoConversor;
        private RadioButton rdnHexadecimalBinario;
        private RadioButton rdnDecimalBinario;
        private RadioButton rdnBinarioDecimal;
        private RadioButton rdnBinarioHaxa;
        private RadioButton rdnDecimalHexa;
        private RadioButton rdnHexaDecimal;
    }
}
