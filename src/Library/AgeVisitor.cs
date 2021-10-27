using System;

namespace Library
{
    public class AgeVisitor : Visitor
    {
        public int sum {get; private set;}
        public override void Visit(Node node)
        {
            this.sum += node.Person.age;
            foreach (Node item in node.Children)
            {
                item.Accept(this);
            }
        }
    }
}