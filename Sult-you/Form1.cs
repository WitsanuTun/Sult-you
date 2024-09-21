using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sult_you
{
    public partial class Form1 : Form
    {
        int mun;
        int result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listshow.Items.Clear();
            for ( int i = 1; i <= 1000; i++)

            {
                com.Items.Add(i);
            }
        }

        private void com_SelectedIndexChanged(object sender, EventArgs e)
        {
            mun = Convert.ToInt16(com.SelectedItem);
            listshow.Items.Clear();
            for (int i = 1; i <=12 ; i++){
                result = mun * i;
                listshow.Items.Add(mun+"x"+i+"="+result);
            }
        }
    }
}
