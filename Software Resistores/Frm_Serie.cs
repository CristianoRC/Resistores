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
        uint NumeroResistorAtual = 0;

        private void Btm_Adicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Resistor.Text))
            {
                try
                {
                    listResistores.Items.Add($"R{NumeroResistorAtual} {Txt_Resistor.Text} Ω");
                    serie.AdicionarResistor(Convert.ToDecimal(Txt_Resistor.Text));

                    Lbl_Req.Text = $"Resistência Total: {serie.ResistenciaEquivalente.ToString("0.000")} Ω";
                    Txt_Resistor.Clear();

                    NumeroResistorAtual++;
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

        private void Btm_Remover_Click(object sender, EventArgs e)
        {
            string[] ListaParcial = new string[2];
            string VariavelParcial;

            try
            {
                VariavelParcial = listResistores.SelectedItem.ToString(); //Passando o nome do itens selecionado

                listResistores.Items.Remove(listResistores.SelectedItem); //Apagando da lista

                ListaParcial = VariavelParcial.Split();

                serie.RemoverResistor(Decimal.Parse(ListaParcial[1])); //Removendo o valor do Req = Soma dos resistor

                Lbl_Req.Text = $"Resistência Total: {serie.ResistenciaEquivalente.ToString("0.000")} Ω";
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
                decimal resultado = serie.CalcularCorrente(Decimal.Parse(Txt_Tensão.Text));

                Lbl_CorrenteTotal.Text = $"Corrente: {resultado.ToString("0.000")} A";
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ocorreu um erro {exc.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
