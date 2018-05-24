using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircularLists
{
    public partial class BusStation : Form
    {
        DataStructure ds = new DataStructure();
        Base b;
        Int32 _hourBegin, _hourEnd;
        public BusStation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            b = new Base(textBoxName.Text,Convert.ToInt32(maskedTextMinutes.Text));
            ds.AddFinal(b);
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            textBoxShow.Text=ds.List();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxShow.Text = ds.Search(textBoxName.Text).ToString();
            }
            catch
            {
                MessageBox.Show("Pruebe buscando con otro nombre", "No se encontro", MessageBoxButtons.OK);
            }
            
        }

        private void buttonDeleteL_Click(object sender, EventArgs e)
        {
            textBoxShow.Text = ds.DeleteLast().ToString();
        }

        private void buttonDeleteF_Click(object sender, EventArgs e)
        {
            textBoxShow.Text = ds.DeleteFirst().ToString();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            b = new Base(textBoxName.Text, Convert.ToInt32(maskedTextMinutes.Text));
            ds.Insert(b, Convert.ToInt32(maskedTextPos.Text));
        }

        private void buttonRoute_Click(object sender, EventArgs e)
        {
            textBoxShow.Text = ds.Route(textBoxName.Text, dateTimeBegin.Value, dateTimeEnd.Value);
        }
    }
}
