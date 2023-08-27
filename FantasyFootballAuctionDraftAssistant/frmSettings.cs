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
        List<FantasyTeam> teamList = new List<FantasyTeam>();
        public frmSettings()
        {
            InitializeComponent();
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

                for (int row = 1; row <= rowCount; row++)
                {
                    Player player = new Player();
                    string playerName = worksheet.Cells[row, Convert.ToInt32(nudName.Value)].Text; // A
                    string position = worksheet.Cells[row, Convert.ToInt32(nudPosition.Value)].Text; // B
                    int value = int.Parse(worksheet.Cells[row, Convert.ToInt32(nudValue.Value)].Text); // C

                    player.Name = playerName;
                    player.PositionString = position;
                    player.EstimatedValue = value;
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
            teamList = SQLiteDataAccess.LoadFantasyTeams();
            lbFantasyTeams.DataSource = teamList;
            lbFantasyTeams.DisplayMember = "Name";

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            teamList = SQLiteDataAccess.LoadFantasyTeams();
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
            if (cbBye.Checked) { nudBye.Enabled = true;}
            else { nudBye.Enabled = false;}
        }

        private void cbValue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbValue.Checked) { nudValue.Enabled = true; }
            else { nudValue.Enabled= false; }
        }

        private void cbYear_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYear.Checked) { nudYear.Enabled = true;}
            else
            {
                nudYear.Enabled = false;
            }
        }
    }
}
