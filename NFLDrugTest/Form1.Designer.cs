namespace NFLDrugTest
{
    partial class Form1
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
            this.NFLDrug = new System.Windows.Forms.Label();
            this.NumOf = new System.Windows.Forms.Label();
            this.NumCandidates = new System.Windows.Forms.TextBox();
            this.Selections = new System.Windows.Forms.TextBox();
            this.Selection = new System.Windows.Forms.GroupBox();
            this.Select = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Selection.SuspendLayout();
            this.SuspendLayout();
            // 
            // NFLDrug
            // 
            this.NFLDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NFLDrug.Location = new System.Drawing.Point(133, 61);
            this.NFLDrug.Name = "NFLDrug";
            this.NFLDrug.Size = new System.Drawing.Size(488, 87);
            this.NFLDrug.TabIndex = 0;
            this.NFLDrug.Text = "NFL Drug Testing Program";
            // 
            // NumOf
            // 
            this.NumOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOf.Location = new System.Drawing.Point(59, 224);
            this.NumOf.Name = "NumOf";
            this.NumOf.Size = new System.Drawing.Size(185, 34);
            this.NumOf.TabIndex = 1;
            this.NumOf.Text = "No. of Candidates";
            // 
            // NumCandidates
            // 
            this.NumCandidates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCandidates.Location = new System.Drawing.Point(286, 212);
            this.NumCandidates.Multiline = true;
            this.NumCandidates.Name = "NumCandidates";
            this.NumCandidates.Size = new System.Drawing.Size(78, 46);
            this.NumCandidates.TabIndex = 2;
            this.NumCandidates.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumCandidates.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumCandidates_KeyPress);
            // 
            // Selections
            // 
            this.Selections.Location = new System.Drawing.Point(27, 35);
            this.Selections.Multiline = true;
            this.Selections.Name = "Selections";
            this.Selections.Size = new System.Drawing.Size(189, 307);
            this.Selections.TabIndex = 3;
            // 
            // Selection
            // 
            this.Selection.Controls.Add(this.Selections);
            this.Selection.Location = new System.Drawing.Point(455, 224);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(244, 362);
            this.Selection.TabIndex = 4;
            this.Selection.TabStop = false;
            // 
            // Select
            // 
            this.Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select.Location = new System.Drawing.Point(487, 192);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(145, 29);
            this.Select.TabIndex = 5;
            this.Select.Text = "Selection List";
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(54, 504);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(107, 42);
            this.Start.TabIndex = 6;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(188, 504);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(107, 42);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(326, 504);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(107, 42);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 668);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.NumCandidates);
            this.Controls.Add(this.NumOf);
            this.Controls.Add(this.NFLDrug);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Selection.ResumeLayout(false);
            this.Selection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NFLDrug;
        private System.Windows.Forms.Label NumOf;
        private System.Windows.Forms.TextBox NumCandidates;
        private System.Windows.Forms.TextBox Selections;
        private System.Windows.Forms.GroupBox Selection;
        private System.Windows.Forms.Label Select;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Exit;
    }
}

