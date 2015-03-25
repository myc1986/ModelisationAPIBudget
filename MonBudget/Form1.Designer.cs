namespace MonBudget
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtg_enregistrement = new System.Windows.Forms.DataGridView();
            this.grp_enregistrement = new System.Windows.Forms.GroupBox();
            this.txt_montant = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ajouterGroupe = new System.Windows.Forms.Button();
            this.btn_ajouterType = new System.Windows.Forms.Button();
            this.txt_libelle = new System.Windows.Forms.TextBox();
            this.lbl_libelle = new System.Windows.Forms.Label();
            this.lbl_pourQui = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_montant = new System.Windows.Forms.Label();
            this.cmb_pourQui = new System.Windows.Forms.ComboBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.grp_tableauCroiseDynamique = new System.Windows.Forms.GroupBox();
            this.tdc_budget = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grp_evolution = new System.Windows.Forms.GroupBox();
            this.rpv_important = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grp_important = new System.Windows.Forms.GroupBox();
            this.VueEnregistrementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enregistrementidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEnregistrementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vueEnregistrementsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_enregistrement)).BeginInit();
            this.grp_enregistrement.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grp_tableauCroiseDynamique.SuspendLayout();
            this.grp_evolution.SuspendLayout();
            this.grp_important.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VueEnregistrementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEnregistrementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueEnregistrementsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_enregistrement
            // 
            this.dtg_enregistrement.AllowUserToAddRows = false;
            this.dtg_enregistrement.AllowUserToOrderColumns = true;
            this.dtg_enregistrement.AutoGenerateColumns = false;
            this.dtg_enregistrement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_enregistrement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enregistrementidDataGridViewTextBoxColumn,
            this.groupeDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dtg_enregistrement.DataSource = this.cEnregistrementBindingSource;
            this.dtg_enregistrement.Location = new System.Drawing.Point(6, 19);
            this.dtg_enregistrement.Name = "dtg_enregistrement";
            this.dtg_enregistrement.Size = new System.Drawing.Size(605, 155);
            this.dtg_enregistrement.TabIndex = 0;
            this.dtg_enregistrement.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtg_enregistrement_MouseClick);
            // 
            // grp_enregistrement
            // 
            this.grp_enregistrement.Controls.Add(this.dtg_enregistrement);
            this.grp_enregistrement.Location = new System.Drawing.Point(283, 12);
            this.grp_enregistrement.Name = "grp_enregistrement";
            this.grp_enregistrement.Size = new System.Drawing.Size(619, 180);
            this.grp_enregistrement.TabIndex = 1;
            this.grp_enregistrement.TabStop = false;
            this.grp_enregistrement.Text = "Enregistrement";
            // 
            // txt_montant
            // 
            this.txt_montant.Location = new System.Drawing.Point(82, 99);
            this.txt_montant.Name = "txt_montant";
            this.txt_montant.Size = new System.Drawing.Size(142, 20);
            this.txt_montant.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ajouterGroupe);
            this.groupBox1.Controls.Add(this.btn_ajouterType);
            this.groupBox1.Controls.Add(this.txt_libelle);
            this.groupBox1.Controls.Add(this.lbl_libelle);
            this.groupBox1.Controls.Add(this.lbl_pourQui);
            this.groupBox1.Controls.Add(this.lbl_type);
            this.groupBox1.Controls.Add(this.lbl_montant);
            this.groupBox1.Controls.Add(this.cmb_pourQui);
            this.groupBox1.Controls.Add(this.cmb_type);
            this.groupBox1.Controls.Add(this.btn_ajouter);
            this.groupBox1.Controls.Add(this.txt_montant);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter";
            // 
            // btn_ajouterGroupe
            // 
            this.btn_ajouterGroupe.Location = new System.Drawing.Point(230, 44);
            this.btn_ajouterGroupe.Name = "btn_ajouterGroupe";
            this.btn_ajouterGroupe.Size = new System.Drawing.Size(29, 23);
            this.btn_ajouterGroupe.TabIndex = 14;
            this.btn_ajouterGroupe.Text = "+";
            this.btn_ajouterGroupe.UseVisualStyleBackColor = true;
            this.btn_ajouterGroupe.Click += new System.EventHandler(this.btn_ajouterGroupe_Click);
            // 
            // btn_ajouterType
            // 
            this.btn_ajouterType.Location = new System.Drawing.Point(230, 17);
            this.btn_ajouterType.Name = "btn_ajouterType";
            this.btn_ajouterType.Size = new System.Drawing.Size(29, 23);
            this.btn_ajouterType.TabIndex = 13;
            this.btn_ajouterType.Text = "+";
            this.btn_ajouterType.UseVisualStyleBackColor = true;
            this.btn_ajouterType.Click += new System.EventHandler(this.btn_ajouterType_Click);
            // 
            // txt_libelle
            // 
            this.txt_libelle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_libelle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_libelle.Location = new System.Drawing.Point(82, 73);
            this.txt_libelle.Name = "txt_libelle";
            this.txt_libelle.Size = new System.Drawing.Size(142, 20);
            this.txt_libelle.TabIndex = 12;
            // 
            // lbl_libelle
            // 
            this.lbl_libelle.AutoSize = true;
            this.lbl_libelle.Location = new System.Drawing.Point(6, 76);
            this.lbl_libelle.Name = "lbl_libelle";
            this.lbl_libelle.Size = new System.Drawing.Size(43, 13);
            this.lbl_libelle.TabIndex = 11;
            this.lbl_libelle.Text = "Libellé :";
            // 
            // lbl_pourQui
            // 
            this.lbl_pourQui.AutoSize = true;
            this.lbl_pourQui.Location = new System.Drawing.Point(6, 49);
            this.lbl_pourQui.Name = "lbl_pourQui";
            this.lbl_pourQui.Size = new System.Drawing.Size(61, 13);
            this.lbl_pourQui.TabIndex = 10;
            this.lbl_pourQui.Text = "Pour qui ? :";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(6, 22);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(37, 13);
            this.lbl_type.TabIndex = 9;
            this.lbl_type.Text = "Type :";
            // 
            // lbl_montant
            // 
            this.lbl_montant.AutoSize = true;
            this.lbl_montant.Location = new System.Drawing.Point(6, 105);
            this.lbl_montant.Name = "lbl_montant";
            this.lbl_montant.Size = new System.Drawing.Size(52, 13);
            this.lbl_montant.TabIndex = 8;
            this.lbl_montant.Text = "Montant :";
            // 
            // cmb_pourQui
            // 
            this.cmb_pourQui.DisplayMember = "groupe_libelle";
            this.cmb_pourQui.FormattingEnabled = true;
            this.cmb_pourQui.Location = new System.Drawing.Point(82, 46);
            this.cmb_pourQui.Name = "cmb_pourQui";
            this.cmb_pourQui.Size = new System.Drawing.Size(142, 21);
            this.cmb_pourQui.TabIndex = 7;
            this.cmb_pourQui.ValueMember = "groupe_id";
            // 
            // cmb_type
            // 
            this.cmb_type.DisplayMember = "type_libelle";
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(82, 19);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(142, 21);
            this.cmb_type.TabIndex = 6;
            this.cmb_type.ValueMember = "type_id";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(9, 125);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(250, 23);
            this.btn_ajouter.TabIndex = 5;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // grp_tableauCroiseDynamique
            // 
            this.grp_tableauCroiseDynamique.Controls.Add(this.tdc_budget);
            this.grp_tableauCroiseDynamique.Location = new System.Drawing.Point(283, 198);
            this.grp_tableauCroiseDynamique.Name = "grp_tableauCroiseDynamique";
            this.grp_tableauCroiseDynamique.Size = new System.Drawing.Size(857, 428);
            this.grp_tableauCroiseDynamique.TabIndex = 3;
            this.grp_tableauCroiseDynamique.TabStop = false;
            this.grp_tableauCroiseDynamique.Text = "Tableau croisée dynamique";
            // 
            // tdc_budget
            // 
            reportDataSource3.Name = "tableau";
            reportDataSource3.Value = this.VueEnregistrementsBindingSource;
            this.tdc_budget.LocalReport.DataSources.Add(reportDataSource3);
            this.tdc_budget.LocalReport.ReportEmbeddedResource = "MonBudget.Report1.rdlc";
            this.tdc_budget.Location = new System.Drawing.Point(7, 19);
            this.tdc_budget.Name = "tdc_budget";
            this.tdc_budget.Size = new System.Drawing.Size(844, 403);
            this.tdc_budget.TabIndex = 0;
            this.tdc_budget.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // grp_evolution
            // 
            this.grp_evolution.Controls.Add(this.reportViewer1);
            this.grp_evolution.Location = new System.Drawing.Point(12, 198);
            this.grp_evolution.Name = "grp_evolution";
            this.grp_evolution.Size = new System.Drawing.Size(265, 183);
            this.grp_evolution.TabIndex = 4;
            this.grp_evolution.TabStop = false;
            this.grp_evolution.Text = "Evolution";
            // 
            // rpv_important
            // 
            reportDataSource4.Name = "tableauImportant";
            reportDataSource4.Value = this.VueEnregistrementsBindingSource;
            this.rpv_important.LocalReport.DataSources.Add(reportDataSource4);
            this.rpv_important.LocalReport.ReportEmbeddedResource = "MonBudget.Report2.rdlc";
            this.rpv_important.Location = new System.Drawing.Point(6, 18);
            this.rpv_important.Name = "rpv_important";
            this.rpv_important.Size = new System.Drawing.Size(220, 156);
            this.rpv_important.TabIndex = 0;
            // 
            // grp_important
            // 
            this.grp_important.Controls.Add(this.rpv_important);
            this.grp_important.Location = new System.Drawing.Point(908, 12);
            this.grp_important.Name = "grp_important";
            this.grp_important.Size = new System.Drawing.Size(232, 180);
            this.grp_important.TabIndex = 6;
            this.grp_important.TabStop = false;
            this.grp_important.Text = "Important";
            // 
            // VueEnregistrementsBindingSource
            // 
            this.VueEnregistrementsBindingSource.DataSource = typeof(MonBudget.VueEnregistrements);
            // 
            // enregistrementidDataGridViewTextBoxColumn
            // 
            this.enregistrementidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.enregistrementidDataGridViewTextBoxColumn.DataPropertyName = "enregistrement_id";
            this.enregistrementidDataGridViewTextBoxColumn.HeaderText = "Identifiant";
            this.enregistrementidDataGridViewTextBoxColumn.Name = "enregistrementidDataGridViewTextBoxColumn";
            this.enregistrementidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.enregistrementidDataGridViewTextBoxColumn.Width = 78;
            // 
            // groupeDataGridViewTextBoxColumn
            // 
            this.groupeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.groupeDataGridViewTextBoxColumn.DataPropertyName = "groupe";
            this.groupeDataGridViewTextBoxColumn.HeaderText = "Groupe";
            this.groupeDataGridViewTextBoxColumn.Name = "groupeDataGridViewTextBoxColumn";
            this.groupeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.groupeDataGridViewTextBoxColumn.Width = 67;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.typeDataGridViewTextBoxColumn.Width = 56;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "enregistrement_libelle";
            this.dataGridViewTextBoxColumn1.HeaderText = "Libellé";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn1.Width = 62;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "enregistrement_valeur";
            this.dataGridViewTextBoxColumn2.HeaderText = "Montant réel";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn2.Width = 91;
            // 
            // cEnregistrementBindingSource
            // 
            this.cEnregistrementBindingSource.DataSource = typeof(MonBudget.CEnregistrement);
            // 
            // vueEnregistrementsBindingSource1
            // 
            this.vueEnregistrementsBindingSource1.DataSource = typeof(MonBudget.VueEnregistrements);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(9, 19);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(250, 158);
            this.reportViewer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 638);
            this.Controls.Add(this.grp_important);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_evolution);
            this.Controls.Add(this.grp_tableauCroiseDynamique);
            this.Controls.Add(this.grp_enregistrement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_enregistrement)).EndInit();
            this.grp_enregistrement.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_tableauCroiseDynamique.ResumeLayout(false);
            this.grp_evolution.ResumeLayout(false);
            this.grp_important.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VueEnregistrementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEnregistrementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueEnregistrementsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_enregistrement;
        private System.Windows.Forms.GroupBox grp_enregistrement;
        private System.Windows.Forms.TextBox txt_montant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_pourQui;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_montant;
        private System.Windows.Forms.ComboBox cmb_pourQui;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.GroupBox grp_tableauCroiseDynamique;
        private System.Windows.Forms.BindingSource cEnregistrementBindingSource;
        private System.Windows.Forms.TextBox txt_libelle;
        private System.Windows.Forms.Label lbl_libelle;
        private System.Windows.Forms.GroupBox grp_evolution;
        private System.Windows.Forms.GroupBox grp_important;
        private System.Windows.Forms.BindingSource VueEnregistrementsBindingSource;
        private System.Windows.Forms.BindingSource vueEnregistrementsBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer tdc_budget;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_important;
        private System.Windows.Forms.Button btn_ajouterGroupe;
        private System.Windows.Forms.Button btn_ajouterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn enregistrementidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}

