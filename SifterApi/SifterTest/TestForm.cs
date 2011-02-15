using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SifterApi;

namespace SifterTest
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        public string ApiKey = "<enter your api key here>";
        public string Uri = "<enter your company name here>";

        public SifterApi.Types.Project Proj = null;
        public SifterApi.Types.IssueListingEntry ILE = null;

        private void projectsToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Sifter S = new Sifter( ApiKey, Uri );

            List<SifterApi.Types.Project> Projs = S.Projects();

            Proj = Projs[ 0 ];

            Results.AppendText( "Projects Count = " + Projs.Count.ToString() + Environment.NewLine );

            EnableMenuItems();
        }

        private void milestonesToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Sifter S = new Sifter( ApiKey, Uri );

            List<SifterApi.Types.Milestone> Miles = S.Milestones( Proj );

            Results.AppendText( "Milestones Count = " + Miles.Count.ToString() + Environment.NewLine );
        }

        private void peopleToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Sifter S = new Sifter( ApiKey, Uri );

            List<SifterApi.Types.Person> People = S.People( Proj );

            Results.AppendText( "People Count = " + People.Count.ToString() + Environment.NewLine );

        }

        private void issueListPage1ToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Sifter S = new Sifter( ApiKey, Uri );

            int Total = 0;
            List<SifterApi.Types.IssueListingEntry> ILEs = S.Issues( Proj, 2, 17, out Total );

            Results.AppendText( "ILEs Count = " + ILEs.Count.ToString() + Environment.NewLine );

            ILE = ILEs[ 0 ];

            EnableMenuItems();
        }

        private void issuesListAllToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Sifter S = new Sifter( ApiKey, Uri );

            List<SifterApi.Types.IssueListingEntry> ILEs = S.Issues( Proj );

            Results.AppendText( "ILEs Count = " + ILEs.Count.ToString() + Environment.NewLine );
            ILE = ILEs[ 0 ];

            EnableMenuItems();
        }

        private void issueDetailsToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Sifter S = new Sifter( ApiKey, Uri );

            SifterApi.Types.IssueDetails ID = S.IssueDetails( Proj, ILE );

            Results.AppendText( "Issue Details Comments Count = " + ID.Comments.Count.ToString() + Environment.NewLine );
        }

        private void EnableMenuItems()
        {
            if ( Proj != null )
            {
                milestonesToolStripMenuItem.Enabled = true;
                peopleToolStripMenuItem.Enabled = true;
                issueListPage1ToolStripMenuItem.Enabled = true;
                issuesListAllToolStripMenuItem.Enabled = true;

                modifiedTodayToolStripMenuItem.Enabled = true;
            }
            if ( ILE != null )
            {
                issueDetailsToolStripMenuItem.Enabled = true;
            }
        }

        private void exitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        public bool CompareDatesForSameDay( DateTime dt1, DateTime dt2 )
        {
            return ( dt1.Year == dt2.Year && dt2.Month == dt1.Month && dt1.Day == dt2.Day ) ;
        }

        private void modifiedTodayToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Sifter S = new Sifter( ApiKey, Uri );

            DateTime Today = DateTime.Now;

            List<SifterApi.Types.IssueListingEntry> ILEs = S.Issues( Proj );
            List<SifterApi.Types.IssueDetails> IDs = S.IssueDetails( Proj, ILEs );

            List<SifterApi.Types.IssueDetails> Modified = IDs.Where( 
                M => M.Comments.Where( 
                    C => CompareDatesForSameDay( C.Updated_At, Today ) == true ).Count() > 0 ).ToList();

            Results.AppendText( "Modified Count = " + Modified.Count.ToString() + Environment.NewLine );
        }
    }
}
