using Microsoft.AspNetCore.Mvc;
using System.Linq;
using VisualRoutines.Data;
using VisualRoutinesLibrary.Models;
using VisualRoutinesLibrary.Models.Binding;

//how we get tasks from database
//loads pages but does not do actions 
namespace VisualRoutines.Controllers
{
    public class TasksController : Controller
    {

        private ApplicationDbContext dbContext;
        
        //dependancy injection
        public TasksController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;

        }
        public IActionResult Index()
        {
            //returns all the tasks 
            var allTasks = dbContext.Tasks.ToList();
            return View(allTasks);
        }

        //placeholder from task object
       [Route("details/{id:int}")]
        //returns one task
        public IActionResult Details(int id)
       {
            var taskById = dbContext.Tasks.FirstOrDefault(c => c.ID == id);

          return View(taskById);
       }

        //CREATE 
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(AddTaskBindingModel bindingModel)
        {
            var taskToCreate = new Task
            {
                TaskName = bindingModel.TaskName,
                Time = bindingModel.Time,
                Description= bindingModel.Description,
                PictureURL = "https://th.bing.com/th/id/R80677ad4549c7ab35bc3e3cca9f5fa4e?rik=nlG0uuKC%2fVgkDg&pid=ImgRaw",
                //CreatedAt = DateTime.Now
            };
           
           dbContext.Tasks.Add(taskToCreate);
            dbContext.SaveChanges();
            //index returns all the cats
            return RedirectToAction("Index");
        }


        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var taskById = dbContext.Tasks.FirstOrDefault(c => c.ID == id);

            return View(taskById);
           // return View();
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Task task, int id)
        {
            var taskToUpdate = dbContext.Tasks.FirstOrDefault(c => c.ID == id);
            taskToUpdate.TaskName = task.TaskName;
            taskToUpdate.Time = task.Time;
            taskToUpdate.PictureURL = task.PictureURL;
            taskToUpdate.Description = task.Description;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var taskToDelete = dbContext.Tasks.FirstOrDefault(c => c.ID == id);
            dbContext.Tasks.Remove(taskToDelete);
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
