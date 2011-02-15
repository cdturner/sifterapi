namespace SifterTest
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.milestonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueListPage1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesListAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linqExamplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifiedTodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Results = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.callsToolStripMenuItem,
            this.linqExamplesToolStripMenuItem} );
            this.menuStrip1.Location = new System.Drawing.Point( 0, 0 );
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size( 282, 28 );
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem} );
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size( 44, 24 );
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size( 102, 24 );
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler( this.exitToolStripMenuItem_Click );
            // 
            // callsToolStripMenuItem
            // 
            this.callsToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem,
            this.milestonesToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.issueListPage1ToolStripMenuItem,
            this.issuesListAllToolStripMenuItem,
            this.issueDetailsToolStripMenuItem} );
            this.callsToolStripMenuItem.Name = "callsToolStripMenuItem";
            this.callsToolStripMenuItem.Size = new System.Drawing.Size( 52, 24 );
            this.callsToolStripMenuItem.Text = "Calls";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size( 181, 24 );
            this.projectsToolStripMenuItem.Text = "Projects";
            this.projectsToolStripMenuItem.Click += new System.EventHandler( this.projectsToolStripMenuItem_Click );
            // 
            // milestonesToolStripMenuItem
            // 
            this.milestonesToolStripMenuItem.Enabled = false;
            this.milestonesToolStripMenuItem.Name = "milestonesToolStripMenuItem";
            this.milestonesToolStripMenuItem.Size = new System.Drawing.Size( 181, 24 );
            this.milestonesToolStripMenuItem.Text = "Milestones";
            this.milestonesToolStripMenuItem.Click += new System.EventHandler( this.milestonesToolStripMenuItem_Click );
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Enabled = false;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size( 181, 24 );
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler( this.peopleToolStripMenuItem_Click );
            // 
            // issueListPage1ToolStripMenuItem
            // 
            this.issueListPage1ToolStripMenuItem.Enabled = false;
            this.issueListPage1ToolStripMenuItem.Name = "issueListPage1ToolStripMenuItem";
            this.issueListPage1ToolStripMenuItem.Size = new System.Drawing.Size( 181, 24 );
            this.issueListPage1ToolStripMenuItem.Text = "IssueList Page 2";
            this.issueListPage1ToolStripMenuItem.Click += new System.EventHandler( this.issueListPage1ToolStripMenuItem_Click );
            // 
            // issuesListAllToolStripMenuItem
            // 
            this.issuesListAllToolStripMenuItem.Enabled = false;
            this.issuesListAllToolStripMenuItem.Name = "issuesListAllToolStripMenuItem";
            this.issuesListAllToolStripMenuItem.Size = new System.Drawing.Size( 181, 24 );
            this.issuesListAllToolStripMenuItem.Text = "IssuesList All";
            this.issuesListAllToolStripMenuItem.Click += new System.EventHandler( this.issuesListAllToolStripMenuItem_Click );
            // 
            // issueDetailsToolStripMenuItem
            // 
            this.issueDetailsToolStripMenuItem.Enabled = false;
            this.issueDetailsToolStripMenuItem.Name = "issueDetailsToolStripMenuItem";
            this.issueDetailsToolStripMenuItem.Size = new System.Drawing.Size( 181, 24 );
            this.issueDetailsToolStripMenuItem.Text = "IssueDetails";
            this.issueDetailsToolStripMenuItem.Click += new System.EventHandler( this.issueDetailsToolStripMenuItem_Click );
            // 
            // linqExamplesToolStripMenuItem
            // 
            this.linqExamplesToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.modifiedTodayToolStripMenuItem} );
            this.linqExamplesToolStripMenuItem.Name = "linqExamplesToolStripMenuItem";
            this.linqExamplesToolStripMenuItem.Size = new System.Drawing.Size( 116, 24 );
            this.linqExamplesToolStripMenuItem.Text = "Linq Examples";
            // 
            // modifiedTodayToolStripMenuItem
            // 
            this.modifiedTodayToolStripMenuItem.Name = "modifiedTodayToolStripMenuItem";
            this.modifiedTodayToolStripMenuItem.Size = new System.Drawing.Size( 184, 24 );
            this.modifiedTodayToolStripMenuItem.Text = "Modified Today";
            this.modifiedTodayToolStripMenuItem.Click += new System.EventHandler( this.modifiedTodayToolStripMenuItem_Click );
            // 
            // Results
            // 
            this.Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Results.Location = new System.Drawing.Point( 0, 28 );
            this.Results.Multiline = true;
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size( 282, 229 );
            this.Results.TabIndex = 1;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 8F, 16F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 282, 257 );
            this.Controls.Add( this.Results );
            this.Controls.Add( this.menuStrip1 );
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TestForm";
            this.Text = "SifterApi Test App";
            this.menuStrip1.ResumeLayout( false );
            this.menuStrip1.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.TextBox Results;
        private System.Windows.Forms.ToolStripMenuItem milestonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueListPage1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesListAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linqExamplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifiedTodayToolStripMenuItem;
    }
}

