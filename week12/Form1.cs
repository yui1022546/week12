using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace week12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
           
            string path=@menuTxb.Text;
            string[] file = Directory.GetDirectories(path);
            foreach (var items in file) {
                showTxb.Text += "\n"+items.ToString()+"\n";
                    
            
            
            }
        
        }

        private void menuTxb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
