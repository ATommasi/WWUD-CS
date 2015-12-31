using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Linq;
using WWUD2.Models;
using WWUD2.DAV;
using Microsoft.AspNet.Identity;
using System.Web;

namespace WWUD2.Repositories
{
    // The QuestionRespository class. This is used to 
    // Isolate the EntityFramework based Data Access Layer from 
    // the MVC Controller class
    public class QuestionRepository : IRepository<Question, int>
    {
        [Dependency]
        public MainDBContext context { get; set; }

        public void Add(Question entity)
        {
            entity.UserID = HttpContext.Current.User.Identity.GetUserId();

            context.Questions.Add(entity);
            context.SaveChanges();
        }

        public IEnumerable<Question> Get()
        {
            return context.Questions.ToList();
        }

        public Question Get(int id)
        {
            return context.Questions.Find(id);
        }

        public void Remove(int id)
        {
            var obj = context.Questions.Find(id);
            context.Questions.Remove(obj);
            context.SaveChanges();

        }
        public void Remove(Question entity)
        {
            this.Remove(entity.QuestionID);
          
        }

   
    }
}