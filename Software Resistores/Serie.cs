using System;

namespace SoftwareResistores
{
    public class Serie
    {
        private double req;
        private double corrente;
        private double tensao;

        public double Req
        {
            get
            {
                return req;
            }
        }

        public double Corrente
        {
            get
            {
                return corrente;
            }
        }

        public double Tensao
        {
            get
            {
                return tensao;
            }
        }

        /// <summary>
        /// Adicionando Valores a variavel de resistencia total;
        /// </summary>
        /// <param name="Valor"></param>
        /// <returns></returns>
        public string AdicionarResistor(double Valor)
        {
            string saida = "";
            try
            {
                req += Valor;
            }
            catch (Exception exc)
            {
                saida = $"Erro: {exc.Message}";
            }

            return saida;
        }

        /// <summary>
        /// Removendo Valores a variavel de resistencia total;
        /// </summary>
        /// <param name="Valor"></param>
        /// <returns></returns>
        public string RemoverResistor(double Valor)
        {
            string saida = "";
            try
            {
                req -= Valor;
            }
            catch (Exception exc)
            {

                saida = $"Erro: {exc.Message}";
            }

            return saida;
        }

        /// <summary>
        /// Cálculando a corrente que passa pelo circuito
        /// </summary>
        /// <param name="Req"></param>
        /// <param name="Vab"></param>
        /// <returns></returns>
        public double CalcularCorrente(double Vab)
        {
            tensao = Vab;

            corrente = Vab / Req;

            return Corrente;
        }
    }
}
