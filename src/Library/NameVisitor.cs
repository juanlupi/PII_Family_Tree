using System;

namespace Library
{
    public class NameVisitor : Visitor
    {
        public int namelen {get; private set;}
        public string name {get; private set;}
        public override void Visit(Node node)
        {
            int car = node.Person.name.Length;
            if (this.namelen < car)
            {
                this.namelen = car;
                this.name = node.Person.name;
            }
            foreach (Node item in node.Children)
            {
                item.Accept(this);
            }
        }
    }
}