using FluentNHibernate.Mapping;
using SunCore;
using SunCore.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunCore.Mapping
{
    public class EmployeeMap:ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(c => c.Id);
            Map(c => c.Address);
            Map(c => c.Birthday);
            Map(c => c.Email);
            Map(c => c.IdDocument);
            Map(c => c.IdFarm);
            Map(c => c.LastName);
            Map(c => c.Name);
            Map(c => c.NickName);
            Map(c => c.Phone);
            Map(c => c.City);
            Map(c => c.DayOfWork);
            Map(c => c.HiringDate);
            Map(c => c.Job);
            Map(c => c.BirthCountry);
            Map(c => c.Neighborhood);
            Map(c => c.Observation);
            Map(c => c.Salary);
            Map(c => c.SalaryObservation);
            Map(c => c.Sex);
            Map(c => c.State);
            Map(c => c.TimeOfWork);
            Map(c => c.Vacation);
            Map(c => c.Temp);
            Table(TableNames.Employee);
        }
    }
}
