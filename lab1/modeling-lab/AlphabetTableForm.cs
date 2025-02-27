using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modeling_lab
{
    public partial class AlphabetTableForm : Form
    {
        Dictionary<string, string> alphabet;

        public AlphabetTableForm(Dictionary<string,string> dict)
        {
            InitializeComponent();
            alphabet = dict;
            InitializeTable();
        }

        private void InitializeTable()
        {
            BindingSource _bindingSource = new BindingSource();
            alphabetTable.DataSource = _bindingSource;
            _bindingSource.DataSource = alphabet;

            alphabetTable.RowHeadersVisible = false;

            alphabetTable.Columns[0].HeaderText = "Функция";
            alphabetTable.Columns[1].HeaderText = "Символ";
        }

    }
}
