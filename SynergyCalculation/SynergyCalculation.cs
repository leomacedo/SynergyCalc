using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SynergyCalculation
{
    public partial class frmSynergyCalculation : Form
    {
        public frmSynergyCalculation()
        {
            InitializeComponent();
            //numStatMin.Value = 0;
            //numStatMax.Value = 0;
            //numLvlAtual.Value = 35;
            //numStatMin.Focus();
            //numStatMax.Focus();
            //numLvlAtual.Focus();
        }

        private void FrmSynergyCalculation_Load(object sender, EventArgs e)
        {
            numStatMin.Text = "";
            numStatMax.Text = "";
            //numLvlAtual.Text = "";
            //numStatMin.Focus();
            //numStatMax.Focus();
            //numLvlAtual.Focus();
        }

        private void TxtReliquia_TextChanged(object sender, EventArgs e)
        {
            //txtReliquia.Select(1000, 10000);
        }

        private void NumStatMin_ValueChanged(object sender, EventArgs e)
        {
            //numStatMin.Focus();
            numStatMin.Select(0, 10);
           
        }

        private void NumStatMax_ValueChanged(object sender, EventArgs e)
        {
            //numStatMax.Focus();
            numStatMax.Select(0, 10);
        }
        private void NumLvlAtual_ValueChanged(object sender, EventArgs e)
        {
            //numLvlAtual.Focus();
            numLvlAtual.Select(0, 10);
        }

        private void BtnLvlAtual_Click(object sender, EventArgs e)
        {

            Button bt = (Button)sender;
            numLvlAtual.Value = Convert.ToDecimal(bt.Text);
        }

        private void BtnNormal5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                txtLvlMax.Text = "30";
            }
        }

        private void BtnNormal6_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                txtLvlMax.Text = "35";
            }
        }


        private void BtnNormal7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                txtLvlMax.Text = "40";
            }
        }

        private void BtnLendaria_CheckedChanged(object sender, EventArgs e)

        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                txtLvlMax.Text = "50";
            }
        }

      
        private void Button1_Click(object sender, EventArgs e)
        {
            // Calculo
            string relic = txtReliquia.Text;
            double minStat = Convert.ToDouble(numStatMin.Value);
            double maxStat = Convert.ToDouble(numStatMax.Value);
            double currentLevel = Convert.ToDouble(numLvlAtual.Value);
            double maxLevel = Convert.ToDouble(txtLvlMax.Text);
            double bonusLevel = (Math.Floor(currentLevel / 5) + 1) * 10;
            if (currentLevel < 5) bonusLevel += 5;
            double RS = Math.Round(minStat + Math.Ceiling((maxStat - minStat) * ((currentLevel - 1 + bonusLevel) / (maxLevel - 1))));
            richTextBox1.Text = Convert.ToString(RS);

            // Tipo da Arma
            string tipo;

            if (maxLevel == 30) { tipo = "Relic 5*"; }
            else if (maxLevel == 35) { tipo = "Relic 6*"; }
            else if (maxLevel == 40) { tipo = "Relic 7*"; }
            else { tipo = "Legend Relic"; }

            /*switch (maxLevel)
            {
                case 30: tipo = "Relic 5*";
                    break;
                case 35: tipo = "Relic 6*";
                    break;
                case 50: tipo = "Relic Lendária";
                    break;
            }
            */
            // Diretorio do arquivo texto
            // string diretorio = "D:\\Leonardo\\FFRK\\DataSave\\zListaResultados.txt";

            if (File.Exists("zResults.txt"))
            {
                StreamWriter arq;
                arq = File.AppendText("zListaResultados.txt");
                //arq.WriteLine("Reliquia: " + relic + " || S.Min: " + minStat + " || S.Max: " + maxStat + " || Level: " + currentLevel + " || Tipo: " + tipo + " || ---> Synergy: " + RS + " <---");
                arq.WriteLine("Relic: " + relic + " || Level: " + currentLevel + " || " + tipo + " || ---> Synergy: " + RS + " <---");
                arq.Close();
                //Comando para abrir o arquivo diretamente do sistema
                //System.Diagnostics.Process.Start("notepad", diretorio);
            }
            else
            {
                // Criando o arquivo texto
                StreamWriter arq;
                arq = File.CreateText("zResults.txt");
                //Titulo
                arq.WriteLine("Results List");
                //arq.WriteLine("Reliquia: " + relic + " || S.Min: " + minStat + " || S.Max: " + maxStat + " || Level: " + currentLevel + " || Tipo: " + tipo + " || ---> Synergy: " + RS + " <---s");
                arq.WriteLine("Relic: " + relic + " || Level: " + currentLevel + " || " + tipo + " || ---> Synergy: " + RS + " <---");
                arq.Close();
                //Comando para abrir o arquivo diretamente do sistema
                //System.Diagnostics.Process.Start("notepad", diretorio);
            }

        }

   
    }
}
