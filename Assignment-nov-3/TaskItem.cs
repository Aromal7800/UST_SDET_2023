using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_nov_3
{
    internal class TaskItem
    {
    public bool isCompleted { get; set;} 
    public int TaskId {  get; set;} 
    public string Desciption {  get; set;} 
       
        public static List<TaskItem> TaskList = new List<TaskItem>();
        public TaskItem()
        {

        }
        public TaskItem( int taskId, string desciption, bool isCompleted)
        {
            
            TaskId = taskId;
            Desciption = desciption;
            this.isCompleted = isCompleted;
        }

        public void AddTask(TaskItem item)
        {
         TaskList.Add(item);
        }
        public void RemoveTask(int TaskId)
        {
            var TaskToCRemove = TaskList.Find(x => x.TaskId == TaskId);
            TaskList.Remove(TaskToCRemove);
        }
        public void ChangeTasktatus(int TaskId)
        {
          var TaskToChangeStatus=TaskList.Find(x => x.TaskId == TaskId);
            if (TaskToChangeStatus != null) { TaskToChangeStatus.isCompleted = true; }  

        }
        public void display()
        {
            if(TaskList.Count > 0) 
            {
                var groupedTask = TaskList.GroupBy(x => x.isCompleted);
                foreach (var group in groupedTask)
                {
                    Console.WriteLine($"Task Completed ? : {group.Key}");
                    foreach (var item in group)
                    {

                        Console.WriteLine($"Task Id :: {item.TaskId} Task Description :: {item.Desciption} Task Status :: {item.isCompleted}");
                    }
                }
            }
            else { Console.WriteLine("There are no more task to display "); }
           
            
        }
    }
}
