using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MernisReference;

namespace Business.Concrete
{
    public class PersonManager: IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }
        
        public  List<Person> GetList(){
            return null;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirth).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
