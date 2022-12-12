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

namespace GameApplication
{
    public partial class form_FindShortestPath : Form
    {
        DBconnection connection = new DBconnection();

        public form_FindShortestPath()
        {
            InitializeComponent();
        }

        private void button_Previous_Click(object sender, EventArgs e)
        {
            //Close();
            this.Visible = false;
            form_GameApplication mainform = new form_GameApplication();
            mainform.Visible = true;
        }

        private void form_FindShortestPath_Load(object sender, EventArgs e)
        {
            button_Save.Enabled = false;
            button_Check.Enabled = false;
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            button_Check.Enabled = true;
            Random random = new Random();
            int randomValue;
            randomValue = random.Next(0, 9);
            int x = randomValue;
            textBox_SourceVertex.Text = (x.ToString());

            int y = Convert.ToInt32(randomValue);

            genarateMatix(y);
            button_Start.Enabled = false;
        }

        private void genarateMatix(int x)
        {
            //create random number object
            Random rand = new Random();

            //genarateMatix();
            var graph = new Graph();

            var a = graph.CreateRoot("A");
            var b = graph.CreateNode("B");
            var c = graph.CreateNode("C");
            var d = graph.CreateNode("D");
            var s = graph.CreateNode("E");  // s === e
            var f = graph.CreateNode("F");
            var g = graph.CreateNode("G");
            var h = graph.CreateNode("H");
            var i = graph.CreateNode("I");
            var j = graph.CreateNode("J");


            a.AddArc(b, rand.Next(10, 100))
                .AddArc(c, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100))
                .AddArc(i, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));

            b.AddArc(a, rand.Next(10, 100))
                .AddArc(c, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100))
                .AddArc(i, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));

            c.AddArc(a, rand.Next(10, 100))
                .AddArc(b, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100))
                .AddArc(i, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));

            d.AddArc(a, rand.Next(10, 100))
                .AddArc(b, rand.Next(10, 100))
                .AddArc(c, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100))
                .AddArc(i, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));


            s.AddArc(a, rand.Next(10, 100))
                .AddArc(b, rand.Next(10, 100))
                .AddArc(c, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100))
                .AddArc(i, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));

            f.AddArc(a, rand.Next(10, 100))
                .AddArc(b, rand.Next(10, 100))
                .AddArc(c, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100))
                .AddArc(i, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));

            g.AddArc(a, rand.Next(10, 100))
                .AddArc(b, rand.Next(10, 100))
                .AddArc(c, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100))
                .AddArc(i, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));

            h.AddArc(a, rand.Next(10, 100))
                .AddArc(b, rand.Next(10, 100))
                .AddArc(c, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(i, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));

            i.AddArc(a, rand.Next(10, 100))
                .AddArc(b, rand.Next(10, 100))
                .AddArc(c, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100))
                .AddArc(j, rand.Next(10, 100));

            j.AddArc(a, rand.Next(10, 100))
                .AddArc(b, 1)
                .AddArc(c, rand.Next(10, 100))
                .AddArc(d, rand.Next(10, 100))
                .AddArc(s, rand.Next(10, 100))
                .AddArc(f, rand.Next(10, 100))
                .AddArc(g, rand.Next(10, 100))
                .AddArc(h, rand.Next(10, 100));



            int[,] adj = graph.CreateAdjMatrix();

            PrintMatrix(ref adj, graph.AllNodes.Count);

            Dijkstra(adj, x);
        }

        private void PrintMatrix(ref int[,] matrix, int Count)
        {
            ListView listView = new ListView();

            listView.Location = new System.Drawing.Point(12, 12);
            listView.Name = "listView";
            listView.Size = new System.Drawing.Size(245, 200);
            listView.ForeColor = System.Drawing.Color.Black;
            listView.Dock = DockStyle.Fill;


            Console.Write("       ");
            listView.Items.Add("       ");
            for (int i = 0; i < Count; i++)
            {
                Console.Write("{0}  ", (char)('A' + i));
                listView.Items.Add(((char)('A' + i)).ToString());
            }
            Console.WriteLine();
            listView.Items.Add("\n");

            for (int i = 0; i < Count; i++)
            {
                Console.Write("{0} | [ ", (char)('A' + i));
                listView.Items.Add(((char)('A' + i)).ToString());
                for (int j = 0; j < Count; j++)
                {
                    if (i == j)
                    {
                        Console.Write(" 0");
                        listView.Items.Add(" 0");
                    }
                    else if (matrix[i, j] == null)
                    {
                        Console.Write(" .,");
                        listView.Items.Add(" .,");
                    }
                    else
                    {
                        Console.Write(" {0},", matrix[i, j]);
                        listView.Items.Add(matrix[i, j].ToString());
                    }

                }
                Console.Write(" ]\r\n");
                listView.Items.Add("\r\n");
            }
            Console.Write("\r\n");
            listView.Items.Add("\r\n");

            panel_RandomNumbers.Controls.Add(listView);

        }


        static int V = 10;
        int minDistance(int[] dist,
                        bool[] sptSet)
        {
            int min = int.MaxValue, min_index = -1;

            for (int v = 0; v < V; v++)
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }

            return min_index;
        }

        void printSolution(int[] dist, int n)
        {
            Console.Write("Vertex     Distance "
                          + "from Source\n");
            for (int i = 0; i < V; i++)
            {
                Console.Write(i + " \t\t " + dist[i] + "\n");
                Values.tDistance.Add(dist[i]);
            }
        }

        public void Dijkstra(int[,] graph, int src)
        {
            int[] dist = new int[V];
            bool[] sptSet = new bool[V];

            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }

            dist[src] = 0;

            for (int count = 0; count < V - 1; count++)
            {
                int u = minDistance(dist, sptSet);

                sptSet[u] = true;

                for (int v = 0; v < V; v++)

                    if (!sptSet[v] && graph[u, v] != 0 &&
                         dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                        dist[v] = dist[u] + graph[u, v];
            }

            printSolution(dist, V);
        }

        private void saveDataInDatabase()
        {
            try
            {
                
                string query = "INSERT INTO `tbl_dijkstra`(`player_name`, `answer`) VALUES ('" + Values.playerName + "','" + Values.uAnswer + "')";
                if (connection.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                    //Execute command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Saved Successfully", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.CloseConnection();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Database saving process failed" + ex.StackTrace, "Saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_PlayerName.Text))
            {
                MessageBox.Show("Please enter player name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Values.playerName = textBox_PlayerName.Text;
                saveDataInDatabase();
            }
        }

        private void form_FindShortestPath_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_GameApplication mainform = new form_GameApplication();
            mainform.Visible = true;
        }

        public void check()
        {
            bool isEqualWeight = Values.tDistance.OrderBy(x => x).SequenceEqual(Values.uAnswer.OrderBy(x => x));

            if (isEqualWeight == true)
            {
                MessageBox.Show("Correct Answer", "Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button_Save.Enabled = true;
            }
            else
            {
                MessageBox.Show("Wrong Answer", "Answer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Answer.Text))
            {
                MessageBox.Show("Please provide your answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                check();
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Answer.Text))
            {
                MessageBox.Show("Please provide your answer.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Values.uAnswer.Clear();
                try
                {
                    string[] txtNumbers = textBox_Answer.Text.Split('\n');
                    foreach (string nbr in txtNumbers)
                    {
                        int number = int.Parse(nbr);
                        Values.uAnswer.Add(number);
                    }
                    
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Process failed. " + ex.StackTrace, "Saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_PlayAgain_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();

            button_Check.Enabled = true;
            Random random = new Random();
            int randomValue;
            randomValue = random.Next(0, 9);
            int x = randomValue;
            textBox_SourceVertex.Text = (x.ToString());

            int y = Convert.ToInt32(randomValue);

            genarateMatix(y);
            button_Start.Enabled = false;
        }
    }
}
