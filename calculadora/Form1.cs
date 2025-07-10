using System.Data;

namespace calculadora
{
    public partial class Form1 : Form
    {
        string conta;
        string resultado;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.res.Text = res.Text;
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            res.Text += "1";
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            res.Text += "2";
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            res.Text += "3";
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            res.Text += "4";
        }

        private void botao5_Click(object sender, EventArgs e)
        {
            res.Text += "5";
        }

        private void botao6_Click(object sender, EventArgs e)
        {
            res.Text += "6";
        }

        private void botao7_Click(object sender, EventArgs e)
        {
            res.Text += "7";
        }

        private void botao8_Click(object sender, EventArgs e)
        {
            res.Text += "8";
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            res.Text += "9";
        }

        private void botao0_Click(object sender, EventArgs e)
        {
            res.Text += "0";
        }

        private void botaosomar_Click(object sender, EventArgs e)
        {
            res.Text += "+";
        }

        private void botaoresultado_Click(object sender, EventArgs e)
        {
            conta = res.Text;
            object resp = new DataTable().Compute(conta, null);
            resultado = Convert.ToString(resp);
            res.Text = resultado;
        }

       
    }
}
