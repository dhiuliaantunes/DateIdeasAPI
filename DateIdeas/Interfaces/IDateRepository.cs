using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateIdeas.Interfaces
{
    public interface IDateRepository
    {
        DateIdeas RandomRainyDate();
        DateIdeas RandomSunnyDate();
    }
}
