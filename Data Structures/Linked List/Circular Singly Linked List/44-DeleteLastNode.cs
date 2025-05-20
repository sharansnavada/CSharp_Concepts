public void pop_back() {
  if(this.head != null) {
    
    //1. if head in not null and next of head
    //   is head, release the head
    if(this.head.next == this.head) {
      this.head = null;
    } else {
      
      //2. Else, traverse to the second last 
      //   element of the list
      Node temp = new Node();
      temp = this.head;
      while(temp.next.next != this.head)
        temp = temp.next;
      
      //3. Change the next of the second 
      //   last node to head and delete the
      //   last node
      Node lastNode = temp.next;
      temp.next = this.head; 
      lastNode = null;
    }
  }
}
