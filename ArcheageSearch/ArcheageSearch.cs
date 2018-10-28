using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcheageSearch
{
    public partial class ArcheageSearch : Form
    {
        private static Charactor mCharactor;

        public ArcheageSearch()
        {
            InitializeComponent();
            mCharactor = new Charactor(webBrowser1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = SearchName.Text;
            Charactor.GetCharactor(Name);
        }

        private void SearchName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
