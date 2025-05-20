public void pop_all(int key) {     
  Node nodeToDelete = new Node();
  
  //1. if the head is not null and value stored at head
  //   is equal to key, keep on adjusting the head as
  //   head next, delete previous head and adjust links
  //   until new head becomes null or not equal to key
  while(head != null && head.data == key) {
    nodeToDelete = head;
    head = head.next;
    nodeToDelete = null;
    if (head != null)
      head.prev = null;
  } 

  //2. create a temp node to traverse through the
  //   list and delete nodes with value equal to 
  //   key and adjust links accordingly
  Node temp = head;        
  if(temp != null) {
    while(temp.next != null) {
      if(temp.next.data == key) {
        nodeToDelete = temp.next;
        temp.next = temp.next.next;
        if(temp.next != null)
          temp.next.prev = temp;  
        nodeToDelete = null;
      } else {
        temp = temp.next;
      }
    }
  }
} 
