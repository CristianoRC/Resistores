using System;
using System.Windows.Forms;

namespace SoftwareResistores
{
    public partial class Frm_Serie : Form
    {
        public Frm_Serie()
        {
            InitializeComponent();
        }
        Serie serie = new Serie();
        uint NResistorAtual = 0;

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Resistor.Text))
            {
                try
                {
                    listResistores.Items.Add($"R{NResistorAtual} {Txt_Resistor.Text}");
                    serie.AdicionarResistor(Convert.ToDouble(Txt_Resistor.Text));

                    Lbl_Req.Text = $"Resistência Total:: {serie.Req} Ω";
                    Txt_Resistor.Clear();

                    NResistorAtual++;//Incrementando o numero de resistores para a identificação do próximo;
                }
                catch (Exception exc)
                {
                    MessageBox.Show($"Ocorreu um erro {exc.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Adiciona um valor antes de adicionar o resistor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] ListaParcial = new string[2];
            string VariavelParcial;

            try
            {
                VariavelParcial = listResistores.SelectedItem.ToString(); //Passando o nome do itens selecionado

                listResistores.Items.Remove(listResistores.SelectedItem); //Apagando da lista

                ListaParcial = VariavelParcial.Split();

                serie.RemoverResistor(Double.Parse(ListaParcial[1])); //Removendo o valor do Req = Soma dos resistor

                Lbl_Req.Text = $"Resistência Total: {serie.Req} Ω";
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ocorreu um erro {exc.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btm_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado = serie.CalcularCorrente(double.Parse(Txt_Tensão.Text));

                Lbl_CorrenteTotal.Text = $"Corrente: {resultado} A";
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ocorreu um erro {exc.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
