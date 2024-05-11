using System.Numerics;

namespace ConversorBinario {
    public partial class Conversor : Form {

        public Conversor() {
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
            } else if(rdnBinarioHaxa.Checked == true) { // Converte numero Binário para Hexadecimal
                string numeroBinario = txtNumero.Text.Trim();
                string numeroHexadecimal = BinarioHexadecimal(numeroBinario);
                lblResultado.Text = numeroHexadecimal;
            } else if(rdnHexadecimalBinario.Checked == true) { // Converte Hexadecimal para binário
                string valorHexadecimal = txtNumero.Text.Trim();
                string numeroBinario = HexadecimalBinario(valorHexadecimal);
                lblResultado.Text = numeroBinario;
            } else if(rdnDecimalHexa.Checked == true) { // Converte Decimal para Hexadecimal
                int numeroDecimal;
                if(!int.TryParse(txtNumero.Text, out numeroDecimal)) {
                    MessageBox.Show("Por favor, insira um número decimal válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string numeroHexadecimal = DecimalHexadecimal(numeroDecimal);
                lblResultado.Text = numeroHexadecimal;
            } else if(rdnHexaDecimal.Checked == true) { // Converte Hexadecimal para Decimal
                string valorHexadecimal = txtNumero.Text.Trim();

                try {
                    int numeroDecimal = HexadecimalDecimal(valorHexadecimal);
                    lblResultado.Text = numeroDecimal.ToString();
                } catch(FormatException) {
                    MessageBox.Show("Por favor, insira um número hexadecimal válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
        private string BinarioHexadecimal(string binario) {
            while(binario.Length % 4 != 0) {
                binario = "0" + binario;
            }

            string numeroHexadecimal = "";

            for(int i = 0; i < binario.Length; i += 4) {
                string grupoBinario = binario.Substring(i, 4);
                int valorDecimal = Convert.ToInt32(grupoBinario, 2);
                string valorHexadecimal = valorDecimal.ToString("X");
                numeroHexadecimal += valorHexadecimal;
            }

            return numeroHexadecimal;
        }
        private string HexadecimalBinario(string hexadecimal) {
            string numeroBinario = "";

            foreach(char digito in hexadecimal) {
                int valorDecimal = Convert.ToInt32(digito.ToString(), 16);
                string valorBinario = Convert.ToString(valorDecimal, 2).PadLeft(4, '0');
                numeroBinario += valorBinario;
            }

            return numeroBinario;
        }
        private string DecimalHexadecimal(int numeroDecimal) {
            string numeroHexadecimal = numeroDecimal.ToString("X");
            return numeroHexadecimal;
        }
        private int HexadecimalDecimal(string hexadecimal) {
            int numeroDecimal = Convert.ToInt32(hexadecimal, 16);
            return numeroDecimal;
        }
    }
}
