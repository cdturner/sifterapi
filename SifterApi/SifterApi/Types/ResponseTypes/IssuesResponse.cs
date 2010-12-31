using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SifterApi.Types.ResponseTypes
{
    [Serializable]
    class IssuesResponse
    {
        public List<IssueListingEntry> Issues = null;

        public int Per_Page = 0;
        public int Current_Page = 0;
        public int Total_Pages = 0;
        public string Next_Page_Url = String.Empty;
        public string Previous_Page_Url = String.Empty;
    }
}
