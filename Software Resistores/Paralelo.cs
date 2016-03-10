using System;

namespace SoftwareResistores
{
    public class Paralelo
    {
        private decimal resistenciaEquivalente;
        private decimal corrente;
        private decimal tensao;


        public decimal Corrente
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

        public decimal Tensao
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

        public decimal ResistenciaEquivalente
        {
            get
            {
                return (1 / resistenciaEquivalente);
            }

            set
            {
                resistenciaEquivalente = value;
            }
        }




        public string AdicionarResistor(decimal Valor)
        {
            string saida = "";
            try
            {
                resistenciaEquivalente += (1 / Valor);
            }
            catch (Exception exc)
            {
                saida = $"Erro: {exc.Message}";
            }

            return saida;
        }

        public string RemoverResistor(decimal Valor)
        {
            string saida = "";
            try
            {
                resistenciaEquivalente -= (1 / Valor);
            }
            catch (Exception exc)
            {

                saida = $"Erro: {exc.Message}";
            }

            return saida;
        }

        public decimal CalcularCorrente(decimal Vab)
        {
            Tensao = Vab;

            Corrente = Vab / ResistenciaEquivalente;

            return Corrente;
        }
    }
}
