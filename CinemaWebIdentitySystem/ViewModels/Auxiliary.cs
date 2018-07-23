using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebIdentitySystem.ViewModels
{
    class Auxiliary
    {
    }

    public class Classificacao
    {
        public static Dictionary<int, string> Classificacoes()
        {
            Dictionary<int, string> d = new Dictionary<int, string>
            {
                { 0, "Livre Para Todos os Públicos" },
                { 10, "Não Recomendade Para Menores de 10 Anos" },
                { 12, "Não Recomendade Para Menores de 12 Anos" },
                { 14, "Não Recomendade Para Menores de 14 Anos" },
                { 16, "Não Recomendade Para Menores de 16 Anos" },
                { 18, "Não Recomendade Para Menores de 18 Anos" }
            };
            return d;
        }

        public static Dictionary<int, string> ClassificacaoImagens()
        {
            Dictionary<int, string> d = new Dictionary<int, string>
            {
                { 0, "/images/livre.png" },
                { 10, "/images/10.png" },
                { 12, "/images/12.png" },
                { 14, "/images/14.png" },
                { 16, "/images/16.png" },
                { 18, "/images/18.png" }
            };
            return d;
        }
    }

    public class Cartao
    {
        public static Dictionary<int, string> Cartoes()
        {
            Dictionary<int, string> d = new Dictionary<int, string>
            {
                { 1, "Cartão Crédito" },
                { 2, "Cartão Débito" }
            };
            return d;
        }
    }

    public class Estados
    {
        public static Dictionary<int, string> SiglaEstados()
        {
            Dictionary<int, string> d = new Dictionary<int, string>
            {
                { 1, "AC" }, { 2, "AL" }, { 3, "AM" }, { 4, "AP" },
                { 5, "BA" }, { 6, "CE" }, { 7, "DF" }, { 8, "ES" },
                { 9, "GO" }, { 10, "MA" }, { 11, "MG" }, { 12, "MS" },
                { 13, "MT" }, { 14, "PA" }, { 15, "PB" }, { 16, "PE" },
                { 17, "PI" }, { 18, "PR" }, { 19, "RJ" }, { 20, "RN" },
                { 21, "RO" }, { 22, "RR" }, { 23, "RS" }, { 24, "SC" },
                { 25, "SE" }, { 26, "SP" }, { 27, "TO" }
            };
            return d;
        }

    }
}
