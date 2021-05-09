using Microsoft.AspNetCore.Mvc;
using System.Linq;
using VisualRoutines.Data;
using VisualRoutinesLibrary.Models;
using VisualRoutinesLibrary.Models.Binding;

namespace VisualRoutines.Controllers
{
    public class GoalsController : Controller
    {
        private ApplicationDbContext dbContext;

        //dependancy injection
        public GoalsController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;

        }
        public IActionResult Index()
        {
            //returns all the tasks 
            var allGoals = dbContext.Goals.ToList();
            return View(allGoals);
        }

        //placeholder from task object
      //  [Route("details/{id:int}")]
        //returns one task
     //   public IActionResult Details(int id)
      //  {
       //     var taskById = dbContext.Tasks.FirstOrDefault(c => c.ID == id);

           // return View(goalById);
       // }

        //CREATE 
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(AddGoalBindingModel bindingModel)
        {
            var goalToCreate = new Goal
            {
                GoalName = bindingModel.GoalName,
              ///  Time = bindingModel.Time,
                Description = bindingModel.Description,
                PictureURL = "https://www.thebalancesmb.com/thmb/f3_NuKDRY2fe11yaHZ0Eh3ZebK4=/1333x1000/smart/filters:no_upscale()/smart-goal-examples-2951827_final-5b6887cc46e0fb0050aa0bc9.png",
                //CreatedAt = DateTime.Now
            };
            dbContext.Goals.Add(goalToCreate);
            dbContext.SaveChanges();
            //index returns all the cats
            return RedirectToAction("Index");
        }


        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var goalById = dbContext.Goals.FirstOrDefault(c => c.ID == id);

            return View(goalById);
            // return View();
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Goal goal, int id)
        {
            var goalToUpdate = dbContext.Goals.FirstOrDefault(c => c.ID == id);
            goalToUpdate.GoalName = goal.GoalName;
            goalToUpdate.PictureURL = goal.PictureURL;
            goalToUpdate.Description = goal.Description;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var GoalToDelete = dbContext.Tasks.FirstOrDefault(c => c.ID == id);
            //dbContext.Goals.Remove(GoalToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Read()

        {
            return View();
        }
        /// public IActionResult Delete()
        //  {
        //     return View();
        //   }

    }
}
    

