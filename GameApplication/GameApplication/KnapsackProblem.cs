using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
//using MySql.Data.MySqlClient;

namespace GameApplication
{
    public partial class form_KnapsackProblem : Form
    {
        DBconnection connection = new DBconnection();

        int[] randomValues = new int[10];
        int[] randomWeight = new int[10];

        int maxWeight;
        int maxSelect;
        //int maxProfit;

        List<int> knapsakSelecteValueIndex = new List<int>();
        List<int> knapsakAnswerWeight = new List<int>();
        List<int> knapsakAnswerValues = new List<int>();
        List<int> userAnswerWeight = new List<int>();
        List<int> userAnswerValues = new List<int>();


        List<KnapsackDisplayValues> displayValues = new List<KnapsackDisplayValues>();

        List<KnapsackDisplayValues> answerValues = new List<KnapsackDisplayValues>();

        public form_KnapsackProblem()
        {
            InitializeComponent();

            maxWeight = 10;
            textBox_MaxWeight.Text = maxWeight.ToString();

            CreateRandomNumbers();
        }

        private void button_Previous_Click(object sender, EventArgs e)
        {
            //Close();
            this.Visible = false;
            form_GameApplication mainform = new form_GameApplication();
            mainform.Visible = true;
        }

        private int[] CreateRandomNumbers()
        {

            Random rnd = new Random();

            for (int i = 0; i < randomValues.Length; i++)
            {


                randomValues[i] = rnd.Next(5, 10);

            }



            for (int i = 0; i < randomWeight.Length; i++)
            {


                randomWeight[i] = rnd.Next(1, 5);

            }



            //Array.Sort(randomWeight, (x, y) => y.CompareTo(x));

            Console.WriteLine("randomWeight");

            foreach (int value in randomWeight)
            {
                Console.WriteLine(value + " ");
            }

            Console.WriteLine("randomValues");

            foreach (int value in randomValues)
            {
                Console.WriteLine(value + " ");
            }



            for (int i = 0; i < 10; i++)
            {
                KnapsackDisplayValues displayValue = new KnapsackDisplayValues();

                displayValue.isSelected = false;
                displayValue.item = "Item" + (i + 1);
                displayValue.weight = randomWeight[i].ToString();
                displayValue.value = randomValues[i].ToString();
                displayValues.Add(displayValue);
            }



            DataTable dtEmp = new DataTable();
            ////add column to datatable  
            dtEmp.Columns.Add("Select", typeof(bool));
            dtEmp.Columns.Add("Item", typeof(string));
            dtEmp.Columns.Add("Weight(Kg)", typeof(string));
            dtEmp.Columns.Add("Value", typeof(string));

            for (int i = 0; i < displayValues.Count; i++)
            {
                dtEmp.Rows.Add(displayValues[i].isSelected, displayValues[i].item, displayValues[i].weight, displayValues[i].value);
            }

            dataGridView_Answers.DataSource = dtEmp;
            dataGridView_Answers.AllowUserToAddRows = false;



            int W = 10;
            int n = randomValues.Length;

            printknapSack(W, randomWeight, randomValues, n);


            return null;

        }


        //calculate Maximum profit 
        private void printknapSack(int W, int[] wt, int[] val, int n)
        {
            int i, w;
            int[,] K = new int[n + 1, W + 1];


            // Build table K[][] in bottom up manner
            for (i = 0; i <= n; i++)
            {
                for (w = 0; w <= W; w++)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (wt[i - 1] <= w)
                        K[i, w] = Math.Max(val[i - 1] + K[i - 1, w - wt[i - 1]], K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            // stores the result of Knapsack
            int res = K[n, W];
            Console.WriteLine("check max");
            Console.WriteLine(res);
            textBox_MaximumProfit.Text = res.ToString();


            w = W;

            for (i = n; i > 0 && res > 0; i--)
            {

                // either the result comes from the top
                // (K[i-1][w]) or from (val[i-1] + K[i-1]
                // [w-wt[i-1]]) as in Knapsack table. If
                // it comes from the latter one/ it means
                // the item is included.
                if (res == K[i - 1, w])
                    continue;
                else
                {
                    Console.WriteLine("check item");

                    // This item is included.
                    Console.WriteLine(wt[i - 1] + " ");

                    knapsakSelecteValueIndex.Add(i - 1);
                    // Since this weight is included its
                    // value is deducted
                    res = res - val[i - 1];
                    w = w - wt[i - 1];


                }
            }

            storeSelectedValue(knapsakSelecteValueIndex);

        }


        private void storeSelectedValue(List<int> knapsakSelecteValueIndex)
        {


            maxSelect = knapsakSelecteValueIndex.Count;
            textBox_Items.Text = maxSelect.ToString();

            //maxProfit = knapsakSelecteValueIndex.Count;


            for (int i = 0; i < knapsakSelecteValueIndex.Count; i++)
            {
                int index = knapsakSelecteValueIndex[i];

                knapsakAnswerWeight.Add(randomWeight[index]);
                knapsakAnswerValues.Add(randomValues[index]);
            }

            Console.WriteLine("answer index");

            foreach (int value in knapsakSelecteValueIndex)
            {
                Console.WriteLine(value + " ");
            }


        }

        private int max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_PlayerName.Text))
            {
                MessageBox.Show("Please enter player name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                int selectCount = 0;
                int selectWeight = 0;

                if (!String.IsNullOrEmpty(textBox_PlayerName.Text))
                {
                    foreach (DataGridViewRow row in dataGridView_Answers.Rows)
                    {
                        bool isSelected = Convert.ToBoolean(row.Cells["Select"].Value);


                        if (isSelected)
                        {
                            selectCount = selectCount + 1;

                            string value = row.Cells["Weight(Kg)"].Value.ToString();

                            int selectValue = int.Parse(value);

                            selectWeight = selectWeight + selectValue;

                        }
                    }

                    if (selectCount.Equals(maxSelect))
                    {
                        if (selectWeight.Equals(maxWeight))
                        {

                            foreach (DataGridViewRow row in dataGridView_Answers.Rows)
                            {
                                KnapsackDisplayValues disValue = new KnapsackDisplayValues();
                                bool isSelected = Convert.ToBoolean(row.Cells["Select"].Value);
                                if (isSelected)
                                {

                                    string item = row.Cells["Item"].Value.ToString();
                                    string weight = row.Cells["Weight(Kg)"].Value.ToString();
                                    string value = row.Cells["Value"].Value.ToString();

                                    int answerWeight = int.Parse(weight);
                                    int answerValue = int.Parse(value);

                                    userAnswerWeight.Add(answerWeight);
                                    userAnswerValues.Add(answerValue);

                                    disValue.item = item;
                                    disValue.weight = weight;
                                    disValue.value = value;

                                    answerValues.Add(disValue);



                                }
                            }

                            List<int> sortKnapsakAnswerWeight = knapsakAnswerWeight.OrderBy(o => o).ToList();
                            List<int> sortknapsakAnswerValues = knapsakAnswerValues.OrderBy(o => o).ToList();
                            List<int> sortUserAnswerWeight = userAnswerWeight.OrderBy(o => o).ToList();
                            List<int> sortUserAnswerValues = userAnswerValues.OrderBy(o => o).ToList();

                            Console.WriteLine("answer weght");
                            foreach (int value in sortKnapsakAnswerWeight)
                            {
                                Console.WriteLine(value + " ");
                            }

                            Console.WriteLine("answer values");
                            foreach (int value in sortknapsakAnswerValues)
                            {
                                Console.WriteLine(value + " ");
                            }

                            Console.WriteLine("user answer value");
                            foreach (int value in sortUserAnswerValues)
                            {
                                Console.WriteLine(value + " ");
                            }

                            Console.WriteLine("user answer wieghtValues");
                            foreach (int value in sortUserAnswerWeight)
                            {
                                Console.WriteLine(value + " ");
                            }


                            bool isEqualWeight = sortKnapsakAnswerWeight.OrderBy(x => x).SequenceEqual(sortUserAnswerWeight.OrderBy(x => x));
                            bool isEqualValue = sortknapsakAnswerValues.OrderBy(x => x).SequenceEqual(sortUserAnswerValues.OrderBy(x => x));


                            if (isEqualWeight && isEqualValue)
                            {
                                MessageBox.Show("Congratulations, You won!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                try
                                {
                                    saveDataInDatabase(answerValues);
                                }

                                catch (Exception ex)
                                {
                                    MessageBox.Show("Database saving process failed" + ex.StackTrace, "Saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                finally
                                {
                                    /*if (myConnection != null)
                                        myConnection.Close();*/
                                    if (connection.OpenConnection() == true)
                                    {
                                        connection.CloseConnection();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Failed, Please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }
                        else
                        {
                            MessageBox.Show("Your select items total weight not compare to max weight", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please check your selection", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter player name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void saveDataInDatabase(List<KnapsackDisplayValues> answerValues)
        {
            string query = "INSERT INTO `tbl_knapsack`(`player_name`, `answer`) VALUES ('" + this.textBox_PlayerName.Text + "','" + answerValues + "')";
            if (connection.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                //Execute command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.CloseConnection();

                this.Controls.Clear();
                this.InitializeComponent();

                /*maxWeight = 10;
                textBox_MaxWeight.Text = maxWeight.ToString();

                CreateRandomNumbers();*/
            }
        }

        private void PrintValues(List<KnapsackDisplayValues> displayValues)
        {
            foreach (KnapsackDisplayValues obj in displayValues)
            {
                Console.WriteLine("{0} ", obj.weight);
            }
        }

        private void form_KnapsackProblem_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_GameApplication mainform = new form_GameApplication();
            mainform.Visible = true;
        }
    }
}
