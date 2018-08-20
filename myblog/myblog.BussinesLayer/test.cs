using myblog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myblog.BussinesLayer
{
    public class test
    {
        private Repository<User> repo_user = new Repository<User>();
        private Repository<Category> repo_cate = new Repository<Category>();
        public test()
        {
            //DAL.myblogContext db = new DAL.myblogContext();// Bunun görevini new lemek olayını repository yapıyor artık
            //db.Categories.ToList();          
            List<Category> categories = repo_cate.List();

        }

        public void InsertTest()
        {

            int result = repo_user.Insert(new User()
            {
                Name = "aaa",
                Surname = "bbb",
                Email = "sevban10086@gmail.com",
                ActivateGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = true,
                Username = "aabbb",
                Password = "sevban41",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUsername = "aabbb",


            });
        }
        public void UpdateTest()
        {
            User user = repo_user.Find(x => x.Username == "aabbb");

            if (user != null)
            {
                user.Username = "Kazım";
                repo_user.Save();
            }
        }
        public void DeleteTest()
        {
            User user = repo_user.Find(x => x.Username == "Kazım");

            if(user != null)
            {
                int result = repo_user.Delete(user);
            }
        }
    }
}

