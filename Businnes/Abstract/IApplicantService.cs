using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstract
{
    public interface IApplicantService
    {
        void applyForMask(Person person);

        List<Person> GetList();

        bool checkPerson(Person person);
        
    }
}
