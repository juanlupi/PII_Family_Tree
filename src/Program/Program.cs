using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            AgeVisitor agevisitor = new AgeVisitor();
            OldestChild oldestchild = new OldestChild();
            NameVisitor namevisitor = new NameVisitor();

            Person p1 = new Person("Antonio",62);
            Person p2 = new Person("Mercedes",31);
            Person p3 = new Person("Santiago",30);
            Person p4 = new Person("Florencia",28);
            Person p5 = new Person("Pedro",27);
            Person p6 = new Person("Juan",19);
            Person p7 = new Person("Francisco",4);
            Person p8 = new Person("Inés",1);


            Node n1 = new Node(1, p1);
            Node n2 = new Node(2, p2);
            Node n3 = new Node(3, p3);
            Node n4 = new Node(4, p4);
            Node n5 = new Node(5, p5);
            Node n6 = new Node(6, p6);
            Node n7 = new Node(7, p7);
            Node n8 = new Node(8, p8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n1.AddChildren(n4);
            n1.AddChildren(n5);
            n1.AddChildren(n6);

            n2.AddChildren(n8);
            n2.AddChildren(n7);

            agevisitor.Visit(n1);
            Console.WriteLine($"La edad de todos los integrantes de la familia sumada es {agevisitor.sum}");

            oldestchild.Visit(n1);
            Console.WriteLine($"El hijo de mayor edad es {oldestchild.name}");

            namevisitor.Visit(n1);
            Console.WriteLine($"La persona con nombre mas largo es {namevisitor.name}");
        }
    }
}
