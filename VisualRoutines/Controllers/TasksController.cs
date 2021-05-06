using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VisualRoutines.Data;

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
            //retunns all the tasks 
            var allTasks = dbContext.Tasks.ToList();
            return View();
        }
        //placeholder from task object
       // [Route("details/{int:id}")]
        //returns one cat
       // public IActionResult Details()
      //  {
       //     var taskById = dbContext.Tasks.FirstOrDefault(c => c.ID == id);

      //      return View(taskById);
      //  }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Read()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        
    }
}
