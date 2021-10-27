using System;

namespace Library
{
    public class OldestChild : Visitor
    {
        public int age {get; private set;}
        public string name {get; private set;}
        public override void Visit(Node node)
        {
            foreach (Node item in node.Children)
            {
                item.Accept(this);
                if (this.age < item.Person.age)
            {
                this.age = item.Person.age;
                this.name = item.Person.name;
            }
            }
        }
    }
}