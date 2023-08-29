using System.Diagnostics;
using static FantasyFootballAuctionDraftAssistant.Player;

namespace FantasyFootballAuctionDraftAssistant
{
    public partial class Form1 : Form
    {
        List<Player> playerList;
        List<Player> FreeAgents;
        List<FantasyTeam> FantasyTeamList;
        FantasyTeam DisplayedTeam = new FantasyTeam();
        Player SelectedPlayerOnRoster = new Player();
        Player playerOnClock = new Player();
        public Form1()
        {
            InitializeComponent();

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            playerList = SQLiteDataAccess.LoadPlayers();
            FantasyTeamList = SQLiteDataAccess.LoadFantasyTeams();
            await webView.EnsureCoreWebView2Async();
            FreeAgents = playerList.Where(player => !player.Drafted).ToList();
            cbAllPositions.Checked = true;
            SetDraftButtonsToFantasyTeams();
            SetRadioButtonsToFantasyTeams();

            SetupListViewColumns();
            UpdateListView();
        }
        private void SetRadioButtonsToFantasyTeams()
        {
            int radioButtonIndex = 0;
            //int labelIndex = 0;

            foreach (Control control in pnlTeamsToView.Controls)
            {
                if (control is RadioButton && radioButtonIndex < FantasyTeamList.Count)
                {
                    control.Text = FantasyTeamList[radioButtonIndex].Name;
                    control.Tag = FantasyTeamList[radioButtonIndex]; // Store the FantasyTeam object in the Tag for later retrieval

                    if (control.Text == "Disappointing Monday")
                    {
                        control.BackColor = Color.LightGreen;
                    }

                    control.Click += RadioButton_Click; // Register common click event
                    CreateSalaryCapLabels(control as RadioButton);
                    radioButtonIndex++;
                }
                //else if (control is Label && labelIndex < FantasyTeamList.Count)
                //{
                //    control.Text = "$" + FantasyTeamList[labelIndex].Budget.ToString();
                //    labelIndex++;
                //}
            }

        }
        private void CreateSalaryCapLabels(RadioButton radioButton)
        {
            FantasyTeam team = radioButton.Tag as FantasyTeam;
            if (team == null) return;

            Label salaryLabel = new Label();
            salaryLabel.AutoSize = false;
            salaryLabel.Size = new Size(40, 30);
            salaryLabel.Text = "$" + team.Budget.ToString() + "\n" + team.Players.Count.ToString() + "/16";
            salaryLabel.Location = new Point(radioButton.Location.X + radioButton.Width + 10, radioButton.Location.Y);
            salaryLabel.Tag = team;
            pnlTeamsToView.Controls.Add(salaryLabel);
        }
        private void UpdateSalaryCapLabels()
        {
            foreach (Control control in pnlTeamsToView.Controls)
            {
                if (control is Label && control.Tag is FantasyTeam)
                {
                    FantasyTeam team = control.Tag as FantasyTeam;
                    control.Text = "$" + team.Budget.ToString() + "\n" + team.Players.Count.ToString() + "/16";
                }
            }
        }

        //private void SetRadioButtonsToFantasyTeams()
        //{
        //    int index = 0;
        //    foreach (Control control in pnlTeamsToView.Controls)
        //    {
        //        if (control is RadioButton && index < FantasyTeamList.Count)
        //        {
        //            control.Text = FantasyTeamList[index].Name;
        //            control.Tag = FantasyTeamList[index]; // Store the FantasyTeam object in the Tag for later retrieval
        //            if (control.Text == "Disappointing Monday")
        //            {
        //                control.BackColor = Color.LightGreen;
        //            }
        //            control.Click += RadioButton_Click; // Register common click event
        //            index++;
        //        }
        //    }
        //}
        //private void SetTeamBudgetLabels()
        //{
        //    foreach (Control control in pnlTeamsToView.Controls)
        //    {
        //        if (control is Label && control.Tag is FantasyTeam)
        //        {
        //            FantasyTeam team = (FantasyTeam)control.Tag;
        //            control.Text = "$" + team.Budget.ToString();
        //        }
        //    }
        //}
        private void SetDraftButtonsToFantasyTeams()
        {

            int index = 0;
            foreach (Control control in pnlOtherTeamsDraft.Controls)
            {
                if (control is Button)
                {
                    // Skip the loop iteration if we've processed all the teams or if the current team is "Disappointing Monday"
                    while (index < FantasyTeamList.Count && FantasyTeamList[index].Name == "Disappointing Monday")
                    {
                        index++;
                    }

                    // Check again if we've reached the end of the otherTeams list
                    if (index >= FantasyTeamList.Count)
                    {
                        break; // Exit the loop if we've processed all the teams
                    }

                    control.Text = FantasyTeamList[index].Name;
                    control.Tag = FantasyTeamList[index]; // Store the FantasyTeam object in the Tag for later retrieval

                    control.Click += DraftButton_Click; // Register common click event 
                    index++;
                }
            }
        }

        private void DraftButton_Click(object? sender, EventArgs e)
        {
            if (IsValidNumber(txtCost.Text))
            {
                if (sender is Button clickedButton && clickedButton.Tag is FantasyTeam selectedTeam)
                {
                    // Assuming playerOnClock and txtCost.Text have been declared and initialized in this scope
                    AddPlayerToTeam(selectedTeam);
                }
                UpdateListView();
                UpdateDisplayTeam();
                UpdateSalaryCapLabels();
                lblPlayerOnClock.Text = "Select A Player";
                lblPlayerOnClockValue.Text = "";
                txtCost.Clear();
            }
            else
            {
                MessageBox.Show("Please enter player cost to draft");
            }
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            RadioButton clickedRadioButton = sender as RadioButton;
            if (clickedRadioButton != null && clickedRadioButton.Checked)
            {
                FantasyTeam selectedTeam = clickedRadioButton.Tag as FantasyTeam;
                if (selectedTeam != null)
                {
                    // Assuming DisplayedTeam is a property where you want to store the selected team
                    DisplayedTeam = selectedTeam;
                }
            }
            //UpdateDisplayTeam();
            UpdateListView();
            UpdateDisplayTeam();
            lblPlayerOnClock.Text = "Select A Player";
            lblPlayerOnClockValue.Text = "";
            txtCost.Clear();
        }
        private void AddPlayerToTeam(FantasyTeam Team)
        {
            if (IsValidNumber(txtCost.Text))
            {
                Team.AddPlayer(playerOnClock, int.Parse(txtCost.Text));
                FreeAgents = playerList.Where(player => !player.Drafted).ToList();
                SQLiteDataAccess.UpdatePlayer(playerOnClock);
            }
            else
            {
                MessageBox.Show("Please enter player cost to draft");
            }

        }
        private void RemovePlayerFromTeam(Player player)
        {

        }
        private void SetupListViewColumns()
        {
            lvUndraftedPlayers.View = View.Details; // Ensure the view is set to details
            lvUndraftedPlayers.Columns.Add("Name", 125, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Value", 50, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Position", 65, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Team", 120, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Bye", 50, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Exp", 50, HorizontalAlignment.Left);
            lvTeamRoster.View = View.Details; // Ensure the view is set to details
            lvTeamRoster.Columns.Add("Name", 125, HorizontalAlignment.Left);
            lvTeamRoster.Columns.Add("Cost", 50, HorizontalAlignment.Left);
            lvTeamRoster.Columns.Add("Position", 65, HorizontalAlignment.Left);
            lvTeamRoster.Columns.Add("Team", 50, HorizontalAlignment.Left);
            lvTeamRoster.Columns.Add("Bye", 50, HorizontalAlignment.Left);
            lvTeamRoster.Columns.Add("Surplus", 50, HorizontalAlignment.Left);
            lvUndraftedPlayers.ListViewItemSorter = lvUndraftedPlayersSorter;
            lvUndraftedPlayers.ColumnClick += LvUndraftedPlayers_ColumnClick;

            lvTeamRoster.ListViewItemSorter = lvTeamRosterSorter;
            lvTeamRoster.ColumnClick += LvTeamRoster_ColumnClick;
        }
        private ListViewColumnSorter lvUndraftedPlayersSorter = new ListViewColumnSorter();
        private ListViewColumnSorter lvTeamRosterSorter = new ListViewColumnSorter();



        private void LvUndraftedPlayers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(e, lvUndraftedPlayers, lvUndraftedPlayersSorter);
        }

        private void LvTeamRoster_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(e, lvTeamRoster, lvTeamRosterSorter);
        }
        private void SortByValueDecending(ListView listView, ListViewColumnSorter sorter)
        {
            sorter.Order = SortOrder.Descending;
            sorter.SortColumn = 1;
        }
        private void SortListView(ColumnClickEventArgs e, ListView listView, ListViewColumnSorter sorter)
        {
            if (e.Column == sorter.SortColumn)
            {
                if (sorter.Order == SortOrder.Ascending)
                {
                    sorter.Order = SortOrder.Descending;
                }
                else
                {
                    sorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                sorter.SortColumn = e.Column;
                sorter.Order = SortOrder.Ascending;
            }

            listView.Sort();
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
                if (player.Year == 1)
                {
                    lvi.SubItems.Add("Rookie");
                }


                lvUndraftedPlayers.Items.Add(lvi);
            }
            SortByValueDecending(lvUndraftedPlayers, lvUndraftedPlayersSorter);
        }
        private void SetPlayerOnClockUI()
        {
            lblPlayerOnClock.Text = playerOnClock.Name;
            lblPlayerOnClockValue.Text = playerOnClock.EstimatedValue.ToString();
        }
        private void UpdateDisplayTeam()
        {
            SelectedPlayerOnRoster = null;
            //lvTeamRoster.Clear();
            foreach (Player player in DisplayedTeam.Players)
            {
                ListViewItem lvi = new ListViewItem(player.Name); // First column
                lvi.SubItems.Add(player.Cost.ToString()); // Second column
                lvi.SubItems.Add(player.Position.ToString());
                lvi.SubItems.Add(player.NflTeam);
                lvi.SubItems.Add(player.ByeWeek.ToString());
                lvi.SubItems.Add(player.ValueDifference.ToString());
                lvTeamRoster.Items.Add(lvi);
            }
            lblDisplayTeamName.Text = DisplayedTeam.Name;
            lblDisplayTeamBudget.Text = DisplayedTeam.Budget.ToString();
            lblQBs.Text = DisplayedTeam.CountPosition(Player.PlayerPosition.QB).ToString();
            lblRBs.Text = DisplayedTeam.CountPosition(Player.PlayerPosition.RB).ToString();
            lblWRs.Text = DisplayedTeam.CountPosition(Player.PlayerPosition.WR).ToString();
            lblTEs.Text = DisplayedTeam.CountPosition(Player.PlayerPosition.TE).ToString();
            lblDEFs.Text = DisplayedTeam.CountPosition(Player.PlayerPosition.DEF).ToString();
            lblKs.Text = DisplayedTeam.CountPosition(Player.PlayerPosition.K).ToString();
            lblRosterSpots.Text = DisplayedTeam.RosterSpots.ToString();
            lblRosterValueDifference.Text = DisplayedTeam.TeamValueDifference().ToString();
            if (DisplayedTeam.RosterSpots > 0)
            {
                lblAvgCapPerSpotLeft.Text = (DisplayedTeam.Budget / DisplayedTeam.RosterSpots).ToString();
            }

            lblMaxBid.Text = (DisplayedTeam.Budget - DisplayedTeam.RosterSpots).ToString();
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

            if (IsValidNumber(txtCost.Text))
            {

                DisplayedTeam = FantasyTeamList.FirstOrDefault(team => team.Name == "Disappointing Monday");
                AddPlayerToTeam(DisplayedTeam);
                UpdateListView();
                UpdateDisplayTeam();
                UpdateSalaryCapLabels();

                lblPlayerOnClock.Text = "Select A Player";
                lblPlayerOnClockValue.Text = "";
                txtCost.Clear();
            }
            else
            {
                MessageBox.Show("Please enter player cost to draft");
            }
        }

        private void btnOtherDraftsOnClock_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelOnClock_Click(object sender, EventArgs e)
        {
            lblPlayerOnClock.Text = "Select A Player";
            lblPlayerOnClockValue.Text = "";
            txtCost.Clear();
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

        private void btnOpenOnlineInfo_Click(object sender, EventArgs e)
        {
            webView.Visible = true;
            webView.Enabled = true;
            webView.BringToFront();
            btnSearch.Visible = false;
            txtSearch.Visible = false;
            btnDraftHistory.Visible = false;
            btnCloseBrowser.Visible = true;
            btnCloseBrowser.Enabled = true;

            //string url = GetYahooURL();
            //string url = GetFantasyProsURL();
            string url = GetFantasyDataSearchURL();
            if (webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(url);
            }
            else
            {
                MessageBox.Show("WebView2 is not ready. Please try again later.");
            }
            //webView.CoreWebView2.Navigate(url);
            //OpenUrl(url);
        }
        private string GetYahooURL()
        {
            string playerName = playerOnClock.Name;
            string escapedPlayerName = Uri.EscapeDataString(playerName);


            // Construct the Google search query. Adjust as needed.
            //string query = $"NFL {playerName} {lastYear} season stats";
            //string url = "https://www.google.com/search?q=" + Uri.EscapeDataString(query);
            string url = $"https://football.fantasysports.yahoo.com/f1/58184/playersearch?&search={escapedPlayerName}";
            return url;
        }
        private string GetFantasyProsURL()  // Consider renaming this method since it doesn't return a Yahoo URL anymore
        {
            string playerName = playerOnClock.Name;
            string escapedPlayerName = Uri.EscapeDataString(playerName);

            string url = $"https://www.fantasypros.com/nfl/players/{escapedPlayerName.ToLower().Replace(" ", "-")}.php";
            return url;
        }
        private string GetFantasyDataSearchURL()
        {
            string playerName = playerOnClock.Name;
            string query = $"site:fantasydata.com {playerName}";
            string url = "https://www.google.com/search?q=" + Uri.EscapeDataString(query);
            return url;
        }
        private void OpenUrl(string url)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Handle exception if needed
                Console.WriteLine(ex.Message);
            }
        }

        private void btnCloseBrowser_Click(object sender, EventArgs e)
        {
            webView.Visible = false;
            webView.Enabled = false;
            btnSearch.Visible = true;
            txtSearch.Visible = true;
            btnDraftHistory.Visible = true;
            btnCloseBrowser.Visible = false;
        }

        private void btnOpenSettings_Click(object sender, EventArgs e)
        {
            Form form = new frmSettings();
            form.ShowDialog();
        }

        private void btnRemovePlayerFromTeam_Click(object sender, EventArgs e)
        {
            DisplayedTeam.RemovePlayer(SelectedPlayerOnRoster);
            FreeAgents.Add(SelectedPlayerOnRoster);
            SQLiteDataAccess.UpdatePlayer(SelectedPlayerOnRoster);
            UpdateListView();
            UpdateDisplayTeam();
        }

        private void lvTeamRoster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTeamRoster.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvTeamRoster.SelectedItems[0]; // Get the first selected item


                string selectedPlayerName = selectedItem.Text;
                SelectedPlayerOnRoster = playerList.FirstOrDefault(p => p.Name == selectedPlayerName);
                SetPlayerOnClockUI();
            }
        }
    }
}