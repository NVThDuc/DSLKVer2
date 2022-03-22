// See https://aka.ms/new-console-template for more information

using DSLK;
Node node = new Node(1,"Volcano", "Thailand" ,"Albidus");
Node node1 = new Node(2,"Destructor" , "Australia" , "Albidus");
Node node2 = new Node(3, "Bluepearl" , "Thailand", "Albidus");
Node node3 = new Node(4, "Blueclaw","Indonesia","Peknyj");

ListNode list = new ListNode();
Console.Write("Nhap So luong node : ");
int x = int.Parse(Console.ReadLine());

list.addNode(node);
list.addNode(node1);
list.addNode(node2);
list.addNode(node3);
list.InputList(x);
list.OutputList();


