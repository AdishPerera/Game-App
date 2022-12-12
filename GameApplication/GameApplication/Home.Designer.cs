
namespace GameApplication
{
    partial class form_GameApplication
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
            this.label_GameApp = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.menuStrip_GameList = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_GameList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_KnapsackProblem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_FindShortestPath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_IdentifyMinimumConnectors = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_GameList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_GameApp
            // 
            this.label_GameApp.AutoSize = true;
            this.label_GameApp.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GameApp.Location = new System.Drawing.Point(941, 326);
            this.label_GameApp.Name = "label_GameApp";
            this.label_GameApp.Size = new System.Drawing.Size(548, 145);
            this.label_GameApp.TabIndex = 2;
            this.label_GameApp.Text = "Game App";
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(1878, 888);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(99, 41);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // menuStrip_GameList
            // 
            this.menuStrip_GameList.BackgroundImage = global::GameApplication.Properties.Resources._360_F_344528805_o1LwyPDkkDZ7TEbTE5J08e9m00ZifmGK;
            this.menuStrip_GameList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip_GameList.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip_GameList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_GameList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_GameList,
            this.toolStripMenuItem_KnapsackProblem,
            this.toolStripMenuItem_FindShortestPath,
            this.toolStripMenuItem_IdentifyMinimumConnectors});
            this.menuStrip_GameList.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_GameList.Name = "menuStrip_GameList";
            this.menuStrip_GameList.Size = new System.Drawing.Size(446, 953);
            this.menuStrip_GameList.TabIndex = 7;
            this.menuStrip_GameList.Text = "menuStrip_GameList";
            // 
            // toolStripMenuItem_GameList
            // 
            this.toolStripMenuItem_GameList.Font = new System.Drawing.Font("MV Boli", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem_GameList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem_GameList.Name = "toolStripMenuItem_GameList";
            this.toolStripMenuItem_GameList.Size = new System.Drawing.Size(433, 48);
            this.toolStripMenuItem_GameList.Text = "Game List";
            this.toolStripMenuItem_GameList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripMenuItem_KnapsackProblem
            // 
            this.toolStripMenuItem_KnapsackProblem.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem_KnapsackProblem.Image = global::GameApplication.Properties.Resources.colourful_play_button_icon_play_symbol_for_website_design_logo_app_ui_illustration_vector;
            this.toolStripMenuItem_KnapsackProblem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem_KnapsackProblem.Name = "toolStripMenuItem_KnapsackProblem";
            this.toolStripMenuItem_KnapsackProblem.Size = new System.Drawing.Size(433, 41);
            this.toolStripMenuItem_KnapsackProblem.Text = "Knapsack Problem";
            this.toolStripMenuItem_KnapsackProblem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem_KnapsackProblem.Click += new System.EventHandler(this.toolStripMenuItem_KnapsackProblem_Click);
            // 
            // toolStripMenuItem_FindShortestPath
            // 
            this.toolStripMenuItem_FindShortestPath.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem_FindShortestPath.Image = global::GameApplication.Properties.Resources.colourful_play_button_icon_play_symbol_for_website_design_logo_app_ui_illustration_vector;
            this.toolStripMenuItem_FindShortestPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem_FindShortestPath.Name = "toolStripMenuItem_FindShortestPath";
            this.toolStripMenuItem_FindShortestPath.Size = new System.Drawing.Size(433, 41);
            this.toolStripMenuItem_FindShortestPath.Text = "Find Shortest Path";
            this.toolStripMenuItem_FindShortestPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem_FindShortestPath.Click += new System.EventHandler(this.toolStripMenuItem_FindShortestPath_Click);
            // 
            // toolStripMenuItem_IdentifyMinimumConnectors
            // 
            this.toolStripMenuItem_IdentifyMinimumConnectors.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem_IdentifyMinimumConnectors.Image = global::GameApplication.Properties.Resources.colourful_play_button_icon_play_symbol_for_website_design_logo_app_ui_illustration_vector;
            this.toolStripMenuItem_IdentifyMinimumConnectors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem_IdentifyMinimumConnectors.Name = "toolStripMenuItem_IdentifyMinimumConnectors";
            this.toolStripMenuItem_IdentifyMinimumConnectors.Size = new System.Drawing.Size(433, 41);
            this.toolStripMenuItem_IdentifyMinimumConnectors.Text = "Identify Minimum Connectors";
            this.toolStripMenuItem_IdentifyMinimumConnectors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem_IdentifyMinimumConnectors.Click += new System.EventHandler(this.toolStripMenuItem_IdentifyMinimumConnectors_Click);
            // 
            // form_GameApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameApplication.Properties.Resources.istockphoto_1172024297_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.Controls.Add(this.menuStrip_GameList);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label_GameApp);
            this.Name = "form_GameApplication";
            this.Text = "Game Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_GameApplication_FormClosing);
            this.menuStrip_GameList.ResumeLayout(false);
            this.menuStrip_GameList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_GameApp;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.MenuStrip menuStrip_GameList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_GameList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_KnapsackProblem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_FindShortestPath;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_IdentifyMinimumConnectors;
    }
}

