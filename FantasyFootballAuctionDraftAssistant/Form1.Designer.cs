namespace FantasyFootballAuctionDraftAssistant
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvUndraftedPlayers = new ListView();
            panel1 = new Panel();
            cbK = new CheckBox();
            cbDEF = new CheckBox();
            cbTE = new CheckBox();
            cbWR = new CheckBox();
            cbRB = new CheckBox();
            cbQB = new CheckBox();
            cbAllPositions = new CheckBox();
            lblPlayerOnClock = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pnlOtherTeamsDraft = new Panel();
            button14 = new Button();
            button13 = new Button();
            button11 = new Button();
            button10 = new Button();
            button8 = new Button();
            button7 = new Button();
            button12 = new Button();
            button5 = new Button();
            button9 = new Button();
            button4 = new Button();
            button6 = new Button();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            btnOtherDraftsOnClock = new Button();
            btnWeDraftOnClock = new Button();
            btnOpenOnlineInfo = new Button();
            txtCost = new TextBox();
            btnCancelOnClock = new Button();
            lblPlayerOnClockValue = new Label();
            panel3 = new Panel();
            panel7 = new Panel();
            lblRosterSpots = new Label();
            label11 = new Label();
            lblAvgCapPerSpotLeft = new Label();
            label13 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            lblRosterValueDifference = new Label();
            lblDisplayTeamBudget = new Label();
            label4 = new Label();
            panel4 = new Panel();
            lblKs = new Label();
            lblDEFs = new Label();
            lblTEs = new Label();
            lblWRs = new Label();
            lblRBs = new Label();
            lblQBs = new Label();
            label8 = new Label();
            label10 = new Label();
            label5 = new Label();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            lvTeamRoster = new ListView();
            lblDisplayTeamName = new Label();
            panel5 = new Panel();
            rdoDrafted = new RadioButton();
            rdoFreeAgents = new RadioButton();
            btnDraftHistory = new Button();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            btnCloseBrowser = new Button();
            btnOpenSettings = new Button();
            pnlTeamsToView = new Panel();
            radioButton16 = new RadioButton();
            radioButton15 = new RadioButton();
            radioButton12 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton14 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton13 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlOtherTeamsDraft.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            pnlTeamsToView.SuspendLayout();
            SuspendLayout();
            // 
            // lvUndraftedPlayers
            // 
            lvUndraftedPlayers.Location = new Point(299, 79);
            lvUndraftedPlayers.Name = "lvUndraftedPlayers";
            lvUndraftedPlayers.Size = new Size(575, 667);
            lvUndraftedPlayers.TabIndex = 0;
            lvUndraftedPlayers.UseCompatibleStateImageBehavior = false;
            lvUndraftedPlayers.SelectedIndexChanged += lvUndraftedPlayers_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbK);
            panel1.Controls.Add(cbDEF);
            panel1.Controls.Add(cbTE);
            panel1.Controls.Add(cbWR);
            panel1.Controls.Add(cbRB);
            panel1.Controls.Add(cbQB);
            panel1.Controls.Add(cbAllPositions);
            panel1.Location = new Point(299, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 30);
            panel1.TabIndex = 1;
            // 
            // cbK
            // 
            cbK.Appearance = Appearance.Button;
            cbK.BackColor = Color.FromArgb(255, 192, 255);
            cbK.Location = new Point(489, 3);
            cbK.Name = "cbK";
            cbK.Size = new Size(75, 24);
            cbK.TabIndex = 0;
            cbK.Text = "K";
            cbK.TextAlign = ContentAlignment.MiddleCenter;
            cbK.UseVisualStyleBackColor = false;
            cbK.CheckedChanged += cbK_CheckedChanged;
            // 
            // cbDEF
            // 
            cbDEF.Appearance = Appearance.Button;
            cbDEF.BackColor = Color.FromArgb(255, 192, 255);
            cbDEF.Location = new Point(408, 3);
            cbDEF.Name = "cbDEF";
            cbDEF.Size = new Size(75, 24);
            cbDEF.TabIndex = 0;
            cbDEF.Text = "DEF";
            cbDEF.TextAlign = ContentAlignment.MiddleCenter;
            cbDEF.UseVisualStyleBackColor = false;
            cbDEF.CheckedChanged += cbDEF_CheckedChanged;
            // 
            // cbTE
            // 
            cbTE.Appearance = Appearance.Button;
            cbTE.BackColor = Color.FromArgb(255, 192, 255);
            cbTE.Location = new Point(327, 3);
            cbTE.Name = "cbTE";
            cbTE.Size = new Size(75, 24);
            cbTE.TabIndex = 0;
            cbTE.Text = "TE";
            cbTE.TextAlign = ContentAlignment.MiddleCenter;
            cbTE.UseVisualStyleBackColor = false;
            cbTE.CheckedChanged += cbTE_CheckedChanged;
            // 
            // cbWR
            // 
            cbWR.Appearance = Appearance.Button;
            cbWR.BackColor = Color.FromArgb(255, 192, 255);
            cbWR.Location = new Point(246, 3);
            cbWR.Name = "cbWR";
            cbWR.Size = new Size(75, 24);
            cbWR.TabIndex = 0;
            cbWR.Text = "WR";
            cbWR.TextAlign = ContentAlignment.MiddleCenter;
            cbWR.UseVisualStyleBackColor = false;
            cbWR.CheckedChanged += cbWR_CheckedChanged;
            // 
            // cbRB
            // 
            cbRB.Appearance = Appearance.Button;
            cbRB.BackColor = Color.FromArgb(255, 192, 255);
            cbRB.Location = new Point(165, 3);
            cbRB.Name = "cbRB";
            cbRB.Size = new Size(75, 24);
            cbRB.TabIndex = 0;
            cbRB.Text = "RB";
            cbRB.TextAlign = ContentAlignment.MiddleCenter;
            cbRB.UseVisualStyleBackColor = false;
            cbRB.CheckedChanged += cbRB_CheckedChanged;
            // 
            // cbQB
            // 
            cbQB.Appearance = Appearance.Button;
            cbQB.BackColor = Color.FromArgb(255, 192, 255);
            cbQB.Location = new Point(84, 3);
            cbQB.Name = "cbQB";
            cbQB.Size = new Size(75, 24);
            cbQB.TabIndex = 0;
            cbQB.Text = "QB";
            cbQB.TextAlign = ContentAlignment.MiddleCenter;
            cbQB.UseVisualStyleBackColor = false;
            cbQB.CheckedChanged += cbQB_CheckedChanged;
            // 
            // cbAllPositions
            // 
            cbAllPositions.Appearance = Appearance.Button;
            cbAllPositions.BackColor = Color.FromArgb(255, 192, 255);
            cbAllPositions.Location = new Point(3, 3);
            cbAllPositions.Name = "cbAllPositions";
            cbAllPositions.Size = new Size(75, 24);
            cbAllPositions.TabIndex = 0;
            cbAllPositions.Text = "All";
            cbAllPositions.TextAlign = ContentAlignment.MiddleCenter;
            cbAllPositions.UseVisualStyleBackColor = false;
            cbAllPositions.CheckedChanged += cbAllPositions_CheckedChanged;
            // 
            // lblPlayerOnClock
            // 
            lblPlayerOnClock.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerOnClock.Location = new Point(3, 47);
            lblPlayerOnClock.Name = "lblPlayerOnClock";
            lblPlayerOnClock.Size = new Size(246, 35);
            lblPlayerOnClock.TabIndex = 2;
            lblPlayerOnClock.Text = "Choose Player";
            lblPlayerOnClock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 116);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 3;
            label1.Text = "Value:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(pnlOtherTeamsDraft);
            panel2.Controls.Add(btnWeDraftOnClock);
            panel2.Controls.Add(btnOpenOnlineInfo);
            panel2.Controls.Add(txtCost);
            panel2.Controls.Add(btnCancelOnClock);
            panel2.Controls.Add(lblPlayerOnClock);
            panel2.Controls.Add(lblPlayerOnClockValue);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(33, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 734);
            panel2.TabIndex = 4;
            // 
            // pnlOtherTeamsDraft
            // 
            pnlOtherTeamsDraft.Controls.Add(button14);
            pnlOtherTeamsDraft.Controls.Add(button13);
            pnlOtherTeamsDraft.Controls.Add(button11);
            pnlOtherTeamsDraft.Controls.Add(button10);
            pnlOtherTeamsDraft.Controls.Add(button8);
            pnlOtherTeamsDraft.Controls.Add(button7);
            pnlOtherTeamsDraft.Controls.Add(button12);
            pnlOtherTeamsDraft.Controls.Add(button5);
            pnlOtherTeamsDraft.Controls.Add(button9);
            pnlOtherTeamsDraft.Controls.Add(button4);
            pnlOtherTeamsDraft.Controls.Add(button6);
            pnlOtherTeamsDraft.Controls.Add(button2);
            pnlOtherTeamsDraft.Controls.Add(button3);
            pnlOtherTeamsDraft.Controls.Add(button1);
            pnlOtherTeamsDraft.Controls.Add(btnOtherDraftsOnClock);
            pnlOtherTeamsDraft.Location = new Point(3, 254);
            pnlOtherTeamsDraft.Name = "pnlOtherTeamsDraft";
            pnlOtherTeamsDraft.Size = new Size(246, 475);
            pnlOtherTeamsDraft.TabIndex = 7;
            // 
            // button14
            // 
            button14.Location = new Point(14, 437);
            button14.Margin = new Padding(3, 5, 3, 3);
            button14.Name = "button14";
            button14.Size = new Size(206, 28);
            button14.TabIndex = 4;
            button14.Text = "Other Team Drafted";
            button14.UseVisualStyleBackColor = true;
            button14.Click += btnOtherDraftsOnClock_Click;
            // 
            // button13
            // 
            button13.Location = new Point(14, 406);
            button13.Margin = new Padding(3, 5, 3, 3);
            button13.Name = "button13";
            button13.Size = new Size(206, 28);
            button13.TabIndex = 4;
            button13.Text = "Other Team Drafted";
            button13.UseVisualStyleBackColor = true;
            button13.Click += btnOtherDraftsOnClock_Click;
            // 
            // button11
            // 
            button11.Location = new Point(14, 344);
            button11.Margin = new Padding(3, 5, 3, 3);
            button11.Name = "button11";
            button11.Size = new Size(206, 28);
            button11.TabIndex = 4;
            button11.Text = "Other Team Drafted";
            button11.UseVisualStyleBackColor = true;
            button11.Click += btnOtherDraftsOnClock_Click;
            // 
            // button10
            // 
            button10.Location = new Point(14, 313);
            button10.Margin = new Padding(3, 5, 3, 3);
            button10.Name = "button10";
            button10.Size = new Size(206, 28);
            button10.TabIndex = 4;
            button10.Text = "Other Team Drafted";
            button10.UseVisualStyleBackColor = true;
            button10.Click += btnOtherDraftsOnClock_Click;
            // 
            // button8
            // 
            button8.Location = new Point(14, 251);
            button8.Margin = new Padding(3, 5, 3, 3);
            button8.Name = "button8";
            button8.Size = new Size(206, 28);
            button8.TabIndex = 4;
            button8.Text = "Other Team Drafted";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnOtherDraftsOnClock_Click;
            // 
            // button7
            // 
            button7.Location = new Point(14, 220);
            button7.Margin = new Padding(3, 5, 3, 3);
            button7.Name = "button7";
            button7.Size = new Size(206, 28);
            button7.TabIndex = 4;
            button7.Text = "Other Team Drafted";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnOtherDraftsOnClock_Click;
            // 
            // button12
            // 
            button12.Location = new Point(14, 375);
            button12.Margin = new Padding(3, 5, 3, 3);
            button12.Name = "button12";
            button12.Size = new Size(206, 28);
            button12.TabIndex = 4;
            button12.Text = "Other Team Drafted";
            button12.UseVisualStyleBackColor = true;
            button12.Click += btnOtherDraftsOnClock_Click;
            // 
            // button5
            // 
            button5.Location = new Point(14, 158);
            button5.Margin = new Padding(3, 5, 3, 3);
            button5.Name = "button5";
            button5.Size = new Size(206, 28);
            button5.TabIndex = 4;
            button5.Text = "Other Team Drafted";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnOtherDraftsOnClock_Click;
            // 
            // button9
            // 
            button9.Location = new Point(14, 282);
            button9.Margin = new Padding(3, 5, 3, 3);
            button9.Name = "button9";
            button9.Size = new Size(206, 28);
            button9.TabIndex = 4;
            button9.Text = "Other Team Drafted";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btnOtherDraftsOnClock_Click;
            // 
            // button4
            // 
            button4.Location = new Point(14, 127);
            button4.Margin = new Padding(3, 5, 3, 3);
            button4.Name = "button4";
            button4.Size = new Size(206, 28);
            button4.TabIndex = 4;
            button4.Text = "Other Team Drafted";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnOtherDraftsOnClock_Click;
            // 
            // button6
            // 
            button6.Location = new Point(14, 189);
            button6.Margin = new Padding(3, 5, 3, 3);
            button6.Name = "button6";
            button6.Size = new Size(206, 28);
            button6.TabIndex = 4;
            button6.Text = "Other Team Drafted";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnOtherDraftsOnClock_Click;
            // 
            // button2
            // 
            button2.Location = new Point(14, 65);
            button2.Margin = new Padding(3, 5, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(206, 28);
            button2.TabIndex = 4;
            button2.Text = "Other Team Drafted";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnOtherDraftsOnClock_Click;
            // 
            // button3
            // 
            button3.Location = new Point(14, 96);
            button3.Margin = new Padding(3, 5, 3, 3);
            button3.Name = "button3";
            button3.Size = new Size(206, 28);
            button3.TabIndex = 4;
            button3.Text = "Other Team Drafted";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnOtherDraftsOnClock_Click;
            // 
            // button1
            // 
            button1.Location = new Point(14, 34);
            button1.Margin = new Padding(3, 5, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(206, 28);
            button1.TabIndex = 4;
            button1.Text = "Other Team Drafted";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnOtherDraftsOnClock_Click;
            // 
            // btnOtherDraftsOnClock
            // 
            btnOtherDraftsOnClock.Location = new Point(14, 3);
            btnOtherDraftsOnClock.Margin = new Padding(3, 5, 3, 3);
            btnOtherDraftsOnClock.Name = "btnOtherDraftsOnClock";
            btnOtherDraftsOnClock.Size = new Size(206, 28);
            btnOtherDraftsOnClock.TabIndex = 4;
            btnOtherDraftsOnClock.Text = "Other Team Drafted";
            btnOtherDraftsOnClock.UseVisualStyleBackColor = true;
            btnOtherDraftsOnClock.Click += btnOtherDraftsOnClock_Click;
            // 
            // btnWeDraftOnClock
            // 
            btnWeDraftOnClock.Location = new Point(17, 211);
            btnWeDraftOnClock.Name = "btnWeDraftOnClock";
            btnWeDraftOnClock.Size = new Size(206, 37);
            btnWeDraftOnClock.TabIndex = 4;
            btnWeDraftOnClock.Text = "We Draft";
            btnWeDraftOnClock.UseVisualStyleBackColor = true;
            btnWeDraftOnClock.Click += btnWeDraftOnClock_Click;
            // 
            // btnOpenOnlineInfo
            // 
            btnOpenOnlineInfo.Location = new Point(17, 6);
            btnOpenOnlineInfo.Name = "btnOpenOnlineInfo";
            btnOpenOnlineInfo.Size = new Size(197, 23);
            btnOpenOnlineInfo.TabIndex = 6;
            btnOpenOnlineInfo.Text = "View Info";
            btnOpenOnlineInfo.UseVisualStyleBackColor = true;
            btnOpenOnlineInfo.Click += btnOpenOnlineInfo_Click;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(17, 170);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(206, 23);
            txtCost.TabIndex = 5;
            // 
            // btnCancelOnClock
            // 
            btnCancelOnClock.FlatStyle = FlatStyle.Flat;
            btnCancelOnClock.Location = new Point(220, 6);
            btnCancelOnClock.Name = "btnCancelOnClock";
            btnCancelOnClock.Size = new Size(29, 23);
            btnCancelOnClock.TabIndex = 4;
            btnCancelOnClock.Text = "X";
            btnCancelOnClock.UseVisualStyleBackColor = true;
            btnCancelOnClock.Click += btnCancelOnClock_Click;
            // 
            // lblPlayerOnClockValue
            // 
            lblPlayerOnClockValue.AutoSize = true;
            lblPlayerOnClockValue.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerOnClockValue.Location = new Point(134, 116);
            lblPlayerOnClockValue.Name = "lblPlayerOnClockValue";
            lblPlayerOnClockValue.Size = new Size(34, 25);
            lblPlayerOnClockValue.TabIndex = 3;
            lblPlayerOnClockValue.Text = "$$";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 255, 192);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(lvTeamRoster);
            panel3.Controls.Add(lblDisplayTeamName);
            panel3.Location = new Point(880, 162);
            panel3.Name = "panel3";
            panel3.Size = new Size(451, 584);
            panel3.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(128, 255, 128);
            panel7.Controls.Add(lblRosterSpots);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(lblAvgCapPerSpotLeft);
            panel7.Controls.Add(label13);
            panel7.Location = new Point(249, 28);
            panel7.Name = "panel7";
            panel7.Size = new Size(177, 100);
            panel7.TabIndex = 14;
            // 
            // lblRosterSpots
            // 
            lblRosterSpots.AutoSize = true;
            lblRosterSpots.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRosterSpots.Location = new Point(115, 14);
            lblRosterSpots.Name = "lblRosterSpots";
            lblRosterSpots.Size = new Size(25, 21);
            lblRosterSpots.TabIndex = 8;
            lblRosterSpots.Text = "16";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 14);
            label11.Name = "label11";
            label11.Size = new Size(106, 21);
            label11.TabIndex = 8;
            label11.Text = "Empty Spots:";
            // 
            // lblAvgCapPerSpotLeft
            // 
            lblAvgCapPerSpotLeft.AutoSize = true;
            lblAvgCapPerSpotLeft.Location = new Point(119, 44);
            lblAvgCapPerSpotLeft.Name = "lblAvgCapPerSpotLeft";
            lblAvgCapPerSpotLeft.Size = new Size(13, 15);
            lblAvgCapPerSpotLeft.TabIndex = 11;
            lblAvgCapPerSpotLeft.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 44);
            label13.Name = "label13";
            label13.Size = new Size(110, 15);
            label13.TabIndex = 11;
            label13.Text = "Avg Cap Per Player:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(128, 255, 128);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(lblRosterValueDifference);
            panel6.Controls.Add(lblDisplayTeamBudget);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(18, 28);
            panel6.Name = "panel6";
            panel6.Size = new Size(195, 99);
            panel6.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 14);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 7;
            label3.Text = "Cap Space:";
            // 
            // lblRosterValueDifference
            // 
            lblRosterValueDifference.AutoSize = true;
            lblRosterValueDifference.Location = new Point(157, 44);
            lblRosterValueDifference.Name = "lblRosterValueDifference";
            lblRosterValueDifference.Size = new Size(13, 15);
            lblRosterValueDifference.TabIndex = 12;
            lblRosterValueDifference.Text = "0";
            // 
            // lblDisplayTeamBudget
            // 
            lblDisplayTeamBudget.AutoSize = true;
            lblDisplayTeamBudget.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisplayTeamBudget.Location = new Point(114, 14);
            lblDisplayTeamBudget.Name = "lblDisplayTeamBudget";
            lblDisplayTeamBudget.Size = new Size(37, 21);
            lblDisplayTeamBudget.TabIndex = 7;
            lblDisplayTeamBudget.Text = "200";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 44);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 11;
            label4.Text = "Roster Value Difference:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(128, 255, 128);
            panel4.Controls.Add(lblKs);
            panel4.Controls.Add(lblDEFs);
            panel4.Controls.Add(lblTEs);
            panel4.Controls.Add(lblWRs);
            panel4.Controls.Add(lblRBs);
            panel4.Controls.Add(lblQBs);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(2, 145);
            panel4.Name = "panel4";
            panel4.Size = new Size(443, 51);
            panel4.TabIndex = 10;
            // 
            // lblKs
            // 
            lblKs.AutoSize = true;
            lblKs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblKs.Location = new Point(402, 15);
            lblKs.Name = "lblKs";
            lblKs.Size = new Size(19, 21);
            lblKs.TabIndex = 15;
            lblKs.Text = "0";
            // 
            // lblDEFs
            // 
            lblDEFs.AutoSize = true;
            lblDEFs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDEFs.Location = new Point(320, 15);
            lblDEFs.Name = "lblDEFs";
            lblDEFs.Size = new Size(19, 21);
            lblDEFs.TabIndex = 14;
            lblDEFs.Text = "0";
            // 
            // lblTEs
            // 
            lblTEs.AutoSize = true;
            lblTEs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTEs.Location = new Point(246, 15);
            lblTEs.Name = "lblTEs";
            lblTEs.Size = new Size(19, 21);
            lblTEs.TabIndex = 13;
            lblTEs.Text = "0";
            // 
            // lblWRs
            // 
            lblWRs.AutoSize = true;
            lblWRs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWRs.Location = new Point(166, 15);
            lblWRs.Name = "lblWRs";
            lblWRs.Size = new Size(19, 21);
            lblWRs.TabIndex = 12;
            lblWRs.Text = "0";
            // 
            // lblRBs
            // 
            lblRBs.AutoSize = true;
            lblRBs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRBs.Location = new Point(90, 15);
            lblRBs.Name = "lblRBs";
            lblRBs.Size = new Size(19, 21);
            lblRBs.TabIndex = 11;
            lblRBs.Text = "0";
            // 
            // lblQBs
            // 
            lblQBs.AutoSize = true;
            lblQBs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQBs.Location = new Point(22, 15);
            lblQBs.Name = "lblQBs";
            lblQBs.Size = new Size(19, 21);
            lblQBs.TabIndex = 10;
            lblQBs.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(246, 0);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 9;
            label8.Text = "TEs:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(402, 0);
            label10.Name = "label10";
            label10.Size = new Size(22, 15);
            label10.TabIndex = 9;
            label10.Text = "Ks:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 0);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 9;
            label5.Text = "QBs:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(320, 0);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 9;
            label9.Text = "DEFs:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 0);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 9;
            label6.Text = "RBs:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(166, 0);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 9;
            label7.Text = "WRs:";
            // 
            // lvTeamRoster
            // 
            lvTeamRoster.Location = new Point(2, 200);
            lvTeamRoster.Name = "lvTeamRoster";
            lvTeamRoster.Size = new Size(443, 379);
            lvTeamRoster.TabIndex = 8;
            lvTeamRoster.UseCompatibleStateImageBehavior = false;
            // 
            // lblDisplayTeamName
            // 
            lblDisplayTeamName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisplayTeamName.Location = new Point(5, 0);
            lblDisplayTeamName.Name = "lblDisplayTeamName";
            lblDisplayTeamName.Size = new Size(440, 25);
            lblDisplayTeamName.TabIndex = 6;
            lblDisplayTeamName.Text = "Disappointing Monday";
            lblDisplayTeamName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(rdoDrafted);
            panel5.Controls.Add(rdoFreeAgents);
            panel5.Location = new Point(302, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(324, 27);
            panel5.TabIndex = 6;
            // 
            // rdoDrafted
            // 
            rdoDrafted.Appearance = Appearance.Button;
            rdoDrafted.Location = new Point(179, -1);
            rdoDrafted.Name = "rdoDrafted";
            rdoDrafted.Size = new Size(139, 25);
            rdoDrafted.TabIndex = 0;
            rdoDrafted.TabStop = true;
            rdoDrafted.Text = "Drafted";
            rdoDrafted.TextAlign = ContentAlignment.MiddleCenter;
            rdoDrafted.UseVisualStyleBackColor = true;
            // 
            // rdoFreeAgents
            // 
            rdoFreeAgents.Appearance = Appearance.Button;
            rdoFreeAgents.Location = new Point(0, -1);
            rdoFreeAgents.Name = "rdoFreeAgents";
            rdoFreeAgents.Size = new Size(173, 24);
            rdoFreeAgents.TabIndex = 0;
            rdoFreeAgents.TabStop = true;
            rdoFreeAgents.Text = "Free Agents";
            rdoFreeAgents.TextAlign = ContentAlignment.MiddleCenter;
            rdoFreeAgents.UseVisualStyleBackColor = true;
            // 
            // btnDraftHistory
            // 
            btnDraftHistory.Location = new Point(676, 15);
            btnDraftHistory.Name = "btnDraftHistory";
            btnDraftHistory.Size = new Size(187, 23);
            btnDraftHistory.TabIndex = 7;
            btnDraftHistory.Text = "View Draft History";
            btnDraftHistory.UseVisualStyleBackColor = true;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Enabled = false;
            webView.Location = new Point(299, 30);
            webView.Name = "webView";
            webView.Size = new Size(1032, 716);
            webView.TabIndex = 8;
            webView.Visible = false;
            webView.ZoomFactor = 1D;
            // 
            // btnCloseBrowser
            // 
            btnCloseBrowser.Enabled = false;
            btnCloseBrowser.Location = new Point(1129, 7);
            btnCloseBrowser.Name = "btnCloseBrowser";
            btnCloseBrowser.Size = new Size(207, 23);
            btnCloseBrowser.TabIndex = 9;
            btnCloseBrowser.Text = "Close Window";
            btnCloseBrowser.UseVisualStyleBackColor = true;
            btnCloseBrowser.Visible = false;
            btnCloseBrowser.Click += btnCloseBrowser_Click;
            // 
            // btnOpenSettings
            // 
            btnOpenSettings.Location = new Point(1000, 9);
            btnOpenSettings.Name = "btnOpenSettings";
            btnOpenSettings.Size = new Size(103, 23);
            btnOpenSettings.TabIndex = 10;
            btnOpenSettings.Text = "Settings";
            btnOpenSettings.UseVisualStyleBackColor = true;
            btnOpenSettings.Click += btnOpenSettings_Click;
            // 
            // pnlTeamsToView
            // 
            pnlTeamsToView.Controls.Add(radioButton16);
            pnlTeamsToView.Controls.Add(radioButton15);
            pnlTeamsToView.Controls.Add(radioButton12);
            pnlTeamsToView.Controls.Add(radioButton11);
            pnlTeamsToView.Controls.Add(radioButton8);
            pnlTeamsToView.Controls.Add(radioButton14);
            pnlTeamsToView.Controls.Add(radioButton7);
            pnlTeamsToView.Controls.Add(radioButton10);
            pnlTeamsToView.Controls.Add(radioButton4);
            pnlTeamsToView.Controls.Add(radioButton13);
            pnlTeamsToView.Controls.Add(radioButton6);
            pnlTeamsToView.Controls.Add(radioButton9);
            pnlTeamsToView.Controls.Add(radioButton3);
            pnlTeamsToView.Controls.Add(radioButton5);
            pnlTeamsToView.Controls.Add(radioButton2);
            pnlTeamsToView.Controls.Add(radioButton1);
            pnlTeamsToView.Location = new Point(882, 40);
            pnlTeamsToView.Name = "pnlTeamsToView";
            pnlTeamsToView.Size = new Size(448, 113);
            pnlTeamsToView.TabIndex = 11;
            // 
            // radioButton16
            // 
            radioButton16.Appearance = Appearance.Button;
            radioButton16.Location = new Point(331, 89);
            radioButton16.Name = "radioButton16";
            radioButton16.Size = new Size(112, 24);
            radioButton16.TabIndex = 0;
            radioButton16.TabStop = true;
            radioButton16.Text = "radioButton1";
            radioButton16.TextAlign = ContentAlignment.MiddleCenter;
            radioButton16.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            radioButton15.Appearance = Appearance.Button;
            radioButton15.Location = new Point(221, 89);
            radioButton15.Name = "radioButton15";
            radioButton15.Size = new Size(112, 24);
            radioButton15.TabIndex = 0;
            radioButton15.TabStop = true;
            radioButton15.Text = "radioButton1";
            radioButton15.TextAlign = ContentAlignment.MiddleCenter;
            radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            radioButton12.Appearance = Appearance.Button;
            radioButton12.Location = new Point(331, 59);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(112, 24);
            radioButton12.TabIndex = 0;
            radioButton12.TabStop = true;
            radioButton12.Text = "radioButton1";
            radioButton12.TextAlign = ContentAlignment.MiddleCenter;
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.Appearance = Appearance.Button;
            radioButton11.Location = new Point(221, 59);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(112, 24);
            radioButton11.TabIndex = 0;
            radioButton11.TabStop = true;
            radioButton11.Text = "radioButton1";
            radioButton11.TextAlign = ContentAlignment.MiddleCenter;
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.Appearance = Appearance.Button;
            radioButton8.Location = new Point(331, 29);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(112, 24);
            radioButton8.TabIndex = 0;
            radioButton8.TabStop = true;
            radioButton8.Text = "radioButton1";
            radioButton8.TextAlign = ContentAlignment.MiddleCenter;
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            radioButton14.Appearance = Appearance.Button;
            radioButton14.Location = new Point(111, 89);
            radioButton14.Name = "radioButton14";
            radioButton14.Size = new Size(112, 24);
            radioButton14.TabIndex = 0;
            radioButton14.TabStop = true;
            radioButton14.Text = "radioButton1";
            radioButton14.TextAlign = ContentAlignment.MiddleCenter;
            radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.Appearance = Appearance.Button;
            radioButton7.Location = new Point(221, 29);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(112, 24);
            radioButton7.TabIndex = 0;
            radioButton7.TabStop = true;
            radioButton7.Text = "radioButton1";
            radioButton7.TextAlign = ContentAlignment.MiddleCenter;
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.Appearance = Appearance.Button;
            radioButton10.Location = new Point(111, 59);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(112, 24);
            radioButton10.TabIndex = 0;
            radioButton10.TabStop = true;
            radioButton10.Text = "radioButton1";
            radioButton10.TextAlign = ContentAlignment.MiddleCenter;
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.Appearance = Appearance.Button;
            radioButton4.Location = new Point(331, 0);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(112, 24);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton1";
            radioButton4.TextAlign = ContentAlignment.MiddleCenter;
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            radioButton13.Appearance = Appearance.Button;
            radioButton13.Location = new Point(3, 89);
            radioButton13.Name = "radioButton13";
            radioButton13.Size = new Size(112, 24);
            radioButton13.TabIndex = 0;
            radioButton13.TabStop = true;
            radioButton13.Text = "radioButton1";
            radioButton13.TextAlign = ContentAlignment.MiddleCenter;
            radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.Appearance = Appearance.Button;
            radioButton6.Location = new Point(111, 29);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(112, 24);
            radioButton6.TabIndex = 0;
            radioButton6.TabStop = true;
            radioButton6.Text = "radioButton1";
            radioButton6.TextAlign = ContentAlignment.MiddleCenter;
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.Appearance = Appearance.Button;
            radioButton9.Location = new Point(3, 59);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(112, 24);
            radioButton9.TabIndex = 0;
            radioButton9.TabStop = true;
            radioButton9.Text = "radioButton1";
            radioButton9.TextAlign = ContentAlignment.MiddleCenter;
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.Appearance = Appearance.Button;
            radioButton3.Location = new Point(221, 0);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(112, 24);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton1";
            radioButton3.TextAlign = ContentAlignment.MiddleCenter;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.Appearance = Appearance.Button;
            radioButton5.Location = new Point(3, 29);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(112, 24);
            radioButton5.TabIndex = 0;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton1";
            radioButton5.TextAlign = ContentAlignment.MiddleCenter;
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Appearance = Appearance.Button;
            radioButton2.Location = new Point(111, 0);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(112, 24);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton1";
            radioButton2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.Location = new Point(3, 0);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(112, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 758);
            Controls.Add(pnlTeamsToView);
            Controls.Add(btnOpenSettings);
            Controls.Add(btnCloseBrowser);
            Controls.Add(btnDraftHistory);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lvUndraftedPlayers);
            Controls.Add(webView);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlOtherTeamsDraft.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            pnlTeamsToView.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView lvUndraftedPlayers;
        private Panel panel1;
        private CheckBox cbK;
        private CheckBox cbDEF;
        private CheckBox cbTE;
        private CheckBox cbWR;
        private CheckBox cbRB;
        private CheckBox cbQB;
        private CheckBox cbAllPositions;
        private Label lblPlayerOnClock;
        private Label label1;
        private Panel panel2;
        private Button btnCancelOnClock;
        private Button btnWeDraftOnClock;
        private Button btnOtherDraftsOnClock;
        private Label lblPlayerOnClockValue;
        private Panel panel3;
        private Label lblDisplayTeamName;
        private Panel panel4;
        private Label lblKs;
        private Label lblDEFs;
        private Label lblTEs;
        private Label lblWRs;
        private Label lblRBs;
        private Label lblQBs;
        private Label label8;
        private Label label10;
        private Label label5;
        private Label label9;
        private Label label6;
        private Label label7;
        private ListView lvTeamRoster;
        private Label lblDisplayTeamBudget;
        private Label label3;
        private Panel panel5;
        private RadioButton rdoDrafted;
        private RadioButton rdoFreeAgents;
        private TextBox txtCost;
        private Panel panel7;
        private Label lblRosterSpots;
        private Label label11;
        private Label lblAvgCapPerSpotLeft;
        private Label label13;
        private Panel panel6;
        private Label lblRosterValueDifference;
        private Label label4;
        private Button btnOpenOnlineInfo;
        private Button btnDraftHistory;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private Button btnCloseBrowser;
        private Button btnOpenSettings;
        private Panel pnlTeamsToView;
        private RadioButton radioButton16;
        private RadioButton radioButton15;
        private RadioButton radioButton12;
        private RadioButton radioButton11;
        private RadioButton radioButton8;
        private RadioButton radioButton14;
        private RadioButton radioButton7;
        private RadioButton radioButton10;
        private RadioButton radioButton4;
        private RadioButton radioButton13;
        private RadioButton radioButton6;
        private RadioButton radioButton9;
        private RadioButton radioButton3;
        private RadioButton radioButton5;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel pnlOtherTeamsDraft;
        private Button button14;
        private Button button13;
        private Button button11;
        private Button button10;
        private Button button8;
        private Button button7;
        private Button button12;
        private Button button5;
        private Button button9;
        private Button button4;
        private Button button6;
        private Button button2;
        private Button button3;
        private Button button1;
    }
}