using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Engineering_2017
{
    class Connection
    {
        //private string for the connection
        private string connectionString;

        //object that is used to store the connection to the database
        private SqlConnection connectionToDatabase;

        //used to open and change tables in the database
        private SqlDataAdapter dataAdapter;

        //constructor 
        public Connection(string connectionStr)
        {
            //stores connection string
            this.connectionString = connectionStr;
        }


        public void openConnection()
        {
            //creates the connection to the database
            connectionToDatabase = new SqlConnection(connectionString);

            //opens the connection to the database
            connectionToDatabase.Open();
        }

        public void closeConnection()
        {
            //close the connection to the database
            connectionToDatabase.Close();
        }

        public DataSet GetDataSet(string sqlStatement)
        {
            DataSet dataSet;

            //creates an object to minipulate a table in the database using the connection
            dataAdapter = new SqlDataAdapter(sqlStatement, connectionToDatabase);

            //creates the dataset
            dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);
            //return the dataSet
            return dataSet;
        }
    }

}