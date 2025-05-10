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

  //reverse the list
  public void reverseList() {
    if(this.head != null) {
      Node prevNode = this.head;
      Node tempNode = this.head;
      Node curNode = this.head.next;
      
      prevNode.next = null;
      
      while(curNode != null) {
        tempNode = curNode.next;
        curNode.next = prevNode;
        prevNode = curNode;
        curNode = tempNode;
      }

      this.head = prevNode;
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

    //Reversing the list.
    MyList.reverseList();
  
    //Display the content of the list.
    MyList.PrintList();
  }
}
