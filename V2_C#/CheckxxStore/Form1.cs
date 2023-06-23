using IronXL;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CheckxxStore
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=VIPER17\\SQL17;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            InitalizeListViewStoreDetails();
        }


        private void InitalizeListViewStoreDetails()
        {

            Dbo all_store_connection = new Dbo(QuerySql.queryAllStore);
            while (all_store_connection.getReader().Read())
            {
                var STORE_NO = all_store_connection.getReader().GetValue(0);
                var BRANCHNAME = all_store_connection.getReader().GetValue(1);
                var COUNTRY = all_store_connection.getReader().GetValue(2);
                var COMANYCODE = all_store_connection.getReader().GetValue(3);
                var RLAREA = all_store_connection.getReader().GetValue(5);
                var item = new ListViewItem(new[] { STORE_NO.ToString(), BRANCHNAME.ToString(), COUNTRY.ToString(), COMANYCODE.ToString(), RLAREA.ToString() });
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            all_store_connection.getReader().Close();
            all_store_connection.getConnection().Close();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            panel2.Height = button2.Height;
            panel2.Top = button2.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Height = button3.Height;
            panel2.Top = button3.Top;
        }

        private void CheckStore_Click(object sender, EventArgs e)
        {
            panel2.Height = CheckStore.Height;
            panel2.Top = CheckStore.Top;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterStore.Text.Trim().ToLower();


            foreach (ListViewItem item in listView1.Items)
            {
                bool itemFound = false;

                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text.ToLower().Contains(searchText))
                    {
                        itemFound = true;
                        break;
                    }
                }

                item.Selected = itemFound;

                if (itemFound)
                {
                    item.EnsureVisible();
                }
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            // Parcours des éléments de la ListView
            string printContent = "";
            foreach (ListViewItem item in listView1.Items)
            {
                // Récupérer le contenu de chaque élément
                string itemContent = "";
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    itemContent += item.SubItems[i].Text + "\t"; // Ajouter une tabulation entre chaque sous-élément
                }
                printContent += itemContent + Environment.NewLine; // Ajouter un retour à la ligne après chaque élément
            }

            // Imprimer le contenu
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, pe) =>
            {
                pe.Graphics.DrawString(printContent, new Font("Arial", 5), Brushes.Black, new PointF(10, 10));
            };
            printDocument.Print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IronXL.WorkBook workbook = WorkBook.Create(ExcelFileFormat.XLSX);
            var worksheet = workbook.CreateWorkSheet("example");

            
            for (int col = 0; col < listView1.Columns.Count; col++)
            {
               
                worksheet.SetCellValue(0, col, listView1.Columns[col].Text);
                //worksheet.Columns[col].AutoSizeColumn();
                
                
            }

            for (int row = 0; row < listView1.Items.Count; row++)
            {
               
                var item = listView1.Items[row];
                for (int col = 0; col < item.SubItems.Count; col++)
                {
                    worksheet.SetCellValue(row + 1, col , item.SubItems[col].Text);
                   
                    
                }
                
               
            }
           
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Enregistrer le fichier Excel";
            saveFileDialog.Filter = "Fichier Excel (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;
                workbook.SaveAs(outputPath);
                MessageBox.Show("Le fichier Excel a été généré avec succès !");
            }

        }
    }
}


    

