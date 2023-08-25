using static FantasyFootballAuctionDraftAssistant.Player;

namespace FantasyFootballAuctionDraftAssistant
{
    public partial class Form1 : Form
    {
        List<Player> playerList;
        List<Player> FreeAgents;
        FantasyTeam DisplayedTeam = new FantasyTeam();

        Player playerOnClock = new Player();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playerList = SQLiteDataAccess.LoadPlayers();

            FreeAgents = playerList.Where(player => !player.Drafted).ToList();
            cbAllPositions.Checked = true;


            SetupListViewColumns();
            UpdateListView();
        }
        private void AddPlayerToMyTeam()
        {
            DisplayedTeam.AddPlayer(playerOnClock, int.Parse(txtCost.Text));
            FreeAgents = playerList.Where(player => !player.Drafted).ToList();
        }
        private void SetupListViewColumns()
        {
            lvUndraftedPlayers.View = View.Details; // Ensure the view is set to details
            lvUndraftedPlayers.Columns.Add("Name", 125, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Value", 50, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Position", 65, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Team", 120, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Bye", 50, HorizontalAlignment.Left);
            lvTeamRoster.View = View.Details; // Ensure the view is set to details
            lvTeamRoster.Columns.Add("Name", 125, HorizontalAlignment.Left);
            lvTeamRoster.Columns.Add("Value", 50, HorizontalAlignment.Left);
            lvTeamRoster.Columns.Add("Position", 65, HorizontalAlignment.Left);
            lvTeamRoster.Columns.Add("Team", 120, HorizontalAlignment.Left);
            lvTeamRoster.Columns.Add("Bye", 50, HorizontalAlignment.Left);
        }
        private void UpdateListView()
        {
            lvUndraftedPlayers.Items.Clear(); // Clear existing items first
            lvTeamRoster.Items.Clear();
            IEnumerable<Player> filteredPlayers = FreeAgents.Where(player => IsPositionChecked(player.Position));

            foreach (Player player in filteredPlayers)
            {
                ListViewItem lvi = new ListViewItem(player.Name); // First column
                lvi.SubItems.Add(player.EstimatedValue.ToString()); // Second column
                lvi.SubItems.Add(player.Position.ToString());
                lvi.SubItems.Add(player.NflTeam);
                lvi.SubItems.Add(player.ByeWeek.ToString());

                lvUndraftedPlayers.Items.Add(lvi);
            }
            
        }
        private void SetPlayerOnClockUI()
        {
            lblPlayerOnClock.Text = playerOnClock.Name;
            lblPlayerOnClockValue.Text = playerOnClock.EstimatedValue.ToString();
        }
        private void UpdateDisplayTeam()
        {
            foreach (Player player in DisplayedTeam.Players)
            {
                ListViewItem lvi = new ListViewItem(player.Name); // First column
                lvi.SubItems.Add(player.EstimatedValue.ToString()); // Second column
                lvi.SubItems.Add(player.Position.ToString());
                lvi.SubItems.Add(player.NflTeam);
                lvi.SubItems.Add(player.ByeWeek.ToString());

                lvTeamRoster.Items.Add(lvi);
            }
            lblDisplayTeamBudget.Text = DisplayedTeam.Budget.ToString();
            lblQBs.Text = DisplayedTeam.CountPosition(Player.PlayerPosition.QB).ToString();
        }

        private void lvUndraftedPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUndraftedPlayers.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvUndraftedPlayers.SelectedItems[0]; // Get the first selected item

                // Assuming the player's name uniquely identifies them:
                string selectedPlayerName = selectedItem.Text;
                playerOnClock = playerList.FirstOrDefault(p => p.Name == selectedPlayerName);
                SetPlayerOnClockUI();
            }
        }
        private bool IsPositionChecked(PlayerPosition position)
        {
            switch (position)
            {
                case PlayerPosition.QB:
                    return cbQB.Checked;
                case PlayerPosition.RB:
                    return cbRB.Checked;
                case PlayerPosition.WR:
                    return cbWR.Checked;
                case PlayerPosition.TE:
                    return cbTE.Checked;
                case PlayerPosition.DEF:
                    return cbDEF.Checked;
                case PlayerPosition.K:
                    return cbK.Checked;
                default:
                    return false;
            }
        }
        private void cbAllPositions_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllPositions.Checked)
            {
                cbDEF.Checked = true;
                cbK.Checked = true;
                cbQB.Checked = true;
                cbRB.Checked = true;
                cbTE.Checked = true;
                cbWR.Checked = true;
                UpdateListView();
            }
            if (!cbAllPositions.Checked)
            {
                cbDEF.Checked = false;
                cbK.Checked = false;
                cbQB.Checked = false;
                cbRB.Checked = false;
                cbTE.Checked = false;
                cbWR.Checked = false;
            }

        }

        private void cbQB_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbQB.Checked) { UpdateListView(); }
            UpdateListView();

        }

        private void cbRB_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbRB.Checked) { UpdateListView(); }
            UpdateListView();
        }

        private void cbWR_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbWR.Checked) { UpdateListView(); }
            UpdateListView();
        }

        private void cbTE_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbTE.Checked) { UpdateListView(); }
            UpdateListView();
        }

        private void cbDEF_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbDEF.Checked) { UpdateListView(); }
            UpdateListView();
        }

        private void cbK_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbK.Checked) { UpdateListView(); }
            UpdateListView();
        }

        private void btnWeDraftOnClock_Click(object sender, EventArgs e)
        {
            AddPlayerToMyTeam();
            UpdateListView();
            UpdateDisplayTeam();
        }

        private void btnOtherDraftsOnClock_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelOnClock_Click(object sender, EventArgs e)
        {

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