using OtobusSefer.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusSefer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_Nerden.DisplayMember = "DurakID";
            cmb_Nerden.ValueMember = "DurakID";
            cmb_Nerden.DataSource = DuraklarBLL.GetDuraklarNerden(); //bu satırı iki satır üste alınca çalışmıyor!!! nedenini düşün!!!
        }

        private void cmb_Nerden_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Nereye.DataSource = DuraklarBLL.GetDuraklarNereye((int)cmb_Nerden.SelectedValue);
            cmb_Nereye.DisplayMember = "DurakID";
            cmb_Nereye.ValueMember = "DurakID";
        }
    }
}
