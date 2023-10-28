namespace Salario_liquido_2
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            const double IRPF = 0.15;
            const double PP = 0.12;

            double salario, valoIRPF, valorPP;

            salario = double.Parse(labelSalarioBrut.Text);

            valoIRPF = salario * IRPF;
            valorPP = salario * PP;
            labelimposto.Text = valoIRPF.ToString();
            labelPrevidencia.Text = valorPP.ToString();
            labelSalarioLiq.Text = (salario - valoIRPF - valorPP).ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}