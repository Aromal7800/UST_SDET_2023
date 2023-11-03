// See https://aka.ms/new-console-template for more information
using Assignment_nov_3;
 FamilyTree familyTree = new FamilyTree("Shaji", 90);
        familyTree.AddChild("Shaji", "Aromal", 50);
        familyTree.AddChild("Shaji", "Nandu", 40);
        familyTree.AddChild("Aromal", "Chandu", 42);
        familyTree.AddChild("Aromal", "Nandu", 39);

        familyTree.DisplayFamilyTree();
/*
while(true){
    Console.WriteLine("1.Add a task ");
    Console.WriteLine("2.Remove a Task");
    Console.WriteLine("3.Change task status to completed");
    Console.WriteLine("4.Display all task");
    Console.WriteLine("6.Exit");
    Console.WriteLine("Enter your Choice :");
    int ch = Convert.ToInt32(Console.ReadLine());
    switch (ch)
    {
        case 1:
            {
                Console.WriteLine("Enter Task Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Task Description :");
                string description = Console.ReadLine();

                Console.WriteLine("Is Completed :(1.true||2.false)");
                string isCompleted = Console.ReadLine();
                bool.TryParse(isCompleted, out bool isCompleted2);
                TaskItem taskItem = new TaskItem(id, description, isCompleted2);
                break;
            }
        case 2:
            {
                Console.WriteLine("Enter the id of the task to remove :");
                int id = Convert.ToInt32(Console.ReadLine());
                TaskItem taskItem = new TaskItem();
                taskItem.RemoveTask(id);
                break;
            }
        case 3:
            {

                Console.WriteLine("Enter the id of the task completed :");
                int id = Convert.ToInt32(Console.ReadLine());
                TaskItem taskItem = new TaskItem();
                taskItem.ChangeTasktatus(id);
                break;
            }
        case 4:
            {
                TaskItem taskItem = new TaskItem();
                taskItem.display();
                break;
            }
    }
    
}
*/