using System.Numerics;

namespace ConversorBinario {
    public partial class Form1 : Form {
        private string binaryNumber;
        private object decimalNumber;
        private object hexadecimalNumber;
        private object binary;

        public Form1() {
            InitializeComponent();
        }

        private void lblResultado_Click(object sender, EventArgs e) {

        }

        private void btnConverter_Click(object sender, EventArgs e) {

            string numero = txtNumero.Text;

            if(rdnDecimalBinario.Checked == true) { // Converter numero de Binário para Decimal
                int binarioDecimal = BinarioDecimal(numero);
                lblResultado.Text = binarioDecimal.ToString();
            } else if(rdnBinarioDecimal.Checked == true) { // Converter numero de Decimal para Binário
                int decimalBinario;
                if(!int.TryParse(txtNumero.Text, out decimalBinario)) {
                    MessageBox.Show("Por favor, insira um número decimal válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string numerosBinarios = DecimalBinario(decimalBinario);
                lblResultado.Text = numerosBinarios.ToString();
            }
        }
        private int BinarioDecimal(string binario) {
            int numeroDecimal = 0;
            int power = 0;

            for(int i = binario.Length - 1; i >= 0; i--) {
                if(binario[i] == '1') {
                    numeroDecimal += (int)Math.Pow(2, power);
                }
                power++;
            }

            return numeroDecimal;
        }

        private string DecimalBinario(int numerosDecimais) {
            if(numerosDecimais == 0) {
                return "0";
            }

            string numeroBinario = "";

            while(numerosDecimais > 0) {
                int remainder = numerosDecimais % 2;
                numeroBinario = remainder + numeroBinario;
                numerosDecimais /= 2;
            }

            return numeroBinario;
        }
    }
}
