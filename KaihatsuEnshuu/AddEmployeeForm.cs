using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KaihatsuEnshuu
{
    public partial class AddEmployeeForm : template.Form1
    {


        String sqlQuery = "select * from emp";
        public AddEmployeeForm()
        {
            InitializeComponent();
        }


   
        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            reloadDataGridView(sqlQuery,  dataGridView1); //load datagridview with the values from sqlQuery

        }

        private void addEmployee_Click(object sender, EventArgs e)
        {

            string name = employeeName.Text.ToString();
            string dateTime = hiredate.Value.ToString();
            string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
            OleDbConnection con = new OleDbConnection(str);
            con.Open();
            OleDbCommand cmmd = new OleDbCommand("INSERT INTO emp(empname,hiredate) Values(@Name,@hiredate)", con);
            if (con.State == ConnectionState.Open)
            {
                cmmd.Parameters.AddWithValue("@Name", name);
                cmmd.Parameters.AddWithValue("@hiredate", dateTime);
                cmmd.ExecuteNonQuery();

                reloadDataGridView(sqlQuery,  dataGridView1);

            }
            con.Close();


            reloadDataGridView(sqlQuery, dataGridView1);
            



        }
    }
}
