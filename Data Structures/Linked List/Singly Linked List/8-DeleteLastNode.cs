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
      //for first element in the list
      head = newNode;
    } else {
      Node temp = new Node();
      temp = head;
      while(temp.next != null)
        temp = temp.next;
      temp.next = newNode;
    }    
  }

  //Delete last node of the list
  public void pop_back() {
    if(this.head != null) {
      if(this.head.next == null) {
        this.head = null;
      } else {
        Node temp = new Node();
        temp = this.head;
        while(temp.next.next != null)
          temp = temp.next;
        Node lastNode = temp.next;
        temp.next = null; 
        lastNode = null;
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

    //Add four elements in the list.
    MyList.push_back(10);
    MyList.push_back(20);
    MyList.push_back(30);
    MyList.push_back(40);
    MyList.PrintList();   

    //Delete the last node
    MyList.pop_back();
    MyList.PrintList();  
  }
}
