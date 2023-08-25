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
            txtCost = new TextBox();
            btnCancelOnClock = new Button();
            btnWeDraftOnClock = new Button();
            btnOtherDraftsOnClock = new Button();
            lblPlayerOnClockValue = new Label();
            panel3 = new Panel();
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
            lblDisplayTeamBudget = new Label();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            rdoDrafted = new RadioButton();
            rdoFreeAgents = new RadioButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // lvUndraftedPlayers
            // 
            lvUndraftedPlayers.Location = new Point(617, 182);
            lvUndraftedPlayers.Name = "lvUndraftedPlayers";
            lvUndraftedPlayers.Size = new Size(639, 564);
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
            panel1.Location = new Point(617, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 30);
            panel1.TabIndex = 1;
            // 
            // cbK
            // 
            cbK.Appearance = Appearance.Button;
            cbK.Location = new Point(549, 3);
            cbK.Name = "cbK";
            cbK.Size = new Size(85, 24);
            cbK.TabIndex = 0;
            cbK.Text = "K";
            cbK.TextAlign = ContentAlignment.MiddleCenter;
            cbK.UseVisualStyleBackColor = true;
            cbK.CheckedChanged += cbK_CheckedChanged;
            // 
            // cbDEF
            // 
            cbDEF.Appearance = Appearance.Button;
            cbDEF.Location = new Point(458, 3);
            cbDEF.Name = "cbDEF";
            cbDEF.Size = new Size(85, 24);
            cbDEF.TabIndex = 0;
            cbDEF.Text = "DEF";
            cbDEF.TextAlign = ContentAlignment.MiddleCenter;
            cbDEF.UseVisualStyleBackColor = true;
            cbDEF.CheckedChanged += cbDEF_CheckedChanged;
            // 
            // cbTE
            // 
            cbTE.Appearance = Appearance.Button;
            cbTE.Location = new Point(367, 3);
            cbTE.Name = "cbTE";
            cbTE.Size = new Size(85, 24);
            cbTE.TabIndex = 0;
            cbTE.Text = "TE";
            cbTE.TextAlign = ContentAlignment.MiddleCenter;
            cbTE.UseVisualStyleBackColor = true;
            cbTE.CheckedChanged += cbTE_CheckedChanged;
            // 
            // cbWR
            // 
            cbWR.Appearance = Appearance.Button;
            cbWR.Location = new Point(276, 3);
            cbWR.Name = "cbWR";
            cbWR.Size = new Size(85, 24);
            cbWR.TabIndex = 0;
            cbWR.Text = "WR";
            cbWR.TextAlign = ContentAlignment.MiddleCenter;
            cbWR.UseVisualStyleBackColor = true;
            cbWR.CheckedChanged += cbWR_CheckedChanged;
            // 
            // cbRB
            // 
            cbRB.Appearance = Appearance.Button;
            cbRB.Location = new Point(185, 3);
            cbRB.Name = "cbRB";
            cbRB.Size = new Size(85, 24);
            cbRB.TabIndex = 0;
            cbRB.Text = "RB";
            cbRB.TextAlign = ContentAlignment.MiddleCenter;
            cbRB.UseVisualStyleBackColor = true;
            cbRB.CheckedChanged += cbRB_CheckedChanged;
            // 
            // cbQB
            // 
            cbQB.Appearance = Appearance.Button;
            cbQB.Location = new Point(94, 3);
            cbQB.Name = "cbQB";
            cbQB.Size = new Size(85, 24);
            cbQB.TabIndex = 0;
            cbQB.Text = "QB";
            cbQB.TextAlign = ContentAlignment.MiddleCenter;
            cbQB.UseVisualStyleBackColor = true;
            cbQB.CheckedChanged += cbQB_CheckedChanged;
            // 
            // cbAllPositions
            // 
            cbAllPositions.Appearance = Appearance.Button;
            cbAllPositions.Location = new Point(3, 3);
            cbAllPositions.Name = "cbAllPositions";
            cbAllPositions.Size = new Size(85, 24);
            cbAllPositions.TabIndex = 0;
            cbAllPositions.Text = "All";
            cbAllPositions.TextAlign = ContentAlignment.MiddleCenter;
            cbAllPositions.UseVisualStyleBackColor = true;
            cbAllPositions.CheckedChanged += cbAllPositions_CheckedChanged;
            // 
            // lblPlayerOnClock
            // 
            lblPlayerOnClock.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerOnClock.Location = new Point(311, 0);
            lblPlayerOnClock.Name = "lblPlayerOnClock";
            lblPlayerOnClock.Size = new Size(500, 35);
            lblPlayerOnClock.TabIndex = 2;
            lblPlayerOnClock.Text = "Choose Player to be on the clock";
            lblPlayerOnClock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(480, 35);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 3;
            label1.Text = "Value:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(txtCost);
            panel2.Controls.Add(btnCancelOnClock);
            panel2.Controls.Add(btnWeDraftOnClock);
            panel2.Controls.Add(btnOtherDraftsOnClock);
            panel2.Controls.Add(lblPlayerOnClock);
            panel2.Controls.Add(lblPlayerOnClockValue);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(33, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1247, 100);
            panel2.TabIndex = 4;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(869, 6);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(137, 23);
            txtCost.TabIndex = 5;
            // 
            // btnCancelOnClock
            // 
            btnCancelOnClock.Location = new Point(796, 6);
            btnCancelOnClock.Name = "btnCancelOnClock";
            btnCancelOnClock.Size = new Size(67, 23);
            btnCancelOnClock.TabIndex = 4;
            btnCancelOnClock.Text = "Cancel";
            btnCancelOnClock.UseVisualStyleBackColor = true;
            btnCancelOnClock.Click += btnCancelOnClock_Click;
            // 
            // btnWeDraftOnClock
            // 
            btnWeDraftOnClock.Location = new Point(869, 35);
            btnWeDraftOnClock.Name = "btnWeDraftOnClock";
            btnWeDraftOnClock.Size = new Size(137, 23);
            btnWeDraftOnClock.TabIndex = 4;
            btnWeDraftOnClock.Text = "We Draft";
            btnWeDraftOnClock.UseVisualStyleBackColor = true;
            btnWeDraftOnClock.Click += btnWeDraftOnClock_Click;
            // 
            // btnOtherDraftsOnClock
            // 
            btnOtherDraftsOnClock.Location = new Point(869, 64);
            btnOtherDraftsOnClock.Name = "btnOtherDraftsOnClock";
            btnOtherDraftsOnClock.Size = new Size(137, 23);
            btnOtherDraftsOnClock.TabIndex = 4;
            btnOtherDraftsOnClock.Text = "Other Team Drafted";
            btnOtherDraftsOnClock.UseVisualStyleBackColor = true;
            btnOtherDraftsOnClock.Click += btnOtherDraftsOnClock_Click;
            // 
            // lblPlayerOnClockValue
            // 
            lblPlayerOnClockValue.AutoSize = true;
            lblPlayerOnClockValue.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerOnClockValue.Location = new Point(550, 35);
            lblPlayerOnClockValue.Name = "lblPlayerOnClockValue";
            lblPlayerOnClockValue.Size = new Size(34, 25);
            lblPlayerOnClockValue.TabIndex = 3;
            lblPlayerOnClockValue.Text = "$$";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 255, 192);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(lvTeamRoster);
            panel3.Controls.Add(lblDisplayTeamBudget);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(33, 182);
            panel3.Name = "panel3";
            panel3.Size = new Size(513, 564);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
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
            panel4.Location = new Point(15, 125);
            panel4.Name = "panel4";
            panel4.Size = new Size(477, 51);
            panel4.TabIndex = 10;
            // 
            // lblKs
            // 
            lblKs.AutoSize = true;
            lblKs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblKs.Location = new Point(421, 15);
            lblKs.Name = "lblKs";
            lblKs.Size = new Size(19, 21);
            lblKs.TabIndex = 15;
            lblKs.Text = "0";
            // 
            // lblDEFs
            // 
            lblDEFs.AutoSize = true;
            lblDEFs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDEFs.Location = new Point(339, 15);
            lblDEFs.Name = "lblDEFs";
            lblDEFs.Size = new Size(19, 21);
            lblDEFs.TabIndex = 14;
            lblDEFs.Text = "0";
            // 
            // lblTEs
            // 
            lblTEs.AutoSize = true;
            lblTEs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTEs.Location = new Point(265, 15);
            lblTEs.Name = "lblTEs";
            lblTEs.Size = new Size(19, 21);
            lblTEs.TabIndex = 13;
            lblTEs.Text = "0";
            // 
            // lblWRs
            // 
            lblWRs.AutoSize = true;
            lblWRs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWRs.Location = new Point(185, 15);
            lblWRs.Name = "lblWRs";
            lblWRs.Size = new Size(19, 21);
            lblWRs.TabIndex = 12;
            lblWRs.Text = "0";
            // 
            // lblRBs
            // 
            lblRBs.AutoSize = true;
            lblRBs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRBs.Location = new Point(109, 15);
            lblRBs.Name = "lblRBs";
            lblRBs.Size = new Size(19, 21);
            lblRBs.TabIndex = 11;
            lblRBs.Text = "0";
            // 
            // lblQBs
            // 
            lblQBs.AutoSize = true;
            lblQBs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQBs.Location = new Point(41, 15);
            lblQBs.Name = "lblQBs";
            lblQBs.Size = new Size(19, 21);
            lblQBs.TabIndex = 10;
            lblQBs.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(265, 0);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 9;
            label8.Text = "TEs:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(421, 0);
            label10.Name = "label10";
            label10.Size = new Size(22, 15);
            label10.TabIndex = 9;
            label10.Text = "Ks:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 0);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 9;
            label5.Text = "QBs:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(339, 0);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 9;
            label9.Text = "DEFs:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 0);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 9;
            label6.Text = "RBs:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(185, 0);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 9;
            label7.Text = "WRs:";
            // 
            // lvTeamRoster
            // 
            lvTeamRoster.Location = new Point(15, 182);
            lvTeamRoster.Name = "lvTeamRoster";
            lvTeamRoster.Size = new Size(477, 360);
            lvTeamRoster.TabIndex = 8;
            lvTeamRoster.UseCompatibleStateImageBehavior = false;
            // 
            // lblDisplayTeamBudget
            // 
            lblDisplayTeamBudget.AutoSize = true;
            lblDisplayTeamBudget.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisplayTeamBudget.Location = new Point(305, 38);
            lblDisplayTeamBudget.Name = "lblDisplayTeamBudget";
            lblDisplayTeamBudget.Size = new Size(37, 21);
            lblDisplayTeamBudget.TabIndex = 7;
            lblDisplayTeamBudget.Text = "200";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(150, 38);
            label3.Name = "label3";
            label3.Size = new Size(149, 21);
            label3.TabIndex = 7;
            label3.Text = "Remaining Budget:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(150, 0);
            label2.Name = "label2";
            label2.Size = new Size(208, 25);
            label2.TabIndex = 6;
            label2.Text = "Disappointing Monday";
            // 
            // panel5
            // 
            panel5.Controls.Add(rdoDrafted);
            panel5.Controls.Add(rdoFreeAgents);
            panel5.Location = new Point(620, 115);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 758);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lvUndraftedPlayers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
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
        private Label label2;
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
    }
}