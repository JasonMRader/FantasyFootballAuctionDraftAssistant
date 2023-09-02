namespace FantasyFootballAuctionDraftAssistant
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoadExcelData = new Button();
            cbName = new CheckBox();
            cbPosition = new CheckBox();
            cbTeam = new CheckBox();
            cbBye = new CheckBox();
            cbValue = new CheckBox();
            lbFantasyTeams = new ListBox();
            panel6 = new Panel();
            nudNotes = new NumericUpDown();
            nudPosRank = new NumericUpDown();
            nudAltValue = new NumericUpDown();
            cbNotes = new CheckBox();
            cbPositionRank = new CheckBox();
            cbAltValue = new CheckBox();
            btnDeleteAllPlayers = new Button();
            nudYear = new NumericUpDown();
            nudValue = new NumericUpDown();
            nudBye = new NumericUpDown();
            nudTeam = new NumericUpDown();
            nudPosition = new NumericUpDown();
            nudName = new NumericUpDown();
            cbYear = new CheckBox();
            panel7 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnDelete = new Button();
            btnSaveFantasyTeam = new Button();
            txtFantasyOwner = new TextBox();
            txtFantasyName = new TextBox();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPosRank).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAltValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTeam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPosition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudName).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoadExcelData
            // 
            btnLoadExcelData.Location = new Point(13, 279);
            btnLoadExcelData.Name = "btnLoadExcelData";
            btnLoadExcelData.Size = new Size(193, 40);
            btnLoadExcelData.TabIndex = 0;
            btnLoadExcelData.Text = "Load Excel Data";
            btnLoadExcelData.UseVisualStyleBackColor = true;
            btnLoadExcelData.Click += btnLoadExcelData_Click;
            // 
            // cbName
            // 
            cbName.Appearance = Appearance.Button;
            cbName.Checked = true;
            cbName.CheckState = CheckState.Checked;
            cbName.Location = new Point(13, 3);
            cbName.Name = "cbName";
            cbName.Size = new Size(75, 23);
            cbName.TabIndex = 3;
            cbName.Text = "Name";
            cbName.TextAlign = ContentAlignment.MiddleCenter;
            cbName.UseVisualStyleBackColor = true;
            cbName.CheckedChanged += cbName_CheckedChanged;
            // 
            // cbPosition
            // 
            cbPosition.Appearance = Appearance.Button;
            cbPosition.Checked = true;
            cbPosition.CheckState = CheckState.Checked;
            cbPosition.Location = new Point(13, 32);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(75, 23);
            cbPosition.TabIndex = 3;
            cbPosition.Text = "Position";
            cbPosition.TextAlign = ContentAlignment.MiddleCenter;
            cbPosition.UseVisualStyleBackColor = true;
            cbPosition.CheckedChanged += cbPosition_CheckedChanged;
            // 
            // cbTeam
            // 
            cbTeam.Appearance = Appearance.Button;
            cbTeam.Checked = true;
            cbTeam.CheckState = CheckState.Checked;
            cbTeam.Location = new Point(13, 61);
            cbTeam.Name = "cbTeam";
            cbTeam.Size = new Size(75, 23);
            cbTeam.TabIndex = 3;
            cbTeam.Text = "Team";
            cbTeam.TextAlign = ContentAlignment.MiddleCenter;
            cbTeam.UseVisualStyleBackColor = true;
            cbTeam.CheckedChanged += cbTeam_CheckedChanged;
            // 
            // cbBye
            // 
            cbBye.Appearance = Appearance.Button;
            cbBye.Checked = true;
            cbBye.CheckState = CheckState.Checked;
            cbBye.Location = new Point(13, 90);
            cbBye.Name = "cbBye";
            cbBye.Size = new Size(75, 23);
            cbBye.TabIndex = 3;
            cbBye.Text = "Bye";
            cbBye.TextAlign = ContentAlignment.MiddleCenter;
            cbBye.UseVisualStyleBackColor = true;
            cbBye.CheckedChanged += cbBye_CheckedChanged;
            // 
            // cbValue
            // 
            cbValue.Appearance = Appearance.Button;
            cbValue.Checked = true;
            cbValue.CheckState = CheckState.Checked;
            cbValue.Location = new Point(13, 119);
            cbValue.Name = "cbValue";
            cbValue.Size = new Size(75, 23);
            cbValue.TabIndex = 3;
            cbValue.Text = "Value";
            cbValue.TextAlign = ContentAlignment.MiddleCenter;
            cbValue.UseVisualStyleBackColor = true;
            cbValue.CheckedChanged += cbValue_CheckedChanged;
            // 
            // lbFantasyTeams
            // 
            lbFantasyTeams.FormattingEnabled = true;
            lbFantasyTeams.ItemHeight = 15;
            lbFantasyTeams.Location = new Point(158, 21);
            lbFantasyTeams.Name = "lbFantasyTeams";
            lbFantasyTeams.Size = new Size(184, 319);
            lbFantasyTeams.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(224, 224, 224);
            panel6.Controls.Add(nudNotes);
            panel6.Controls.Add(nudPosRank);
            panel6.Controls.Add(nudAltValue);
            panel6.Controls.Add(cbNotes);
            panel6.Controls.Add(cbPositionRank);
            panel6.Controls.Add(cbAltValue);
            panel6.Controls.Add(btnDeleteAllPlayers);
            panel6.Controls.Add(nudYear);
            panel6.Controls.Add(nudValue);
            panel6.Controls.Add(nudBye);
            panel6.Controls.Add(nudTeam);
            panel6.Controls.Add(nudPosition);
            panel6.Controls.Add(nudName);
            panel6.Controls.Add(cbYear);
            panel6.Controls.Add(cbValue);
            panel6.Controls.Add(cbBye);
            panel6.Controls.Add(cbTeam);
            panel6.Controls.Add(cbPosition);
            panel6.Controls.Add(cbName);
            panel6.Controls.Add(btnLoadExcelData);
            panel6.Location = new Point(12, 14);
            panel6.Name = "panel6";
            panel6.Size = new Size(224, 351);
            panel6.TabIndex = 5;
            // 
            // nudNotes
            // 
            nudNotes.Location = new Point(109, 238);
            nudNotes.Name = "nudNotes";
            nudNotes.Size = new Size(67, 23);
            nudNotes.TabIndex = 8;
            nudNotes.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // nudPosRank
            // 
            nudPosRank.Location = new Point(109, 209);
            nudPosRank.Name = "nudPosRank";
            nudPosRank.Size = new Size(67, 23);
            nudPosRank.TabIndex = 8;
            nudPosRank.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // nudAltValue
            // 
            nudAltValue.Location = new Point(109, 179);
            nudAltValue.Name = "nudAltValue";
            nudAltValue.Size = new Size(67, 23);
            nudAltValue.TabIndex = 8;
            nudAltValue.Value = new decimal(new int[] { 7, 0, 0, 0 });
            // 
            // cbNotes
            // 
            cbNotes.Appearance = Appearance.Button;
            cbNotes.Checked = true;
            cbNotes.CheckState = CheckState.Checked;
            cbNotes.Location = new Point(13, 238);
            cbNotes.Name = "cbNotes";
            cbNotes.Size = new Size(74, 24);
            cbNotes.TabIndex = 7;
            cbNotes.Text = "Notes";
            cbNotes.TextAlign = ContentAlignment.MiddleCenter;
            cbNotes.UseVisualStyleBackColor = true;
            // 
            // cbPositionRank
            // 
            cbPositionRank.Appearance = Appearance.Button;
            cbPositionRank.Checked = true;
            cbPositionRank.CheckState = CheckState.Checked;
            cbPositionRank.Location = new Point(13, 208);
            cbPositionRank.Name = "cbPositionRank";
            cbPositionRank.Size = new Size(74, 24);
            cbPositionRank.TabIndex = 7;
            cbPositionRank.Text = "Pos Rank";
            cbPositionRank.TextAlign = ContentAlignment.MiddleCenter;
            cbPositionRank.UseVisualStyleBackColor = true;
            // 
            // cbAltValue
            // 
            cbAltValue.Appearance = Appearance.Button;
            cbAltValue.Checked = true;
            cbAltValue.CheckState = CheckState.Checked;
            cbAltValue.Location = new Point(14, 178);
            cbAltValue.Name = "cbAltValue";
            cbAltValue.Size = new Size(74, 24);
            cbAltValue.TabIndex = 7;
            cbAltValue.Text = "Alt Value";
            cbAltValue.TextAlign = ContentAlignment.MiddleCenter;
            cbAltValue.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAllPlayers
            // 
            btnDeleteAllPlayers.Location = new Point(13, 325);
            btnDeleteAllPlayers.Name = "btnDeleteAllPlayers";
            btnDeleteAllPlayers.Size = new Size(65, 23);
            btnDeleteAllPlayers.TabIndex = 6;
            btnDeleteAllPlayers.Text = "Delete All Players";
            btnDeleteAllPlayers.UseVisualStyleBackColor = true;
            btnDeleteAllPlayers.Click += btnDeleteAllPlayers_Click;
            // 
            // nudYear
            // 
            nudYear.Location = new Point(109, 148);
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(67, 23);
            nudYear.TabIndex = 5;
            nudYear.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // nudValue
            // 
            nudValue.Location = new Point(109, 119);
            nudValue.Name = "nudValue";
            nudValue.Size = new Size(67, 23);
            nudValue.TabIndex = 5;
            nudValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudBye
            // 
            nudBye.Location = new Point(109, 90);
            nudBye.Name = "nudBye";
            nudBye.Size = new Size(67, 23);
            nudBye.TabIndex = 5;
            nudBye.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // nudTeam
            // 
            nudTeam.Location = new Point(109, 61);
            nudTeam.Name = "nudTeam";
            nudTeam.Size = new Size(67, 23);
            nudTeam.TabIndex = 5;
            nudTeam.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // nudPosition
            // 
            nudPosition.Location = new Point(109, 32);
            nudPosition.Name = "nudPosition";
            nudPosition.Size = new Size(67, 23);
            nudPosition.TabIndex = 5;
            nudPosition.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // nudName
            // 
            nudName.Location = new Point(109, 3);
            nudName.Name = "nudName";
            nudName.Size = new Size(67, 23);
            nudName.TabIndex = 5;
            nudName.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // cbYear
            // 
            cbYear.Appearance = Appearance.Button;
            cbYear.CheckAlign = ContentAlignment.TopRight;
            cbYear.Checked = true;
            cbYear.CheckState = CheckState.Checked;
            cbYear.Location = new Point(13, 148);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(75, 23);
            cbYear.TabIndex = 4;
            cbYear.Text = "Year";
            cbYear.TextAlign = ContentAlignment.MiddleCenter;
            cbYear.UseVisualStyleBackColor = true;
            cbYear.CheckedChanged += cbYear_CheckedChanged;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(224, 224, 224);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(btnDelete);
            panel7.Controls.Add(btnSaveFantasyTeam);
            panel7.Controls.Add(txtFantasyOwner);
            panel7.Controls.Add(txtFantasyName);
            panel7.Controls.Add(lbFantasyTeams);
            panel7.Location = new Point(252, 14);
            panel7.Name = "panel7";
            panel7.Size = new Size(363, 351);
            panel7.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 89);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 7;
            label2.Text = "Owner";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 7;
            label1.Text = "Team Name";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(13, 189);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 32);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete Team";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSaveFantasyTeam
            // 
            btnSaveFantasyTeam.Location = new Point(13, 151);
            btnSaveFantasyTeam.Name = "btnSaveFantasyTeam";
            btnSaveFantasyTeam.Size = new Size(130, 32);
            btnSaveFantasyTeam.TabIndex = 6;
            btnSaveFantasyTeam.Text = "Save Team";
            btnSaveFantasyTeam.UseVisualStyleBackColor = true;
            btnSaveFantasyTeam.Click += btnSaveFantasyTeam_Click;
            // 
            // txtFantasyOwner
            // 
            txtFantasyOwner.Location = new Point(13, 107);
            txtFantasyOwner.Name = "txtFantasyOwner";
            txtFantasyOwner.Size = new Size(130, 23);
            txtFantasyOwner.TabIndex = 5;
            // 
            // txtFantasyName
            // 
            txtFantasyName.Location = new Point(13, 43);
            txtFantasyName.Name = "txtFantasyName";
            txtFantasyName.Size = new Size(130, 23);
            txtFantasyName.TabIndex = 5;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 385);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Name = "frmSettings";
            Text = "frmSettings";
            Load += frmSettings_Load;
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudNotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPosRank).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAltValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBye).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTeam).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPosition).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudName).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadExcelData;
        private CheckBox cbName;
        private CheckBox cbPosition;
        private CheckBox cbTeam;
        private CheckBox cbBye;
        private CheckBox cbValue;
        private ListBox lbFantasyTeams;
        private Panel panel6;
        private Panel panel7;
        private Label label2;
        private Label label1;
        private Button btnSaveFantasyTeam;
        private TextBox txtFantasyOwner;
        private TextBox txtFantasyName;
        private NumericUpDown nudYear;
        private NumericUpDown nudValue;
        private NumericUpDown nudBye;
        private NumericUpDown nudTeam;
        private NumericUpDown nudPosition;
        private NumericUpDown nudName;
        private CheckBox cbYear;
        private Button btnDelete;
        private Button btnDeleteAllPlayers;
        private NumericUpDown nudNotes;
        private NumericUpDown nudPosRank;
        private NumericUpDown nudAltValue;
        private CheckBox cbNotes;
        private CheckBox cbPositionRank;
        private CheckBox cbAltValue;
    }
}