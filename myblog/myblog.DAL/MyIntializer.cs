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

            Category elektrik = new Category()
            {
                Title = "Elektrik tesisat",
                Description = "elektrik",  
                CreatedOn=DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUsername = admin.Username
            };

            Category soundsystem = new Category()
            {
                Title = "Ses Sistemleri",
                Description = "mekan seslendirme",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUsername = admin.Username
            };
            context.Categories.Add(soundsystem);
            context.Categories.Add(elektrik);

            Note amfi = new Note()
            {
                Title = "Miker Amfi",
                Text = "Sony KA-FA 1500 1500watt mixer",
                Category = soundsystem,
                IsDraft = false,
                Photo="fotografyolu",
                Owner = admin,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUsername = admin.Username
            };

            Note evtesisat = new Note()
            {
                Title = "3+1 Ev Tesisat",
                Text = " Mustakil eviç dış tesisat ışıklandırma",
                Category = elektrik,
                IsDraft = false,
                Photo = "fotografyolu",
                Owner = standartUser,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUsername = standartUser.Username
            };

            
            context.Notes.Add(amfi);
            context.Notes.Add(evtesisat);
        }
    }
}
