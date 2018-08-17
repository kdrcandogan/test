using myblog.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myblog.DAL
{
    public class MyIntializer : CreateDatabaseIfNotExists<myblogContext>
    {
        protected override void Seed(myblogContext context)
        {
            User admin = new User()
            {   
                Name = "Sevban",
                Surname = "Bayrak",
                Email = "svbnbyrk@gmail.com",
                ActivateGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = true,
                Username = "svbnbyrk",
                Password = "sevban1903",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUsername = "svbnbyrk"
            };

            User standartUser = new User()
            {
                Name = "Rıdvan",
                Surname = "Döşşak",
                Email = "ridvanbayrak41@gmail.com",
                ActivateGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = false,
                Username = "rdvn41",
                Password = "rıdvan1903",
                CreatedOn = DateTime.Now.AddHours(1),
                ModifiedOn = DateTime.Now.AddMinutes(43),
                ModifiedUsername = "rdvn41"
            };
            context.myblogUsers.Add(admin);
            context.myblogUsers.Add(standartUser);

            for (int i = 0; i < 10; i++)
            {
                Category cat = new Category()
                {
                    Title = FakeData.PlaceData.GetStreetName(),
                    Description = FakeData.PlaceData.GetAddress(),
                    ModifiedOn = DateTime.Now,
                    ModifiedUsername = "svbnbyrk"
                };

                for(int k= 0; k < FakeData.NumberData.GetNumber(3, 5); k++)
                {
                    Note not = new Note()
                    {                      
                        Title= FakeData.TextData.GetAlphabetical(FakeData.NumberData.GetNumber(5,20)),
                        Text= FakeData.TextData.GetSentences(FakeData.NumberData.GetNumber(1,3)),
                        Category= cat,
                        IsDraft=false,
                        Owner= (k % 2 == 0)? admin :standartUser,
                        CreatedOn= FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1),DateTime.Now),
                        ModifiedOn= FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                        ModifiedUsername=(k % 2==0)? admin.Username : standartUser.Username
                    };
                }
            }
        }
    }
}
