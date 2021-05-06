using Google.Apis.Analytics.v3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisualRoutines.Models
{
    public class task
    {
        public string TaskName { get; set; }

        public string Time { get; set; }

        public int ID { get; set; }

        public string description { get; set; }

        public string PictureURL { get; set; }

        public DateTime CreatedAt { get; set; }
        ///  public Size Size { get; set; }

    }
   // public enum Size
   // {
       // Morning = 1,
       // Noon,
      //  Afternoon, 
      //  Night
  //  }

    //virtual sets relationships
   

public class Goal
{
    public int ID { get; set; }

    public string GoalName { get; set; }

    public string Description { get; set; }

    public string PictureURL { get; set; }

    public DateTime CreatedAt { get; set; }
}
   // public enum Time
  //  {
   //     Morning = 1,
   //     Noon,
   //     Afternoon,
   //     Night
        
    }

