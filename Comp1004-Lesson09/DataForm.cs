﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp1004_Lesson09
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Comp1004_namesDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this._Comp1004_namesDataSet.Users);

        }
    }
}
