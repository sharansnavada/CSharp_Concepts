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

  //Delete last node by key
  public void pop_last(int key) {     
    if(head != null) {
      Node previousToLast, lastNode, temp; 
      previousToLast = null;
      lastNode = null;
      
      if(head.data == key) 
        lastNode = head;
      
      temp = head;
      while(temp.next != null) {
        if(temp.next.data == key) {
          previousToLast = temp;
          lastNode = temp.next;
        }
        temp = temp.next;
      }
   
      if(lastNode != null) {
        if(lastNode == head) {
          head = head.next;
          lastNode = null;
        } else {
          previousToLast.next = lastNode.next;
          lastNode = null;
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
    MyList.push_back(20);
    MyList.push_back(40);
    MyList.PrintList(); 

    //Delete last occurrence of 20
    MyList.pop_last(20);
    MyList.PrintList();     
  }
}
