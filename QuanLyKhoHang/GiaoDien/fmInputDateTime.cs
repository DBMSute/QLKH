using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.GiaoDien
{
    public partial class fmInputDateTime : Form
    {
        public static string datetimepicked = null;
        public fmInputDateTime()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dateTimePick.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid data!");
                return;
            }
            datetimepicked = dateTimePick.Value.ToString("d", new System.Globalization.CultureInfo("es-ES"));
            this.Close();
        }
    }
}
