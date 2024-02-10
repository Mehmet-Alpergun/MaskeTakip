using Businnes.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class PttManager: ISupplierService
    {
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            if (_applicantService.checkPerson(person))
            {
                Console.WriteLine(person.firstname + "e maske verildi");

            }
            else
            {
                Console.WriteLine(person.firstname + " e maske verilmedi");
            }
        }
    }
}
