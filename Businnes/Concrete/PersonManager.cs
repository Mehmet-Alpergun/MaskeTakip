using Businnes.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class PersonManager: IApplicantService
    {
        public void applyForMask(Person person)
        {

        }
        public List<Person> GetList()
        {
            return null;
        }
        public bool checkPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.nationality,person.firstname,person.lastname,person.dateofbirthday))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
