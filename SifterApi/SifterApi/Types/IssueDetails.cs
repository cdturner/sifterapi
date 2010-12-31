using System;
using System.Collections.Generic;
using System.Text;

namespace SifterApi.Types
{
    [Serializable]
    public class IssueDetails
    {
        public int Number = 0;
        public List<CommentDetails> Comments = null;

        public string Category_Name = string.Empty;
        public string Url = string.Empty;
        public string Priority = string.Empty;
        public string Subject = string.Empty;
        public string Description = string.Empty;
        public string Milestone_Name = string.Empty;
        public string Opener_Name = string.Empty;
        public string Assignee_Name = string.Empty;
        public string Status = string.Empty;
        public string Api_Url = string.Empty;
    }

    [Serializable]
    public class CommentDetails
    {
        public string Category = string.Empty;
        public string Body = string.Empty;
        public DateTime Updated_At = DateTime.MinValue;
        public string Priority = string.Empty;
        public string Commenter = string.Empty;
        public string Milestone_Name = string.Empty;
        public string Assignee_Name = string.Empty;
        public string Status = string.Empty;
    }
}
