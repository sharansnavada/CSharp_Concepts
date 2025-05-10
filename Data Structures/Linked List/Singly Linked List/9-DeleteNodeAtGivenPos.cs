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

  //Delete an element at the given position
  public void pop_at(int position) {     
    if(position < 1) {
      Console.Write("\nposition should be >= 1.");
    } else if (position == 1 && head != null) {
      Node nodeToDelete = head;
      head = head.next;
      nodeToDelete = null;
    } else {
      Node temp = new Node();
      temp = head;
      for(int i = 1; i < position-1; i++) {
        if(temp != null) {
          temp = temp.next;
        }
      }
      if(temp != null && temp.next != null) {
        Node nodeToDelete = temp.next;
        temp.next = temp.next.next; 
        nodeToDelete = null;  
      } else {
        Console.Write("\nThe node is already null.");
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

    //Add three elements at the end of the list.
    MyList.push_back(10);
    MyList.push_back(20);
    MyList.push_back(30);
    MyList.PrintList(); 

    //Delete an element at position 2
    MyList.pop_at(2);
    MyList.PrintList();

    //Delete an element at position 1
    MyList.pop_at(1);
    MyList.PrintList();        
  }
}
