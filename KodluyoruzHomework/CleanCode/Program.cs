using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // * Variable name is important *


            // False
            int a; int b; int c; // Bizim için bu değişken isimleri hiçbir anlam ifade etmiyor.
                                 // Açıkcası nerede kullanılacak kim biliyor ?

            // True
            int totalPrice; int productCount; // Şimdi anlamlı gelmeye başladı.

            // *************************************************************************************************************
            // *************************************************************************************************************

            // * Boolean Conditional * 

            // False
            bool isRequire = true;
            if (isRequire == true) // Bu yapının aslında doğru olduğu bir gerçek ama okunuş açısından bu o kadar güzel durmuyor.
            {}

            // True

            if (isRequire) { }  // Aynı işlem ve bir o kadar kolay okunuş :) 

            // *************************************************************************************************************
            // *************************************************************************************************************

            int acceptedMinAge = 18;
            bool acceptClub;
            int age = 20;

            // False
            if (age > 18)       // 18'in anlamı ne ? bir yaşın 18 yaşından büyük olması neden önemli ? 
                acceptClub = true;      // Bunun cevabını okuyarak veremiyoruz. Hadi doğrusunu okuyalım.
            else
            {
                acceptClub = false;
            }

            //True
            if (age > acceptedMinAge) // Şimdi çözdük. Kabul edilen en küçük yaştan bahsediyormuşuz. 
                acceptClub = true;
            else {
                acceptClub = false;
            }

            // Yukarıdaki yazım ne kadar doğru gelsede çirkin duruyor.
            // Hadi şimdi clean code prensiplerinde ""Increase signal to noise ratio"" bahsedilen işi yapalım.


            acceptClub = age > acceptedMinAge; // Tek satır ve kitap okur gibi okuduk.

            // *************************************************************************************************************
            // *************************************************************************************************************

            // Pozitif Ol 
            // Bir değişkene isim verirken pozitif olmaktan bahsediyoruz. Hadi negatif isimleri düşünelim.
            /*
             isNotRequire --> Zorunlu değildir ?
             authenticationFailed --> Daha çok console'a mesaj yazıyormuşuz gibi oldu. Hadi şimdi doğrularını düşünelim.
             */

            bool isLogin;
            bool InFrontOfTheLastItem; // Uzun ama derdimizi anlatacak kadar güzel
            bool isPerson;

            // Method yapılarımızda da pozitif olmaktan vazgeçmemeliyiz.

            // isCompleted();
            // isLogin();
            // textReader();


            // *************************************************************************************************************
            // *************************************************************************************************************

            int weeklyPocketMoney;
            bool isDoneHomework = true; 

            //False

            if (isDoneHomework) // Küçük bir cep harçlığı hesabı yaparken bile ne kadar uzattık kodu. Hadi bunu "noise" kısımlarını atalım...
            {
                weeklyPocketMoney = 100;
            }
            else
            {
                weeklyPocketMoney = 10;
            }

            // True

            weeklyPocketMoney = acceptClub ? 100 : 10; // İşte bitti yapmamız gereken artık ternary If kullanmak. Basit ve kullanışlı,hala kitap okur gibi


            // *************************************************************************************************************
            // *************************************************************************************************************


            string carType;

            /* False
                 if(carType == "BUS")
                {                       // Acaba lowercase mi ? Uppercase mi gelecek ? Bunlardan kurtulmak için ve Bus neydi ya neden alıyorduk dememek için
                                        // ayrıca Bunları referans üzerinden takip etmek daha kolay olur.
                }

            */

            /*
             True
            if(carType == carTypes.Bus) // Oldukça basit ve referans aldığımız yerin içeriklerini biliyoruz.
                
             
             */


            // *************************************************************************************************************
            // *************************************************************************************************************
            int totalHomework = 10;
            int isCompletedHomework = 8;
            string messageInfo; 

            // False
            if ((totalHomework - isCompletedHomework) < 2 && DateTime.Now.Hour > 8) // Uzun uzun koşulları okurken yorulduk. Hadi bunu 2 satıra indirelim
                                                                                    // Kitap gibi okuyalım
            {
                messageInfo = "Play game";
            }
            else
            {
                messageInfo = "work work and work";
            }


            // True

            isDoneHomework = (totalHomework - isCompletedHomework) < 2 && DateTime.Now.Hour > 8; 
            messageInfo = isDoneHomework ? "Play Game" : "work work and work"; // İşte bitti sadece 2 satırda okuması bir o kadar kolay kodu yazabildik.



            // *************************************************************************************************************
            // *************************************************************************************************************

//False

// List<CarModel> _carList = new List<CarModel>() 
/* string findValue;
 foreach (var car in _carList)
 {
     if (car.Name == "Mercedes")
     {
         findValue = car.Name;
     }
 }

 // True

 return _carList.Where(car =>car.Name == findCar)   //  Bir listeyi tek bir satırda dönmek kadar basit ve kullanışlı bir yolumuz varken 
                                                    // Linq kullanmak kesinlikle yeterli :)

 */


// *************************************************************************************************************
// *************************************************************************************************************

/*     METHOD         

 Just-in-time variable atamaları ilk değer atamasından hemen önce yapılmalı.


int minAcceptAge = 18;
int maxAcceptAge = 20;

if (person.age < minAcceptAge)
    return false;
if (person.age > maxAcceptAge)
    return false;

------------------------------------------------------------
// doğru

int minAcceptAge = 6;
if (person.age < minAcceptAge)
    return false;

int maxAcceptAge = 20;
if (person.age > maxAcceptAge)
    return false;

*/


/*  
 * Bir method yalnızca bir işlem için kullanılmalı
 * 
 * public void postUser(int id,
                        string FirstName,
                        string Surname,
                        int Age,
                        )


*/
/* Karmaşıklığı gidermek if koşullarını ardı ardına yazmak büyük bir karmaşıklığa yol açar.

            //FALSE
  if()
{
   if()
   {
       do
       {
          
       } while()
   }
}

TRUE
Yöntem = Exctract Method

if()
{
   if()
   {
      DoSomething();
   }
}
 
 
private void DoSomething()
{
   do 
   { 
      
   } while()
}

False //
public void SaveUser(string userName,
                    string password,
                    string FullName,
                    Datetime birthday)
{
   if(!string.IsNullOrWhiteSpace(userName))
   { 
      // kod
      if(!string.IsNullOrWhiteSpace(password))
      {
         
      }
      else 
      {
         throw ...
      }
   }
   else 
   {
          throw ...
   }

 TRUE // Fail Fast
public void SaveUser(string userName,
                    string password,
                    string FullName,
                    Datetime birthday)
{ 
   if(string.IsNullOrWhiteSpace(userName)) 
       throw ...;
   if(string.IsNullOrWhiteSpace(password)) 
       throw ...;
 
   // Login;
}


            Yöntem = Return Early
Fail Fast mantığıyla aynı düşünebiliriz.
Fail Fast kazanımlarının hepsi geçerlidir.
Methodun işleyişine göre return edilebilecek değerlerin öncelikli olarak geri dönülmesi ile uygulanır.

            // FALSE
private bool ValidUserName(string userName)
{
   int minUserNameLenght = 6;
   int maxUserNameLenght = 20;
   bool isValid = false;
   
   if(userName.Length >= minUserNameLength)
   {
        if(userName.Length <= maxUserNameLength)
        {
            bool isAlphaNumeric = userName.All(Char.IsLetterOrDigit);
            if(isAlphaNumeric)
            {
                if(!ContainsCurseWords(userName))
                {
                   isValid = IsUniqueUserName(userName);
                }
            }
        }
   }
   return isValid;
}

TRUE 
private bool ValidUserName(string userName) 
{ 
   int minUserNameLenght = 6; 
   if(userName.Length < minUserNameLength) 
      return false;
   int maxUserNameLenght = 20; 
   if(userName.Length > maxUserNameLength) 
      return false;
   bool isAlphaNumeric = userName.All(Char.IsLetterOrDigit); 
   if(!isAlphaNumeric) 
      return false;
  
   if(ContainsCurseWords(userName)) 
      return false;
 
   return IsUniqueUserName(userName);
}



















