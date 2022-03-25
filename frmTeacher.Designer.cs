
namespace HighSchoolGroupProject
{
    partial class frmTeacher
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
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSeats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGrades
            // 
            this.btnGrades.Location = new System.Drawing.Point(317, 83);
            this.btnGrades.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(176, 66);
            this.btnGrades.TabIndex = 5;
            this.btnGrades.Text = "Grades";
            this.btnGrades.UseVisualStyleBackColor = true;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(457, 224);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(128, 36);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSeats
            // 
            this.btnSeats.Location = new System.Drawing.Point(108, 83);
            this.btnSeats.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSeats.Name = "btnSeats";
            this.btnSeats.Size = new System.Drawing.Size(176, 66);
            this.btnSeats.TabIndex = 3;
            this.btnSeats.Text = "Seating Chart";
            this.btnSeats.UseVisualStyleBackColor = true;
            this.btnSeats.Click += new System.EventHandler(this.btnSeats_Click);
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 277);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSeats);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTeacher";
            this.Text = "frmTeacher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSeats;
    }
}