
namespace GameApplication
{
    partial class form_IdentifyMinimumConnectors
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
            this.label_IdentifyMinimumConnectors = new System.Windows.Forms.Label();
            this.textBox_PlayerName = new System.Windows.Forms.TextBox();
            this.label_PlayerName = new System.Windows.Forms.Label();
            this.button_Previous = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.groupBox_PlayerDetails = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_PlayAgain = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_AnswerResult = new System.Windows.Forms.Label();
            this.label_Answer = new System.Windows.Forms.Label();
            this.textBox_Distance = new System.Windows.Forms.TextBox();
            this.label_Distance = new System.Windows.Forms.Label();
            this.groupBox_GameResults = new System.Windows.Forms.GroupBox();
            this.listBox_GameResults = new System.Windows.Forms.ListBox();
            this.panel_RandomNumbers = new System.Windows.Forms.Panel();
            this.label_Note = new System.Windows.Forms.Label();
            this.groupBox_PlayerDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_GameResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_IdentifyMinimumConnectors
            // 
            this.label_IdentifyMinimumConnectors.AutoSize = true;
            this.label_IdentifyMinimumConnectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IdentifyMinimumConnectors.Location = new System.Drawing.Point(842, 19);
            this.label_IdentifyMinimumConnectors.Name = "label_IdentifyMinimumConnectors";
            this.label_IdentifyMinimumConnectors.Size = new System.Drawing.Size(408, 32);
            this.label_IdentifyMinimumConnectors.TabIndex = 32;
            this.label_IdentifyMinimumConnectors.Text = "Identify Minimum Connectors";
            // 
            // textBox_PlayerName
            // 
            this.textBox_PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox_PlayerName.Location = new System.Drawing.Point(234, 57);
            this.textBox_PlayerName.Name = "textBox_PlayerName";
            this.textBox_PlayerName.Size = new System.Drawing.Size(239, 38);
            this.textBox_PlayerName.TabIndex = 31;
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
            // button_Previous
            // 
            this.button_Previous.BackgroundImage = global::GameApplication.Properties.Resources._93634;
            this.button_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Previous.Location = new System.Drawing.Point(14, 12);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(49, 39);
            this.button_Previous.TabIndex = 41;
            this.button_Previous.UseVisualStyleBackColor = true;
            this.button_Previous.Click += new System.EventHandler(this.button_Previous_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.Location = new System.Drawing.Point(76, 147);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(153, 55);
            this.btn_Check.TabIndex = 43;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // groupBox_PlayerDetails
            // 
            this.groupBox_PlayerDetails.Controls.Add(this.textBox_PlayerName);
            this.groupBox_PlayerDetails.Controls.Add(this.label_PlayerName);
            this.groupBox_PlayerDetails.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox_PlayerDetails.Location = new System.Drawing.Point(1368, 148);
            this.groupBox_PlayerDetails.Name = "groupBox_PlayerDetails";
            this.groupBox_PlayerDetails.Size = new System.Drawing.Size(497, 148);
            this.groupBox_PlayerDetails.TabIndex = 44;
            this.groupBox_PlayerDetails.TabStop = false;
            this.groupBox_PlayerDetails.Text = "Player Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Start);
            this.groupBox1.Controls.Add(this.button_PlayAgain);
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(1368, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 148);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Play Game";
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.Location = new System.Drawing.Point(51, 62);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(153, 55);
            this.button_Start.TabIndex = 45;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_PlayAgain
            // 
            this.button_PlayAgain.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PlayAgain.Location = new System.Drawing.Point(249, 62);
            this.button_PlayAgain.Name = "button_PlayAgain";
            this.button_PlayAgain.Size = new System.Drawing.Size(193, 55);
            this.button_PlayAgain.TabIndex = 44;
            this.button_PlayAgain.Text = "Play Again";
            this.button_PlayAgain.UseVisualStyleBackColor = true;
            this.button_PlayAgain.Click += new System.EventHandler(this.button_PlayAgain_Click);
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(269, 147);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(153, 55);
            this.button_Save.TabIndex = 44;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_AnswerResult);
            this.groupBox2.Controls.Add(this.label_Answer);
            this.groupBox2.Controls.Add(this.textBox_Distance);
            this.groupBox2.Controls.Add(this.button_Save);
            this.groupBox2.Controls.Add(this.btn_Check);
            this.groupBox2.Controls.Add(this.label_Distance);
            this.groupBox2.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(1368, 520);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 314);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Submit Answers";
            // 
            // label_AnswerResult
            // 
            this.label_AnswerResult.AutoSize = true;
            this.label_AnswerResult.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold);
            this.label_AnswerResult.Location = new System.Drawing.Point(229, 245);
            this.label_AnswerResult.Name = "label_AnswerResult";
            this.label_AnswerResult.Size = new System.Drawing.Size(59, 34);
            this.label_AnswerResult.TabIndex = 46;
            this.label_AnswerResult.Text = "....";
            // 
            // label_Answer
            // 
            this.label_Answer.AutoSize = true;
            this.label_Answer.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold);
            this.label_Answer.Location = new System.Drawing.Point(20, 245);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(111, 34);
            this.label_Answer.TabIndex = 45;
            this.label_Answer.Text = "Answer";
            // 
            // textBox_Distance
            // 
            this.textBox_Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox_Distance.Location = new System.Drawing.Point(235, 67);
            this.textBox_Distance.Name = "textBox_Distance";
            this.textBox_Distance.Size = new System.Drawing.Size(239, 38);
            this.textBox_Distance.TabIndex = 33;
            // 
            // label_Distance
            // 
            this.label_Distance.AutoSize = true;
            this.label_Distance.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold);
            this.label_Distance.Location = new System.Drawing.Point(19, 69);
            this.label_Distance.Name = "label_Distance";
            this.label_Distance.Size = new System.Drawing.Size(126, 34);
            this.label_Distance.TabIndex = 32;
            this.label_Distance.Text = "Distance";
            // 
            // groupBox_GameResults
            // 
            this.groupBox_GameResults.Controls.Add(this.listBox_GameResults);
            this.groupBox_GameResults.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox_GameResults.Location = new System.Drawing.Point(796, 148);
            this.groupBox_GameResults.Name = "groupBox_GameResults";
            this.groupBox_GameResults.Size = new System.Drawing.Size(506, 686);
            this.groupBox_GameResults.TabIndex = 47;
            this.groupBox_GameResults.TabStop = false;
            this.groupBox_GameResults.Text = "Game Results";
            // 
            // listBox_GameResults
            // 
            this.listBox_GameResults.FormattingEnabled = true;
            this.listBox_GameResults.ItemHeight = 34;
            this.listBox_GameResults.Location = new System.Drawing.Point(18, 59);
            this.listBox_GameResults.Name = "listBox_GameResults";
            this.listBox_GameResults.Size = new System.Drawing.Size(460, 616);
            this.listBox_GameResults.TabIndex = 0;
            // 
            // panel_RandomNumbers
            // 
            this.panel_RandomNumbers.Location = new System.Drawing.Point(34, 148);
            this.panel_RandomNumbers.Name = "panel_RandomNumbers";
            this.panel_RandomNumbers.Size = new System.Drawing.Size(698, 686);
            this.panel_RandomNumbers.TabIndex = 48;
            // 
            // label_Note
            // 
            this.label_Note.AutoSize = true;
            this.label_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label_Note.Location = new System.Drawing.Point(29, 90);
            this.label_Note.Name = "label_Note";
            this.label_Note.Size = new System.Drawing.Size(825, 25);
            this.label_Note.TabIndex = 49;
            this.label_Note.Text = "Identify minimum connectors in cities of A-J and insert minimum connecting distan" +
    "ce.";
            // 
            // form_IdentifyMinimumConnectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameApplication.Properties.Resources.gradient_light_color_background_graphic_free_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.Controls.Add(this.label_Note);
            this.Controls.Add(this.panel_RandomNumbers);
            this.Controls.Add(this.groupBox_GameResults);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_PlayerDetails);
            this.Controls.Add(this.button_Previous);
            this.Controls.Add(this.label_IdentifyMinimumConnectors);
            this.Name = "form_IdentifyMinimumConnectors";
            this.Text = "Identify Minimum Connectors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_IdentifyMinimumConnectors_FormClosing);
            this.Load += new System.EventHandler(this.form_IdentifyMinimumConnectors_Load);
            this.groupBox_PlayerDetails.ResumeLayout(false);
            this.groupBox_PlayerDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_GameResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Previous;
        private System.Windows.Forms.Label label_IdentifyMinimumConnectors;
        private System.Windows.Forms.TextBox textBox_PlayerName;
        private System.Windows.Forms.Label label_PlayerName;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.GroupBox groupBox_PlayerDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_PlayAgain;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Distance;
        private System.Windows.Forms.Label label_Distance;
        private System.Windows.Forms.Label label_AnswerResult;
        private System.Windows.Forms.Label label_Answer;
        private System.Windows.Forms.GroupBox groupBox_GameResults;
        private System.Windows.Forms.ListBox listBox_GameResults;
        private System.Windows.Forms.Panel panel_RandomNumbers;
        private System.Windows.Forms.Label label_Note;
    }
}