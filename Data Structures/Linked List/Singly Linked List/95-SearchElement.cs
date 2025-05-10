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

  //Search an element in the list
  public void SearchElement(int searchValue) {
    Node temp = new Node();
    temp = this.head;
    int found = 0;
    int i = 0;

    if(temp != null) {
      while(temp != null) {
        i++;
        if(temp.data == searchValue) {
          found++;
          break;
        }
        temp = temp.next;
      }
      if (found == 1) {
        Console.WriteLine(searchValue + " is found at index = " + i +".");
      } else {
        Console.WriteLine(searchValue + " is not found in the list.");
      }
    } else {
      Console.WriteLine("The list is empty.");
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

    //traverse to display the content of the list.
    MyList.PrintList();   

    //search for element in the list
    MyList.SearchElement(10);
    MyList.SearchElement(15);
    MyList.SearchElement(20);
  }
}
