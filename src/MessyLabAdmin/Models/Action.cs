﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessyLabAdmin.Models
{
    public class Action
    {

        public enum ActionType
        {
            Login = 1,
            Compile,
            StartDebug,
            EndDebug,
            AddBreakpoint,
            RemoveBreakpoint,
            HitBreakpoint,
            SetWatch,
            CompilationSuccess,
            CompilationFailure,
        }

        public int ID { get; set; }

        [Required]
        public ActionType Type { get; set; }
        
        [DataType(DataType.DateTime)]
        [Display(Name = "Created at")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime CreatedTime { get; set; }

        public int StudentID { get; set; }
        public virtual Student Student { get; set; }

        public string Data { get; set; }


    }
}
