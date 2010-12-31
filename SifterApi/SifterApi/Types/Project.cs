using System;
using System.Collections.Generic;
using System.Text;

namespace SifterApi.Types
{
    [Serializable]
    public class Project
    {
        public string Name = "";
        public bool Archived = false;
        public string Url = "";
        public string Issues_Url = "";
        public string Api_Milestones_Url = "";
        public string Api_People_Url = "";
        public string Api_Issues_Url = "";
    }
}
