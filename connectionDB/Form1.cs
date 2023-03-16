using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            mySqlCommand1.Parameters.Add("@login", MySqlDbType.VarChar);
            mySqlCommand1.Parameters.Add("@password",MySqlDbType.VarChar);
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection1.Open();

                string user = login.Text;
                string pass = password.Text;

                mySqlCommand1.Parameters["@login"].Value = user;
                mySqlCommand1.Parameters["@password"].Value = pass;

                int result = Convert.ToInt32(mySqlCommand1.ExecuteScalar());

                if(result>0)
                {
                    MessageBox.Show("Zalogowano");
                }
                else
                {
                    MessageBox.Show("Nie ma takiego użytkownika w naszej bazie danych");
                }

                mySqlConnection1.Close();
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
