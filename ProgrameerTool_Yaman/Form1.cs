using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrameerTool_Yaman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdvies_Click(object sender, EventArgs e)
        {
            try    // is voor een mooie foutmelding
            {
                lbxUitvoer.Items.Clear();    //Listbox word gecleard

                int Beginwaarde = int.Parse(txtBeginwaarde.Text); // int aangemaakt
                int Eindwaarde = int.Parse(txtEindwaarde.Text);   // int aangemaakt
                int Stapgrootte = int.Parse(txtStapgrootte.Text);     // int aangemaakt

                if (rdbFor.Checked) //for of while luss
                {

                    if (rdbGelijk.Checked)    // of gelijk button is aangeklikt
                    {

                        if (rdbKleiner.Checked)        // van laag naar hoog tellen
                        {

                            if (rdbPlus.Checked)      // van laag naar hoog tellen
                            {
                                lbxUitvoer.Items.Add("for (int i = " + Beginwaarde + " ; i < " + Eindwaarde + " ; i+=" + Stapgrootte + ")");          // de code die wordt weergegeven
                                lbxUitvoer.Items.Add("{");          // de code die wordt weergegeven
                                lbxUitvoer.Items.Add("}");          // de code die wordt weergegeven

                                if (Eindwaarde < Beginwaarde)    // foutmelding dat eindgetal groter is dat begingetal
                                {
                                    lbxUitvoer.Items.Clear();       //listbox wordt leeg gemaakt
                                    MessageBox.Show("Er is een fout opgetreden");       //de foutmelding

                                }
                            }
                            else        //als rdbPlus niet geselecteerd is word deze code gebruikt
                            {
                                lbxUitvoer.Items.Add("for (int i = " + Beginwaarde + " ; i < " + Eindwaarde + " ; i-=" + Stapgrootte + ")");          // de code die wordt weergegeven
                                lbxUitvoer.Items.Add("{");          // de code die wordt weergegeven
                                lbxUitvoer.Items.Add("}");          // de code die wordt weergegeven
                            }
                        }
                        else   //als rdbKleiner niet geselecteerd is word deze code gebruikt
                        {
                            if (rdbPlus.Checked)//kijkt of rdbPlus is geselecteerd
                            {
                                lbxUitvoer.Items.Add("for (int i = " + Beginwaarde + " ; i > " + Eindwaarde + " ; i+=" + Stapgrootte + ")");              // de code die wordt weergegeven
                                lbxUitvoer.Items.Add("{");          // de code die wordt weergegeven
                                lbxUitvoer.Items.Add("}");              // de code die wordt weergegeven

                                if (Eindwaarde < Beginwaarde)//kijkt naar de getallen die zijn ingevoerd bij tekstbalk een kijkt of het eind getal kleiner is dan het begin getal
                                {
                                    lbxUitvoer.Items.Clear();//listbox word leeg gemaakt
                                    MessageBox.Show("Er is een fout opgetreden");//maak een massagebox aan een zegt dat er een fout is opgetreden

                                }
                            }
                            else//als rbtplus niet geselecteerd is word deze code gebruikt
                            {
                                lbxUitvoer.Items.Add("for (int i = " + Beginwaarde + " ; i > " + Eindwaarde + " ; i-=" + Stapgrootte + ")");              // de code die wordt weergegeven
                                lbxUitvoer.Items.Add("{");                  // de code die wordt weergegeven
                                lbxUitvoer.Items.Add("}");                  // de code die wordt weergegeven
                            }
                        }
                    }
                    else            //als rdbGelijkaan niet geselecteerd is word deze code gebruikt
                    {
                        lbxUitvoer.Items.Clear();//listbox wordt leeg gemaakt
                        MessageBox.Show("Gelijk aan niet geselecteerd");//zegt dat gelijkaan niet geselecteerd is
                    }
                }
                else    //als rdbFor niet geselecteerd is word deze code gebruikt
                {
                    if (rdbGelijk.Checked)//kijkt of rdbGelijkaan is geselecteerd
                    {

                        if (rdbKleiner.Checked)//kijkt of rdbkleiner is geselecteerd
                        {

                            if (rdbPlus.Checked)//kijkt of rdbPlus is geselecteerd
                            {
                                lbxUitvoer.Items.Add("int i = " + Beginwaarde + ";");// de code die wordt weergegeven
                                lbxUitvoer.Items.Add("while (i < " + Eindwaarde + ")");// de code die wordt weergegeven
                                lbxUitvoer.Items.Add("{");// de code die wordt weergegeven
                                lbxUitvoer.Items.Add("i+=" + Stapgrootte + ";");// de code die wordt weergegeven
                                lbxUitvoer.Items.Add("}");  // de code die wordt weergegeven

                                if (Eindwaarde < Beginwaarde)//kijkt of het eind getal kleiner is dan het begin getal
                                {
                                    lbxUitvoer.Items.Clear();//listbox wordt leeg gemaakt
                                    MessageBox.Show("Er is een fout opgetreden");//zegt dat er een fout is opgetreden

                                }
                            }
                            else//als rdbPlus niet geselecteerd is word deze code gebruikt
                            {
                                lbxUitvoer.Items.Add("int i = " + Beginwaarde + ";");// de code die wordt weergegeven
                                lbxUitvoer.Items.Add("while (i < " + Eindwaarde + ")");// de code die wordt weergegeven
                                lbxUitvoer.Items.Add("{");// de code die wordt weergegeven
                                lbxUitvoer.Items.Add("i-=" + Stapgrootte + ";");// de code die wordt weergegeven
                                lbxUitvoer.Items.Add("}");// de code die wordt weergegeven

                                if (Eindwaarde < Beginwaarde)//kijkt of het eind getal kleiner is dan het begin getal
                                {
                                    lbxUitvoer.Items.Clear();//listbox wordt leeg gemaakt
                                    MessageBox.Show("Er is een fout opgetreden");//zegt dat er een fout is opgetreden

                                }
                            }
                        }
                        else//als rdbKleiner niet geselecteerd is word deze code gebruikt
                        {
                            if (rdbPlus.Checked)//kijkt of rdbPlus is geselecteerd
                            {
                                lbxUitvoer.Items.Add("int i = " + Beginwaarde + ";");// de code die wordt weergegeven
                                lbxUitvoer.Items.Add("while (i > " + Eindwaarde + ")");// de code die wordt weergegeven
                                lbxUitvoer.Items.Add("{");// de code die wordt weergegeven
                                lbxUitvoer.Items.Add("i+=" + Stapgrootte + ";");// de code die wordt weergegeven
                                lbxUitvoer.Items.Add("}");// de code die wordt weergegeven

                                if (Eindwaarde < Beginwaarde)//kijkt of het eind getal kleiner is dan het begin getal
                                {
                                    lbxUitvoer.Items.Clear();//listbox wordt leeg gemaakt
                                    MessageBox.Show("Er is een fout opgetreden");//zegt dat er een fout is opgetreden

                                }
                            }
                            else//als rdbPlus niet geselecteerd is word deze code gebruikt
                            {
                                lbxUitvoer.Items.Add("int i = " + Beginwaarde + ";");// de code die wordt weergegeven
                                lbxUitvoer.Items.Add("while (i > " + Eindwaarde + ")");// de code die wordt weergegeven
                                lbxUitvoer.Items.Add("{");// de code die wordt weergegeven
                                lbxUitvoer.Items.Add("i-=" + Stapgrootte + ";");// de code die wordt weergegeven
                                lbxUitvoer.Items.Add("}");// de code die wordt weergegeven

                                if (Eindwaarde < Beginwaarde)//kijkt of het eind getal kleiner is dan het begin getal
                                {
                                    lbxUitvoer.Items.Clear();//listbox wordt leeg gemaakt
                                    MessageBox.Show("Er is een fout opgetreden");//zegt dat er een fout is opgetreden

                                }
                            }
                        }
                    }
                    else//als rdbGelijkaan niet geselecteerd is word deze code gebruikt
                    {
                        lbxUitvoer.Items.Clear();//listbox wordt leeg gemaakt
                        MessageBox.Show("Gelijk aan niet geselecteerd");//zegt dat gelijk niet geselecteerd is

                    }
                }
            }
            catch
            {
                MessageBox.Show("Er is een fout opgetreden");         // foutmelding
            }
        }

        private void frmProgrammeertool_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gboxEindwaarde_Enter(object sender, EventArgs e)
        {

        }

        private void lbxUitvoer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdbWhile_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbFor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbGelijk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbGroter_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
        
    

