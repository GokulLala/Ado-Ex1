using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day14.Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source = ECXLC5502\SQLEXPRESS; initial catalog = Training; Integrated Security = true;");

            cmd = new SqlCommand("Select cStudentCode, vStudentName, cDepartmentCode, cDob, vAddress from Student_master", con);
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            txtStCode.Text = reader["cStudentCode"].ToString();
            txtStName.Text = reader["vStudentName"].ToString();
            txtDeptCode.Text = reader["cDepartmentCode"].ToString();
            dtDob.Text = reader["cDob"].ToString();
            txtAddress.Text = reader["VAddress"].ToString();

            reader.Close();
            cmd.Dispose();
            con.Close();

        }

        private void btnInsrt_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(@"Data Source = ECXLC5502\SQLEXPRESS; Initial Catalog = Training; Integrated Security = true"))
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                using (reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Already Have Records");
                    }
                    else
                    {
                        Console.Write("Enter Student Code");
                        txtStCode.Text = Console.ReadLine();
                        Console.Write("Enter Student Name");
                        txtStName.Text = Console.ReadLine();
                        Console.Write("Enter Dept Code");
                        txtDeptCode.Text = int.Parse(Console.ReadLine());
                        Console.Write("Enter DOB");
                        dtDob.Text = Console.ReadLine();
                        Console.Write("Enter Address");
                        txtAddress.Text = Console.ReadLine();



                    }
                }
            }
        }
    }
}
