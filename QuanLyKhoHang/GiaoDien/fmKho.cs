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
    public partial class fmKho : Form
    {
        public fmKho()
        {
            InitializeComponent();
            BUS.KhoBUS.Instance.loadData(dtgvWare);

        }
     
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtgvWare.Visible = false;
            dtgvWare.Size = new Size(0, 0);
            tmrSlide.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmrSlide_Tick(object sender, EventArgs e)
        {
            int X, Y;
            if (pnMidL.Location.X <= -990)
            {
                if (pnMidL2.Location.X == 10)
                {
                    dtgvWare2.Size = new Size(721, 430);
                    dtgvWare2.Visible = true;
                    tmrSlide.Stop();
                    return;
                }
                X = pnMidL2.Location.X;
                Y = pnMidL2.Location.Y;
                pnMidL2.Location = new Point(X + 100, Y);
            }
            else
            {

                X = pnMidL.Location.X;
                Y = pnMidL.Location.Y;
                pnMidL.Location = new Point(X - 100, Y);
            }
        }

        private void tmrSlide2_Tick(object sender, EventArgs e)
        {
            int X, Y;
            if (pnMidL2.Location.X <= -990)
            {
                if (pnMidL.Location.X == 10)
                {
                    dtgvWare.Size = new Size(721, 430);
                    dtgvWare.Visible = true;
                    tmrSlide2.Stop();
                    return;
                }
                X = pnMidL.Location.X;
                Y = pnMidL.Location.Y;
                pnMidL.Location = new Point(X + 100, Y);
            }
            else
            {
                X = pnMidL2.Location.X;
                Y = pnMidL2.Location.Y;
                pnMidL2.Location = new Point(X - 100, Y);
            }
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            dtgvWare2.Visible = false;
            dtgvWare2.Size = new Size(0, 0);
            tmrSlide2.Start();
        }
    }
}
