using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace VisualRoutinesLibrary.Models
{
    public class Task
    {
        [Key]
        public int ID { get; set; }
        public string TaskName { get; set; }

        public string Time { get; set; }

        public string Description { get; set; }

        public string PictureURL { get; set; }


      //public List<Goal> Goal { get; set }

       // public DateTime CreatedAt { get; set; }
        ///  public Size Size { get; set; }

    }
   // public enum Time
  //  {
   //     Morning = 1,
   //     Noon,
   //     Afternoon,
   //     Night
        
    }

