public void pop_at(int position) { 
  
  //1. create two nodes - temp and nodeToDelete 
  //   to traverse and track the node to delete  
  Node nodeToDelete = head;
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

  //3. check if the specified position is valid
  if(position < 1 || position > NoOfElements) {
    Console.Write("\nInvalid position.");
  } else if (position == 1) {
  
  //4. if the position is 1 and head is the only element
  //   in the list, then make it null, else make next
  //   of head as new head and adjust links accordingly
    if(head.next == head) {
      head = null;
    } else {
      while(temp.next != head)
        temp = temp.next;
      head = head.next;
      temp.next = head;
      head.prev = temp; 
      nodeToDelete = null; 
    }
  } else {

   //5. Else, traverse to the node previous to
   //   the given position and delete the given 
   //   node and adjust links accordingly 
    temp = head;
    for(int i = 1; i < position-1; i++) 
      temp = temp.next;
    nodeToDelete = temp.next;
    temp.next = temp.next.next;
    temp.next.prev = temp;
    nodeToDelete = null;   
  }
}
