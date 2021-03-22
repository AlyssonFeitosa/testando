using System.Collections.Generic;
namespace deliveryfast.Models
{
    public class BaseDados
    {
        private static List<Cadastro> dados = new List<Cadastro>();
        public static void Incluir(Cadastro u)
        {
            dados.Add(u);
        }
        public static List<Cadastro> Listar()
        {
            return dados;
        }
    }
}