using Microsoft.Office.Interop.Excel;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonBudget
{
    public partial class Form1 : Form
    {
        protected BddBudget _maBdd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //using (BddBudget modele = new BddBudget())
            //{

            //    var allEnreg = from enrg in modele.enregistrements
            //                   select enrg;
            //    dataGridView1.DataSource = modele.enregistrements;
            //}

            RafraichirDonnees();
            this.reportViewer1.RefreshReport();
        }

        private void RafraichirDonnees()
        {
            RafraichirTypeEnregistrement();
            RafraichirGroupes();
            RafraichirEnregistrements();
            ChargerLibelles();
            RafraichirTableauCroiseDynamique();
            RafraichirTableauImportant();
        }

        private void RafraichirTableauImportant()
        {
            try
            {
                using (_maBdd = new BddBudget())
                {
                    rpv_important.LocalReport.DataSources["tableauImportant"].Value = _maBdd.allenregistrement.ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("{0}", e.Message), "Erreur de récupération des enregistrements");
            }

            rpv_important.RefreshReport();
        }

        private void RafraichirTableauCroiseDynamique()
        {
            try
            {
                using (_maBdd = new BddBudget())
                {
                    tdc_budget.LocalReport.DataSources["tableau"].Value = _maBdd.allenregistrement.ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("{0}", e.Message), "Erreur de récupération des enregistrements");
            }

            tdc_budget.RefreshReport();
        }

        private void ChargerLibelles()
        {
            try
            {
                using (_maBdd = new BddBudget())
                {
                    AutoCompleteStringCollection dataCollection = new AutoCompleteStringCollection();
                    dataCollection.AddRange(_maBdd.enregistrements.Select(pp => pp.enregistrement_libelle).ToArray());
                    txt_libelle.AutoCompleteCustomSource = dataCollection;
                    txt_libelle.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txt_libelle.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("{0}", e.Message), "Erreur de récupération des libellés");
            }
        }

        private void RafraichirEnregistrements()
        {
            try
            {
                using (_maBdd = new BddBudget())
                {
                    dtg_enregistrement.DataSource = _maBdd.allenregistrement.ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("{0}", e.Message), "Erreur de récupération des enregistrements");
            }
        }

        private void RafraichirGroupes()
        {
            try
            {
                using (_maBdd = new BddBudget())
                {
                    cmb_pourQui.DataSource = _maBdd.groupes.ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("{0}", e.Message), "Impossisble de récupération des groupes dans la base de données");
            }

        }

        private void RafraichirTypeEnregistrement()
        {
            try
            {
                using (_maBdd = new BddBudget())
                {
                    cmb_type.DataSource = _maBdd.types.ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("{0}", e.Message), "Impossisble de récupération des types dans la base de données");
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Double montant;
            bool bienRempli = true;


            if (cmb_type.SelectedItem == null && bienRempli)
	        {
                MessageBox.Show("Merci de sélectionner 'Un type pour votre montant'");
                bienRempli = false;
	        }

            if (cmb_pourQui.SelectedItem == null && bienRempli)
            {
                MessageBox.Show("Merci de sélectionner un groupe 'pour qui' il faut associer votre montant");
                bienRempli = false;
            }

            if (!Double.TryParse(txt_montant.Text, out montant) && bienRempli)
            {
                MessageBox.Show("Merci de saisir un réel dans 'Montant'");
                bienRempli = false;
            }

            if (bienRempli)
            {
                using (_maBdd = new BddBudget())
                {
                    CEnregistrement unEnregistrement = new CEnregistrement();
                    unEnregistrement.enregistrement_libelle = txt_libelle.Text;
                    unEnregistrement.enregistrement_valeur = montant;
                    unEnregistrement.group_id =  ((CGroupe)cmb_pourQui.SelectedItem).groupe_id;
                    unEnregistrement.type_id = ((CType)cmb_type.SelectedItem).type_id;
                    _maBdd.enregistrements.Add(unEnregistrement);
                    _maBdd.SaveChanges();

                    tdc_budget.LocalReport.DataSources["tableau"].Value = _maBdd.allenregistrement.ToList();
                    
                }

                RafraichirEnregistrements();
                tdc_budget.RefreshReport();
            }
        }

        private void dtg_enregistrement_MouseClick(object sender, MouseEventArgs e)
        {
            cmb_pourQui.SelectedValue = ((VueEnregistrements)dtg_enregistrement.CurrentRow.DataBoundItem).groupe_id;
            cmb_type.SelectedValue = ((VueEnregistrements)dtg_enregistrement.CurrentRow.DataBoundItem).type_id;
            txt_libelle.Text = ((VueEnregistrements)dtg_enregistrement.CurrentRow.DataBoundItem).enregistrement_libelle;
            txt_montant.Text = ((VueEnregistrements)dtg_enregistrement.CurrentRow.DataBoundItem).enregistrement_valeur.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 maForm = new Form2();
            maForm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 uneForm = new Form2();

            uneForm.ShowDialog();

            
        }

        private void tdc_budget_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ajouterType_Click(object sender, EventArgs e)
        {
            if (cmb_type.SelectedItem == null)
            {
                using (_maBdd = new BddBudget())
                {
                    CType unType = new CType();
                    unType.type_libelle = cmb_type.Text;

                    _maBdd.types.Add(unType);
                    _maBdd.SaveChanges();
                }

                RafraichirDonnees();
            }
        }

        private void btn_ajouterGroupe_Click(object sender, EventArgs e)
        {
            if (cmb_pourQui.SelectedItem == null)
            {
                using (_maBdd = new BddBudget())
                {
                    CGroupe unGroupe = new CGroupe();
                    unGroupe.groupe_libelle = cmb_pourQui.Text;

                    _maBdd.groupes.Add(unGroupe);
                    _maBdd.SaveChanges();
                }

                RafraichirDonnees();
            }
        }
    }
}
