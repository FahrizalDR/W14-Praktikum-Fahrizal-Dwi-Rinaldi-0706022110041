
namespace W14Praktikum
{
    partial class Team
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
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelManager = new System.Windows.Forms.Label();
            this.labelStadium = new System.Windows.Forms.Label();
            this.labelTopScorer = new System.Windows.Forms.Label();
            this.labelWorstDicipline = new System.Windows.Forms.Label();
            this.OutputTeamName = new System.Windows.Forms.Label();
            this.OutputManager = new System.Windows.Forms.Label();
            this.OutputWorstDicipline = new System.Windows.Forms.Label();
            this.OutputStadium = new System.Windows.Forms.Label();
            this.OutputTopScorer = new System.Windows.Forms.Label();
            this.dataGridViewMatch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(67, 33);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 51);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(157, 33);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 51);
            this.buttonPrevious.TabIndex = 1;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(248, 33);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 51);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(339, 33);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 51);
            this.buttonLast.TabIndex = 2;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Location = new System.Drawing.Point(64, 115);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(129, 17);
            this.labelTeamName.TabIndex = 4;
            this.labelTeamName.Text = "Team Name          :";
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Location = new System.Drawing.Point(64, 151);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(128, 17);
            this.labelManager.TabIndex = 5;
            this.labelManager.Text = "Manager               :";
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(64, 192);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(127, 17);
            this.labelStadium.TabIndex = 7;
            this.labelStadium.Text = "Stadium                :";
            // 
            // labelTopScorer
            // 
            this.labelTopScorer.AutoSize = true;
            this.labelTopScorer.Location = new System.Drawing.Point(64, 230);
            this.labelTopScorer.Name = "labelTopScorer";
            this.labelTopScorer.Size = new System.Drawing.Size(127, 17);
            this.labelTopScorer.TabIndex = 6;
            this.labelTopScorer.Text = "Top Scorer           :";
            // 
            // labelWorstDicipline
            // 
            this.labelWorstDicipline.AutoSize = true;
            this.labelWorstDicipline.Location = new System.Drawing.Point(64, 272);
            this.labelWorstDicipline.Name = "labelWorstDicipline";
            this.labelWorstDicipline.Size = new System.Drawing.Size(126, 17);
            this.labelWorstDicipline.TabIndex = 8;
            this.labelWorstDicipline.Text = "Worst Dicipline     :";
            // 
            // OutputTeamName
            // 
            this.OutputTeamName.AutoSize = true;
            this.OutputTeamName.Location = new System.Drawing.Point(199, 115);
            this.OutputTeamName.Name = "OutputTeamName";
            this.OutputTeamName.Size = new System.Drawing.Size(108, 17);
            this.OutputTeamName.TabIndex = 9;
            this.OutputTeamName.Text = ".........................";
            // 
            // OutputManager
            // 
            this.OutputManager.AutoSize = true;
            this.OutputManager.Location = new System.Drawing.Point(199, 151);
            this.OutputManager.Name = "OutputManager";
            this.OutputManager.Size = new System.Drawing.Size(108, 17);
            this.OutputManager.TabIndex = 10;
            this.OutputManager.Text = ".........................";
            // 
            // OutputWorstDicipline
            // 
            this.OutputWorstDicipline.AutoSize = true;
            this.OutputWorstDicipline.Location = new System.Drawing.Point(199, 272);
            this.OutputWorstDicipline.Name = "OutputWorstDicipline";
            this.OutputWorstDicipline.Size = new System.Drawing.Size(108, 17);
            this.OutputWorstDicipline.TabIndex = 13;
            this.OutputWorstDicipline.Text = ".........................";
            // 
            // OutputStadium
            // 
            this.OutputStadium.AutoSize = true;
            this.OutputStadium.Location = new System.Drawing.Point(199, 192);
            this.OutputStadium.Name = "OutputStadium";
            this.OutputStadium.Size = new System.Drawing.Size(108, 17);
            this.OutputStadium.TabIndex = 12;
            this.OutputStadium.Text = ".........................";
            // 
            // OutputTopScorer
            // 
            this.OutputTopScorer.AutoSize = true;
            this.OutputTopScorer.Location = new System.Drawing.Point(199, 230);
            this.OutputTopScorer.Name = "OutputTopScorer";
            this.OutputTopScorer.Size = new System.Drawing.Size(108, 17);
            this.OutputTopScorer.TabIndex = 11;
            this.OutputTopScorer.Text = ".........................";
            // 
            // dataGridViewMatch
            // 
            this.dataGridViewMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatch.Location = new System.Drawing.Point(67, 327);
            this.dataGridViewMatch.Name = "dataGridViewMatch";
            this.dataGridViewMatch.RowHeadersWidth = 51;
            this.dataGridViewMatch.RowTemplate.Height = 24;
            this.dataGridViewMatch.Size = new System.Drawing.Size(702, 258);
            this.dataGridViewMatch.TabIndex = 14;
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.dataGridViewMatch);
            this.Controls.Add(this.OutputWorstDicipline);
            this.Controls.Add(this.OutputStadium);
            this.Controls.Add(this.OutputTopScorer);
            this.Controls.Add(this.OutputManager);
            this.Controls.Add(this.OutputTeamName);
            this.Controls.Add(this.labelWorstDicipline);
            this.Controls.Add(this.labelStadium);
            this.Controls.Add(this.labelTopScorer);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonFirst);
            this.Name = "Team";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.Team_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.Label labelStadium;
        private System.Windows.Forms.Label labelTopScorer;
        private System.Windows.Forms.Label labelWorstDicipline;
        private System.Windows.Forms.Label OutputTeamName;
        private System.Windows.Forms.Label OutputManager;
        private System.Windows.Forms.Label OutputWorstDicipline;
        private System.Windows.Forms.Label OutputStadium;
        private System.Windows.Forms.Label OutputTopScorer;
        private System.Windows.Forms.DataGridView dataGridViewMatch;
    }
}

