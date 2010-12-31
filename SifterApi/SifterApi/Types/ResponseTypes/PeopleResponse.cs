using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SifterApi.Types.ResponseTypes
{
    [Serializable]
    class PeopleResponse
    {
        public List<Person> People = null;
    }
}
