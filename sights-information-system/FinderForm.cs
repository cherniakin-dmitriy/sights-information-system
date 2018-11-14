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
    public partial class FinderForm : Form
    {
        public FinderForm()
        {
            InitializeComponent();
        }

        private void FinderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sightsDS.Countries". При необходимости она может быть перемещена или удалена.
            this.countriesTableAdapter.Fill(this.sightsDS.Countries);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sightsDS.Cities". При необходимости она может быть перемещена или удалена.
            this.citiesTableAdapter.Fill(this.sightsDS.Cities);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sightsDS.sTypes". При необходимости она может быть перемещена или удалена.
            this.sTypesTableAdapter.Fill(this.sightsDS.sTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sightsDS.Sights". При необходимости она может быть перемещена или удалена.
            this.sightsTableAdapter.Fill(this.sightsDS.Sights);

        }

        private void fillByFilterToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sightsTableAdapter.FillByFilter(this.sightsDS.Sights, s_nameToolStripTextBox.Text + "%", c_nameToolStripTextBox.Text + "%", sT_nameToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByFilterToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
