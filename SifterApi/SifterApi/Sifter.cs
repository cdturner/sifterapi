using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace SifterApi
{
    public class Sifter
    {
        protected string _ApiKey = "";
        protected string _Uri = "";

        public delegate void OnStartWebRequestDelegate();
        public delegate void OnCompletedWebRequestDelegate();
        public delegate void OnErrorWebRequestDelegate( Exception E );

        // this is called at the start of EACH web request. most calls are only one webrequest, except Issues() and IssueDetails()
        public OnStartWebRequestDelegate OnStartWebRequest = null;

        // called at the successful completion of a webrequest
        public OnCompletedWebRequestDelegate OnCompletedWebRequest = null;

        // called upon an exception being fired, such as "cannot resolve host" or "406 Nto acceptable"....
        public OnErrorWebRequestDelegate OnErrorDuringWebRequest = null;

        public Sifter( string ApiKey, string Uri )
        {
            _ApiKey = ApiKey;
            _Uri = Uri;
        }

        public List<Types.Project> Projects()
        {
            const string ApiPart = "/api/projects";

            string Data = MakeApiCall( BuildUrl( ApiPart ) );

            JavaScriptSerializer JSS = new JavaScriptSerializer();
            Types.ResponseTypes.ProjectsResponse PR = JSS.Deserialize<Types.ResponseTypes.ProjectsResponse>( Data );

            return PR.Projects;
        }

        public List<Types.Milestone> Milestones( Types.Project CurrentProject )
        {
            string Data = MakeApiCall( CurrentProject.Api_Milestones_Url );

            JavaScriptSerializer JSS = new JavaScriptSerializer();
            Types.ResponseTypes.MilestonesResponse MR = JSS.Deserialize<Types.ResponseTypes.MilestonesResponse>( Data );

            return MR.Milestones;
        }

        public List<Types.Person> People( Types.Project CurrentProject )
        {
            string Data = MakeApiCall( CurrentProject.Api_People_Url );

            JavaScriptSerializer JSS = new JavaScriptSerializer();
            Types.ResponseTypes.PeopleResponse PR = JSS.Deserialize<Types.ResponseTypes.PeopleResponse>( Data );

            return PR.People;
        }

        public List<Types.IssueListingEntry>Issues( Types.Project CurrentProject )
        {
            string Url = CurrentProject.Api_Issues_Url;

            int CurrentPage = 0;
            int TotalPages = 1;

            List<Types.IssueListingEntry> Results = new List<SifterApi.Types.IssueListingEntry>();

            do
            {
                string Data = MakeApiCall( Url );

                JavaScriptSerializer JSS = new JavaScriptSerializer();
                Types.ResponseTypes.IssuesResponse IR = JSS.Deserialize<Types.ResponseTypes.IssuesResponse>( Data );

                Results.AddRange( IR.Issues );

                TotalPages = IR.Total_Pages;
                CurrentPage += 1;
                Url = IR.Next_Page_Url;
            }
            while ( CurrentPage <= TotalPages );

            return Results;
        }

        public List<Types.IssueListingEntry>Issues( Types.Project CurrentProject, int Page, int ResultsToReturn, out int TotalPages )
        {
            string Data = MakeApiCall( CurrentProject.Api_Issues_Url + "?per_page=" + ResultsToReturn.ToString() + "&pg=" + Page.ToString() );

            JavaScriptSerializer JSS = new JavaScriptSerializer();
            Types.ResponseTypes.IssuesResponse IR = JSS.Deserialize<Types.ResponseTypes.IssuesResponse>( Data );

            TotalPages = IR.Total_Pages;

            return IR.Issues;
        }

        public Types.IssueDetails IssueDetails( Types.Project CurrentProject, Types.IssueListingEntry ILE )
        {
            string Data = MakeApiCall( ILE.Api_Url );

            JavaScriptSerializer JSS = new JavaScriptSerializer();
            Types.ResponseTypes.IssueDetailsResponse IR = JSS.Deserialize<Types.ResponseTypes.IssueDetailsResponse>( Data );

            return IR.Issue;
        }

        public List<Types.IssueDetails> IssueDetails( Types.Project CurrentProject, List<Types.IssueListingEntry> ILEs )
        {
            List<Types.IssueDetails> Results = new List<SifterApi.Types.IssueDetails>();

            foreach ( Types.IssueListingEntry ILE in ILEs )
            {
                Results.Add( IssueDetails( CurrentProject, ILE ) );
            }

            return Results;
        }

        protected string BuildUrl( string ApiPart )
        {
            return "https://" + _Uri + ".sifterapp.com" + ApiPart;
        }

        protected string MakeApiCall( string FullUrl )
        {
            HttpWebRequest WR = (HttpWebRequest) WebRequest.Create( FullUrl );
            WR.Headers["X-Sifter-Token"] = _ApiKey;
            WR.UseDefaultCredentials = true;
            WR.Accept = "application/json";

            if ( OnStartWebRequest != null )
            {
                OnStartWebRequest();
            }

            string Response = "";
            try
            {
                HttpWebResponse HWR = (HttpWebResponse)WR.GetResponse();
                using ( Stream DS = HWR.GetResponseStream() )
                {
                    using ( StreamReader SR = new StreamReader( DS ) )
                    {
                        Response = SR.ReadToEnd();

                        SR.Close();
                    }
                    DS.Close();
                }

                HWR.Close();

                if ( OnCompletedWebRequest != null )
                {
                    OnCompletedWebRequest();
                }
            }
            catch ( Exception E )
            {
                if ( OnErrorDuringWebRequest != null )
                {
                    OnErrorDuringWebRequest( E );
                }
            }

            return Response;
        }
    }
}