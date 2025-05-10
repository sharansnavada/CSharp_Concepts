using System;

//node structure
class Node {
  public int data;
  public Node next;
};

class LinkedList {
  Node head;

  public LinkedList(){
    head = null;
  }
  
  //Add new element at the end of the list
  public void push_back(int newElement) {
    Node newNode = new Node();
    newNode.data = newElement;
    newNode.next = null; 
    if(head == null) {
      head = newNode;
    } else {
      Node temp = new Node();
      temp = head;
      while(temp.next != null)
        temp = temp.next;
      temp.next = newNode;
    }    
  }

  //swap node values
  public void swapNodeValues(int node1, int node2) {
    
    Node temp = new Node();
    temp = this.head;
    int N = 0;
    while(temp != null) {
      N++;
      temp = temp.next;
    }

    if(node1 < 1 || node1 > N || node2 < 1 || node2 > N)
      return;

    Node pos1 = this.head;
    Node pos2 = this.head;
    for(int i = 1; i < node1; i++) {
      pos1 = pos1.next;
    }
    for(int i = 1; i < node2; i++) {
      pos2 = pos2.next;
    }

    int val = pos1.data;
    pos1.data = pos2.data;
    pos2.data = val; 
  }  

  //display the content of the list
  public void PrintList() {
    Node temp = new Node();
    temp = this.head;
    if(temp != null) {
      Console.Write("The list contains: ");
      while(temp != null) {
        Console.Write(temp.data + " ");
        temp = temp.next;
      }
      Console.WriteLine();
    } else {
      Console.WriteLine("The list is empty.");
    }
  }     
};

// test the code
class Implementation {
  static void Main(string[] args) {
    LinkedList MyList = new LinkedList();

    //Add five elements in the list.
    MyList.push_back(10);
    MyList.push_back(20);
    MyList.push_back(30);
    MyList.push_back(40);
    MyList.push_back(50);

    //Display the content of the list.
    MyList.PrintList();  

    //swap values of node=1 and node=4
    MyList.swapNodeValues(1, 4);

    //Display the content of the list.
    MyList.PrintList();  
  }
}
