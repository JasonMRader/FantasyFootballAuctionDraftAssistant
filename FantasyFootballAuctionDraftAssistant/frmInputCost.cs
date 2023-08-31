using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasyFootballAuctionDraftAssistant
{
    public partial class frmInputCost : Form
    {
        //public string PlayerCostString => txtPlayerCost.Text;
        private string PlayerName;
        public int PlayerCost => Int32.Parse(txtPlayerCost.Text);
        public frmInputCost(string playerName)
        {
            InitializeComponent();
            PlayerName = playerName;
        }

        private void btnDraft_Click(object sender, EventArgs e)
        {
            if (IsValidNumber(txtPlayerCost.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblWarningText.Text = "Please Enter A Valid Number!";
                lblWarningText.ForeColor = Color.Red;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmInputCost_Load(object sender, EventArgs e)
        {
            lblPlayerName.Text = PlayerName;
        }
        private bool IsValidNumber(string text)
        {
            int number;
            if (int.TryParse(text, out number) && number >= 1 && number <= 200)
            {
                return true;
            }
            return false;
        }
    }
}
