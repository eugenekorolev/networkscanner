using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ListNetworkComputers
{
    /// <summary>
    /// A simply test form that creates a new NetworkBrowser
    /// object, and displays a list of the network computers
    /// found by the NetworkBrowser
    /// </summary>
    /// 

    public partial class mainWindow : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// 
        BindingList<Pair> computeList;
        public mainWindow()
        {
            InitializeComponent();
            computeList = new BindingList<Pair>();
        }

        

        private void frmMain_Load(object sender, EventArgs e)
        {

            //create a new NetworkBrowser object, and get the
            //list of network computers it found, and add each
            //entry to the combo box on this form
            try
            {
                NetworkBrowser nb = new NetworkBrowser();
                ArrayList pcList = nb.getNetworkComputers();

                IEnumerator myEnum = pcList.GetEnumerator();


                int i = 0;
                while (myEnum.MoveNext()) {
                    Pair pair = new Pair(i, myEnum.Current.ToString());
                    computeList.Add(pair);
                    i++;
                }

                //foreach (string pc in myEnum)
                //{
                    //computeList.Add();
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred trying to access the network computers", "error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                //dataGridView1.
                
                dataGridView1.Columns.Add("key", "Íîìåð ÏÝÂÌ");
                dataGridView1.Columns.Add("value", "Èìÿ ÏÝÂÌ");

                dataGridView1.DataSource = computeList;
            }

        }

        static DataTable ConvertListToDataTable(List<Pair> list)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 0;
            foreach (var array in list)
            {
                if (array. > columns)
                {
                    columns = array.Length;
                }
            }

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }

    }
    class Pair
    {
        int key;
        string value;
        public Pair() { }
        public Pair(int parKey, string parValue)
        {
            this.key = parKey;
            this.value = parValue;
        }

        public string ToString()
        {
            return " " + key + " " + value;
        }

    }
}