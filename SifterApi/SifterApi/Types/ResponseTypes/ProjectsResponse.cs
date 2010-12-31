using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SifterApi.Types.ResponseTypes
{
    [Serializable]
    class ProjectsResponse
    {
        public List<Project> Projects = null;
    }
}
