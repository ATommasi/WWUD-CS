using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Linq;
using WWUD2.Models;
using WWUD2.DAL;
using Microsoft.AspNet.Identity;
using System.Web;
using System;
using WWUD2.Infrastructure;

namespace WWUD2.Repositories
{
    // The QuestionRespository class. This is used to 
    // Isolate the EntityFramework based Data Access Layer from 
    // the MVC Controller class
    public class QuestionRepository : RepositoryBase<Question>, IQuestionRepository
    {
        [Dependency]
        public MainDBContext dataContext { get; set; }

        public QuestionRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        //public override void Update(Question entity)
        //{
        //    entity.DateUpdated = DateTime.Now;
        //    base.Update(entity);
        //}


        //Custom operation - add to interface definition below
        //public Question GetRandom()
        //{
        //    var RetQuest = new Question();
        //    var selection = context.Questions.Where(o => true);

        //    try
        //    {
        //        RetQuest = selection
        //           .OrderBy(c => c.AddDate)
        //            .Skip(new Random().Next(selection.Count()))
        //            .First();
        //    }
        //    catch
        //    {

        //    }

        //    return RetQuest;


        //}
    }

    public interface IQuestionRepository : IRepository<Question>
    {
        //Question GetRandom();
    }

}