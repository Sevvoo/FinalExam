using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shop myshop = new Shop();
            foreach (var filter in myshop.Filters)
            {
                TreeNode newNode = new TreeNode();
                newNode.Text = filter.Title;
                foreach (var categories in filter.Categories)
                {
                    newNode.Nodes.Add(categories.Title);
                }
                TreeFilters.Nodes.Add(newNode);
            }
        }

        private void FormProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
