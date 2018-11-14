namespace SDB
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TABC = new System.Windows.Forms.TabControl();
            this.tabSights = new System.Windows.Forms.TabPage();
            this.BTNDeleteSights = new System.Windows.Forms.Button();
            this.BTNSaveSights = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sightsDS = new SDB.SightsDS();
            this.scntryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabHotels = new System.Windows.Forms.TabPage();
            this.BTNDeleteHotels = new System.Windows.Forms.Button();
            this.BTNSaveHotels = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabCities = new System.Windows.Forms.TabPage();
            this.BTNDeleteCities = new System.Windows.Forms.Button();
            this.BTNSaveCities = new System.Windows.Forms.Button();
            this.DGVCities = new System.Windows.Forms.DataGridView();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccntryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabCountries = new System.Windows.Forms.TabPage();
            this.BTNDeleteAddresses = new System.Windows.Forms.Button();
            this.BTNSaveAddresses = new System.Windows.Forms.Button();
            this.DGVCoutries = new System.Windows.Forms.DataGridView();
            this.cntrynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntry_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabsType = new System.Windows.Forms.TabPage();
            this.BTNDeletesType = new System.Windows.Forms.Button();
            this.BTNSavesType = new System.Windows.Forms.Button();
            this.DGVsTypes = new System.Windows.Forms.DataGridView();
            this.sTnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiesTableAdapter = new SDB.SightsDSTableAdapters.CitiesTableAdapter();
            this.hotelsTableAdapter = new SDB.SightsDSTableAdapters.HotelsTableAdapter();
            this.countriesTableAdapter = new SDB.SightsDSTableAdapters.CountriesTableAdapter();
            this.sTypesTableAdapter = new SDB.SightsDSTableAdapters.sTypesTableAdapter();
            this.sightsTableAdapter = new SDB.SightsDSTableAdapters.SightsTableAdapter();
            this.queriesTableAdapter1 = new SDB.SightsDSTableAdapters.QueriesTableAdapter();
            this.citiesInCountryTableAdapter = new SDB.SightsDSTableAdapters.Cities1TableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пошукПамятокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.памяткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.готеліToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hcntryIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hcityIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TABC.SuspendLayout();
            this.tabSights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightsDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightsBindingSource)).BeginInit();
            this.tabHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabCities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCities)).BeginInit();
            this.tabCountries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCoutries)).BeginInit();
            this.tabsType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVsTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TABC
            // 
            this.TABC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TABC.Controls.Add(this.tabSights);
            this.TABC.Controls.Add(this.tabHotels);
            this.TABC.Controls.Add(this.tabCities);
            this.TABC.Controls.Add(this.tabCountries);
            this.TABC.Controls.Add(this.tabsType);
            this.TABC.Location = new System.Drawing.Point(12, 27);
            this.TABC.Name = "TABC";
            this.TABC.SelectedIndex = 0;
            this.TABC.Size = new System.Drawing.Size(661, 355);
            this.TABC.TabIndex = 0;
            this.TABC.SelectedIndexChanged += new System.EventHandler(this.TABC_SelectedIndexChanged);
            // 
            // tabSights
            // 
            this.tabSights.Controls.Add(this.BTNDeleteSights);
            this.tabSights.Controls.Add(this.BTNSaveSights);
            this.tabSights.Controls.Add(this.dataGridView2);
            this.tabSights.Location = new System.Drawing.Point(4, 22);
            this.tabSights.Name = "tabSights";
            this.tabSights.Padding = new System.Windows.Forms.Padding(3);
            this.tabSights.Size = new System.Drawing.Size(653, 329);
            this.tabSights.TabIndex = 1;
            this.tabSights.Text = "Пам\'ятки";
            this.tabSights.UseVisualStyleBackColor = true;
            // 
            // BTNDeleteSights
            // 
            this.BTNDeleteSights.Location = new System.Drawing.Point(120, 6);
            this.BTNDeleteSights.Name = "BTNDeleteSights";
            this.BTNDeleteSights.Size = new System.Drawing.Size(75, 23);
            this.BTNDeleteSights.TabIndex = 2;
            this.BTNDeleteSights.Text = "Видалити";
            this.BTNDeleteSights.UseVisualStyleBackColor = true;
            this.BTNDeleteSights.Click += new System.EventHandler(this.BTNDeleteSights_Click);
            // 
            // BTNSaveSights
            // 
            this.BTNSaveSights.Location = new System.Drawing.Point(25, 6);
            this.BTNSaveSights.Name = "BTNSaveSights";
            this.BTNSaveSights.Size = new System.Drawing.Size(75, 23);
            this.BTNSaveSights.TabIndex = 1;
            this.BTNSaveSights.Text = "Зберегти";
            this.BTNSaveSights.UseVisualStyleBackColor = true;
            this.BTNSaveSights.Click += new System.EventHandler(this.BTNSaveSights_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snameDataGridViewTextBoxColumn,
            this.Column4,
            this.ssTypeIDDataGridViewTextBoxColumn,
            this.scntryIDDataGridViewTextBoxColumn,
            this.scityIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.sightsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(641, 286);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "s_name";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "s_ID";
            this.Column4.HeaderText = "s_ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // ssTypeIDDataGridViewTextBoxColumn
            // 
            this.ssTypeIDDataGridViewTextBoxColumn.DataPropertyName = "s_sTypeID";
            this.ssTypeIDDataGridViewTextBoxColumn.DataSource = this.sTypesBindingSource;
            this.ssTypeIDDataGridViewTextBoxColumn.DisplayMember = "sT_name";
            this.ssTypeIDDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.ssTypeIDDataGridViewTextBoxColumn.Name = "ssTypeIDDataGridViewTextBoxColumn";
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
            // scntryIDDataGridViewTextBoxColumn
            // 
            this.scntryIDDataGridViewTextBoxColumn.DataPropertyName = "s_cntryID";
            this.scntryIDDataGridViewTextBoxColumn.DataSource = this.countriesBindingSource;
            this.scntryIDDataGridViewTextBoxColumn.DisplayMember = "cntry_name";
            this.scntryIDDataGridViewTextBoxColumn.HeaderText = "Країна";
            this.scntryIDDataGridViewTextBoxColumn.Name = "scntryIDDataGridViewTextBoxColumn";
            this.scntryIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.scntryIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.scntryIDDataGridViewTextBoxColumn.ValueMember = "cntry_ID";
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.sightsDS;
            // 
            // scityIDDataGridViewTextBoxColumn
            // 
            this.scityIDDataGridViewTextBoxColumn.DataPropertyName = "s_cityID";
            this.scityIDDataGridViewTextBoxColumn.DataSource = this.citiesBindingSource;
            this.scityIDDataGridViewTextBoxColumn.DisplayMember = "c_name";
            this.scityIDDataGridViewTextBoxColumn.HeaderText = "Місто";
            this.scityIDDataGridViewTextBoxColumn.Name = "scityIDDataGridViewTextBoxColumn";
            this.scityIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.scityIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.scityIDDataGridViewTextBoxColumn.ValueMember = "c_ID";
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.sightsDS;
            // 
            // sightsBindingSource
            // 
            this.sightsBindingSource.DataMember = "Sights";
            this.sightsBindingSource.DataSource = this.sightsDS;
            // 
            // tabHotels
            // 
            this.tabHotels.Controls.Add(this.BTNDeleteHotels);
            this.tabHotels.Controls.Add(this.BTNSaveHotels);
            this.tabHotels.Controls.Add(this.dataGridView3);
            this.tabHotels.Location = new System.Drawing.Point(4, 22);
            this.tabHotels.Name = "tabHotels";
            this.tabHotels.Size = new System.Drawing.Size(653, 329);
            this.tabHotels.TabIndex = 2;
            this.tabHotels.Text = "Готелі";
            this.tabHotels.UseVisualStyleBackColor = true;
            // 
            // BTNDeleteHotels
            // 
            this.BTNDeleteHotels.Location = new System.Drawing.Point(120, 6);
            this.BTNDeleteHotels.Name = "BTNDeleteHotels";
            this.BTNDeleteHotels.Size = new System.Drawing.Size(75, 23);
            this.BTNDeleteHotels.TabIndex = 2;
            this.BTNDeleteHotels.Text = "Видалити";
            this.BTNDeleteHotels.UseVisualStyleBackColor = true;
            this.BTNDeleteHotels.Click += new System.EventHandler(this.BTNDeleteHotels_Click);
            // 
            // BTNSaveHotels
            // 
            this.BTNSaveHotels.Location = new System.Drawing.Point(25, 6);
            this.BTNSaveHotels.Name = "BTNSaveHotels";
            this.BTNSaveHotels.Size = new System.Drawing.Size(75, 23);
            this.BTNSaveHotels.TabIndex = 1;
            this.BTNSaveHotels.Text = "Зберегти";
            this.BTNSaveHotels.UseVisualStyleBackColor = true;
            this.BTNSaveHotels.Click += new System.EventHandler(this.BTNSaveHotels_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hnameDataGridViewTextBoxColumn1,
            this.Column3,
            this.hcntryIDDataGridViewTextBoxColumn1,
            this.hcityIDDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.hotelsBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 35);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(641, 286);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabCities
            // 
            this.tabCities.Controls.Add(this.BTNDeleteCities);
            this.tabCities.Controls.Add(this.BTNSaveCities);
            this.tabCities.Controls.Add(this.DGVCities);
            this.tabCities.Location = new System.Drawing.Point(4, 22);
            this.tabCities.Name = "tabCities";
            this.tabCities.Padding = new System.Windows.Forms.Padding(3);
            this.tabCities.Size = new System.Drawing.Size(653, 329);
            this.tabCities.TabIndex = 0;
            this.tabCities.Text = "Міста";
            this.tabCities.UseVisualStyleBackColor = true;
            // 
            // BTNDeleteCities
            // 
            this.BTNDeleteCities.Location = new System.Drawing.Point(120, 6);
            this.BTNDeleteCities.Name = "BTNDeleteCities";
            this.BTNDeleteCities.Size = new System.Drawing.Size(75, 23);
            this.BTNDeleteCities.TabIndex = 2;
            this.BTNDeleteCities.Text = "Видалити";
            this.BTNDeleteCities.UseVisualStyleBackColor = true;
            this.BTNDeleteCities.Click += new System.EventHandler(this.BTNDeleteCity_Click);
            // 
            // BTNSaveCities
            // 
            this.BTNSaveCities.Location = new System.Drawing.Point(25, 6);
            this.BTNSaveCities.Name = "BTNSaveCities";
            this.BTNSaveCities.Size = new System.Drawing.Size(75, 23);
            this.BTNSaveCities.TabIndex = 1;
            this.BTNSaveCities.Text = "Зберегти";
            this.BTNSaveCities.UseVisualStyleBackColor = true;
            this.BTNSaveCities.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // DGVCities
            // 
            this.DGVCities.AutoGenerateColumns = false;
            this.DGVCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnameDataGridViewTextBoxColumn,
            this.c_ID,
            this.ccntryIDDataGridViewTextBoxColumn});
            this.DGVCities.DataSource = this.citiesBindingSource;
            this.DGVCities.Location = new System.Drawing.Point(6, 35);
            this.DGVCities.Name = "DGVCities";
            this.DGVCities.Size = new System.Drawing.Size(641, 286);
            this.DGVCities.TabIndex = 0;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "c_name";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            // 
            // c_ID
            // 
            this.c_ID.DataPropertyName = "c_ID";
            this.c_ID.HeaderText = "c_ID";
            this.c_ID.Name = "c_ID";
            this.c_ID.ReadOnly = true;
            this.c_ID.Visible = false;
            // 
            // ccntryIDDataGridViewTextBoxColumn
            // 
            this.ccntryIDDataGridViewTextBoxColumn.DataPropertyName = "c_cntryID";
            this.ccntryIDDataGridViewTextBoxColumn.DataSource = this.countriesBindingSource;
            this.ccntryIDDataGridViewTextBoxColumn.DisplayMember = "cntry_name";
            this.ccntryIDDataGridViewTextBoxColumn.HeaderText = "Країна";
            this.ccntryIDDataGridViewTextBoxColumn.Name = "ccntryIDDataGridViewTextBoxColumn";
            this.ccntryIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ccntryIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ccntryIDDataGridViewTextBoxColumn.ValueMember = "cntry_ID";
            // 
            // tabCountries
            // 
            this.tabCountries.Controls.Add(this.BTNDeleteAddresses);
            this.tabCountries.Controls.Add(this.BTNSaveAddresses);
            this.tabCountries.Controls.Add(this.DGVCoutries);
            this.tabCountries.Location = new System.Drawing.Point(4, 22);
            this.tabCountries.Name = "tabCountries";
            this.tabCountries.Size = new System.Drawing.Size(653, 329);
            this.tabCountries.TabIndex = 3;
            this.tabCountries.Text = "Країни";
            this.tabCountries.UseVisualStyleBackColor = true;
            // 
            // BTNDeleteAddresses
            // 
            this.BTNDeleteAddresses.Location = new System.Drawing.Point(120, 6);
            this.BTNDeleteAddresses.Name = "BTNDeleteAddresses";
            this.BTNDeleteAddresses.Size = new System.Drawing.Size(75, 23);
            this.BTNDeleteAddresses.TabIndex = 2;
            this.BTNDeleteAddresses.Text = "Видалити";
            this.BTNDeleteAddresses.UseVisualStyleBackColor = true;
            this.BTNDeleteAddresses.Click += new System.EventHandler(this.BTNDeleteAddresses_Click);
            // 
            // BTNSaveAddresses
            // 
            this.BTNSaveAddresses.Location = new System.Drawing.Point(25, 6);
            this.BTNSaveAddresses.Name = "BTNSaveAddresses";
            this.BTNSaveAddresses.Size = new System.Drawing.Size(75, 23);
            this.BTNSaveAddresses.TabIndex = 1;
            this.BTNSaveAddresses.Text = "Зберегти";
            this.BTNSaveAddresses.UseVisualStyleBackColor = true;
            this.BTNSaveAddresses.Click += new System.EventHandler(this.BTNSaveCountries_Click);
            // 
            // DGVCoutries
            // 
            this.DGVCoutries.AutoGenerateColumns = false;
            this.DGVCoutries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCoutries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cntrynameDataGridViewTextBoxColumn,
            this.cntry_ID});
            this.DGVCoutries.DataSource = this.countriesBindingSource;
            this.DGVCoutries.Location = new System.Drawing.Point(6, 35);
            this.DGVCoutries.Name = "DGVCoutries";
            this.DGVCoutries.Size = new System.Drawing.Size(641, 286);
            this.DGVCoutries.TabIndex = 0;
            // 
            // cntrynameDataGridViewTextBoxColumn
            // 
            this.cntrynameDataGridViewTextBoxColumn.DataPropertyName = "cntry_name";
            this.cntrynameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.cntrynameDataGridViewTextBoxColumn.Name = "cntrynameDataGridViewTextBoxColumn";
            // 
            // cntry_ID
            // 
            this.cntry_ID.DataPropertyName = "cntry_ID";
            this.cntry_ID.HeaderText = "cntry_ID";
            this.cntry_ID.Name = "cntry_ID";
            this.cntry_ID.ReadOnly = true;
            this.cntry_ID.Visible = false;
            // 
            // tabsType
            // 
            this.tabsType.Controls.Add(this.BTNDeletesType);
            this.tabsType.Controls.Add(this.BTNSavesType);
            this.tabsType.Controls.Add(this.DGVsTypes);
            this.tabsType.Location = new System.Drawing.Point(4, 22);
            this.tabsType.Name = "tabsType";
            this.tabsType.Size = new System.Drawing.Size(653, 329);
            this.tabsType.TabIndex = 4;
            this.tabsType.Text = "Типи пам\'яток";
            this.tabsType.UseVisualStyleBackColor = true;
            // 
            // BTNDeletesType
            // 
            this.BTNDeletesType.Location = new System.Drawing.Point(120, 6);
            this.BTNDeletesType.Name = "BTNDeletesType";
            this.BTNDeletesType.Size = new System.Drawing.Size(75, 23);
            this.BTNDeletesType.TabIndex = 2;
            this.BTNDeletesType.Text = "Видалити";
            this.BTNDeletesType.UseVisualStyleBackColor = true;
            this.BTNDeletesType.Click += new System.EventHandler(this.BTNDeletesType_Click);
            // 
            // BTNSavesType
            // 
            this.BTNSavesType.Location = new System.Drawing.Point(25, 6);
            this.BTNSavesType.Name = "BTNSavesType";
            this.BTNSavesType.Size = new System.Drawing.Size(75, 23);
            this.BTNSavesType.TabIndex = 1;
            this.BTNSavesType.Text = "Зберегти";
            this.BTNSavesType.UseVisualStyleBackColor = true;
            this.BTNSavesType.Click += new System.EventHandler(this.BTNSavesType_Click);
            // 
            // DGVsTypes
            // 
            this.DGVsTypes.AutoGenerateColumns = false;
            this.DGVsTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVsTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTnameDataGridViewTextBoxColumn,
            this.sT_ID});
            this.DGVsTypes.DataSource = this.sTypesBindingSource;
            this.DGVsTypes.Location = new System.Drawing.Point(6, 35);
            this.DGVsTypes.Name = "DGVsTypes";
            this.DGVsTypes.Size = new System.Drawing.Size(641, 286);
            this.DGVsTypes.TabIndex = 0;
            // 
            // sTnameDataGridViewTextBoxColumn
            // 
            this.sTnameDataGridViewTextBoxColumn.DataPropertyName = "sT_name";
            this.sTnameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.sTnameDataGridViewTextBoxColumn.Name = "sTnameDataGridViewTextBoxColumn";
            // 
            // sT_ID
            // 
            this.sT_ID.DataPropertyName = "sT_ID";
            this.sT_ID.HeaderText = "sT_ID";
            this.sT_ID.Name = "sT_ID";
            this.sT_ID.ReadOnly = true;
            this.sT_ID.Visible = false;
            // 
            // hotelsBindingSource
            // 
            this.hotelsBindingSource.DataMember = "Hotels";
            this.hotelsBindingSource.DataSource = this.sightsDS;
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // hotelsTableAdapter
            // 
            this.hotelsTableAdapter.ClearBeforeFill = true;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // sTypesTableAdapter
            // 
            this.sTypesTableAdapter.ClearBeforeFill = true;
            // 
            // sightsTableAdapter
            // 
            this.sightsTableAdapter.ClearBeforeFill = true;
            // 
            // citiesInCountryTableAdapter
            // 
            this.citiesInCountryTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пошукПамятокToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пошукПамятокToolStripMenuItem
            // 
            this.пошукПамятокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.памяткиToolStripMenuItem,
            this.готеліToolStripMenuItem});
            this.пошукПамятокToolStripMenuItem.Name = "пошукПамятокToolStripMenuItem";
            this.пошукПамятокToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.пошукПамятокToolStripMenuItem.Text = "Пошук";
            // 
            // памяткиToolStripMenuItem
            // 
            this.памяткиToolStripMenuItem.Name = "памяткиToolStripMenuItem";
            this.памяткиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.памяткиToolStripMenuItem.Text = "Пам\'ятки";
            this.памяткиToolStripMenuItem.Click += new System.EventHandler(this.памяткиToolStripMenuItem_Click);
            // 
            // готеліToolStripMenuItem
            // 
            this.готеліToolStripMenuItem.Name = "готеліToolStripMenuItem";
            this.готеліToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.готеліToolStripMenuItem.Text = "Готелі";
            // 
            // hnameDataGridViewTextBoxColumn1
            // 
            this.hnameDataGridViewTextBoxColumn1.DataPropertyName = "h_name";
            this.hnameDataGridViewTextBoxColumn1.HeaderText = "Назва";
            this.hnameDataGridViewTextBoxColumn1.Name = "hnameDataGridViewTextBoxColumn1";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "h_ID";
            this.Column3.HeaderText = "h_ID";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // hcntryIDDataGridViewTextBoxColumn1
            // 
            this.hcntryIDDataGridViewTextBoxColumn1.DataPropertyName = "h_cntryID";
            this.hcntryIDDataGridViewTextBoxColumn1.DataSource = this.countriesBindingSource;
            this.hcntryIDDataGridViewTextBoxColumn1.DisplayMember = "cntry_name";
            this.hcntryIDDataGridViewTextBoxColumn1.HeaderText = "Країна";
            this.hcntryIDDataGridViewTextBoxColumn1.Name = "hcntryIDDataGridViewTextBoxColumn1";
            this.hcntryIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hcntryIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hcntryIDDataGridViewTextBoxColumn1.ValueMember = "cntry_ID";
            // 
            // hcityIDDataGridViewTextBoxColumn1
            // 
            this.hcityIDDataGridViewTextBoxColumn1.DataPropertyName = "h_cityID";
            this.hcityIDDataGridViewTextBoxColumn1.DataSource = this.citiesBindingSource;
            this.hcityIDDataGridViewTextBoxColumn1.DisplayMember = "c_name";
            this.hcityIDDataGridViewTextBoxColumn1.HeaderText = "Місто";
            this.hcityIDDataGridViewTextBoxColumn1.Name = "hcityIDDataGridViewTextBoxColumn1";
            this.hcityIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hcityIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hcityIDDataGridViewTextBoxColumn1.ValueMember = "c_ID";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 394);
            this.Controls.Add(this.TABC);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Sights Observer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TABC.ResumeLayout(false);
            this.tabSights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightsDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightsBindingSource)).EndInit();
            this.tabHotels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabCities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCities)).EndInit();
            this.tabCountries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCoutries)).EndInit();
            this.tabsType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVsTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TABC;
        private System.Windows.Forms.TabPage tabCities;
        private System.Windows.Forms.TabPage tabSights;
        private System.Windows.Forms.DataGridView DGVCities;
        private System.Windows.Forms.TabPage tabHotels;
        private System.Windows.Forms.Button BTNSaveCities;
        private System.Windows.Forms.Button BTNDeleteCities;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button BTNDeleteSights;
        private System.Windows.Forms.Button BTNSaveSights;
        private System.Windows.Forms.Button BTNDeleteHotels;
        private System.Windows.Forms.Button BTNSaveHotels;
        private System.Windows.Forms.TabPage tabCountries;
        private System.Windows.Forms.DataGridView DGVCoutries;
        private System.Windows.Forms.TabPage tabsType;
        private System.Windows.Forms.DataGridView DGVsTypes;
        private System.Windows.Forms.Button BTNDeleteAddresses;
        private System.Windows.Forms.Button BTNSaveAddresses;
        private System.Windows.Forms.Button BTNDeletesType;
        private System.Windows.Forms.Button BTNSavesType;
        private SightsDS sightsDS;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private SightsDSTableAdapters.CitiesTableAdapter citiesTableAdapter;
        private System.Windows.Forms.BindingSource hotelsBindingSource;
        private SightsDSTableAdapters.HotelsTableAdapter hotelsTableAdapter;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private SightsDSTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.BindingSource sTypesBindingSource;
        private SightsDSTableAdapters.sTypesTableAdapter sTypesTableAdapter;
        private System.Windows.Forms.BindingSource sightsBindingSource;
        private SightsDSTableAdapters.SightsTableAdapter sightsTableAdapter;
        private SightsDSTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private SightsDSTableAdapters.Cities1TableAdapter citiesInCountryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntrynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntry_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ccntryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn ssTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn scntryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn scityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem пошукПамятокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem памяткиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem готеліToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn hnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn hcntryIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn hcityIDDataGridViewTextBoxColumn1;
    }
}

