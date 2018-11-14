namespace SDB
{
    partial class FinderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sightsDS = new SDB.SightsDS();
            this.scityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scntryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sightsTableAdapter = new SDB.SightsDSTableAdapters.SightsTableAdapter();
            this.fillByFilterToolStrip = new System.Windows.Forms.ToolStrip();
            this.s_nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.s_nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.c_nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.c_nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.sT_nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.sT_nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByFilterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sTypesTableAdapter = new SDB.SightsDSTableAdapters.sTypesTableAdapter();
            this.citiesTableAdapter = new SDB.SightsDSTableAdapters.CitiesTableAdapter();
            this.countriesTableAdapter = new SDB.SightsDSTableAdapters.CountriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightsDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightsBindingSource)).BeginInit();
            this.fillByFilterToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snameDataGridViewTextBoxColumn,
            this.ssTypeIDDataGridViewTextBoxColumn,
            this.scityIDDataGridViewTextBoxColumn,
            this.scntryIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sightsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(581, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "s_name";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ssTypeIDDataGridViewTextBoxColumn
            // 
            this.ssTypeIDDataGridViewTextBoxColumn.DataPropertyName = "s_sTypeID";
            this.ssTypeIDDataGridViewTextBoxColumn.DataSource = this.sTypesBindingSource;
            this.ssTypeIDDataGridViewTextBoxColumn.DisplayMember = "sT_name";
            this.ssTypeIDDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.ssTypeIDDataGridViewTextBoxColumn.Name = "ssTypeIDDataGridViewTextBoxColumn";
            this.ssTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ssTypeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ssTypeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ssTypeIDDataGridViewTextBoxColumn.ValueMember = "sT_ID";
            // 
            // sTypesBindingSource
            // 
            this.sTypesBindingSource.DataMember = "sTypes";
            this.sTypesBindingSource.DataSource = this.sightsDS;
            // 
            // sightsDS
            // 
            this.sightsDS.DataSetName = "SightsDS";
            this.sightsDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scityIDDataGridViewTextBoxColumn
            // 
            this.scityIDDataGridViewTextBoxColumn.DataPropertyName = "s_cityID";
            this.scityIDDataGridViewTextBoxColumn.DataSource = this.citiesBindingSource;
            this.scityIDDataGridViewTextBoxColumn.DisplayMember = "c_name";
            this.scityIDDataGridViewTextBoxColumn.HeaderText = "Місто";
            this.scityIDDataGridViewTextBoxColumn.Name = "scityIDDataGridViewTextBoxColumn";
            this.scityIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.scityIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.scityIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.scityIDDataGridViewTextBoxColumn.ValueMember = "c_ID";
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.sightsDS;
            // 
            // scntryIDDataGridViewTextBoxColumn
            // 
            this.scntryIDDataGridViewTextBoxColumn.DataPropertyName = "s_cntryID";
            this.scntryIDDataGridViewTextBoxColumn.DataSource = this.countriesBindingSource;
            this.scntryIDDataGridViewTextBoxColumn.DisplayMember = "cntry_name";
            this.scntryIDDataGridViewTextBoxColumn.HeaderText = "Країна";
            this.scntryIDDataGridViewTextBoxColumn.Name = "scntryIDDataGridViewTextBoxColumn";
            this.scntryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.scntryIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.scntryIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.scntryIDDataGridViewTextBoxColumn.ValueMember = "cntry_ID";
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.sightsDS;
            // 
            // sightsBindingSource
            // 
            this.sightsBindingSource.DataMember = "Sights";
            this.sightsBindingSource.DataSource = this.sightsDS;
            // 
            // sightsTableAdapter
            // 
            this.sightsTableAdapter.ClearBeforeFill = true;
            // 
            // fillByFilterToolStrip
            // 
            this.fillByFilterToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.s_nameToolStripLabel,
            this.s_nameToolStripTextBox,
            this.c_nameToolStripLabel,
            this.c_nameToolStripTextBox,
            this.sT_nameToolStripLabel,
            this.sT_nameToolStripTextBox,
            this.fillByFilterToolStripButton});
            this.fillByFilterToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByFilterToolStrip.Name = "fillByFilterToolStrip";
            this.fillByFilterToolStrip.Size = new System.Drawing.Size(613, 25);
            this.fillByFilterToolStrip.TabIndex = 1;
            this.fillByFilterToolStrip.Text = "fillByFilterToolStrip";
            this.fillByFilterToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillByFilterToolStrip_ItemClicked);
            // 
            // s_nameToolStripLabel
            // 
            this.s_nameToolStripLabel.Name = "s_nameToolStripLabel";
            this.s_nameToolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.s_nameToolStripLabel.Text = "Назва:";
            // 
            // s_nameToolStripTextBox
            // 
            this.s_nameToolStripTextBox.Name = "s_nameToolStripTextBox";
            this.s_nameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // c_nameToolStripLabel
            // 
            this.c_nameToolStripLabel.Name = "c_nameToolStripLabel";
            this.c_nameToolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.c_nameToolStripLabel.Text = "Місто:";
            // 
            // c_nameToolStripTextBox
            // 
            this.c_nameToolStripTextBox.Name = "c_nameToolStripTextBox";
            this.c_nameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // sT_nameToolStripLabel
            // 
            this.sT_nameToolStripLabel.Name = "sT_nameToolStripLabel";
            this.sT_nameToolStripLabel.Size = new System.Drawing.Size(31, 22);
            this.sT_nameToolStripLabel.Text = "Тип:";
            // 
            // sT_nameToolStripTextBox
            // 
            this.sT_nameToolStripTextBox.Name = "sT_nameToolStripTextBox";
            this.sT_nameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByFilterToolStripButton
            // 
            this.fillByFilterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByFilterToolStripButton.Name = "fillByFilterToolStripButton";
            this.fillByFilterToolStripButton.Size = new System.Drawing.Size(50, 22);
            this.fillByFilterToolStripButton.Text = "Пошук";
            this.fillByFilterToolStripButton.Click += new System.EventHandler(this.fillByFilterToolStripButton_Click);
            // 
            // sTypesTableAdapter
            // 
            this.sTypesTableAdapter.ClearBeforeFill = true;
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // FinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 346);
            this.Controls.Add(this.fillByFilterToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "FinderForm";
            this.Text = "FinderForm";
            this.Load += new System.EventHandler(this.FinderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightsDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightsBindingSource)).EndInit();
            this.fillByFilterToolStrip.ResumeLayout(false);
            this.fillByFilterToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SightsDS sightsDS;
        private System.Windows.Forms.BindingSource sightsBindingSource;
        private SightsDSTableAdapters.SightsTableAdapter sightsTableAdapter;
        private System.Windows.Forms.ToolStrip fillByFilterToolStrip;
        private System.Windows.Forms.ToolStripLabel s_nameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox s_nameToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel c_nameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox c_nameToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel sT_nameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox sT_nameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByFilterToolStripButton;
        private System.Windows.Forms.BindingSource sTypesBindingSource;
        private SightsDSTableAdapters.sTypesTableAdapter sTypesTableAdapter;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private SightsDSTableAdapters.CitiesTableAdapter citiesTableAdapter;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private SightsDSTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ssTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn scityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn scntryIDDataGridViewTextBoxColumn;
    }
}