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
            btnSaveNotes = new Button();
            txtPlayerNotes = new TextBox();
            label12 = new Label();
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
            txtCost = new TextBox();
            btnCancelOnClock = new Button();
            lblPlayerOnClockValue = new Label();
            panel3 = new Panel();
            lblDisplayKeeper = new Label();
            label14 = new Label();
            btnSetKeeper = new Button();
            btnRemovePlayerFromTeam = new Button();
            panel7 = new Panel();
            lblRosterSpots = new Label();
            label11 = new Label();
            lblAvgCapPerSpotLeft = new Label();
            label13 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            lblRosterValueDifference = new Label();
            lblDisplayTeamBudget = new Label();
            lblMaxBid = new Label();
            label2 = new Label();
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            cbDraftHistory = new CheckBox();
            cbKeepers = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlOtherTeamsDraft.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            pnlTeamsToView.SuspendLayout();
            SuspendLayout();
            // 
            // lvUndraftedPlayers
            // 
            lvUndraftedPlayers.Location = new Point(311, 79);
            lvUndraftedPlayers.Name = "lvUndraftedPlayers";
            lvUndraftedPlayers.Size = new Size(575, 845);
            lvUndraftedPlayers.Sorting = SortOrder.Descending;
            lvUndraftedPlayers.TabIndex = 0;
            lvUndraftedPlayers.UseCompatibleStateImageBehavior = false;
            lvUndraftedPlayers.SelectedIndexChanged += lvUndraftedPlayers_SelectedIndexChanged;
            lvUndraftedPlayers.DoubleClick += lvUndraftedPlayers_DoubleClick;
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
            panel1.Location = new Point(311, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 30);
            panel1.TabIndex = 1;
            // 
            // cbK
            // 
            cbK.Appearance = Appearance.Button;
            cbK.BackColor = SystemColors.Control;
            cbK.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 192);
            cbK.FlatStyle = FlatStyle.Flat;
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
            cbDEF.BackColor = SystemColors.Control;
            cbDEF.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 192);
            cbDEF.FlatStyle = FlatStyle.Flat;
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
            cbTE.BackColor = SystemColors.Control;
            cbTE.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 192);
            cbTE.FlatStyle = FlatStyle.Flat;
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
            cbWR.BackColor = SystemColors.Control;
            cbWR.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 192);
            cbWR.FlatStyle = FlatStyle.Flat;
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
            cbRB.BackColor = SystemColors.Control;
            cbRB.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 192);
            cbRB.FlatStyle = FlatStyle.Flat;
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
            cbQB.BackColor = SystemColors.Control;
            cbQB.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 192);
            cbQB.FlatStyle = FlatStyle.Flat;
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
            cbAllPositions.BackColor = SystemColors.Control;
            cbAllPositions.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 192);
            cbAllPositions.FlatStyle = FlatStyle.Flat;
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
            lblPlayerOnClock.BackColor = SystemColors.ControlText;
            lblPlayerOnClock.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerOnClock.ForeColor = SystemColors.MenuHighlight;
            lblPlayerOnClock.Location = new Point(3, 25);
            lblPlayerOnClock.Name = "lblPlayerOnClock";
            lblPlayerOnClock.Size = new Size(246, 35);
            lblPlayerOnClock.TabIndex = 2;
            lblPlayerOnClock.Text = "Choose Player";
            lblPlayerOnClock.TextAlign = ContentAlignment.MiddleCenter;
            lblPlayerOnClock.Click += lblPlayerOnClock_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 61);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 3;
            label1.Text = "Value: $";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(btnSaveNotes);
            panel2.Controls.Add(txtPlayerNotes);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(pnlOtherTeamsDraft);
            panel2.Controls.Add(btnWeDraftOnClock);
            panel2.Controls.Add(txtCost);
            panel2.Controls.Add(btnCancelOnClock);
            panel2.Controls.Add(lblPlayerOnClock);
            panel2.Controls.Add(lblPlayerOnClockValue);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(45, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 915);
            panel2.TabIndex = 4;
            // 
            // btnSaveNotes
            // 
            btnSaveNotes.BackColor = SystemColors.Info;
            btnSaveNotes.FlatStyle = FlatStyle.Flat;
            btnSaveNotes.Location = new Point(181, 117);
            btnSaveNotes.Name = "btnSaveNotes";
            btnSaveNotes.Size = new Size(42, 23);
            btnSaveNotes.TabIndex = 10;
            btnSaveNotes.Text = "Save";
            btnSaveNotes.UseVisualStyleBackColor = false;
            btnSaveNotes.Click += btnSaveNotes_Click;
            // 
            // txtPlayerNotes
            // 
            txtPlayerNotes.BackColor = SystemColors.Info;
            txtPlayerNotes.Location = new Point(17, 89);
            txtPlayerNotes.Multiline = true;
            txtPlayerNotes.Name = "txtPlayerNotes";
            txtPlayerNotes.Size = new Size(206, 51);
            txtPlayerNotes.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(17, 144);
            label12.Name = "label12";
            label12.Size = new Size(50, 25);
            label12.TabIndex = 8;
            label12.Text = "Cost";
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
            pnlOtherTeamsDraft.Location = new Point(3, 233);
            pnlOtherTeamsDraft.Name = "pnlOtherTeamsDraft";
            pnlOtherTeamsDraft.Size = new Size(246, 676);
            pnlOtherTeamsDraft.TabIndex = 7;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(14, 630);
            button14.Margin = new Padding(0, 0, 0, 10);
            button14.Name = "button14";
            button14.Size = new Size(206, 35);
            button14.TabIndex = 4;
            button14.Text = "Other Team Drafted";
            button14.UseVisualStyleBackColor = true;
            button14.Click += btnOtherDraftsOnClock_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(14, 585);
            button13.Margin = new Padding(0, 0, 0, 10);
            button13.Name = "button13";
            button13.Size = new Size(206, 35);
            button13.TabIndex = 4;
            button13.Text = "Other Team Drafted";
            button13.UseVisualStyleBackColor = true;
            button13.Click += btnOtherDraftsOnClock_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(14, 495);
            button11.Margin = new Padding(0, 0, 0, 10);
            button11.Name = "button11";
            button11.Size = new Size(206, 35);
            button11.TabIndex = 4;
            button11.Text = "Other Team Drafted";
            button11.UseVisualStyleBackColor = true;
            button11.Click += btnOtherDraftsOnClock_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(14, 450);
            button10.Margin = new Padding(0, 0, 0, 10);
            button10.Name = "button10";
            button10.Size = new Size(206, 35);
            button10.TabIndex = 4;
            button10.Text = "Other Team Drafted";
            button10.UseVisualStyleBackColor = true;
            button10.Click += btnOtherDraftsOnClock_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(14, 360);
            button8.Margin = new Padding(0, 0, 0, 10);
            button8.Name = "button8";
            button8.Size = new Size(206, 35);
            button8.TabIndex = 4;
            button8.Text = "Other Team Drafted";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnOtherDraftsOnClock_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(14, 315);
            button7.Margin = new Padding(0, 0, 0, 10);
            button7.Name = "button7";
            button7.Size = new Size(206, 35);
            button7.TabIndex = 4;
            button7.Text = "Other Team Drafted";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnOtherDraftsOnClock_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(14, 540);
            button12.Margin = new Padding(0, 0, 0, 10);
            button12.Name = "button12";
            button12.Size = new Size(206, 35);
            button12.TabIndex = 4;
            button12.Text = "Other Team Drafted";
            button12.UseVisualStyleBackColor = true;
            button12.Click += btnOtherDraftsOnClock_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(14, 225);
            button5.Margin = new Padding(0, 0, 0, 10);
            button5.Name = "button5";
            button5.Size = new Size(206, 35);
            button5.TabIndex = 4;
            button5.Text = "Other Team Drafted";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnOtherDraftsOnClock_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(14, 405);
            button9.Margin = new Padding(0, 0, 0, 10);
            button9.Name = "button9";
            button9.Size = new Size(206, 35);
            button9.TabIndex = 4;
            button9.Text = "Other Team Drafted";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btnOtherDraftsOnClock_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(14, 180);
            button4.Margin = new Padding(0, 0, 0, 10);
            button4.Name = "button4";
            button4.Size = new Size(206, 35);
            button4.TabIndex = 4;
            button4.Text = "Other Team Drafted";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnOtherDraftsOnClock_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(14, 270);
            button6.Margin = new Padding(0, 0, 0, 10);
            button6.Name = "button6";
            button6.Size = new Size(206, 35);
            button6.TabIndex = 4;
            button6.Text = "Other Team Drafted";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnOtherDraftsOnClock_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(14, 95);
            button2.Margin = new Padding(0, 0, 0, 10);
            button2.Name = "button2";
            button2.Size = new Size(206, 35);
            button2.TabIndex = 4;
            button2.Text = "Other Team Drafted";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnOtherDraftsOnClock_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(14, 135);
            button3.Margin = new Padding(0, 0, 0, 10);
            button3.Name = "button3";
            button3.Size = new Size(206, 35);
            button3.TabIndex = 4;
            button3.Text = "Other Team Drafted";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnOtherDraftsOnClock_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(14, 50);
            button1.Margin = new Padding(0, 0, 0, 10);
            button1.Name = "button1";
            button1.Size = new Size(206, 35);
            button1.TabIndex = 4;
            button1.Text = "Other Team Drafted";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnOtherDraftsOnClock_Click;
            // 
            // btnOtherDraftsOnClock
            // 
            btnOtherDraftsOnClock.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOtherDraftsOnClock.Location = new Point(14, 5);
            btnOtherDraftsOnClock.Margin = new Padding(0, 0, 0, 10);
            btnOtherDraftsOnClock.Name = "btnOtherDraftsOnClock";
            btnOtherDraftsOnClock.Size = new Size(206, 35);
            btnOtherDraftsOnClock.TabIndex = 4;
            btnOtherDraftsOnClock.Text = "Other Team Drafted";
            btnOtherDraftsOnClock.UseVisualStyleBackColor = true;
            btnOtherDraftsOnClock.Click += btnOtherDraftsOnClock_Click;
            // 
            // btnWeDraftOnClock
            // 
            btnWeDraftOnClock.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnWeDraftOnClock.Location = new Point(17, 175);
            btnWeDraftOnClock.Name = "btnWeDraftOnClock";
            btnWeDraftOnClock.Size = new Size(206, 52);
            btnWeDraftOnClock.TabIndex = 4;
            btnWeDraftOnClock.Text = "We Draft";
            btnWeDraftOnClock.UseVisualStyleBackColor = true;
            btnWeDraftOnClock.Click += btnWeDraftOnClock_Click;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(69, 146);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(154, 23);
            txtCost.TabIndex = 5;
            // 
            // btnCancelOnClock
            // 
            btnCancelOnClock.FlatAppearance.BorderSize = 0;
            btnCancelOnClock.FlatStyle = FlatStyle.Flat;
            btnCancelOnClock.Location = new Point(223, 1);
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
            lblPlayerOnClockValue.Location = new Point(92, 61);
            lblPlayerOnClockValue.Name = "lblPlayerOnClockValue";
            lblPlayerOnClockValue.Size = new Size(34, 25);
            lblPlayerOnClockValue.TabIndex = 3;
            lblPlayerOnClockValue.Text = "$$";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 255, 192);
            panel3.Controls.Add(lblDisplayKeeper);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(btnSetKeeper);
            panel3.Controls.Add(btnRemovePlayerFromTeam);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(lvTeamRoster);
            panel3.Controls.Add(lblDisplayTeamName);
            panel3.Location = new Point(919, 331);
            panel3.Name = "panel3";
            panel3.Size = new Size(531, 593);
            panel3.TabIndex = 5;
            // 
            // lblDisplayKeeper
            // 
            lblDisplayKeeper.AutoSize = true;
            lblDisplayKeeper.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisplayKeeper.Location = new Point(256, 122);
            lblDisplayKeeper.Name = "lblDisplayKeeper";
            lblDisplayKeeper.Size = new Size(41, 20);
            lblDisplayKeeper.TabIndex = 17;
            lblDisplayKeeper.Text = "None";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(204, 122);
            label14.Name = "label14";
            label14.Size = new Size(56, 20);
            label14.TabIndex = 17;
            label14.Text = "Keeper:";
            // 
            // btnSetKeeper
            // 
            btnSetKeeper.Location = new Point(183, 530);
            btnSetKeeper.Name = "btnSetKeeper";
            btnSetKeeper.Size = new Size(133, 23);
            btnSetKeeper.TabIndex = 16;
            btnSetKeeper.Text = "Set Keeper";
            btnSetKeeper.UseVisualStyleBackColor = true;
            btnSetKeeper.Click += btnSetKeeper_Click;
            // 
            // btnRemovePlayerFromTeam
            // 
            btnRemovePlayerFromTeam.Location = new Point(322, 530);
            btnRemovePlayerFromTeam.Name = "btnRemovePlayerFromTeam";
            btnRemovePlayerFromTeam.Size = new Size(205, 23);
            btnRemovePlayerFromTeam.TabIndex = 15;
            btnRemovePlayerFromTeam.Text = "Remove Player";
            btnRemovePlayerFromTeam.UseVisualStyleBackColor = true;
            btnRemovePlayerFromTeam.Click += btnRemovePlayerFromTeam_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(128, 255, 128);
            panel7.Controls.Add(lblRosterSpots);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(lblAvgCapPerSpotLeft);
            panel7.Controls.Add(label13);
            panel7.Location = new Point(274, 38);
            panel7.Name = "panel7";
            panel7.Size = new Size(230, 81);
            panel7.TabIndex = 14;
            // 
            // lblRosterSpots
            // 
            lblRosterSpots.AutoSize = true;
            lblRosterSpots.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRosterSpots.Location = new Point(144, 5);
            lblRosterSpots.Name = "lblRosterSpots";
            lblRosterSpots.Size = new Size(32, 22);
            lblRosterSpots.TabIndex = 8;
            lblRosterSpots.Text = "16";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 5);
            label11.Name = "label11";
            label11.Size = new Size(135, 22);
            label11.TabIndex = 8;
            label11.Text = "Empty Spots:";
            // 
            // lblAvgCapPerSpotLeft
            // 
            lblAvgCapPerSpotLeft.AutoSize = true;
            lblAvgCapPerSpotLeft.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvgCapPerSpotLeft.Location = new Point(151, 36);
            lblAvgCapPerSpotLeft.Name = "lblAvgCapPerSpotLeft";
            lblAvgCapPerSpotLeft.Size = new Size(16, 20);
            lblAvgCapPerSpotLeft.TabIndex = 11;
            lblAvgCapPerSpotLeft.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(3, 36);
            label13.Name = "label13";
            label13.Size = new Size(148, 20);
            label13.TabIndex = 11;
            label13.Text = "Avg Cap Per Player:  $";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(128, 255, 128);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(lblRosterValueDifference);
            panel6.Controls.Add(lblDisplayTeamBudget);
            panel6.Controls.Add(lblMaxBid);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(16, 39);
            panel6.Name = "panel6";
            panel6.Size = new Size(232, 80);
            panel6.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 4);
            label3.Name = "label3";
            label3.Size = new Size(133, 22);
            label3.TabIndex = 7;
            label3.Text = "Cap Space: $";
            // 
            // lblRosterValueDifference
            // 
            lblRosterValueDifference.AutoSize = true;
            lblRosterValueDifference.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRosterValueDifference.Location = new Point(159, 55);
            lblRosterValueDifference.Name = "lblRosterValueDifference";
            lblRosterValueDifference.Size = new Size(16, 20);
            lblRosterValueDifference.TabIndex = 12;
            lblRosterValueDifference.Text = "0";
            // 
            // lblDisplayTeamBudget
            // 
            lblDisplayTeamBudget.AutoSize = true;
            lblDisplayTeamBudget.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisplayTeamBudget.Location = new Point(156, 4);
            lblDisplayTeamBudget.Name = "lblDisplayTeamBudget";
            lblDisplayTeamBudget.Size = new Size(43, 22);
            lblDisplayTeamBudget.TabIndex = 7;
            lblDisplayTeamBudget.Text = "200";
            // 
            // lblMaxBid
            // 
            lblMaxBid.AutoSize = true;
            lblMaxBid.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaxBid.Location = new Point(159, 35);
            lblMaxBid.Name = "lblMaxBid";
            lblMaxBid.Size = new Size(16, 20);
            lblMaxBid.TabIndex = 11;
            lblMaxBid.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(76, 35);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 11;
            label2.Text = "Max Bid:  $";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(46, 55);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 11;
            label4.Text = "Roster Value:  $";
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
            panel4.Size = new Size(525, 51);
            panel4.TabIndex = 10;
            // 
            // lblKs
            // 
            lblKs.AutoSize = true;
            lblKs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblKs.Location = new Point(474, 15);
            lblKs.Name = "lblKs";
            lblKs.Size = new Size(19, 21);
            lblKs.TabIndex = 15;
            lblKs.Text = "0";
            // 
            // lblDEFs
            // 
            lblDEFs.AutoSize = true;
            lblDEFs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDEFs.Location = new Point(376, 15);
            lblDEFs.Name = "lblDEFs";
            lblDEFs.Size = new Size(19, 21);
            lblDEFs.TabIndex = 14;
            lblDEFs.Text = "0";
            // 
            // lblTEs
            // 
            lblTEs.AutoSize = true;
            lblTEs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTEs.Location = new Point(289, 16);
            lblTEs.Name = "lblTEs";
            lblTEs.Size = new Size(19, 21);
            lblTEs.TabIndex = 13;
            lblTEs.Text = "0";
            // 
            // lblWRs
            // 
            lblWRs.AutoSize = true;
            lblWRs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWRs.Location = new Point(202, 16);
            lblWRs.Name = "lblWRs";
            lblWRs.Size = new Size(19, 21);
            lblWRs.TabIndex = 12;
            lblWRs.Text = "0";
            // 
            // lblRBs
            // 
            lblRBs.AutoSize = true;
            lblRBs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRBs.Location = new Point(108, 15);
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
            label8.Location = new Point(289, 0);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 9;
            label8.Text = "TEs:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(471, 0);
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
            label9.Location = new Point(376, 0);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 9;
            label9.Text = "DEFs:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 0);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 9;
            label6.Text = "RBs:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(196, 1);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 9;
            label7.Text = "WRs:";
            // 
            // lvTeamRoster
            // 
            lvTeamRoster.Location = new Point(2, 200);
            lvTeamRoster.Name = "lvTeamRoster";
            lvTeamRoster.Size = new Size(526, 324);
            lvTeamRoster.TabIndex = 8;
            lvTeamRoster.UseCompatibleStateImageBehavior = false;
            lvTeamRoster.SelectedIndexChanged += lvTeamRoster_SelectedIndexChanged;
            // 
            // lblDisplayTeamName
            // 
            lblDisplayTeamName.Font = new Font("Rockwell Extra Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisplayTeamName.Location = new Point(3, 0);
            lblDisplayTeamName.Name = "lblDisplayTeamName";
            lblDisplayTeamName.Size = new Size(524, 38);
            lblDisplayTeamName.TabIndex = 6;
            lblDisplayTeamName.Text = "Disappointing Monday";
            lblDisplayTeamName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Enabled = false;
            webView.Location = new Point(311, 30);
            webView.Name = "webView";
            webView.Size = new Size(1177, 891);
            webView.TabIndex = 8;
            webView.Visible = false;
            webView.ZoomFactor = 1D;
            // 
            // btnCloseBrowser
            // 
            btnCloseBrowser.Enabled = false;
            btnCloseBrowser.Location = new Point(1123, 1);
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
            btnOpenSettings.Location = new Point(1014, 1);
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
            pnlTeamsToView.Location = new Point(919, 47);
            pnlTeamsToView.Name = "pnlTeamsToView";
            pnlTeamsToView.Size = new Size(570, 278);
            pnlTeamsToView.TabIndex = 11;
            // 
            // radioButton16
            // 
            radioButton16.Appearance = Appearance.Button;
            radioButton16.BackColor = Color.FromArgb(192, 192, 255);
            radioButton16.FlatAppearance.BorderSize = 0;
            radioButton16.FlatStyle = FlatStyle.Flat;
            radioButton16.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton16.Location = new Point(5, 210);
            radioButton16.Name = "radioButton16";
            radioButton16.Size = new Size(170, 30);
            radioButton16.TabIndex = 0;
            radioButton16.TabStop = true;
            radioButton16.Text = "radioButton1";
            radioButton16.TextAlign = ContentAlignment.MiddleCenter;
            radioButton16.UseVisualStyleBackColor = false;
            // 
            // radioButton15
            // 
            radioButton15.Appearance = Appearance.Button;
            radioButton15.BackColor = Color.FromArgb(192, 192, 255);
            radioButton15.FlatAppearance.BorderSize = 0;
            radioButton15.FlatStyle = FlatStyle.Flat;
            radioButton15.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton15.Location = new Point(5, 244);
            radioButton15.Margin = new Padding(0, 0, 0, 2);
            radioButton15.Name = "radioButton15";
            radioButton15.Size = new Size(170, 30);
            radioButton15.TabIndex = 0;
            radioButton15.TabStop = true;
            radioButton15.Text = "radioButton1";
            radioButton15.TextAlign = ContentAlignment.MiddleCenter;
            radioButton15.UseVisualStyleBackColor = false;
            // 
            // radioButton12
            // 
            radioButton12.Appearance = Appearance.Button;
            radioButton12.BackColor = Color.FromArgb(192, 192, 255);
            radioButton12.FlatAppearance.BorderSize = 0;
            radioButton12.FlatStyle = FlatStyle.Flat;
            radioButton12.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton12.Location = new Point(5, 108);
            radioButton12.Margin = new Padding(0, 0, 0, 2);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(170, 30);
            radioButton12.TabIndex = 0;
            radioButton12.TabStop = true;
            radioButton12.Text = "radioButton1";
            radioButton12.TextAlign = ContentAlignment.MiddleCenter;
            radioButton12.UseVisualStyleBackColor = false;
            // 
            // radioButton11
            // 
            radioButton11.Appearance = Appearance.Button;
            radioButton11.BackColor = Color.FromArgb(192, 192, 255);
            radioButton11.FlatAppearance.BorderSize = 0;
            radioButton11.FlatStyle = FlatStyle.Flat;
            radioButton11.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton11.Location = new Point(285, 244);
            radioButton11.Margin = new Padding(0, 0, 0, 2);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(170, 30);
            radioButton11.TabIndex = 0;
            radioButton11.TabStop = true;
            radioButton11.Text = "radioButton1";
            radioButton11.TextAlign = ContentAlignment.MiddleCenter;
            radioButton11.UseVisualStyleBackColor = false;
            // 
            // radioButton8
            // 
            radioButton8.Appearance = Appearance.Button;
            radioButton8.BackColor = Color.FromArgb(192, 192, 255);
            radioButton8.FlatAppearance.BorderSize = 0;
            radioButton8.FlatStyle = FlatStyle.Flat;
            radioButton8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton8.Location = new Point(285, 142);
            radioButton8.Margin = new Padding(0, 0, 0, 2);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(170, 30);
            radioButton8.TabIndex = 0;
            radioButton8.TabStop = true;
            radioButton8.Text = "radioButton1";
            radioButton8.TextAlign = ContentAlignment.MiddleCenter;
            radioButton8.UseVisualStyleBackColor = false;
            // 
            // radioButton14
            // 
            radioButton14.Appearance = Appearance.Button;
            radioButton14.BackColor = Color.FromArgb(192, 192, 255);
            radioButton14.FlatAppearance.BorderSize = 0;
            radioButton14.FlatStyle = FlatStyle.Flat;
            radioButton14.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton14.Location = new Point(285, 210);
            radioButton14.Margin = new Padding(0, 0, 0, 2);
            radioButton14.Name = "radioButton14";
            radioButton14.Size = new Size(170, 30);
            radioButton14.TabIndex = 0;
            radioButton14.TabStop = true;
            radioButton14.Text = "radioButton1";
            radioButton14.TextAlign = ContentAlignment.MiddleCenter;
            radioButton14.UseVisualStyleBackColor = false;
            // 
            // radioButton7
            // 
            radioButton7.Appearance = Appearance.Button;
            radioButton7.BackColor = Color.FromArgb(192, 192, 255);
            radioButton7.FlatAppearance.BorderSize = 0;
            radioButton7.FlatStyle = FlatStyle.Flat;
            radioButton7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton7.Location = new Point(285, 74);
            radioButton7.Margin = new Padding(0, 0, 0, 2);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(170, 30);
            radioButton7.TabIndex = 0;
            radioButton7.TabStop = true;
            radioButton7.Text = "radioButton1";
            radioButton7.TextAlign = ContentAlignment.MiddleCenter;
            radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton10
            // 
            radioButton10.Appearance = Appearance.Button;
            radioButton10.BackColor = Color.FromArgb(192, 192, 255);
            radioButton10.FlatAppearance.BorderSize = 0;
            radioButton10.FlatStyle = FlatStyle.Flat;
            radioButton10.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton10.Location = new Point(285, 176);
            radioButton10.Margin = new Padding(0, 0, 0, 2);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(170, 30);
            radioButton10.TabIndex = 0;
            radioButton10.TabStop = true;
            radioButton10.Text = "radioButton1";
            radioButton10.TextAlign = ContentAlignment.MiddleCenter;
            radioButton10.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.Appearance = Appearance.Button;
            radioButton4.BackColor = Color.FromArgb(192, 192, 255);
            radioButton4.FlatAppearance.BorderSize = 0;
            radioButton4.FlatStyle = FlatStyle.Flat;
            radioButton4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton4.Location = new Point(285, 108);
            radioButton4.Margin = new Padding(0, 0, 0, 2);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(170, 30);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton1";
            radioButton4.TextAlign = ContentAlignment.MiddleCenter;
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton13
            // 
            radioButton13.Appearance = Appearance.Button;
            radioButton13.BackColor = Color.FromArgb(192, 192, 255);
            radioButton13.FlatAppearance.BorderSize = 0;
            radioButton13.FlatStyle = FlatStyle.Flat;
            radioButton13.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton13.Location = new Point(5, 176);
            radioButton13.Margin = new Padding(0, 0, 0, 2);
            radioButton13.Name = "radioButton13";
            radioButton13.Size = new Size(170, 30);
            radioButton13.TabIndex = 0;
            radioButton13.TabStop = true;
            radioButton13.Text = "radioButton1";
            radioButton13.TextAlign = ContentAlignment.MiddleCenter;
            radioButton13.UseVisualStyleBackColor = false;
            // 
            // radioButton6
            // 
            radioButton6.Appearance = Appearance.Button;
            radioButton6.BackColor = Color.FromArgb(192, 192, 255);
            radioButton6.FlatAppearance.BorderSize = 0;
            radioButton6.FlatStyle = FlatStyle.Flat;
            radioButton6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton6.Location = new Point(5, 74);
            radioButton6.Margin = new Padding(0, 0, 0, 2);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(170, 30);
            radioButton6.TabIndex = 0;
            radioButton6.TabStop = true;
            radioButton6.Text = "radioButton1";
            radioButton6.TextAlign = ContentAlignment.MiddleCenter;
            radioButton6.UseVisualStyleBackColor = false;
            // 
            // radioButton9
            // 
            radioButton9.Appearance = Appearance.Button;
            radioButton9.BackColor = Color.FromArgb(192, 192, 255);
            radioButton9.FlatAppearance.BorderSize = 0;
            radioButton9.FlatStyle = FlatStyle.Flat;
            radioButton9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton9.Location = new Point(5, 142);
            radioButton9.Margin = new Padding(0, 0, 0, 2);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(170, 30);
            radioButton9.TabIndex = 0;
            radioButton9.TabStop = true;
            radioButton9.Text = "radioButton1";
            radioButton9.TextAlign = ContentAlignment.MiddleCenter;
            radioButton9.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.Appearance = Appearance.Button;
            radioButton3.BackColor = Color.FromArgb(192, 192, 255);
            radioButton3.FlatAppearance.BorderSize = 0;
            radioButton3.FlatStyle = FlatStyle.Flat;
            radioButton3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(5, 40);
            radioButton3.Margin = new Padding(0, 0, 0, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(170, 30);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton1";
            radioButton3.TextAlign = ContentAlignment.MiddleCenter;
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            radioButton5.Appearance = Appearance.Button;
            radioButton5.BackColor = Color.FromArgb(192, 192, 255);
            radioButton5.FlatAppearance.BorderSize = 0;
            radioButton5.FlatStyle = FlatStyle.Flat;
            radioButton5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton5.Location = new Point(285, 40);
            radioButton5.Margin = new Padding(0, 0, 0, 2);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(170, 30);
            radioButton5.TabIndex = 0;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton1";
            radioButton5.TextAlign = ContentAlignment.MiddleCenter;
            radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.Appearance = Appearance.Button;
            radioButton2.BackColor = Color.FromArgb(192, 192, 255);
            radioButton2.FlatAppearance.BorderSize = 0;
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(285, 6);
            radioButton2.Margin = new Padding(0, 0, 0, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(170, 30);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton1";
            radioButton2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.BackColor = Color.FromArgb(192, 192, 255);
            radioButton1.FlatAppearance.BorderSize = 0;
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(5, 6);
            radioButton1.Margin = new Padding(0, 0, 0, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(170, 30);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(314, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by Name";
            txtSearch.Size = new Size(237, 23);
            txtSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(566, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 23);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbDraftHistory
            // 
            cbDraftHistory.Appearance = Appearance.Button;
            cbDraftHistory.Location = new Point(664, 9);
            cbDraftHistory.Name = "cbDraftHistory";
            cbDraftHistory.Size = new Size(104, 24);
            cbDraftHistory.TabIndex = 16;
            cbDraftHistory.Text = "Draft History";
            cbDraftHistory.TextAlign = ContentAlignment.MiddleCenter;
            cbDraftHistory.UseVisualStyleBackColor = true;
            cbDraftHistory.CheckedChanged += cbDraftHistory_CheckedChanged;
            // 
            // cbKeepers
            // 
            cbKeepers.Appearance = Appearance.Button;
            cbKeepers.Location = new Point(774, 9);
            cbKeepers.Name = "cbKeepers";
            cbKeepers.Size = new Size(104, 24);
            cbKeepers.TabIndex = 17;
            cbKeepers.Text = "Keepers";
            cbKeepers.TextAlign = ContentAlignment.MiddleCenter;
            cbKeepers.UseVisualStyleBackColor = true;
            cbKeepers.CheckedChanged += cbKeepers_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1520, 951);
            Controls.Add(cbKeepers);
            Controls.Add(cbDraftHistory);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(pnlTeamsToView);
            Controls.Add(btnOpenSettings);
            Controls.Add(btnCloseBrowser);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lvUndraftedPlayers);
            Controls.Add(webView);
            Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlOtherTeamsDraft.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            pnlTeamsToView.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtCost;
        private Panel panel7;
        private Label lblRosterSpots;
        private Label label11;
        private Label lblAvgCapPerSpotLeft;
        private Label label13;
        private Panel panel6;
        private Label lblRosterValueDifference;
        private Label label4;
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
        private Label label2;
        private Label lblMaxBid;
        private Button btnRemovePlayerFromTeam;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnSetKeeper;
        private Label lblDisplayKeeper;
        private Label label14;
        private CheckBox cbDraftHistory;
        private CheckBox cbKeepers;
        private Button btnSaveNotes;
        private TextBox txtPlayerNotes;
        private Label label12;
    }
}