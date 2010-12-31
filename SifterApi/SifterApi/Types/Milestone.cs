using System;
using System.Collections.Generic;
using System.Text;

namespace SifterApi.Types
{
    [Serializable]
    public class Milestone
    {
        public string Name = "";
        public string Url = "";
        public DateTime DueDate = DateTime.MinValue;
        public string Api_Url = "";
    }
}
