using DateIdeas.Context;
using DateIdeas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateIdeas.Repository
{
    public class DateIdeasRepository : IDateRepository
    {
        private PostgreSQLContext _context;

        public DateIdeasRepository(PostgreSQLContext context)
        {
            _context = context;
        }


        public DateIdeas RandomRainyDate()
        {
            try
            {
                var dateList = _context.DateIdeas.Where(r => r.RainyDay.Equals(true)).ToList();
                var dateId = dateList[new Random().Next(0, dateList.Count)];

                if(dateList.Count == 0)
                {
                    return null;
                }
                return dateId;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public DateIdeas RandomSunnyDate()
        {
            try
            {
                var dateList = _context.DateIdeas.Where(r => r.SunnyDay.Equals(true)).ToList();
                var dateId = dateList[new Random().Next(0, dateList.Count)];

                if (dateList.Count == 0)
                {
                    return null;
                }
                return dateId;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
