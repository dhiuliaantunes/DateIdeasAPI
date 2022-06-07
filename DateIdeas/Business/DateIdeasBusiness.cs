using DateIdeas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateIdeas.Business
{
    public class DateIdeasBusiness : IDateBusiness
    {
        private readonly IDateRepository _repository;
    
        public DateIdeasBusiness(IDateRepository repository)
        {
            _repository = repository;
        }
  
        public DateIdeas RandomRainyDate()
        {
            return _repository.RandomRainyDate();
        }

        public DateIdeas RandomSunnyDate()
        {
            return _repository.RandomSunnyDate();
        }
    }
}
