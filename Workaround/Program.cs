using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
Console.WriteLine("Lütfen Adınızı Giriniz: ");
person1.FirstName = Console.ReadLine();
Console.WriteLine("Lütfen Soyadınızı Giriniz: ");
person1.LastName = Console.ReadLine();
Console.WriteLine("Lütfen TcNo Giriniz: ");
string inputTc=Console.ReadLine();
long tcno;
if (long.TryParse(inputTc, out tcno))
{
    person1.NationalIdentity = tcno;
}
else
{
    Console.WriteLine("Hatalı Giriş Yaptınız");
}
Console.WriteLine("Dogum Yılı Giriniz");
person1.DateOfBirth= (int)Convert.ToInt64(Console.ReadLine());
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);