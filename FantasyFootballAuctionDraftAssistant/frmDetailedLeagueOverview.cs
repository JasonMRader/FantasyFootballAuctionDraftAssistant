using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasyFootballAuctionDraftAssistant
{
    public partial class frmDetailedLeagueOverview : Form
    {
        public DraftManager Draft;
        //private Form1 form1Instance;
        public event EventHandler<FantasyTeamEventArgs> TeamSelected;


        public frmDetailedLeagueOverview()
        {
            InitializeComponent();

        }
        public frmDetailedLeagueOverview(DraftManager draft)
        {
            InitializeComponent();
            this.Draft = draft;
            this.Draft.DraftChanged += Draft_DraftChanged;
            
        }


        private void frmDetailedLeagueOverview_Load(object sender, EventArgs e)
        {
            SetPanelsToFantasyTeams();
        }
        private void Draft_DraftChanged(object sender, EventArgs e)
        {
            SetPanelsToFantasyTeams();
        }
        private void InitializePanelWithTeamInfo(Panel panel, FantasyTeam team)
        {
            if (team.Name == "Disappointing Monday")
            {
                //panel.BackColor = Color.FromArgb(98, 88, 52);
                //panel.BorderStyle = BorderStyle.Fixed3D;
                Panel sideHighlightPanel = new Panel();
                sideHighlightPanel.Size = new Size(2, panel.Height);
                sideHighlightPanel.Dock = DockStyle.Right;
                sideHighlightPanel.BackColor = Color.Gold;
                panel.Controls.Add(sideHighlightPanel);
                Panel bottomHighlightPanel = new Panel();
                bottomHighlightPanel.Size = new Size(panel.Width, 2);
                bottomHighlightPanel.Dock = DockStyle.Bottom;
                bottomHighlightPanel.BackColor = Color.Gold;
                panel.Controls.Add(bottomHighlightPanel);
                //panel.Width =+ 2;
                //panel.Height =+ 2;



            }
            // Set up RadioButton
            Button btnChooseTeam = new Button();
            btnChooseTeam.Text = team.Name;
            btnChooseTeam.FlatStyle = FlatStyle.Flat;
            btnChooseTeam.FlatAppearance.BorderSize = 0;
            btnChooseTeam.Font = new Font("Arial", 10, FontStyle.Bold);
            btnChooseTeam.BackColor = Color.FromArgb(176, 209, 176);
            btnChooseTeam.Dock = DockStyle.Top;
            btnChooseTeam.Tag = team;
            btnChooseTeam.Click += TeamButton_Click; // if you want an event
            panel.Controls.Add(btnChooseTeam);

            int labelXPoint = 1;

            System.Windows.Forms.Label lblRosterSpots = SetPositionCountLabels(Player.PlayerPosition.QB, team);
            lblRosterSpots.Location = new Point(labelXPoint, btnChooseTeam.Height);
            lblRosterSpots.Size = new Size(50, 33);
            lblRosterSpots.ForeColor = Color.Black;
            lblRosterSpots.Text = "Players\n" + team.Players.Count.ToString() + "/16";
            lblRosterSpots.Font = new Font("Arial Narrow", 10, FontStyle.Bold);

            panel.Controls.Add(lblRosterSpots);
            //System.Windows.Forms.Label lblRosterSpots = CreateMoneyLabels(team.Players.Count.ToString() + "/16");
            //lblRosterSpots.Location = new Point(labelXPoint, btnChooseTeam.Height + 2);
            //lblRosterSpots.Size = new Size(30, 30);
            //lblRosterSpots.Font = new Font("Arial Narrow", 13, FontStyle.Bold);
            //panel.Controls.Add(lblRosterSpots);

            labelXPoint += lblRosterSpots.Width;

            System.Windows.Forms.Label lblQB = SetPositionCountLabels(Player.PlayerPosition.QB, team);
            lblQB.Location = new Point(labelXPoint, btnChooseTeam.Height + 2);
            panel.Controls.Add(lblQB);

            labelXPoint = labelXPoint + lblQB.Width;

            System.Windows.Forms.Label lblRB = SetPositionCountLabels(Player.PlayerPosition.RB, team);
            lblRB.Location = new Point(labelXPoint, btnChooseTeam.Height + 2);
            panel.Controls.Add(lblRB);

            labelXPoint += lblRB.Width;

            System.Windows.Forms.Label lblWR = SetPositionCountLabels(Player.PlayerPosition.WR, team);
            lblWR.Location = new Point(labelXPoint, btnChooseTeam.Height + 2);
            panel.Controls.Add(lblWR);

            labelXPoint += lblWR.Width;

            System.Windows.Forms.Label lblTE = SetPositionCountLabels(Player.PlayerPosition.TE, team);
            lblTE.Location = new Point(labelXPoint, btnChooseTeam.Height + 2);
            panel.Controls.Add(lblTE);

            labelXPoint += lblTE.Width;

            System.Windows.Forms.Label lblDEF = SetPositionCountLabels(Player.PlayerPosition.DEF, team);
            lblDEF.Location = new Point(labelXPoint, btnChooseTeam.Height + 2);
            panel.Controls.Add(lblDEF);

            labelXPoint += lblDEF.Width;

            System.Windows.Forms.Label lblK = SetPositionCountLabels(Player.PlayerPosition.K, team);
            lblK.Location = new Point(labelXPoint - 3, btnChooseTeam.Height + 2);
            panel.Controls.Add(lblK);

            System.Windows.Forms.Label lblMaxBid = CreateMoneyLabels("Max $" + team.CalculateMaxBid().ToString());
            System.Windows.Forms.Label lblBudget = CreateMoneyLabels("Budget $" + team.Budget.ToString());


            //lblMaxBid.Text = "Max Bid $" + team.CalculateMaxBid().ToString();
            //lblBudget.Text = "Budget $" + team.Budget.ToString();
            //lblRosterSpots.Text = team.Players.Count.ToString() + "/16";

            labelXPoint = 3;
            int labelYPoint = lblQB.Location.Y + lblQB.Height + 5;
            lblMaxBid.Location = new Point(labelXPoint, labelYPoint);

            lblMaxBid.Size = new Size((panel.Width / 2) - 3, 30);

            panel.Controls.Add(lblMaxBid);

            labelXPoint += lblMaxBid.Width;

            lblBudget.Location = new Point(labelXPoint, labelYPoint);
            lblBudget.Size = lblMaxBid.Size;

            panel.Controls.Add(lblBudget);

            labelXPoint += lblBudget.Width;

        }
        private System.Windows.Forms.Label CreateMoneyLabels(string labelString)
        {
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            label.Text = labelString;
            label.AutoSize = false;
            label.Size = new Size(100, 30);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font("Arial Narrow", 12, FontStyle.Bold);
            label.ForeColor = Color.Black;
            return label;
        }
        private System.Windows.Forms.Label SetPositionCountLabels(Player.PlayerPosition position, FantasyTeam team)
        {
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            label.Text = position.ToString() + "\n" + " " + team.CountPosition(position);
            label.AutoSize = false;
            label.Size = new Size(36, 37);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font("Arial", 10, FontStyle.Regular);
            label.ForeColor = GetPositionFontColor(team.CountPosition(position), position);
            return label;
        }

        private void TeamButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button clickedButton && clickedButton.Tag is FantasyTeam clickedTeam)
            {
                // Hide this form
                this.Hide();
                TeamSelected?.Invoke(this, new FantasyTeamEventArgs(clickedTeam));
                // Assuming you have access to the Form1 instance (let's say it's a property or field called form1Instance)
                //form1Instance.Draft.DisplayTeam = clickedTeam;
            }
        }

        private void SetPanelsToFantasyTeams()
        {
            int panelIndex = 0;


            foreach (Control control in this.Controls)
            {

                if (control is Panel && panelIndex < Draft.AllFantasyTeams.Count)
                {
                    control.Controls.Clear();
                    FantasyTeam currentTeam = Draft.AllFantasyTeams[panelIndex];
                    control.Tag = currentTeam;  // store the team in the Tag for retrieval later
                    //control.BackColor = Color.FromArgb(36, 2, 3);
                    //control.BackColor = Color.FromArgb(132, 130, 143);
                    control.BackColor = Color.FromArgb(152, 150, 163);
                    InitializePanelWithTeamInfo(control as Panel, currentTeam);

                    panelIndex++;
                }

            }

        }
        private void SetButtonsToTeams(FantasyTeam team)
        {

        }
        private Color GetPositionFontColor(int positionCount, Player.PlayerPosition position)
        {
            if (position == Player.PlayerPosition.RB || position == Player.PlayerPosition.WR)
            {
                if (positionCount == 0)
                {
                    return Color.FromArgb(177, 34, 12);
                }
                if (positionCount == 1)
                {
                    return Color.Orange;
                }
                if (positionCount == 2)
                {
                    return Color.Yellow;
                }
                else
                {
                    return Color.Green;
                }
            }

            else
            {
                if (positionCount == 0)
                {
                    return Color.FromArgb(177, 34, 12);
                }
                if (positionCount == 1)
                {
                    return Color.Yellow;
                }
                else
                {
                    return Color.Green;
                }
            }
        }

        private void frmDetailedLeagueOverview_Shown(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //SetPanelsToFantasyTeams();
        }
    }
}
