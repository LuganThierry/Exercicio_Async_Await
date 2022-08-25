using System.Diagnostics;

namespace TP.Aula08Exer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Calculos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public async Task Calculos()
        {
            Stopwatch stopwatch = new();

            stopwatch.Start();

            var folhaPagamento = FolhaPagamento();
            var imposto = Imposto();
            var receita = Receita();
            var despesa = Despesa();
            button1.Enabled = false;
            label3.ForeColor = Color.LightPink;
            label3.Text = "Cálculos sendo realizados ... ";

            await folhaPagamento;
            await imposto;
            await receita;
            await despesa;

            button1.Enabled = true;
            label3.ForeColor = Color.HotPink;
            label3.Text = "Cálculos finalizados!";

            stopwatch.Stop();

            label1.BackColor = Color.Beige;
            label1.Text = $"{folhaPagamento.Result},\n {imposto.Result},\n {receita.Result},\n {despesa.Result}";


            label2.ForeColor = Color.DarkRed;
            label2.Text = $"Tempo do processo é igual a {(stopwatch.ElapsedMilliseconds)/1000}";

        }



        public async Task<string> FolhaPagamento()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return "Retorno do método folha de pagamento";
        }

        public async Task<string> Imposto()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            return "Retorno do método imposto";
        }

        public async Task<string> Receita()
        {
            await Task.Delay(TimeSpan.FromSeconds(4));
            return "Retorno do método receita";
        }

        public async Task<string> Despesa()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            return "Retorno do método despesa";
        }

    }
}