public void pop_last(int key) {     

  //1. if head is not null create three nodes
  //   lastNode - to track last node with value
  //   equal to key, previousToLast - to track 
  //   node previous to lastNode, temp - to
  //   traverse through the list
  if(head != null) {
    Node previousToLast, lastNode, temp; 
    previousToLast = null;
    lastNode = null;
    
    //2. traverse through the list and keep on updating
    //   lastNode and previousToLast whenever find a node
    //   with value equal to the specified key
    if(head.data == key) 
      lastNode = head;
    
    temp = head;
    while(temp.next != head) {
      if(temp.next.data == key) {
        previousToLast = temp;
        lastNode = temp.next;
      }
      temp = temp.next;
    }
 
    //3. Delete the lastNode and update all links
    if(lastNode != null) {
      if(lastNode == head) {
        if(head.next == head)
          head = null;
        else
          head = head.next;
        lastNode = null;
      } else {
        previousToLast.next = lastNode.next;
        lastNode = null;
      }
    }
  }
} 
