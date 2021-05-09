using System;
using System.ComponentModel.DataAnnotations;

namespace VisualRoutinesLibrary.Models
{
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
   [Key] public int ID { get; set; }

    public string GoalName { get; set; }

    public string Description { get; set; }

    public string PictureURL { get; set; }

    //public DateTime CreatedAt { get; set; }

        //public virtual Task Task { get; set; }
    }

    // public enum Time
    //  {
    //     Morning = 1,
    //     Noon,
    //     Afternoon,
    //     Night

}

