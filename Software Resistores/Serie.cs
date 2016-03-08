using System;

namespace SoftwareResistores
{
    public class Serie
    {
        private double resistenciaEquivalente;
        private double corrente;
        private double tensao;


        public double Corrente
        {
            get
            {
                return corrente;
            }

            set
            {
                corrente = value;
            }
        }

        public double Tensao
        {
            get
            {
                return tensao;
            }

            set
            {
                tensao = value;
            }
        }

        public double ResistenciaEquivalente
        {
            get
            {
                return resistenciaEquivalente;
            }

            set
            {
                resistenciaEquivalente = value;
            }
        }

        public string AdicionarResistor(double Valor)
        {
            string saida = "";
            try
            {
                resistenciaEquivalente += Valor;
            }
            catch (Exception exc)
            {
                saida = $"Erro: {exc.Message}";
            }

            return saida;
        }

        public string RemoverResistor(double Valor)
        {
            string saida = "";
            try
            {
                resistenciaEquivalente -= Valor;
            }
            catch (Exception exc)
            {

                saida = $"Erro: {exc.Message}";
            }

            return saida;
        }

        public double CalcularCorrente(double Vab)
        {
            Tensao = Vab;

            Corrente = Vab / resistenciaEquivalente;

            return Corrente;
        }
    }
}
