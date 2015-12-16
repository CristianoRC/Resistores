using System;
using System.Windows.Forms;

namespace Eletrônica_Software
{
    public partial class Frm_RCores : Form
    {
        public Frm_RCores()
        {
            InitializeComponent();
        }

        #region ComboBox 1 Cor
        private void Combo_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Cor_C1 = null;

            if (string.IsNullOrEmpty(Combo_1.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor insira o valor na 1ª caixa de texto", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Cor_C1 = Combo_1.SelectedItem.ToString();
            }


            switch (Cor_C1)
            {

                case "Preto":
                    Cinta1.Image = Eletrônica_Software.Properties.Resources.rPreto;

                    break;
                case "Marrom":
                    Cinta1.Image = Eletrônica_Software.Properties.Resources.rMarrom;

                    break;
                case "Vermelho":
                    Cinta1.Image = Eletrônica_Software.Properties.Resources.rVermelho;

                    break;
                case "Laranja":
                    Cinta1.Image = Eletrônica_Software.Properties.Resources.rLaranja;

                    break;
                case "Amarelo":
                    Cinta1.Image = Eletrônica_Software.Properties.Resources.rAmarelo;

                    break;
                case "Verde":
                    Cinta1.Image = Eletrônica_Software.Properties.Resources.rVerde;

                    break;
                case "Azul":
                    Cinta1.Image = Eletrônica_Software.Properties.Resources.rAzul;

                    break;
                case "Violeta":
                    Cinta1.Image = Eletrônica_Software.Properties.Resources.rVioleta;

                    break;
                case "Cinza":
                    Cinta1.Image = Eletrônica_Software.Properties.Resources.rCinza;

                    break;
                case "Branco":
                    Cinta1.Image = Eletrônica_Software.Properties.Resources.rBranco;

                    break;
            }
        }


        #endregion


        #region ComboBox 2 Cor 
        private void Combo_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Cor_C2 = null;

            if (string.IsNullOrEmpty(Combo_2.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor insira o valor na 2ª caixa de texto", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Cor_C2 = Combo_2.SelectedItem.ToString();
            }

            switch (Cor_C2)
            {

                case "Preto":
                    Cinta2.Image = Eletrônica_Software.Properties.Resources.rPreto;

                    break;
                case "Marrom":
                    Cinta2.Image = Eletrônica_Software.Properties.Resources.rMarrom;

                    break;
                case "Vermelho":
                    Cinta2.Image = Eletrônica_Software.Properties.Resources.rVermelho;

                    break;
                case "Laranja":
                    Cinta2.Image = Eletrônica_Software.Properties.Resources.rLaranja;

                    break;
                case "Amarelo":
                    Cinta2.Image = Eletrônica_Software.Properties.Resources.rAmarelo;

                    break;
                case "Verde":
                    Cinta2.Image = Eletrônica_Software.Properties.Resources.rVerde;

                    break;
                case "Azul":
                    Cinta2.Image = Eletrônica_Software.Properties.Resources.rAzul;

                    break;
                case "Violeta":
                    Cinta2.Image = Eletrônica_Software.Properties.Resources.rVioleta;

                    break;
                case "Cinza":
                    Cinta2.Image = Eletrônica_Software.Properties.Resources.rCinza;

                    break;
                case "Branco":
                    Cinta2.Image = Eletrônica_Software.Properties.Resources.rBranco;

                    break;
            }
        }

        #endregion


        #region ComboBox 3 Cor
        private void Combo_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Cor_C3 = null;

            if (string.IsNullOrEmpty(Combo_3.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor insira o valor na 3ª caixa de texto", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Combo_3.SelectedItem.ToString();
            }

            switch (Cor_C3)
            {

                case "Preto":
                    Cinta3.Image = Eletrônica_Software.Properties.Resources.rPreto;

                    break;
                case "Marrom":
                    Cinta3.Image = Eletrônica_Software.Properties.Resources.rMarrom;

                    break;
                case "Vermelho":
                    Cinta3.Image = Eletrônica_Software.Properties.Resources.rVermelho;

                    break;
                case "Laranja":
                    Cinta3.Image = Eletrônica_Software.Properties.Resources.rLaranja;

                    break;
                case "Amarelo":
                    Cinta3.Image = Eletrônica_Software.Properties.Resources.rAmarelo;

                    break;
                case "Verde":
                    Cinta3.Image = Eletrônica_Software.Properties.Resources.rVerde;

                    break;
                case "Azul":
                    Cinta3.Image = Eletrônica_Software.Properties.Resources.rAzul;

                    break;
                case "Violeta":
                    Cinta3.Image = Eletrônica_Software.Properties.Resources.rVioleta;

                    break;
                case "Cinza":
                    Cinta3.Image = Eletrônica_Software.Properties.Resources.rCinza;

                    break;
                case "Branco":
                    Cinta3.Image = Eletrônica_Software.Properties.Resources.rBranco;

                    break;
            }
        }

        #endregion


        #region ComboBox 4 Cor
        private void Combo4_SelectedIndexChanged(object sender, EventArgs e)
        {

            string Cor_C4 = null;

            if (string.IsNullOrEmpty(Combo4.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor insira o valor na 4ª caixa de texto", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Combo4.SelectedItem.ToString();
            }

            switch (Cor_C4)
            {

                case "Ouro":
                    Cinta4.Image = Eletrônica_Software.Properties.Resources.rOuro;

                    break;
                case "Prata":
                    Cinta4.Image = Eletrônica_Software.Properties.Resources.rPrata;

                    break;
                case "Nenhum":
                    Cinta4.Image = Eletrônica_Software.Properties.Resources.rNada;

                    break;
            }

        }

        #endregion

        //-------------------------------------- Botão Calcular -----------------------------------------//
        #region Botão para Calcular


        private void button1_Click(object sender, EventArgs e)
        {

            Double Resultado = 0;
            string Tolerancia = "";

            try
            {
                string Cor_C4 = Combo4.SelectedItem.ToString();
                string Cor_C3 = Combo_3.SelectedItem.ToString();
                string Cor_C2 = Combo_2.SelectedItem.ToString();
                string Cor_C1 = Combo_1.SelectedItem.ToString();

                #region Calculando Tolerancia
                switch (Cor_C4)
                {

                    case "Ouro":
                        Tolerancia = "± 5%";

                        break;
                    case "Prata":
                        Tolerancia = "± 10%";

                        break;
                    case "Nenhum":
                        Tolerancia = "± 20%";

                        break;
                }
                #endregion

                #region Calculando Primeiro Numero
                //Calculando 1 Numero
                switch (Cor_C1)
                {

                    case "Preto":
                        Resultado = 00;

                        break;
                    case "Marrom":
                        Resultado = 10;

                        break;
                    case "Vermelho":
                        Resultado = 20;

                        break;
                    case "Laranja":
                        Resultado = 30;

                        break;
                    case "Amarelo":
                        Resultado = 40;

                        break;
                    case "Verde":
                        Resultado = 50;

                        break;
                    case "Azul":
                        Resultado = 60;

                        break;
                    case "Violeta":
                        Resultado = 70;

                        break;
                    case "Cinza":
                        Resultado = 80;

                        break;
                    case "Branco":
                        Resultado = 90;

                        break;
                }
                #endregion

                #region Calculando Segundo Numero


                switch (Cor_C2)
                {

                    case "Preto":
                        Resultado += 0;

                        break;
                    case "Marrom":
                        Resultado += 1;

                        break;
                    case "Vermelho":
                        Resultado += 2;

                        break;
                    case "Laranja":
                        Resultado += 3;

                        break;
                    case "Amarelo":
                        Resultado += 4;

                        break;
                    case "Verde":
                        Resultado += 5;

                        break;
                    case "Azul":
                        Resultado += 6;

                        break;
                    case "Violeta":
                        Resultado += 7;

                        break;
                    case "Cinza":
                        Resultado += 8;

                        break;
                    case "Branco":
                        Resultado += 9;

                        break;
                }


                #endregion

                #region Calculando Terceiro Numero


                switch (Cor_C3)
                {

                    case "Preto":
                        Resultado *= Math.Pow(10, 0);

                        break;
                    case "Marrom":
                        Resultado *= Math.Pow(10, 1);

                        break;
                    case "Vermelho":
                        Resultado *= Math.Pow(10, 2);

                        break;
                    case "Laranja":
                        Resultado *= Math.Pow(10, 3);

                        break;
                    case "Amarelo":
                        Resultado *= Math.Pow(10, 4);

                        break;
                    case "Verde":
                        Resultado *= Math.Pow(10, 5);

                        break;
                    case "Azul":
                        Resultado *= Math.Pow(10, 6);

                        break;
                    case "Violeta":
                        Resultado *= Math.Pow(10, 7);

                        break;
                    case "Cinza":
                        Resultado *= Math.Pow(10, 8);

                        break;
                    case "Branco":
                        Resultado *= Math.Pow(10, 9);

                        break;
                }
                #endregion


                //Mandando o resultado para a varialvel
                Lbl_Resultado.Text = Resultado.ToString() + " Ω," + Tolerancia.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ocorreu um erro: {exc.Message}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
