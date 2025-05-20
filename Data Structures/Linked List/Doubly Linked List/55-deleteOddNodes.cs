
// Click on Run Code button to see the result

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
  
  //Add new element at the end of the list
  public void push_back(int newElement) {
    Node newNode = new Node();
    newNode.data = newElement;
    newNode.next = null; 
    newNode.prev = null;
    if(head == null) {
      head = newNode;
    } else {
      Node temp = new Node();
      temp = head;
      while(temp.next != null)
        temp = temp.next;
      temp.next = newNode;
      newNode.prev = temp;
    }    
  }

  //delete odd nodes of the list
  public void deleteOddNodes() {
    if(this.head != null) {
      Node temp = this.head;
      this.head = this.head.next;
      temp = null;
      if(this.head != null) {
        this.head.prev = null;
        Node evenNode = this.head;
        Node oddNode = this.head.next; 
        while(evenNode != null && oddNode != null) {
          evenNode.next = oddNode.next;
          oddNode = null;
          temp = evenNode;
          evenNode = evenNode.next;
          if(evenNode != null) {
            evenNode.prev = temp;
            oddNode = evenNode.next;
          }
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

    //Add five elements in the list.
    MyList.push_back(10);
    MyList.push_back(20);
    MyList.push_back(30);
    MyList.push_back(40);
    MyList.push_back(50);

    //Display the content of the list.
    MyList.PrintList();  

    //delete odd nodes of the list
    MyList.deleteOddNodes();

    Console.WriteLine("After deleting odd nodes.");
    //Display the content of the list.
    MyList.PrintList();
  }
}
