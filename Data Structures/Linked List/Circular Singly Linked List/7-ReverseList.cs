public void reverseList() {
  //1. If head is not null create three nodes
  //   prevNode - pointing to head,
  //   tempNode - pointing to head,
  //   curNode - pointing to next of head
  if(this.head != null) {
    Node prevNode = this.head;
    Node tempNode = this.head;
    Node curNode = this.head.next;
    
    //2. assign next of prevNode as itself to make the
    //   first node as last node of the reversed list
    prevNode.next = prevNode;
    
    while(curNode != this.head) {
      //3. While the curNode is not head adjust links 
      //   (unlink curNode and link it to the reversed list 
      //   from front and modify curNode and prevNode) 
      tempNode = curNode.next;
      curNode.next = prevNode;
      this.head.next = curNode;
      prevNode = curNode;
      curNode = tempNode;
    }

    //4. Make prevNode (last node) as head
    this.head = prevNode;
  }
}  
