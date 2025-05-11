using System;

//node structure
class Node {
  public int data;
  public Node next;
  public Node prev;
};

class LinkedList {
  Node head;

  public LinkedList(){
    head = null;
  }
  
  //Add new element at the start of the list
  public void push_front(int newElement) {
    Node newNode = new Node();
    newNode.data = newElement;
    newNode.next = null; 
    newNode.prev = null;
    if(head == null) {
      head = newNode;
    } else {
      head.prev = newNode;
      newNode.next = head;
      head = newNode;
    }    
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

    //Add three elements at the start of the list.
    MyList.push_front(10);
    MyList.push_front(20);
    MyList.push_front(30);
    MyList.PrintList();   
  }
}
