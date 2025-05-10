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

  //Delete all nodes by key
  public void pop_all(int key) {     
    Node nodeToDelete = new Node();

    while(head != null && head.data == key) {
      nodeToDelete = head;
      head = head.next;
      nodeToDelete = null;
    } 

    Node temp = head;        
    if(temp != null) {
      while(temp.next != null) {
        if(temp.next.data == key) {
          nodeToDelete = temp.next;
          temp.next = temp.next.next;
          nodeToDelete = null;
        } else {
          temp = temp.next;
        }
      }
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

    //Add five elements at the end of the list.
    MyList.push_back(10);
    MyList.push_back(20);
    MyList.push_back(30);
    MyList.push_back(10);
    MyList.push_back(20);
    MyList.PrintList(); 

    //Delete all occurrences of 20
    MyList.pop_all(20);
    MyList.PrintList();     
  }
}
