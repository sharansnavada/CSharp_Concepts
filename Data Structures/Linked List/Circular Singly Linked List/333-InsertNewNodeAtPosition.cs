public void push_at(int newElement, int position) { 
  
  //1. allocate node to new element and 
  //   create a temp node to traverse the list
  Node newNode = new Node(); 
  newNode.data = newElement;
  newNode.next = null;
  Node temp = head;
  int NoOfElements = 0;

  //2. Find the number of elements in the list
  if(temp != null) {
    NoOfElements++;
    temp = temp.next;
  }
  while(temp != head) {
    NoOfElements++;
    temp = temp.next;
  }

  //3. check if the insertion position is valid
  if(position < 1 || position > (NoOfElements+1)) {
    Console.Write("\nInvalid position.");
  } else if (position == 1) {
  
  //4. if the position is 1, make next of the
  //   new node as head and new node as head
    if(head == null) {
      head = newNode;
      head.next = head;
    } else {
      while(temp.next != head) {
        temp = temp.next;
      }
      newNode.next = head;
      head = newNode;
      temp.next = head;
    }
  } else {

   //5. Else, traverse to the node previous to
   //   the given position, make newNode next 
   //   as temp next and temp next as newNode.
    temp = head;
    for(int i = 1; i < position-1; i++) 
      temp = temp.next;
    newNode.next = temp.next;
    temp.next = newNode;  
  }
}
