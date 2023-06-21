using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                var item = new ListViewItem(new[] { STORE_NO.ToString(), BRANCHNAME.ToString(), COUNTRY.ToString(), COMANYCODE.ToString() });
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
    }
    }


    

