using OfficeOpenXml;
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
    public partial class frmSettings : Form
    {
        List<Player> AllPlayerList = new List<Player>();
        List<FantasyTeam> teamList = new List<FantasyTeam>();
        FantasyTeam teamSelected;
        public frmSettings()
        {
            InitializeComponent();
            this.TopMost = true;
        }
        List<Player> playersToAdd = new List<Player>();
        //private void btnLoadExcelData_Click(object sender, EventArgs e)
        //{
        //    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

        //    var fileInfo = new FileInfo(@"path_to_your_excel_file.xlsx");
        //    using (var package = new ExcelPackage(fileInfo))
        //    {
        //        ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Assuming data is in the first sheet
        //        int rowCount = worksheet.Dimension.Rows;

        //        for (int row = 1; row <= rowCount; row++)
        //        {
        //            Player player = new Player();
        //            string playerName = worksheet.Cells[row, 1].Text; // A
        //            string position = worksheet.Cells[row, 2].Text; // B
        //            int value = int.Parse(worksheet.Cells[row, 3].Text); // C

        //            player.Name = playerName;
        //            player.PositionString = position;
        //            player.EstimatedValue = value;
        //            playersToAdd.Add(player);

        //        }
        //    }
        //}
        private void btnLoadExcelData_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"; // Filtering only Excel files

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                LoadExcelData(selectedFilePath);
            }
        }

        private void LoadExcelData(string filePath)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            var fileInfo = new FileInfo(filePath);
            using (var package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Assuming data is in the first sheet
                int rowCount = worksheet.Dimension.Rows;
                //Value, name, pos, Team, bye, year 
                for (int row = 1; row <= rowCount; row++)
                {
                    Player player = new Player();
                    if (cbName.Checked)
                    {
                        string playerName = worksheet.Cells[row, Convert.ToInt32(nudName.Value)].Text;
                        player.Name = playerName;
                    }
                    if (cbPosition.Checked)
                    {
                        string position = worksheet.Cells[row, Convert.ToInt32(nudPosition.Value)].Text;
                        player.PositionString = position;
                    }
                    if (cbTeam.Checked)
                    {
                        string team = worksheet.Cells[row, Convert.ToInt32(nudTeam.Value)].Text;
                        player.NflTeam = team;
                    }
                    if (cbBye.Checked)
                    {
                        int bye = int.Parse(worksheet.Cells[row, Convert.ToInt32(nudBye.Value)].Text);
                        player.ByeWeek = bye;
                    }

                    if (cbValue.Checked)
                    {
                        int value = int.Parse(worksheet.Cells[row, Convert.ToInt32(nudValue.Value)].Text);
                        player.EstimatedValue = value;
                    }
                    if (cbYear.Checked)
                    {
                        int year = int.Parse(worksheet.Cells[row, Convert.ToInt32(nudYear.Value)].Text);
                        player.Year = year;
                    }
                    if (cbAltValue.Checked)
                    {

                        string cellValue = worksheet.Cells[row, Convert.ToInt32(nudAltValue.Value)].Text;

                        if (!string.IsNullOrWhiteSpace(cellValue))
                        {
                            int altValue;
                            if (int.TryParse(cellValue, out altValue))
                            {
                                player.AlternateValue = altValue;
                            }

                        }
                    }
                    if (cbPositionRank.Checked)
                    {
                        string cellValue = worksheet.Cells[row, Convert.ToInt32(nudPosRank.Value)].Text;

                        if (!string.IsNullOrWhiteSpace(cellValue))
                        {
                            int posRank;
                            if (int.TryParse(cellValue, out posRank))
                            {
                                player.PositionRank = posRank;
                            }

                        }
                    }
                    if (cbNotes.Checked)
                    {
                        string notes = worksheet.Cells[row, Convert.ToInt32(nudNotes.Value)].Text;
                        player.Notes = notes;
                    }

                    playersToAdd.Add(player);
                    SQLiteDataAccess.SavePlayer(player);
                }
            }
        }

        private void btnSaveFantasyTeam_Click(object sender, EventArgs e)
        {

            FantasyTeam team = new FantasyTeam(txtFantasyName.Text, txtFantasyOwner.Text);
            SQLiteDataAccess.SaveFantasyTeam(team);
            txtFantasyName.Clear();
            txtFantasyOwner.Clear();
            teamList.Clear();
            teamList = SQLiteDataAccess.LoadFantasyTeams(AllPlayerList);
            lbFantasyTeams.DataSource = teamList;
            lbFantasyTeams.DisplayMember = "Name";

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            AllPlayerList = SQLiteDataAccess.LoadPlayers();
            teamList = SQLiteDataAccess.LoadFantasyTeams(AllPlayerList);
            lbFantasyTeams.DataSource = teamList;
            lbFantasyTeams.DisplayMember = "Name";
            //lbFantasyTeams.Items.Add(teamList);
        }

        private void cbName_CheckedChanged(object sender, EventArgs e)
        {
            if (cbName.Checked)
            {
                nudName.Enabled = true;
            }
            else
            {
                nudName.Enabled = false;
            }
        }

        private void cbPosition_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPosition.Checked)
            {
                nudPosition.Enabled = true;
            }
            else { nudPosition.Enabled = false; }
        }

        private void cbTeam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTeam.Checked) { nudTeam.Enabled = true; }
            else { nudTeam.Enabled = false; }
        }

        private void cbBye_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBye.Checked) { nudBye.Enabled = true; }
            else { nudBye.Enabled = false; }
        }

        private void cbValue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbValue.Checked) { nudValue.Enabled = true; }
            else { nudValue.Enabled = false; }
        }

        private void cbYear_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYear.Checked) { nudYear.Enabled = true; }
            else
            {
                nudYear.Enabled = false;
            }
        }

        private void btnDeleteAllPlayers_Click(object sender, EventArgs e)
        {
            SQLiteDataAccess.DeleteAllPlayers();
        }

        private void lbFantasyTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFantasyTeams.SelectedIndex > 0)
            {
                teamSelected = (FantasyTeam)lbFantasyTeams.SelectedItem;
                txtFantasyName.Text = teamSelected.Name;
                txtFantasyOwner.Text = teamSelected.Owner;
            }
        }

        private void btnUpdateTeam_Click(object sender, EventArgs e)
        {
            teamSelected.Name = txtFantasyName.Text;
            teamSelected.Owner = txtFantasyOwner.Text;
            SQLiteDataAccess.UpdateTeam(teamSelected);
        }
    }
}
