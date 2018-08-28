using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace Questionnaire
{
    /// <summary>
    /// Interaction logic for Questions.xaml
    /// </summary>
    public partial class Questions : Window
    {
        public Questions()
        {
            InitializeComponent();
        }
        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Insert Button Clicked");
            /*string code = this.txtcCode.Text;
            string fname = this.txtfname.Text;
            string lname = this.txtlname.Text;
            DateTime bdate = this.bcal.SelectedDate.Value;
            DateTime adate = this.cal.SelectedDate.Value;*/
            int ans1 = 0;
            int weight1 = 4;
            if (this.a1.IsChecked == true)
            {
                ans1 = 2*weight1;
            }
            else if (this.b1.IsChecked == true)
            {
                ans1 = 3*weight1;
            }
            else if (this.c1.IsChecked == true)
            {
                ans1 = 4*weight1;
            }
            else if (this.d1.IsChecked == true)
            {
                ans1 = 5*weight1;
            }

            int ans2 = 0;
            int weight2 = 5;
            if (this.a2.IsChecked == true)
            {
                ans2 = 5*weight2;
            }
            else if (this.b2.IsChecked == true)
            {
                ans2 = 4*weight2;
            }
            else if (this.c2.IsChecked == true)
            {
                ans2 = 3*weight2;
            }
            else if (this.d2.IsChecked == true)
            {
                ans2 = 2*weight2;
            }

            int ans3 = 0;
            int weight3 = 2;
            if (this.a3.IsChecked == true)
            {
                ans3 = 2*weight3;
            }
            else if (this.b3.IsChecked == true)
            {
                ans3 = 3*weight3;
            }
            else if (this.c3.IsChecked == true)
            {
                ans3 = 4*weight3;
            }
            else if (this.d3.IsChecked == true)
            {
                ans3 = 5*weight3;
            }

            int ans4 = 0;
            int weight4 = 3;
            if (this.a4.IsChecked == true)
            {
                ans4 = 2*weight4;
            }
            else if (this.b4.IsChecked == true)
            {
                ans4 = 3*weight4;
            }
            else if (this.c4.IsChecked == true)
            {
                ans4 = 4*weight4;
            }
            else if (this.d4.IsChecked == true)
            {
                ans4 = 5*weight4;
            }

            int ans5 = 0;
            int weight5 = 2;
            if (this.a5.IsChecked == true)
            {
                ans5 = 2*weight5;
            }
            else if (this.b5.IsChecked == true)
            {
                ans5 = 3*weight5;
            }
            else if (this.c5.IsChecked == true)
            {
                ans5 = 4*weight5;
            }
            else if (this.d5.IsChecked == true)
            {
                ans5 = 5*weight5;
            }

            int ans6 = 0;
            int weight6 = 4;
            if (this.a6.IsChecked == true)
            {
                ans6 = 5*weight6;
            }
            else if (this.b6.IsChecked == true)
            {
                ans6 = 4*weight6;
            }
            else if (this.c6.IsChecked == true)
            {
                ans6 = 3*weight6;
            }
            else if (this.d6.IsChecked == true)
            {
                ans6 = 2*weight6;
            }
            else if (this.e6.IsChecked == true)
            {
                ans6 = 1*weight6;
            }

            int ans7 = 0;
            int weight7 = 3;
            if (this.a7.IsChecked == true)
            {
                ans7 = 2*weight7;
            }
            else if (this.b7.IsChecked == true)
            {
                ans7 = 3*weight7;
            }
            else if (this.c7.IsChecked == true)
            {
                ans7 = 4*weight7;
            }
            else if (this.d7.IsChecked == true)
            {
                ans7 = 5*weight7;
            }

            int ans8 = 0;
            int weight8 = 4;
            if (this.a8.IsChecked == true)
            {
                ans8 = 2*weight8;
            }
            else if (this.b8.IsChecked == true)
            {
                ans8 = 3*weight8;
            }
            else if (this.c8.IsChecked == true)
            {
                ans8 = 4*weight8;
            }
            else if (this.d8.IsChecked == true)
            {
                ans8 = 5*weight8;
            }

            int ans9 = 0;
            int weight9 = 4;
            if (this.a9.IsChecked == true)
            {
                ans9 = 1*weight9;
            }
            else if (this.b9.IsChecked == true)
            {
                ans9 = 2*weight9;
            }
            else if (this.c9.IsChecked == true)
            {
                ans9 = 3*weight9;
            }
            else if (this.d9.IsChecked == true)
            {
                ans9 = 4*weight9;
            }
            else if (this.e9.IsChecked == true)
            {
                ans9 = 5*weight9;
            }

            int ans10 = 0;
            int weight10 = 3;
            if (this.a10.IsChecked == true)
            {
                ans10 = 2*weight10;
            }
            else if (this.b10.IsChecked == true)
            {
                ans10 = 3*weight10;
            }
            else if (this.c10.IsChecked == true)
            {
                ans10 = 4*weight10;
            }
            else if (this.d10.IsChecked == true)
            {
                ans10 = 5*weight10;
            }
            

            int ans11 = 0;
            int weight11 = 3;
            if (this.a11.IsChecked == true)
            {
                ans11 = 5*weight11;
            }
            else if (this.b11.IsChecked == true)
            {
                ans11 = 4*weight11;
            }
            else if (this.c11.IsChecked == true)
            {
                ans11 = 3*weight11;
            }
            else if (this.d11.IsChecked == true)
            {
                ans11 = 2*weight11;
            }

            int risk_score = ans1 + ans2 + ans3 + ans4 + ans5 + ans6 + ans7 + ans8 + ans9 + ans10 + ans11;
            float weight_sum = weight1 + weight2 + weight3 + weight4 + weight5 + weight6 + weight7 + weight8 + weight9 + weight10 + weight11;
            float risk_score_normalized = risk_score/weight_sum;
            risk_score_normalized =  (float)Math.Round(risk_score_normalized, 2);
            int risk_ID = 0;
            if (risk_score_normalized <= 1)
                risk_ID = 1;
            else if (risk_score_normalized <= 2)
                risk_ID = 2;
            else if (risk_score_normalized <= 3)
                risk_ID = 3;
            else if (risk_score_normalized <= 4)
                risk_ID = 4;
            else
                risk_ID = 5;

            MessageBox.Show(risk_score.ToString());
            MessageBox.Show(weight_sum.ToString());
            MessageBox.Show(risk_score_normalized.ToString());
            //MessageBox.Show(ans1.ToString());
            //string gender = thi
            /*string ccode = (this.CountryCode.SelectedItem as ComboBoxItem).Content.ToString();
            string str = string.Format(" code: {0}\n name: {1} {2}\n bdate: {3}\n app date: {4}\n country code: {5}\n gender: {6}", code, fname, lname, bdate, adate, ccode, gender);
            MessageBox.Show(str);
            */
            string uname = "anil";
            int cnworth = 10000;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=Grad18-HP ; User ID=sa; Password=sa123 ; INITIAL CATALOG=ASSET_ALLOCATION; Trusted_Connection=Yes");
                con.Open();
                string sql = "INSERT INTO RISK_PROFILE values " + "(@UNAME,@RISK_ID,@RISK_SCORE,@CNWORTH);";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    SqlParameter parameter = new SqlParameter
                    {
                        ParameterName = "@UNAME",
                        Value = uname,
                        SqlDbType = SqlDbType.VarChar,
                        Size = 20

                    };
                    command.Parameters.Add(parameter);

                    SqlParameter parameter1 = new SqlParameter
                    {
                        ParameterName = "@RISK_ID",
                        Value = risk_ID,
                        SqlDbType = SqlDbType.Int,
                        Size = 4

                    };
                    command.Parameters.Add(parameter1);

                    SqlParameter parameter2 = new SqlParameter
                    {
                        ParameterName = "@CNWORTH",
                        Value = cnworth,
                        SqlDbType = SqlDbType.Decimal,
                        Size = 9

                    };
                    command.Parameters.Add(parameter2);

                    SqlParameter parameter3 = new SqlParameter
                    {
                        ParameterName = "@RISK_SCORE",
                        Value = risk_score_normalized,
                        SqlDbType = SqlDbType.Float,
                        Size = 7

                    };
                    command.Parameters.Add(parameter3);
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
