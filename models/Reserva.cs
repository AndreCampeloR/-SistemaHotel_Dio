using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHotel_Dio.models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            bool VerificarCapacidade = Suite.Capacidade >= hospedes.Count;

            if (VerificarCapacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
               throw new Exception("A capacidade da Suite é menor que a quantoiidade de hospedes");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeDeHospedes = Hospedes.Count;

            return quantidadeDeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor =- (valor * 0.10M);
            }

            return valor;
        }
    }
}