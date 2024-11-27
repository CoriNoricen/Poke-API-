namespace PokéAPI_3
{
    partial class EndScreen
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
            this.pkmnDisplaydgv = new System.Windows.Forms.DataGridView();
            this.P1Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P2Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayAgainbtn = new System.Windows.Forms.Button();
            this.Quitbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Viewbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pkmnDisplaydgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pkmnDisplaydgv
            // 
            this.pkmnDisplaydgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pkmnDisplaydgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P1Team,
            this.P2Team});
            this.pkmnDisplaydgv.Location = new System.Drawing.Point(369, 12);
            this.pkmnDisplaydgv.Name = "pkmnDisplaydgv";
            this.pkmnDisplaydgv.RowHeadersWidth = 51;
            this.pkmnDisplaydgv.RowTemplate.Height = 24;
            this.pkmnDisplaydgv.Size = new System.Drawing.Size(419, 426);
            this.pkmnDisplaydgv.TabIndex = 0;
            // 
            // P1Team
            // 
            this.P1Team.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.P1Team.HeaderText = "PLAYER 1 Team";
            this.P1Team.MinimumWidth = 6;
            this.P1Team.Name = "P1Team";
            // 
            // P2Team
            // 
            this.P2Team.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.P2Team.HeaderText = "PLAYER 2 Team";
            this.P2Team.MinimumWidth = 6;
            this.P2Team.Name = "P2Team";
            // 
            // PlayAgainbtn
            // 
            this.PlayAgainbtn.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgainbtn.Location = new System.Drawing.Point(12, 12);
            this.PlayAgainbtn.Name = "PlayAgainbtn";
            this.PlayAgainbtn.Size = new System.Drawing.Size(342, 87);
            this.PlayAgainbtn.TabIndex = 1;
            this.PlayAgainbtn.Text = "Play Again";
            this.PlayAgainbtn.UseVisualStyleBackColor = true;
            this.PlayAgainbtn.Click += new System.EventHandler(this.PlayAgainbtn_Click);
            // 
            // Quitbtn
            // 
            this.Quitbtn.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitbtn.Location = new System.Drawing.Point(12, 125);
            this.Quitbtn.Name = "Quitbtn";
            this.Quitbtn.Size = new System.Drawing.Size(342, 87);
            this.Quitbtn.TabIndex = 2;
            this.Quitbtn.Text = "Quit App";
            this.Quitbtn.UseVisualStyleBackColor = true;
            this.Quitbtn.Click += new System.EventHandler(this.Quitbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.Location = new System.Drawing.Point(12, 238);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(342, 87);
            this.Savebtn.TabIndex = 3;
            this.Savebtn.Text = "Save Results";
            this.Savebtn.UseVisualStyleBackColor = true;
            // 
            // Viewbtn
            // 
            this.Viewbtn.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewbtn.Location = new System.Drawing.Point(12, 351);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(342, 87);
            this.Viewbtn.TabIndex = 4;
            this.Viewbtn.Text = "View Past Results";
            this.Viewbtn.UseVisualStyleBackColor = true;
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Viewbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Quitbtn);
            this.Controls.Add(this.PlayAgainbtn);
            this.Controls.Add(this.pkmnDisplaydgv);
            this.Name = "EndScreen";
            this.Text = "EndScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pkmnDisplaydgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pkmnDisplaydgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn P1Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn P2Team;
        private System.Windows.Forms.Button PlayAgainbtn;
        private System.Windows.Forms.Button Quitbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Viewbtn;
    }
}