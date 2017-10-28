using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_Engineering_2017
{
    public partial class finalUI : Form
    {
        public finalUI()
        {
            InitializeComponent();
        }
        //creates instance of Connection and DataSet
        Connection databaseCon;
        DataSet dataSet;


        private void finalUI_Load(object sender, EventArgs e)
        {
            //set the connection string
            string connectionString = Properties.Settings.Default.Connection;
            
            //sends connection string to the database 
            databaseCon = new Connection(connectionString);

            //opens the database connection
            databaseCon.openConnection();

            //set data set 
            dataSet = databaseCon.GetDataSet(Constants.selectAll);

            // creates instace and set table 
            DataTable table = dataSet.Tables[0];

            //calls fillInField
            fillInFields(table, 1);


        }

        private void fillInFields(DataTable table, int index)
        {
            /*fills out the UI for information form the table*/
            //dataRow.ItemArray.GetValue(0).ToString();
        }

        private void finalUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            //close database connection 
            databaseCon.closeConnection();
        }
    }
}
