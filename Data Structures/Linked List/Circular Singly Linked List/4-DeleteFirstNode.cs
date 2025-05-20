public void pop_front() {
  if(this.head != null) {
    
    //1. the list contains one node, delete
    //   make the head null
    if(this.head.next == this.head) {
      this.head = null;
    } else {
      
      //2. if the list contains more than one node,
      //   create two nodes - temp and firstNode, both
      //   pointing to head node
      Node temp = this.head;
      Node firstNode = this.head;
      
      //3. using temp node, traverse to the last node
      while(temp.next != this.head) {
        temp = temp.next;
      }
      
      //4. Make head as next of head,
      //   Make next of last node as head,
      //   delete the firstNode
      this.head = this.head.next;
      temp.next = this.head; 
      firstNode = null; 
    }
  }
}
