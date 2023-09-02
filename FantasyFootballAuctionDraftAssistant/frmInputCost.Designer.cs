namespace FantasyFootballAuctionDraftAssistant
{
    partial class frmInputCost
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
            lblWarningText = new Label();
            txtPlayerCost = new TextBox();
            btnDraft = new Button();
            btnCancel = new Button();
            lblPlayerName = new Label();
            label3 = new Label();
            lblTeamName = new Label();
            lblMaxBid = new Label();
            SuspendLayout();
            // 
            // lblWarningText
            // 
            lblWarningText.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblWarningText.ForeColor = Color.White;
            lblWarningText.Location = new Point(-1, 40);
            lblWarningText.Margin = new Padding(4, 0, 4, 0);
            lblWarningText.Name = "lblWarningText";
            lblWarningText.Size = new Size(324, 23);
            lblWarningText.TabIndex = 0;
            lblWarningText.Text = "Winning Bid for:";
            lblWarningText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPlayerCost
            // 
            txtPlayerCost.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlayerCost.Location = new Point(101, 110);
            txtPlayerCost.Margin = new Padding(4);
            txtPlayerCost.Name = "txtPlayerCost";
            txtPlayerCost.Size = new Size(80, 39);
            txtPlayerCost.TabIndex = 1;
            // 
            // btnDraft
            // 
            btnDraft.BackColor = Color.FromArgb(192, 255, 192);
            btnDraft.FlatAppearance.BorderSize = 0;
            btnDraft.FlatStyle = FlatStyle.Flat;
            btnDraft.Location = new Point(12, 154);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(298, 32);
            btnDraft.TabIndex = 2;
            btnDraft.Text = "Draft!";
            btnDraft.UseVisualStyleBackColor = false;
            btnDraft.Click += btnDraft_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 192, 192);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(12, 192);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(298, 32);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblPlayerName
            // 
            lblPlayerName.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerName.ForeColor = Color.White;
            lblPlayerName.Location = new Point(-1, 61);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(324, 45);
            lblPlayerName.TabIndex = 3;
            lblPlayerName.Text = "Player Name Displayed";
            lblPlayerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(79, 116);
            label3.Name = "label3";
            label3.Size = new Size(26, 29);
            label3.TabIndex = 4;
            label3.Text = "$";
            // 
            // lblTeamName
            // 
            lblTeamName.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTeamName.ForeColor = Color.FromArgb(255, 128, 128);
            lblTeamName.Location = new Point(12, 6);
            lblTeamName.Name = "lblTeamName";
            lblTeamName.Size = new Size(298, 32);
            lblTeamName.TabIndex = 5;
            lblTeamName.Text = "label1";
            lblTeamName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaxBid
            // 
            lblMaxBid.AutoSize = true;
            lblMaxBid.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaxBid.ForeColor = Color.White;
            lblMaxBid.Location = new Point(188, 116);
            lblMaxBid.Name = "lblMaxBid";
            lblMaxBid.Size = new Size(91, 23);
            lblMaxBid.TabIndex = 6;
            lblMaxBid.Text = "($200 Max)";
            // 
            // frmInputCost
            // 
            AcceptButton = btnDraft;
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 54, 100);
            CancelButton = btnCancel;
            ClientSize = new Size(322, 246);
            Controls.Add(lblMaxBid);
            Controls.Add(lblTeamName);
            Controls.Add(lblPlayerName);
            Controls.Add(btnCancel);
            Controls.Add(btnDraft);
            Controls.Add(txtPlayerCost);
            Controls.Add(lblWarningText);
            Controls.Add(label3);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmInputCost";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInputCost";
            Load += frmInputCost_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWarningText;
        private TextBox txtPlayerCost;
        private Button btnDraft;
        private Button btnCancel;
        private Label lblPlayerName;
        private Label label3;
        private Label lblTeamName;
        private Label lblMaxBid;
    }
}