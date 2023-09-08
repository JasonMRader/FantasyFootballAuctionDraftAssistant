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
        int MaxBid;
        //string FantasyTeamName;
        public FantasyTeam? team;
        DraftManager Draft;
        public int PlayerCost => Int32.Parse(txtPlayerCost.Text);
        public frmInputCost(string playerName, DraftManager draft)
        {
            InitializeComponent();
            PlayerName = playerName;
            //MaxBid = fantasyTeam.CalculateMaxBid();
            //FantasyTeamName = fantasyTeam.Name;
            Draft = draft;
        }
        private void SetDraftButtonsToFantasyTeams()
        {
            var teamButtons = pnlOtherTeams.Controls.OfType<Button>().ToList();

            // Assuming Draft.AllFantasyTeams is ordered correctly, we'll first remove "Disappointing Monday"
            var orderedTeams = Draft.AllFantasyTeams.Where(team => team.Name != "Disappointing Monday").ToList();

            // Now loop through both the teamButtons and orderedTeams together using Zip
            foreach (var (btn, team) in teamButtons.Zip(orderedTeams, (b, t) => (b, t)))
            {
                btn.Text = team.Name;
                btn.Tag = team;
                btn.Click += DraftButton_Click; // This might add multiple click events if called multiple times. Ensure you only do this once.
            }
            btnDraft.Text = Draft.MyTeam.Name;
            btnDraft.Tag = Draft.MyTeam;
            btnDraft.Click += DraftButton_Click;
        }

        private void DraftButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button clickedButton && clickedButton.Tag is FantasyTeam selectedTeam)
            {
                this.MaxBid = selectedTeam.CalculateMaxBid();
                this.team = selectedTeam;
                if (IsValidNumber(txtPlayerCost.Text))
                {
                    if (int.Parse(txtPlayerCost.Text) <= MaxBid)
                    {
                        OnActionCompleted(DialogResult.OK);
                        this.Close();
                    }
                    else
                    {
                        lblWarningText.Text = "This Team Cannot Bid More Than $" + MaxBid;
                        lblWarningText.ForeColor = Color.Red;
                    }

                }
                else
                {
                    lblWarningText.Text = "Please Enter A Valid Number!";
                    lblWarningText.ForeColor = Color.Red;
                }


            }

        }

        private void btnDraft_Click(object sender, EventArgs e)
        {
            if (IsValidNumber(txtPlayerCost.Text))
            {
                if (int.Parse(txtPlayerCost.Text) <= MaxBid)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblWarningText.Text = "This Team Cannot Bid More Than $" + MaxBid;
                    lblWarningText.ForeColor = Color.Red;
                }

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
            SetDraftButtonsToFantasyTeams();
            //lblTeamName.Text = FantasyTeamName;
            //lblMaxBid.Text = "($" + MaxBid.ToString() + " MAX)";
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

        private void lblTeamName_Click(object sender, EventArgs e)
        {

        }
        public delegate void ActionCompletedEventHandler(object sender, ActionCompletedEventArgs e);

        public event ActionCompletedEventHandler ActionCompleted;

        public class ActionCompletedEventArgs : EventArgs
        {
            public DialogResult Result { get; set; }
            // Add other relevant properties/data
        }

        // Call this method in your frmInputCost when you'd typically set the DialogResult
        public void OnActionCompleted(DialogResult result)
        {
            ActionCompleted?.Invoke(this, new ActionCompletedEventArgs { Result = result });
        }

    }
}
