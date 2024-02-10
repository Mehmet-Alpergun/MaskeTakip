// See https://aka.ms/new-console-template for more information
using Businnes.Abstract;
using Businnes.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!");
string mesaj = "merhaba";
double tutar = 1000000;
int sayi = 100;
bool girisyapildimi = false;


string name = "mehmet";
string surname = "alpergün";
int birth = 2001;
long tcno = 12365411;

Person person1 = new Person();
person1.firstname = name;
person1.lastname = surname;
person1.dateofbirthday = birth;
person1.nationality = tcno;
PttManager manager = new PttManager(new PersonManager());
manager.GiveMask(person1);

/*
string name1 = "ali";
ogrenciler[0] = name1;
ogrenciler[1] = name;
*/
/*
for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}
*/




