
namespace GameApplication
{
    partial class form_FindShortestPath
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
            this.label_FindShortestPath = new System.Windows.Forms.Label();
            this.button_Previous = new System.Windows.Forms.Button();
            this.groupBox_PlayGame = new System.Windows.Forms.GroupBox();
            this.button_PlayAgain = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Check = new System.Windows.Forms.Button();
            this.label_Answer = new System.Windows.Forms.Label();
            this.groupBox_PlayerDetails = new System.Windows.Forms.GroupBox();
            this.textBox_PlayerName = new System.Windows.Forms.TextBox();
            this.label_PlayerName = new System.Windows.Forms.Label();
            this.textBox_SourceVertex = new System.Windows.Forms.TextBox();
            this.label_SourceVertex = new System.Windows.Forms.Label();
            this.panel_RandomNumbers = new System.Windows.Forms.Panel();
            this.label_Note = new System.Windows.Forms.Label();
            this.groupBox_PlayGame.SuspendLayout();
            this.groupBox_PlayerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_FindShortestPath
            // 
            this.label_FindShortestPath.AutoSize = true;
            this.label_FindShortestPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FindShortestPath.Location = new System.Drawing.Point(847, 21);
            this.label_FindShortestPath.Name = "label_FindShortestPath";
            this.label_FindShortestPath.Size = new System.Drawing.Size(268, 32);
            this.label_FindShortestPath.TabIndex = 19;
            this.label_FindShortestPath.Text = "Find Shortest Path";
            // 
            // button_Previous
            // 
            this.button_Previous.BackgroundImage = global::GameApplication.Properties.Resources._93634;
            this.button_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Previous.Location = new System.Drawing.Point(12, 14);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(49, 39);
            this.button_Previous.TabIndex = 29;
            this.button_Previous.UseVisualStyleBackColor = true;
            this.button_Previous.Click += new System.EventHandler(this.button_Previous_Click);
            // 
            // groupBox_PlayGame
            // 
            this.groupBox_PlayGame.Controls.Add(this.button_PlayAgain);
            this.groupBox_PlayGame.Controls.Add(this.listBox1);
            this.groupBox_PlayGame.Controls.Add(this.button_Add);
            this.groupBox_PlayGame.Controls.Add(this.button_Start);
            this.groupBox_PlayGame.Controls.Add(this.textBox_Answer);
            this.groupBox_PlayGame.Controls.Add(this.button_Save);
            this.groupBox_PlayGame.Controls.Add(this.button_Check);
            this.groupBox_PlayGame.Controls.Add(this.label_Answer);
            this.groupBox_PlayGame.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox_PlayGame.Location = new System.Drawing.Point(1370, 335);
            this.groupBox_PlayGame.Name = "groupBox_PlayGame";
            this.groupBox_PlayGame.Size = new System.Drawing.Size(497, 422);
            this.groupBox_PlayGame.TabIndex = 48;
            this.groupBox_PlayGame.TabStop = false;
            this.groupBox_PlayGame.Text = "Play Game";
            // 
            // button_PlayAgain
            // 
            this.button_PlayAgain.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PlayAgain.Location = new System.Drawing.Point(280, 67);
            this.button_PlayAgain.Name = "button_PlayAgain";
            this.button_PlayAgain.Size = new System.Drawing.Size(193, 55);
            this.button_PlayAgain.TabIndex = 48;
            this.button_PlayAgain.Text = "Play Again";
            this.button_PlayAgain.UseVisualStyleBackColor = true;
            this.button_PlayAgain.Click += new System.EventHandler(this.button_PlayAgain_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe Print", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J"});
            this.listBox1.Location = new System.Drawing.Point(150, 175);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(40, 214);
            this.listBox1.TabIndex = 47;
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(320, 175);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(153, 55);
            this.button_Add.TabIndex = 46;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.Location = new System.Drawing.Point(24, 67);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(153, 55);
            this.button_Start.TabIndex = 45;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Answer.Location = new System.Drawing.Point(210, 175);
            this.textBox_Answer.Multiline = true;
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(79, 214);
            this.textBox_Answer.TabIndex = 33;
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(320, 334);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(153, 55);
            this.button_Save.TabIndex = 44;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Check
            // 
            this.button_Check.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Check.Location = new System.Drawing.Point(320, 255);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(153, 55);
            this.button_Check.TabIndex = 43;
            this.button_Check.Text = "Check";
            this.button_Check.UseVisualStyleBackColor = true;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
            // 
            // label_Answer
            // 
            this.label_Answer.AutoSize = true;
            this.label_Answer.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold);
            this.label_Answer.Location = new System.Drawing.Point(24, 192);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(111, 34);
            this.label_Answer.TabIndex = 32;
            this.label_Answer.Text = "Answer";
            // 
            // groupBox_PlayerDetails
            // 
            this.groupBox_PlayerDetails.Controls.Add(this.textBox_PlayerName);
            this.groupBox_PlayerDetails.Controls.Add(this.label_PlayerName);
            this.groupBox_PlayerDetails.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox_PlayerDetails.Location = new System.Drawing.Point(1370, 143);
            this.groupBox_PlayerDetails.Name = "groupBox_PlayerDetails";
            this.groupBox_PlayerDetails.Size = new System.Drawing.Size(497, 148);
            this.groupBox_PlayerDetails.TabIndex = 49;
            this.groupBox_PlayerDetails.TabStop = false;
            this.groupBox_PlayerDetails.Text = "Player Details";
            // 
            // textBox_PlayerName
            // 
            this.textBox_PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox_PlayerName.Location = new System.Drawing.Point(234, 57);
            this.textBox_PlayerName.Name = "textBox_PlayerName";
            this.textBox_PlayerName.Size = new System.Drawing.Size(239, 38);
            this.textBox_PlayerName.TabIndex = 31;
            this.textBox_PlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_PlayerName
            // 
            this.label_PlayerName.AutoSize = true;
            this.label_PlayerName.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold);
            this.label_PlayerName.Location = new System.Drawing.Point(18, 59);
            this.label_PlayerName.Name = "label_PlayerName";
            this.label_PlayerName.Size = new System.Drawing.Size(186, 34);
            this.label_PlayerName.TabIndex = 30;
            this.label_PlayerName.Text = "Player Name";
            // 
            // textBox_SourceVertex
            // 
            this.textBox_SourceVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox_SourceVertex.Location = new System.Drawing.Point(447, 892);
            this.textBox_SourceVertex.Name = "textBox_SourceVertex";
            this.textBox_SourceVertex.Size = new System.Drawing.Size(239, 38);
            this.textBox_SourceVertex.TabIndex = 51;
            this.textBox_SourceVertex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_SourceVertex
            // 
            this.label_SourceVertex.AutoSize = true;
            this.label_SourceVertex.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold);
            this.label_SourceVertex.Location = new System.Drawing.Point(204, 896);
            this.label_SourceVertex.Name = "label_SourceVertex";
            this.label_SourceVertex.Size = new System.Drawing.Size(206, 34);
            this.label_SourceVertex.TabIndex = 50;
            this.label_SourceVertex.Text = "Source Vertex";
            // 
            // panel_RandomNumbers
            // 
            this.panel_RandomNumbers.Location = new System.Drawing.Point(183, 143);
            this.panel_RandomNumbers.Name = "panel_RandomNumbers";
            this.panel_RandomNumbers.Size = new System.Drawing.Size(722, 572);
            this.panel_RandomNumbers.TabIndex = 52;
            // 
            // label_Note
            // 
            this.label_Note.AutoSize = true;
            this.label_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label_Note.Location = new System.Drawing.Point(80, 83);
            this.label_Note.Name = "label_Note";
            this.label_Note.Size = new System.Drawing.Size(726, 25);
            this.label_Note.TabIndex = 53;
            this.label_Note.Text = "Find the shortest path for cities of A-J by inserting distance between cities.";
            // 
            // form_FindShortestPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameApplication.Properties.Resources.gradient_light_color_background_graphic_free_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.Controls.Add(this.label_Note);
            this.Controls.Add(this.panel_RandomNumbers);
            this.Controls.Add(this.textBox_SourceVertex);
            this.Controls.Add(this.label_SourceVertex);
            this.Controls.Add(this.groupBox_PlayerDetails);
            this.Controls.Add(this.groupBox_PlayGame);
            this.Controls.Add(this.button_Previous);
            this.Controls.Add(this.label_FindShortestPath);
            this.Name = "form_FindShortestPath";
            this.Text = "Find Shortest Path";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_FindShortestPath_FormClosing);
            this.Load += new System.EventHandler(this.form_FindShortestPath_Load);
            this.groupBox_PlayGame.ResumeLayout(false);
            this.groupBox_PlayGame.PerformLayout();
            this.groupBox_PlayerDetails.ResumeLayout(false);
            this.groupBox_PlayerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_FindShortestPath;
        private System.Windows.Forms.Button button_Previous;
        private System.Windows.Forms.GroupBox groupBox_PlayGame;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.Label label_Answer;
        private System.Windows.Forms.GroupBox groupBox_PlayerDetails;
        private System.Windows.Forms.TextBox textBox_PlayerName;
        private System.Windows.Forms.Label label_PlayerName;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.TextBox textBox_SourceVertex;
        private System.Windows.Forms.Label label_SourceVertex;
        private System.Windows.Forms.Panel panel_RandomNumbers;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_PlayAgain;
        private System.Windows.Forms.Label label_Note;
    }
}