// See https://aka.ms/new-console-template for more information
using CutomLinkedList;

Console.WriteLine("Hello, World!");
CutomLinkedList.LinkedList<string> linkedList = new CutomLinkedList.LinkedList<string>();


Node<string> a = new Node<string>("a1");
Node<string> b = new Node<string>("a2");
Node<string> c = new Node<string>("a3");
Node<string> d = new Node<string>("a4");
Node<string> e = new Node<string>("a5");
linkedList.AddFirst(a);
linkedList.AddFirst(b);
linkedList.AddFirst(c);
linkedList.AddFirst(d);
linkedList.AddFirst(e);
linkedList.Traverse();