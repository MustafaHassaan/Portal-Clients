using Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal.View.Users
{
    public partial class EmpHistories : Form
    {
        int mov;
        int movx;
        int movy;
        PortalContext Db;
        public EmpHistories()
        {
            InitializeComponent();
            LblName.Text = Employees.UNPassing;
            LbluserId.Text = Employees.IDPassing;
        }
        private void History_Click(object sender, EventArgs e)
        {
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }
        private async void EmpHistories_Load(object sender, EventArgs e)
        {
            DTF.Value = DateTime.Today;
            DTT.Value = DateTime.Today;
            try
            {
                GHLT();
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...","Error");
            }
        }



        //GHLT : Get History List For Today
        public void GHLT()
        {
            Db = new PortalContext();
            int id = Convert.ToInt32(LbluserId.Text);
            var PDb = from hist in Db.Histories
                      where hist.Date == DateTime.Today
                      join USING in Db.Users
                      on hist.UserId equals USING.Id
                      where USING.Id == id
                      select new
                      {
                          hist.SMSPhone,
                          hist.SMSBody,
                          hist.Languge,
                          hist.Status,
                          hist.Result,
                          hist.Date,
                          hist.Time
                      };
            DGV.DataSource = PDb.ToList();
        }

        //GHLT : Get History List For Date Choose
        public void GHLD()
        {
            Db = new PortalContext();
            int id = Convert.ToInt32(LbluserId.Text);
            var PDb = from hist in Db.Histories
                      where hist.Date >= DTF.Value && hist.Date <= DTT.Value
                      join USING in Db.Users
                      on hist.UserId equals USING.Id
                      where USING.Id == id
                      select new
                      {
                          hist.SMSPhone,
                          hist.SMSBody,
                          hist.Languge,
                          hist.Status,
                          hist.Result,
                          hist.Date,
                          hist.Time
                      };
            DGV.DataSource = PDb.ToList();
        }

        //GHLT : Get History Phone List For Today
        public void GHPT()
        {
            Db = new PortalContext();
            int id = Convert.ToInt32(LbluserId.Text);
            var PDb = from hist in Db.Histories
                      where hist.Date == DateTime.Today &&
                            hist.SMSPhone.Contains(TSerching.Text)
                      join USING in Db.Users
                      on hist.UserId equals USING.Id
                      where USING.Id == id
                      select new
                      {
                          hist.SMSPhone,
                          hist.SMSBody,
                          hist.Languge,
                          hist.Status,
                          hist.Result,
                          hist.Date,
                          hist.Time
                      };
            DGV.DataSource = PDb.ToList();
        }

        //GHLT : Get History Phone List For Date Choose
        public void GHPD()
        {
            Db = new PortalContext();
            int id = Convert.ToInt32(LbluserId.Text);
            var PDb = from hist in Db.Histories
                      where hist.Date >= DTF.Value && hist.Date <= DTT.Value &&
                            hist.SMSPhone.Contains(TSerching.Text)
                      join USING in Db.Users
                      on hist.UserId equals USING.Id
                      where USING.Id == id
                      select new
                      {
                          hist.SMSPhone,
                          hist.SMSBody,
                          hist.Languge,
                          hist.Status,
                          hist.Result,
                          hist.Date,
                          hist.Time
                      };
            DGV.DataSource = PDb.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TSerching.Text == "" && DTF.Value == DateTime.Today && DTT.Value == DateTime.Today)
            {
                GHLT();
            }
            if (TSerching.Text == "" && DTF.Value <= DateTime.Today && DTT.Value <= DateTime.Today)
            {
                GHLD();
            }
            if (TSerching.Text != "" && DTF.Value == DateTime.Today && DTT.Value == DateTime.Today)
            {
                GHPT();
            }
            if (TSerching.Text != "" && DTF.Value <= DateTime.Today && DTT.Value <= DateTime.Today)
            {
                GHPD();
            }
        }
        private void DTF_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void DTT_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void DTF_ValueChanged(object sender, EventArgs e)
        {
        }
        private void DTT_ValueChanged(object sender, EventArgs e)
        {
        }
        private void TSerching_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Key Pres Number Only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void TSerching_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TSerching.Text == "" && DTF.Value == DateTime.Today && DTT.Value == DateTime.Today)
                {
                    GHLT();
                }
                if (TSerching.Text == "" && DTF.Value <= DateTime.Today && DTT.Value <= DateTime.Today)
                {
                    GHLD();
                }
                if (TSerching.Text != "" && DTF.Value == DateTime.Today && DTT.Value == DateTime.Today)
                {
                    GHPT();
                }
                if (TSerching.Text != "" && DTF.Value <= DateTime.Today && DTT.Value <= DateTime.Today)
                {
                    GHPD();
                }
            }
        }
    }
}
