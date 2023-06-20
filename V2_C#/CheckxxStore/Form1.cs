﻿using System;
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
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            string query = "use usicoal\n"
                + "select WS.STORE_NO, bc.BRANCHNAME ,BC.COUNTRY, BC.COMPANYCODE, BC.COMPANYNAME ,sl.RLAREA, count(WS.WORKSTATION_NAME) as [TILLCOUNT], wg.WRKST_GRP_NO, wg.WRKST_GRP_NAME, BC.INACTIVE, sl.RLBTYP\n"
                + "from WORKSTATION WS\n"
                + "join common.dbo.BranchCodes BC on BC.brlocd = WS.store_no\n"
                + "left join WORKSTATION_GROUP wg on wg.WRKST_GRP_NO = ws.WRKST_GRP_NO\n"
                + "left join common.dbo.StkLoc sl on sl.RLLOCD = cast(BC.brlocd as varchar)\n"
                + "    where BC.INACTIVE in (0,1)\n"
                + "    and BC.COUNTRY not in ('GB','IE','ZA','MY')\n"
                + "    and BC.BRLOCD not in (976,984,985,986,992,997,998,1996,1998,1994,1995,1991,1999,9999)\n"
                + "    and BC.country in ('BE','NL','LU','FR','PL','CY','PT','ES','CZ','EE','DE','AT','HU','IS','LT','LV','SK','SI','IE')\n"
                + "group by WS.STORE_NO, bc.BRANCHNAME, BC.COUNTRY, BC.COMPANYCODE, BC.COMPANYNAME ,sl.RLAREA, wg.WRKST_GRP_NO, wg.WRKST_GRP_NAME, BC.INACTIVE,sl.RLBTYP\n";
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Connexion réussie !");
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                var result = "";

                while (reader.Read())
                {
                    var column1Value = reader.GetValue(0); // Remplacez l'index par le bon numéro de colonne (commençant à 0)
                    var column2Value = reader.GetString(1); // Remplacez l'index par le bon numéro de colonne (commençant à 0)

                    // Ajoutez les valeurs à la chaîne de résultat
                    result += $"Column1: {column1Value}, Column2: {column2Value}\n";
                }

                reader.Close();

                Console.WriteLine(result);
                reader.Close();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion : " + ex.Message);
            }
        }

    }
}