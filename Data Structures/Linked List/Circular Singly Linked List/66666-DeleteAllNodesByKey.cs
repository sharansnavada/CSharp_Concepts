public void pop_all(int key) {     
  Node nodeToDelete = new Node();
  Node temp = new Node();
  
  //1. if the head is not null and value stored at
  //   head is equal to key, keep on adjusting the
  //   head as head next and deleting previous head
  //   until new head becomes null or not equal to key
  while(this.head != null && this.head.data == key) {

    if(this.head.next == this.head) {
      this.head = null;
    } else {
      nodeToDelete = this.head;
      temp = this.head;
      // traverse to the last element of
      // the list to adjust links
      while(temp.next != this.head) {
        temp = temp.next;
      } 
      this.head = this.head.next;
      temp.next = this.head;   
      nodeToDelete = null;
    }
  }

  //2. create a temp node to traverse through the
  //   list and delete nodes with value equal to 
  //   key and adjust links accordingly
  temp = this.head;        
  if(temp != null) {
    while(temp.next != this.head) {
      if(temp.next.data == key) {
        nodeToDelete = temp.next;
        temp.next = temp.next.next;
        nodeToDelete = null;
      } else {
        temp = temp.next;
      }
    }
  }
} 
