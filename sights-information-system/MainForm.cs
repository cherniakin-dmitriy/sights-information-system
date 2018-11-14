using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sightsDS.Sights". При необходимости она может быть перемещена или удалена.
            this.sightsTableAdapter.Fill(this.sightsDS.Sights);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sightsDS.sTypes". При необходимости она может быть перемещена или удалена.
            this.sTypesTableAdapter.Fill(this.sightsDS.sTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sightsDS.Countries". При необходимости она может быть перемещена или удалена.
            this.countriesTableAdapter.Fill(this.sightsDS.Countries);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sightsDS.Hotels". При необходимости она может быть перемещена или удалена.
            this.hotelsTableAdapter.Fill(this.sightsDS.Hotels);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sightsDS.Cities". При необходимости она может быть перемещена или удалена.
            this.citiesTableAdapter.Fill(this.sightsDS.Cities);
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            citiesTableAdapter.Update(sightsDS.Cities);
        }

        private void BTNSaveSights_Click(object sender, EventArgs e)
        {
            sightsTableAdapter.Update(sightsDS.Sights);
        }

        private void BTNDeleteSights_Click(object sender, EventArgs e)
        {
            try
            {
                sightsBindingSource.RemoveCurrent();
            }
            catch (SystemException)
            {

            }
        }

        private void BTNSaveHotels_Click(object sender, EventArgs e)
        {
            hotelsTableAdapter.Update(sightsDS.Hotels);
        }

        private void BTNSaveCountries_Click(object sender, EventArgs e)
        {
            countriesTableAdapter.Update(sightsDS.Countries);
        }

        private void BTNSavesType_Click(object sender, EventArgs e)
        {
            sTypesTableAdapter.Update(sightsDS.sTypes);
        }

        private void BTNDeleteHotels_Click(object sender, EventArgs e)
        {
            try
            {
                hotelsBindingSource.RemoveCurrent();
            }
            catch (SystemException)
            {

            }
        }

        private void BTNDeleteAddresses_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)DGVCoutries.CurrentRow.Cells["cntry_ID"].Value;
                global::System.Nullable<int> cnt = queriesTableAdapter1.SQCountSightsInCountry(id) + queriesTableAdapter1.SQCountHotelsInCountry(id) + queriesTableAdapter1.SQCountCitiesInCountry(id);
                if (cnt == 0)
                { 
                    countriesBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Дані прив'язані до іншої таблиці. Видалення неможливе");
                }
            }
            catch (SystemException)
            {

            }
        }

        private void BTNDeletesType_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)DGVsTypes.CurrentRow.Cells["sT_ID"].Value;
                global::System.Nullable<int> cnt = queriesTableAdapter1.SQCountSightsOfType(id);
                if (cnt == 0)
                {
                    sTypesBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Дані прив'язані до іншої таблиці. Видалення неможливе");
                }
            }
            catch (SystemException)
            {

            }
        }

        private void BTNDeleteCity_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)DGVCities.CurrentRow.Cells["c_ID"].Value;
                global::System.Nullable<int> cnt = queriesTableAdapter1.SQCountSightsInCity(id) + queriesTableAdapter1.SQCountHotelsInCity(id);
                if (cnt == 0)
                {
                    citiesBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Дані прив'язані до іншої таблиці. Видалення неможливе");
                }
            }
            catch (SystemException)
            {

            }
        }

        private void TABC_SelectedIndexChanged(object sender, EventArgs e)
        {
            sTypesTableAdapter.Update(sightsDS.sTypes);
            citiesTableAdapter.Update(sightsDS.Cities);
            hotelsTableAdapter.Update(sightsDS.Hotels);
            sightsTableAdapter.Update(sightsDS.Sights);
            countriesTableAdapter.Update(sightsDS.Countries);
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void памяткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinderForm ff = new FinderForm();
            ff.Visible = true;
        }
    }
}
