using ModernKonyvtar_AdatbazisBeadando.Models.Manager;
using ModernKonyvtar_AdatbazisBeadando.Models.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernKonyvtar_AdatbazisBeadando
{
    public partial class Form1 : Form
    {
        Konyvek_Tabla tablaManager;
        List<Konyvek> rekords_KonyvekList;
        BackgroundWorker bgWorker;

        public Form1()
        {
            InitializeComponent();
            tablaManager = new Konyvek_Tabla();
            rekords_KonyvekList = new List<Konyvek>();
            bgWorker = new BackgroundWorker();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bgWorker.WorkerSupportsCancellation = true;

            dtp_Kiadas_eve.CustomFormat = "yyyy";
            dtp_Kiadas_eve.ShowUpDown = true;
            cbb_Kategoria.DataSource = Enum.GetValues(typeof(Kategoria));

            InitDataGridView();
            
        }

        private void Form1_Show(object sender,EventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }

        private void InitDataGridView()
        {
            dgv_Konyvek.Rows.Clear();
            dgv_Konyvek.Columns.Clear();          

            DataGridViewColumn CimColumn = new DataGridViewColumn()
            {
                Name = "cim",
                HeaderText = "Cím",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            };
            dgv_Konyvek.Columns.Add(CimColumn);

            DataGridViewColumn SzerzoColumn = new DataGridViewColumn()
            {
                Name = "szerzo",
                HeaderText = "Szerző",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Konyvek.Columns.Add(SzerzoColumn);

            DataGridViewColumn KiadoColumn = new DataGridViewColumn()
            {
                Name = "kiado",
                HeaderText = "Kiadó",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Konyvek.Columns.Add(KiadoColumn);

            DataGridViewColumn Kiadas_eveColumn = new DataGridViewColumn()
            {
                Name = "kiadas_eve",
                HeaderText = "Kiadás éve",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Konyvek.Columns.Add(Kiadas_eveColumn);

            DataGridViewColumn Isbn_azonositoColumn = new DataGridViewColumn()
            {
                Name = "isbn_azonosito",
                HeaderText = "Isbn_azonosító",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Konyvek.Columns.Add(Isbn_azonositoColumn);

            DataGridViewColumn NyelvColumn = new DataGridViewColumn()
            {
                Name = "nyelv",
                HeaderText = "Nyelv",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Konyvek.Columns.Add(NyelvColumn);

            DataGridViewColumn KategoriaColumn = new DataGridViewColumn()
            {
                Name = "kategoria",
                HeaderText = "Kategória",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Konyvek.Columns.Add(KategoriaColumn);
        }

            private void BgWorker_RunWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
            {
                FillDataGridView();
            }

            private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
            {
                rekords_KonyvekList = tablaManager.Select();
            }

            private void FillDataGridView()
            {
                DataGridViewRow[] dataGridViewRows = new DataGridViewRow[rekords_KonyvekList.Count];

                for (int i = 0; i < rekords_KonyvekList.Count; i++)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                  

                    DataGridViewCell CimCell = new DataGridViewTextBoxCell();
                    CimCell.Value = rekords_KonyvekList[i].Cim;
                    dataGridViewRow.Cells.Add(CimCell);

                    DataGridViewCell SzerzoCell = new DataGridViewTextBoxCell();
                    SzerzoCell.Value = rekords_KonyvekList[i].Szerzo;
                    dataGridViewRow.Cells.Add(SzerzoCell);

                    DataGridViewCell KiadoCell = new DataGridViewTextBoxCell();
                    KiadoCell.Value = rekords_KonyvekList[i].Kiado;
                    dataGridViewRow.Cells.Add(KiadoCell);

                    DataGridViewCell Kiadas_eveCell = new DataGridViewTextBoxCell();
                    Kiadas_eveCell.Value = rekords_KonyvekList[i].Kiadas_eve;
                    dataGridViewRow.Cells.Add(Kiadas_eveCell);

                    DataGridViewCell Isbn_azonositoCell = new DataGridViewTextBoxCell();
                    Isbn_azonositoCell.Value = rekords_KonyvekList[i].Isbn_azonosito;
                    dataGridViewRow.Cells.Add(Isbn_azonositoCell);

                    DataGridViewCell NyelvCell = new DataGridViewTextBoxCell();
                    NyelvCell.Value = rekords_KonyvekList[i].Nyelv;
                    dataGridViewRow.Cells.Add(NyelvCell);

                    DataGridViewCell KategoriaCell = new DataGridViewTextBoxCell();
                    KategoriaCell.Value = rekords_KonyvekList[i].Kategoria;
                    dataGridViewRow.Cells.Add(KategoriaCell);

                    dataGridViewRows[i] = dataGridViewRow;

                }
                dgv_Konyvek.Rows.Clear();
                dgv_Konyvek.Rows.AddRange(dataGridViewRows);
            }

            private void tb_Isbn_azonositoLeave(object sender, EventArgs e)
            {
                string actual = tb_Isbn_azonosito.Text;
                bool Correct = tablaManager.CheckIsbn_azonosito(actual);
                tb_Isbn_azonosito.BackColor = Correct ? Color.White : Color.Red;
            }

        private void insert_button_Click(object sender, EventArgs e)
        {
            Konyvek konyv = new Konyvek()
            {
                Cim = tb_Cim.Text,
                Szerzo = tb_Szerzo.Text,
                Kiado = tb_Kiado.Text,
                Kiadas_eve = dtp_Kiadas_eve.Value,
                Isbn_azonosito = tb_Isbn_azonosito.Text,
                Nyelv = tb_Nyelv.Text,
                Kategoria = cbb_Kategoria.SelectedItem.ToString()
            };
            tablaManager.Insert(konyv);
            bgWorker.RunWorkerAsync();

            MessageBox.Show("A könyv hozzá lett adva");
            tb_Cim.Clear();
            tb_Szerzo.Clear();
            tb_Kiado.Clear();
            tb_Isbn_azonosito.Clear();
            tb_Nyelv.Clear();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int ToroltSorok = 0;
            foreach (DataGridViewRow selectedRows in dgv_Konyvek.SelectedRows)
            {
                Konyvek TorlendoRekord = new Konyvek();
                TorlendoRekord.Isbn_azonosito = selectedRows.Cells["isbn_azonosito"].Value.ToString();

                ToroltSorok += tablaManager.Delete(TorlendoRekord);
            }

            MessageBox.Show(string.Format("{0} sor került törlésre", ToroltSorok));
            if (ToroltSorok != 0)
            {
                bgWorker.RunWorkerAsync();
            }
        }

     

       
    }
}
