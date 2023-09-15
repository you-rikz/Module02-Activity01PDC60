using System;
using System.Collections.Generic;
using System.Text;
using App1.Model;

namespace App1.ViewModel
{
    internal class TaskViewModel
    {
        public TaskModel TaskModelSet { get; set; }
        public TaskViewModel()
        {
            TaskModelSet = new TaskModel()
            {
                Subjectcode = "PDC60",
                SubjectTitle = "Xamarin Mobile Programming",
                Unit = 3,

            };

        }

    }
}
