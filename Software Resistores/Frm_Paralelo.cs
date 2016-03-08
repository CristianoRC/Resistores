using System;
using System.Windows.Forms;

namespace SoftwareResistores
{
    public partial class Frm_Paralelo : Form
    {
        public Frm_Paralelo()
        {
            InitializeComponent();
        }

        Paralelo paralelo = new Paralelo();
        uint NumeroResistorAtual = 0;

        private void Btm_Adicionar_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Resistor.Text))
            {
                try
                {
                    listResistores.Items.Add($"R{NumeroResistorAtual} {Txt_Resistor.Text} Ω");
                    paralelo.AdicionarResistor(Convert.ToDouble(Txt_Resistor.Text));

                    Lbl_Req.Text = $"Resistência Total: {paralelo.ResistenciaEquivalente} Ω";
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

                paralelo.RemoverResistor(Double.Parse(ListaParcial[1])); //Removendo o valor do Req = Soma dos resistor

                Lbl_Req.Text = $"Resistência Total: {paralelo.ResistenciaEquivalente} Ω";
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
                double resultado = paralelo.CalcularCorrente(double.Parse(Txt_Tensão.Text));

                Lbl_CorrenteTotal.Text = $"Corrente: {resultado.ToString("0.000")} A";
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ocorreu um erro {exc.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
