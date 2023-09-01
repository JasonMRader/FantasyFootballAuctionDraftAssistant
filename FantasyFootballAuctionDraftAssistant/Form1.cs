using System.Diagnostics;
using static FantasyFootballAuctionDraftAssistant.Player;

namespace FantasyFootballAuctionDraftAssistant
{
    public partial class Form1 : Form
    {

        DraftManager Draft = new DraftManager();
        bool isProgrammaticUpdate = false;
        private bool isDragging = false;
        private Point lastLocation;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void Form1_MouseUo(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }


        public Form1()
        {
            InitializeComponent();

        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            await webView.EnsureCoreWebView2Async();

            cbAllPositions.Checked = true;

            Draft.StartDraft();

            Draft.DisplayTeam = Draft.AllFantasyTeams.FirstOrDefault(team => team.Name == "Disappointing Monday");
            SetDraftButtonsToFantasyTeams();
            SetRadioButtonsToFantasyTeams();

            SetupTeamRosterListViewColumns();
            UpdateListView();
            UpdateDisplayTeam();
        }
        private void SetRadioButtonsToFantasyTeams()
        {
            int radioButtonIndex = 0;


            foreach (Control control in pnlTeamsToView.Controls)
            {
                if (control is RadioButton && radioButtonIndex < Draft.AllFantasyTeams.Count)
                {
                    control.Text = Draft.AllFantasyTeams[radioButtonIndex].Name;
                    control.Tag = Draft.AllFantasyTeams[radioButtonIndex];

                    if (control.Text == "Disappointing Monday")
                    {
                        control.BackColor = Color.LightGreen;
                    }

                    control.Click += RadioButton_Click;
                    CreateSalaryCapLabels(control as RadioButton);
                    radioButtonIndex++;
                }

            }

        }
        private string GetNumberOfSpaces(FantasyTeam team)
        {
            int budgetDigits = team.Budget.ToString().Length;
            int spacesToAdd;
            switch (budgetDigits)
            {
                case 1: spacesToAdd = 6; break;
                case 2: spacesToAdd = 5; break;
                case 3: spacesToAdd = 3; break;
                default: spacesToAdd = 0; break; // Or whatever default you want for other cases
            }

            string spaces = new string(' ', spacesToAdd);
            return spaces;
        }
        private void CreateSalaryCapLabels(RadioButton radioButton)
        {
            FantasyTeam team = radioButton.Tag as FantasyTeam;
            if (team == null) return;
            string spaces = GetNumberOfSpaces(team);
            Label salaryLabel = new Label();
            salaryLabel.AutoSize = true;
            salaryLabel.Size = new Size(40, 30);
            salaryLabel.Text = "$" + team.Budget.ToString() + spaces + team.Players.Count.ToString() + "/16";
            salaryLabel.Location = new Point(radioButton.Location.X + radioButton.Width + 15, radioButton.Location.Y + 3);
            salaryLabel.Tag = team;
            salaryLabel.Font = new Font("Arial Narrow", 14, FontStyle.Bold);
            salaryLabel.ForeColor = Color.LightGray;
            pnlTeamsToView.Controls.Add(salaryLabel);
        }
        private void UpdateSalaryCapLabels()
        {
            foreach (Control control in pnlTeamsToView.Controls)
            {
                if (control is Label && control.Tag is FantasyTeam)
                {
                    FantasyTeam team = control.Tag as FantasyTeam;
                    string spaces = GetNumberOfSpaces(team);
                    control.Text = "$" + team.Budget.ToString() + spaces + team.Players.Count.ToString() + "/16";
                }
            }
        }
        private void SetDraftButtonsToFantasyTeams()
        {
            var teamButtons = pnlOtherTeamsDraft.Controls.OfType<Button>().ToList();

            // Assuming Draft.AllFantasyTeams is ordered correctly, we'll first remove "Disappointing Monday"
            var orderedTeams = Draft.AllFantasyTeams.Where(team => team.Name != "Disappointing Monday").ToList();

            // Now loop through both the teamButtons and orderedTeams together using Zip
            foreach (var (btn, team) in teamButtons.Zip(orderedTeams, (b, t) => (b, t)))
            {
                btn.Text = team.Name;
                btn.Tag = team;
                btn.Click += DraftButton_Click; // This might add multiple click events if called multiple times. Ensure you only do this once.
            }
        }


        private void DraftButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button clickedButton && clickedButton.Tag is FantasyTeam selectedTeam)
            {
                if (Draft.PlayerOnTheClock == null)
                {
                    MessageBox.Show("No Player is Selected To Draft");
                    return;
                }
                using (frmInputCost inputCostForm = new frmInputCost(Draft.PlayerOnTheClock.Name))
                {
                    if (inputCostForm.ShowDialog() == DialogResult.OK)
                    {

                        //Draft.DisplayTeam = Draft.MyTeam;
                        Draft.RecordDraftPick(selectedTeam, inputCostForm.PlayerCost);
                        UpdateListView();
                        UpdateDisplayTeam();
                        UpdateSalaryCapLabels();

                        RemovePlayerOnClock();

                        //lblPlayerOnClock.Text = "Select A Player";
                        //lblPlayerOnClockValue.Text = "";

                    }
                }
            }

        }
        private void btnWeDraftOnClock_Click(object sender, EventArgs e)
        {
            if (Draft.PlayerOnTheClock == null)
            {
                MessageBox.Show("No Player is Selected To Draft");
                return;
            }
            using (frmInputCost inputCostForm = new frmInputCost(Draft.PlayerOnTheClock.Name))
            {
                if (inputCostForm.ShowDialog() == DialogResult.OK)
                {

                    Draft.DisplayTeam = Draft.MyTeam;
                    Draft.RecordDraftPick(Draft.MyTeam, inputCostForm.PlayerCost);
                    UpdateListView();
                    UpdateDisplayTeam();
                    UpdateSalaryCapLabels();

                    RemovePlayerOnClock();
                    //lblPlayerOnClock.Text = "Select A Player";
                    //lblPlayerOnClockValue.Text = "";

                }
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

                    Draft.DisplayTeam = selectedTeam;
                }
            }

            UpdateListView();
            UpdateDisplayTeam();

        }

        private void SetListViewToRosterMoves()
        {
            lvUndraftedPlayers.ListViewItemSorter = null;
            lvUndraftedPlayers.Items.Clear();
            lvUndraftedPlayers.Columns.Clear();
            lvUndraftedPlayers.View = View.Details;

            lvUndraftedPlayers.Columns.Add("Pick", 50, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Name", 125, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Team", 125, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Position", 65, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Cost", 50, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Value", 50, HorizontalAlignment.Left);
            lvUndraftedPlayers.ListViewItemSorter = lvDraftedPlayersSorter;

        }
        private void SetViewToKeepers()
        {
            SetListViewToRosterMoves();
            lvUndraftedPlayers.Items.Clear();



            foreach (Player player in Draft.Keepers)
            {
                ListViewItem lvi = new ListViewItem(player.DraftPickNumber.ToString());
                lvi.SubItems.Add(player.Name);
                lvi.SubItems.Add(player.FantasyTeam.Name);
                lvi.SubItems.Add(player.Position.ToString());
                lvi.SubItems.Add(player.Cost.ToString());
                lvi.SubItems.Add(player.ValueDifference.ToString());



                lvUndraftedPlayers.Items.Add(lvi);
            }
            SortByValue(lvUndraftedPlayersSorter, 2);

        }
        private void SetViewToDraftHistory()
        {
            SetListViewToRosterMoves();
            lvUndraftedPlayers.Items.Clear();



            foreach (Player player in Draft.DraftedPlayers)
            {
                ListViewItem lvi = new ListViewItem(player.DraftPickNumber.ToString());
                lvi.SubItems.Add(player.Name);
                lvi.SubItems.Add(player.FantasyTeam.Name);
                lvi.SubItems.Add(player.Position.ToString());
                lvi.SubItems.Add(player.Cost.ToString());
                lvi.SubItems.Add(player.ValueDifference.ToString());


                lvUndraftedPlayers.Items.Add(lvi);
            }
            SortByValue(lvDraftedPlayersSorter, 0);
        }
        private void SetListViewToFreeAgents()
        {
            lvUndraftedPlayers.Items.Clear();
            lvUndraftedPlayers.Columns.Clear();
            lvUndraftedPlayers.View = View.Details;
            lvUndraftedPlayers.Columns.Add("Name", 125, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Value", 50, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Position", 65, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Team", 120, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Bye", 50, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Exp", 50, HorizontalAlignment.Left);
            lvUndraftedPlayers.Columns.Add("Notes", 100, HorizontalAlignment.Left);
            lvUndraftedPlayers.ListViewItemSorter = null;
            lvUndraftedPlayers.ListViewItemSorter = lvUndraftedPlayersSorter;
            lvUndraftedPlayers.ColumnClick += LvUndraftedPlayers_ColumnClick;
        }
        private void SetupTeamRosterListViewColumns()
        {
            SetListViewToFreeAgents();
            lvTeamRoster.View = View.Details;
            lvTeamRoster.Columns.Add("Name", 125, HorizontalAlignment.Left);
            lvTeamRoster.Columns.Add("Cost", 50, HorizontalAlignment.Left);
            lvTeamRoster.Columns.Add("Position", 65, HorizontalAlignment.Left);
            lvTeamRoster.Columns.Add("Team", 50, HorizontalAlignment.Left);
            lvTeamRoster.Columns.Add("Bye", 50, HorizontalAlignment.Left);
            lvTeamRoster.Columns.Add("Surplus", 60, HorizontalAlignment.Left);
            lvTeamRoster.Columns.Add("Pick", 50, HorizontalAlignment.Left);
            //lvTeamRoster.Columns.Add("Pick", 50, HorizontalAlignment.Left); 


            lvTeamRoster.ListViewItemSorter = lvTeamRosterSorter;
            lvTeamRoster.ColumnClick += LvTeamRoster_ColumnClick;
        }
        private ListViewColumnSorter lvUndraftedPlayersSorter = new ListViewColumnSorter();
        private ListViewColumnSorter lvDraftedPlayersSorter = new ListViewColumnSorter();
        private ListViewColumnSorter lvKeepersPlayersSorter = new ListViewColumnSorter();
        private ListViewColumnSorter lvTeamRosterSorter = new ListViewColumnSorter();



        private void LvUndraftedPlayers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(e, lvUndraftedPlayers, lvUndraftedPlayersSorter);
        }

        private void LvTeamRoster_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(e, lvTeamRoster, lvTeamRosterSorter);
        }
        private void SortByValueDecending(ListViewColumnSorter sorter, int column)
        {
            sorter.Order = SortOrder.Descending;
            sorter.SortColumn = column;
        }
        private void SortByValue(ListViewColumnSorter sorter, int column)
        {
            sorter.Order = SortOrder.Ascending;
            sorter.SortColumn = column;
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
            SetListViewToFreeAgents();
            lvUndraftedPlayers.Items.Clear();
            lvTeamRoster.Items.Clear();
            IEnumerable<Player> filteredPlayers = Draft.FreeAgents.Where(player => IsPositionChecked(player.Position));

            foreach (Player player in filteredPlayers)
            {
                ListViewItem lvi = new ListViewItem(player.Name);
                lvi.SubItems.Add(player.EstimatedValue.ToString());
                lvi.SubItems.Add(player.Position.ToString());
                lvi.SubItems.Add(player.NflTeam);
                lvi.SubItems.Add(player.ByeWeek.ToString());

                if (player.Year == 1)
                {
                    lvi.SubItems.Add("Rookie");
                }
                else
                {
                    lvi.SubItems.Add("");
                }
                lvi.SubItems.Add(player.Notes);

                lvUndraftedPlayers.Items.Add(lvi);
            }

            SortByValueDecending(lvUndraftedPlayersSorter, 1);
        }
        private void SetPlayerOnClockUI()
        {
            pnlPlayerOnClockDisplay.Visible = true;
            foreach (Control c in pnlOtherTeamsDraft.Controls)
            {
                c.Enabled = true;
                btnWeDraftOnClock.Enabled = true;
            }
            lblPlayerOnClock.Text = Draft.PlayerOnTheClock.Name.ToString();
            lblPlayerOnClockValue.Text = Draft.PlayerOnTheClock.EstimatedValue.ToString();
            txtPlayerNotes.Text = Draft.PlayerOnTheClock.Notes;
        }
        private void RemovePlayerOnClock()
        {
            pnlPlayerOnClockDisplay.Visible = false;

            foreach (Control c in pnlOtherTeamsDraft.Controls)
            {
                btnWeDraftOnClock.Enabled = false;
                c.Enabled = false;
            }
        }
        private void UpdateDisplayTeam()
        {
            Draft.SelectedPlayerOnRoster = null;

            foreach (Player player in Draft.DisplayTeam.Players)
            {
                ListViewItem lvi = new ListViewItem(player.Name);
                lvi.SubItems.Add(player.Cost.ToString());
                lvi.SubItems.Add(player.Position.ToString());
                lvi.SubItems.Add(player.NflTeam);
                lvi.SubItems.Add(player.ByeWeek.ToString());
                lvi.SubItems.Add(player.ValueDifference.ToString());
                if (player.Keeper == true)
                {
                    lvi.SubItems.Add("Keeper");
                }
                lvi.SubItems.Add(player.DraftPickNumber.ToString());
                lvTeamRoster.Items.Add(lvi);
            }
            lblDisplayTeamName.Text = Draft.DisplayTeam.Name;
            lblDisplayTeamBudget.Text = Draft.DisplayTeam.Budget.ToString();
            lblQBs.Text = Draft.DisplayTeam.CountPosition(Player.PlayerPosition.QB).ToString();
            lblRBs.Text = Draft.DisplayTeam.CountPosition(Player.PlayerPosition.RB).ToString();
            lblWRs.Text = Draft.DisplayTeam.CountPosition(Player.PlayerPosition.WR).ToString();
            lblTEs.Text = Draft.DisplayTeam.CountPosition(Player.PlayerPosition.TE).ToString();
            lblDEFs.Text = Draft.DisplayTeam.CountPosition(Player.PlayerPosition.DEF).ToString();
            lblKs.Text = Draft.DisplayTeam.CountPosition(Player.PlayerPosition.K).ToString();
            lblRosterSpots.Text = Draft.DisplayTeam.RosterSpots.ToString();
            lblRosterValueDifference.Text = Draft.DisplayTeam.TeamValueDifference().ToString();

            if (Draft.DisplayTeam.RosterSpots > 0)
            {
                lblAvgCapPerSpotLeft.Text = (Draft.DisplayTeam.Budget / Draft.DisplayTeam.RosterSpots).ToString();
            }

            lblMaxBid.Text = (Draft.DisplayTeam.Budget - Draft.DisplayTeam.RosterSpots).ToString();
            if (Draft.DisplayTeam.Keeper != null)
            {
                lblDisplayKeeper.Text = Draft.DisplayTeam.Keeper.Name;
            }
            else
            {
                lblDisplayKeeper.Text = "None";
            }

        }

        private void lvUndraftedPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvUndraftedPlayers.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvUndraftedPlayers.SelectedItems[0];


                string selectedPlayerName = selectedItem.Text;
                if (!cbDraftHistory.Checked)
                {
                    Draft.PlayerOnTheClock = Draft.AllPlayers.FirstOrDefault(p => p.Name == selectedPlayerName);
                    SetPlayerOnClockUI();

                }


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
            isProgrammaticUpdate = true;
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
            isProgrammaticUpdate = false;
        }

        private void cbQB_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticUpdate) { return; }
            FirstClickOnPositionFilters(cbQB);
            UpdateListView();

        }

        private void cbRB_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticUpdate) { return; }
            FirstClickOnPositionFilters(cbRB);
            UpdateListView();
        }

        private void cbWR_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticUpdate) { return; }
            FirstClickOnPositionFilters(cbWR);
            UpdateListView();
        }

        private void cbTE_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticUpdate) { return; }
            FirstClickOnPositionFilters(cbTE);
            UpdateListView();
        }

        private void cbDEF_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticUpdate) { return; }
            FirstClickOnPositionFilters(cbDEF);
            UpdateListView();
        }

        private void cbK_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticUpdate) { return; }
            FirstClickOnPositionFilters(cbK);
            UpdateListView();
        }



        private void btnOtherDraftsOnClock_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelOnClock_Click(object sender, EventArgs e)
        {
            RemovePlayerOnClock();
            Draft.PlayerOnTheClock = null;

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

            cbDraftHistory.Visible = false;
            cbKeepers.Visible = false;
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
            string playerName = Draft.PlayerOnTheClock.Name;
            string escapedPlayerName = Uri.EscapeDataString(playerName);



            //string query = $"NFL {playerName} {lastYear} season stats";
            //string url = "https://www.google.com/search?q=" + Uri.EscapeDataString(query);
            string url = $"https://football.fantasysports.yahoo.com/f1/58184/playersearch?&search={escapedPlayerName}";
            return url;
        }
        private string GetFantasyProsURL()  // Consider renaming this method since it doesn't return a Yahoo URL anymore
        {
            string playerName = Draft.PlayerOnTheClock.Name;
            string escapedPlayerName = Uri.EscapeDataString(playerName);

            string url = $"https://www.fantasypros.com/nfl/players/{escapedPlayerName.ToLower().Replace(" ", "-")}.php";
            return url;
        }
        private string GetFantasyDataSearchURL()
        {
            string playerName = Draft.PlayerOnTheClock.Name;
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
            cbKeepers.Visible = true;
            cbDraftHistory.Visible = true;

            btnCloseBrowser.Visible = false;
        }

        private void btnOpenSettings_Click(object sender, EventArgs e)
        {
            Form form = new frmSettings();
            form.ShowDialog();
        }

        private void btnRemovePlayerFromTeam_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = lvTeamRoster.SelectedItems[0];


            string selectedPlayerName = selectedItem.Text;
            Draft.SelectedPlayerOnRoster = Draft.DisplayTeam.Players.FirstOrDefault(p => p.Name == selectedPlayerName);

            if (Draft.SelectedPlayerOnRoster != null)
            {
                Draft.UndraftPlayer();

                UpdateListView();
                UpdateDisplayTeam();
                UpdateSalaryCapLabels();
            }
            else
            {
                MessageBox.Show("No player is selected");
            }

        }

        private void lvTeamRoster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTeamRoster.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvTeamRoster.SelectedItems[0];


                string selectedPlayerName = selectedItem.Text;
                Draft.SelectedPlayerOnRoster = Draft.DisplayTeam.Players.FirstOrDefault(p => p.Name == selectedPlayerName);

                if (Draft.SelectedPlayerOnRoster != null)
                {
                    btnRemovePlayerFromTeam.Enabled = true;
                    btnSetKeeper.Enabled = false;
                }
                else
                {
                    btnRemovePlayerFromTeam.Enabled = false;
                    btnSetKeeper.Enabled = true;
                }

            }
            else
            {
                btnSetKeeper.Enabled = false;
                btnRemovePlayerFromTeam.Enabled = false;
            }
        }

        private void btnSetKeeper_Click(object sender, EventArgs e)
        {
            Draft.DisplayTeam.SetKeeper(Draft.SelectedPlayerOnRoster);
            SQLiteDataAccess.UpdatePlayer(Draft.SelectedPlayerOnRoster);

            UpdateDisplayTeam();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Player> results = new List<Player>();
            string query = txtSearch.Text.ToLower();
            if (!cbKeepers.Checked && !cbDraftHistory.Checked)
            {
                results = Draft.FreeAgents.Where(p => p.Name.ToLower().Contains(query)).ToList();

                SetListViewToFreeAgents();
                lvUndraftedPlayers.Items.Clear();
                foreach (Player player in results)
                {
                    ListViewItem lvi = new ListViewItem(player.Name);
                    lvi.SubItems.Add(player.EstimatedValue.ToString());
                    lvi.SubItems.Add(player.Position.ToString());
                    lvi.SubItems.Add(player.NflTeam);
                    lvi.SubItems.Add(player.ByeWeek.ToString());

                    if (player.Year == 1)
                    {
                        lvi.SubItems.Add("Rookie");
                    }
                    else
                    {
                        lvi.SubItems.Add("");
                    }
                    lvi.SubItems.Add(player.Notes);

                    lvUndraftedPlayers.Items.Add(lvi);
                }
            }
            if (cbDraftHistory.Checked)
            {
                results = Draft.DraftedPlayers.Where(p => p.Name.ToLower().Contains(query)).ToList();
                SetListViewToRosterMoves();
                lvUndraftedPlayers.Items.Clear();
                foreach (Player player in results)
                {
                    ListViewItem lvi = new ListViewItem(player.DraftPickNumber.ToString());
                    lvi.SubItems.Add(player.Name);
                    lvi.SubItems.Add(player.FantasyTeam.Name);
                    lvi.SubItems.Add(player.Position.ToString());
                    lvi.SubItems.Add(player.Cost.ToString());
                    lvi.SubItems.Add(player.ValueDifference.ToString());


                    lvUndraftedPlayers.Items.Add(lvi);
                }
                SortByValueDecending(lvUndraftedPlayersSorter, 0);
            }
            if (cbKeepers.Checked)
            {
                results = Draft.Keepers.Where(p => p.Name.ToLower().Contains(query)).ToList();
                SetListViewToRosterMoves();
                lvUndraftedPlayers.Items.Clear();
                foreach (Player player in results)
                {
                    ListViewItem lvi = new ListViewItem(player.DraftPickNumber.ToString());
                    lvi.SubItems.Add(player.Name);
                    lvi.SubItems.Add(player.FantasyTeam.Name);
                    lvi.SubItems.Add(player.Position.ToString());
                    lvi.SubItems.Add(player.Cost.ToString());
                    lvi.SubItems.Add(player.ValueDifference.ToString());


                    lvUndraftedPlayers.Items.Add(lvi);
                }
                SortByValueDecending(lvUndraftedPlayersSorter, 1);
            }





        }

        private void cbDraftHistory_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDraftHistory.Checked == true)
            {
                SetViewToDraftHistory();
                cbKeepers.Checked = false;
            }
            else
            {
                UpdateListView();
            }
        }

        private void cbKeepers_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKeepers.Checked)
            {
                SetViewToKeepers();
                cbDraftHistory.Checked = false;
            }
            else { UpdateListView(); }
        }

        private void lvUndraftedPlayers_DoubleClick(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webView.Visible = true;
            webView.Enabled = true;
            webView.BringToFront();
            btnSearch.Visible = false;
            txtSearch.Visible = false;

            cbDraftHistory.Visible = false;
            cbKeepers.Visible = false;
            btnCloseBrowser.Visible = true;
            btnCloseBrowser.Enabled = true;


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

        private void lblPlayerOnClock_Click(object sender, EventArgs e)
        {
            webView.Visible = true;
            webView.Enabled = true;
            webView.BringToFront();
            btnSearch.Visible = false;
            txtSearch.Visible = false;

            cbDraftHistory.Visible = false;
            cbKeepers.Visible = false;
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

        private void btnSaveNotes_Click(object sender, EventArgs e)
        {
            Draft.PlayerOnTheClock.Notes = txtPlayerNotes.Text;
            SQLiteDataAccess.UpdatePlayer(Draft.PlayerOnTheClock);
        }
        private void FirstClickOnPositionFilters(CheckBox thisCheckBox)
        {
            if (cbAllPositions.Checked)
            {
                cbAllPositions.Checked = false;
                thisCheckBox.Checked = true;

            }
            else { return; }
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}