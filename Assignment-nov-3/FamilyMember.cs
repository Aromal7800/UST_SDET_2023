using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_nov_3
{
    internal class FamilyMember
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<FamilyMember> Children { get; set; }

        public FamilyMember(string name, int age)
        {
            Name = name;
            Age = age;
            Children = new List<FamilyMember>();
        }
    }
    public class FamilyTree
    {
        private FamilyMember root;

        public FamilyTree(string rootName, int rootAge)
        {
            root = new FamilyMember(rootName, rootAge);
        }

        public void AddChild(string parentName, string childName, int childAge)
        {
            FamilyMember parent = FindMember(root, parentName);
            if (parent != null)
            {
                parent.Children.Add(new FamilyMember(childName, childAge));
            }
            else
            {
                Console.WriteLine("Parent not found.");
            }
        }

        private FamilyMember FindMember(FamilyMember member, string name)
        {
            if (member.Name == name)
            {
                return member;
            }

            foreach (var child in member.Children)
            {
                var found = FindMember(child, name);
                if (found != null)
                {
                    return found;
                }
            }

            return null;
        }

        public void DisplayFamilyTree()
        {
            Console.WriteLine("Family Tree:");
            DisplayMember(root, 0);
        }

        private void DisplayMember(FamilyMember member, int depth)
        {
            Console.WriteLine(new string('-', depth * 2) + member.Name + " (Age: " + member.Age + ")");
            foreach (var child in member.Children)
            {
                DisplayMember(child, depth + 1);
            }
        }
    }
}

