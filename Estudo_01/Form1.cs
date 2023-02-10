using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo_01
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }


        #region Botões  (Inserir, Alterar, Remover, Listar)

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = tbxNome.Text;
                int idArea = int.Parse(cbArea.Text);
                string turno = cbTurno.Text;
                
                if ((nome != "") && (turno != ""))
                {
                    ComandosBanco.Incluir(nome, idArea, turno);
                    AtualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("O Nome e/ou Turno do colaborador não foi informado.\n\nOperação não realizada, tente novamente", "Erro");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("O Id da Área do colaborador não foi informado.\n\nOperação não realizada, tente novamente", "Erro");
            }
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = tbxNomeAlterar.Text;
                int idAreaNova = int.Parse(cbAreaNova.Text);
                string turnoNovo = cbTurnoNovo.Text;
                
                if ((nome != "") && (turnoNovo != ""))
                {
                    ComandosBanco.Alterar(nome, idAreaNova, turnoNovo);
                    AtualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("O novo Nome e/ou Turno do colaborador não foi informado.\n\nOperação não realizada, tente novamente", "Erro");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("O Id da Área do colaborador não foi informado.\n\nOperação não realizada, tente novamente", "Erro");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string nomeRemover = tbxNomeRemover.Text;
            if (nomeRemover != "")
            {
                ComandosBanco.Remover(nomeRemover);
                AtualizarDataGrid();
            }
            else
            {
                MessageBox.Show("O Nome do colaborador não foi informado.\n\nOperação não realizada, tente novamente", "Erro");
            }

        }

        #endregion


        public void AtualizarDataGrid()
        {
            DgvInfoColab.Rows.Clear();

            string[,] infos = new string[200, 3];   // Suporta no máximo 200 funcionários (se necessário aumentar array
            infos = ComandosBanco.Listar();

            string nome;
            string idArea;
            string turno;
            object[] linhas;

            for (int i = 0; i < infos.Length / 3; i++)
            {
                if (infos[i, 0] != null)
                {
                    nome = infos[i, 0];
                    idArea = infos[i, 1];
                    turno = infos[i, 2];
                    linhas = new object[] { nome, idArea, turno };
                    DgvInfoColab.Rows.Add(linhas);
                }
            }
        }


        #region ComboBoxes

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbArea.Text == "1")
            {
                lblAreaConvertida.Text = "Área: SAR";
            }
            else if (cbArea.Text == "2")
            {
                lblAreaConvertida.Text = "Área: RF";
            }
            else if (cbArea.Text == "3")
            {
                lblAreaConvertida.Text = "Área: EMC";
            }
            else if (cbArea.Text == "4")
            {
                lblAreaConvertida.Text = "Área: CSA";
            }
            else if (cbArea.Text == "5")
            {
                lblAreaConvertida.Text = "Área: OTA";
            }
            else if (cbArea.Text == "6")
            {
                lblAreaConvertida.Text = "Área: Pré-teste";
            }
            else if (cbArea.Text == "7")
            {
                lblAreaConvertida.Text = "Área: Safety";
            }
            else if (cbArea.Text == "8")
            {
                lblAreaConvertida.Text = "Área: Qualidade";
            }
            else
            {
                lblAreaConvertida.Text = "---";

            }
        }
        private void cbAreaNova_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAreaNova.Text == "1")
            {
                lblAreaNovaConvertida.Text = "Área: SAR";
            }
            else if (cbAreaNova.Text == "2")
            {
                lblAreaNovaConvertida.Text = "Área: RF";
            }
            else if (cbAreaNova.Text == "3")
            {
                lblAreaNovaConvertida.Text = "Área: EMC";
            }
            else if (cbAreaNova.Text == "4")
            {
                lblAreaNovaConvertida.Text = "Área: CSA";
            }
            else if (cbAreaNova.Text == "5")
            {
                lblAreaNovaConvertida.Text = "Área: OTA";
            }
            else if (cbAreaNova.Text == "6")
            {
                lblAreaNovaConvertida.Text = "Área: Pré-teste";
            }
            else if (cbAreaNova.Text == "7")
            {
                lblAreaNovaConvertida.Text = "Área: Safety";
            }
            else if (cbAreaNova.Text == "8")
            {
                lblAreaNovaConvertida.Text = "Área: Qualidade";
            }
            else
            {
                lblAreaNovaConvertida.Text = "---";

            }
        }
        private void cbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTurno.Text == "T1")
            {
                lblTurnoConvertido.Text = "Horário: 08h às 17h";
            }
            else if (cbTurno.Text == "T2")
            {
                lblTurnoConvertido.Text = "Horário: 17h às 00h";
            }
            else if (cbTurno.Text == "T3")
            {
                lblTurnoConvertido.Text = "Horário: 00h às 08h";
            }
        }
        private void cbTurnoNovo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTurnoNovo.Text == "T1")
            {
                lblTurnoNovoConvertido.Text = "Horário: 08h às 17h";
            }
            else if (cbTurnoNovo.Text == "T2")
            {
                lblTurnoNovoConvertido.Text = "Horário: 17h às 00h";
            }
            else if (cbTurnoNovo.Text == "T3")
            {
                lblTurnoNovoConvertido.Text = "Horário: 00h às 08h";
            }
        }

        #endregion


    }
}
