using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentss
{
    public partial class Form1 : Form
    {
        string[] predmeti = { "Математика", "ТРПО", "КПИЯП", "Моделирование", "Русский язык" };
        bool isLoaded = false;
        public Form1()
        {
            InitializeComponent();
        }
        List< Dictionary<string, double> > SubjectsAndMarks;
        private void Form1_Load(object sender, EventArgs e)
        {
            SubjectsAndMarks = new List<Dictionary<string, double>>();
            DataSet data = new DataSet();
            data.ReadXml("BD.xml");
            //int index = 0;
            foreach (DataRow row in data.Tables["Students"].Rows)
            {
                int n = table.Rows.Add();
                table.Rows[n].Cells[0].Value = row["Name"];
                table.Rows[n].Cells[1].Value = row["SecondName"];
                table.Rows[n].Cells[2].Value = row["Group"];
                string[] sandm = row["Subject"].ToString().Split(';');
                double midlemark = 0;
                Dictionary<string, double> subandmar = new Dictionary<string, double>();
                foreach (string str in sandm)
                {
                    string[] datas = str.Split('!');
                    subandmar[datas[0]] = double.Parse(datas[1]);
                    midlemark += double.Parse(datas[1]);
                }
                SubjectsAndMarks.Add(subandmar);
                midlemark /= SubjectsAndMarks[n].Count;
                table.Rows[n].Cells[3].Value = midlemark;
            }
            isLoaded = true;
        }

        private void SelectionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectionMode.SelectedIndex == 2)
            {
                View.Text = "Показать";
                textBox1.Visible = false;
            }
            else
            {
                View.Text = "Найти";
                textBox1.Visible = true;
            }
        }

        private void View_Click(object sender, EventArgs e)
        {
            switch (SelectionMode.SelectedIndex)
            {
                case 0:
                    for(int i = 0; i < table.RowCount; i++)
                    {
                        if(table.Rows[i].Cells[0].Value.ToString().ToUpper() != textBox1.Text.ToUpper())
                        {
                            table.Rows[i].Visible = false;
                        }
                    }
                    break;
                case 1:
                    for (int i = 0; i < table.RowCount; i++)
                    {
                        if (table.Rows[i].Cells[2].Value.ToString().ToUpper() != textBox1.Text.ToUpper())
                        {
                            table.Rows[i].Visible = false;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < table.RowCount; i++)
                    {
                        if (double.Parse(table.Rows[i].Cells[3].Value.ToString()) > 4f)
                        {
                            table.Rows[i].Visible = false;
                        }
                    }
                    break;
                default:
                    MessageBox.Show("Выберите режим поиска/отображения");
                    return;
            }
        }

        private void ResetView_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table.RowCount; i++)
                table.Rows[i].Visible = true;
        }

        private void table_SelectionChanged(object sender, EventArgs e)
        {
            secondtable.Rows.Clear();
            if (!this.isLoaded) return;
            for(int i = 0; i < SubjectsAndMarks[table.CurrentRow.Index].Count; i++)
            {
                int n = secondtable.Rows.Add();
                secondtable.Rows[n].Cells[0].Value = predmeti[i];
                secondtable.Rows[n].Cells[1].Value = SubjectsAndMarks[table.CurrentRow.Index][predmeti[i]];
            }
        }
    }
}
