using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo_01
{
    internal class ComandosBanco
    {

        private static string conexao = @"Data Source=(localdb)\MSSQLLocalDB; 
                           Initial Catalog=DbLET;
                           Integrated Security=True";


        public class Colaboradores
        {
            public string Nome { get; set; }
            public int IdArea { get; set; }
            public string Turno { get; set; }
        }


        // Método para incluir colaboradores
        public static void Incluir(string nome, int idArea, string turno)
        {
            using (var conn = new SqlConnection(conexao))
            {
                conn.Execute("INSERT INTO TBColaboradores (Nome, IdArea, Turno) values (@Nome, @IdArea, @Turno)",
                             new { Nome = nome, IdArea = idArea, Turno = turno});
                MessageBox.Show($"Colaborador {nome} inserido com sucesso!", "Registro Councluído");
            }
        }

        // Método para alterar informações do colaborador
        public static void Alterar(string nome, int idAreaNova, string turnoNovo)
        {
            using (var conn = new SqlConnection(conexao))
            {
                int resultado = conn.Execute("UPDATE TBColaboradores SET Nome=@Nome, IdArea=@IdAreaNova, Turno=@TurnoNovo where Nome=@Nome",
                              new { Nome = nome, IdAreaNova = idAreaNova, TurnoNovo = turnoNovo });
                if (resultado == 1)
                {
                    MessageBox.Show($"Turno e/ou área do colaborador {nome} alterado com sucesso!", "Alteração Councluída");
                }
                else
                {
                    MessageBox.Show($"O colaborador {nome} não foi encontrado no banco de dados.\n\nVerifique se o nome foi digitado corretamente e se o colaborador está cadastrado no banco de dados", "Erro");
                }
            }
        }

        // Método para remover colaborador
        public static void Remover(string nomeRemover)
        {
            using (var conn = new SqlConnection(conexao))
            {
                int resultado = conn.Execute("DELETE FROM TBColaboradores where Nome=@NomeRemover",
                     new { NomeRemover = nomeRemover });
                if (resultado == 1)
                {
                    MessageBox.Show($"Colaborador {nomeRemover} removido com sucesso!", "Remoção Concluída");
                }
                else
                {
                    MessageBox.Show($"O colaborador {nomeRemover} não foi encontrado no banco de dados.\n\nVerifique se o nome foi digitado corretamente e se o colaborador está cadastrado no banco de dados", "Erro");
                }
            }
        }

        // Método para listar colaboradores
        public static string[,] Listar()
        {
            DataGridViewRow infosReturn = new DataGridViewRow();
            string[,] infos = new string[2000,3];   // maximo 200 linhas no database funcionariso

            using (var conn = new SqlConnection(conexao))
            {
                var infosColabs = conn.Query<Colaboradores>("SELECT * FROM TBColaboradores");
                int linha = 0;

                foreach (var info in infosColabs)
                {
                    infos[linha, 0] = info.Nome;
                    infos[linha, 1] = ConverterIdArea(info.IdArea);
                    infos[linha, 2] = info.Turno;
                    linha++;
                }
            }

            return infos;
        }


        // Método para converter código da área (int) no nome da área (string)
        static string ConverterIdArea(int id)
        {
            switch (id)
            {
                case 1:
                    return "SAR";
                case 2:
                    return "RF";
                case 3:
                    return "EMC";
                case 4:
                    return "CSA";
                case 5:
                    return "OTA";
                case 6:
                    return "Pré-Teste";
                case 7:
                    return "Safety";
                case 8:
                    return "Qualidade";
                default:
                    return "";
            }
        }

    }
}
