public void pop_first(int key) {
  
  //1. if head is not null, create three nodes- temp,
  //   nodeToDelete and lastNode - to traverse and to 
  //   track the last node and node to delete  
  if(this.head != null) {
    Node temp = this.head;
    Node nodeToDelete = this.head;
    Node lastNode = new Node();
    
    //2. if the value store at head is the key and head
    //   is the only element in the list, make it null
    if(temp.data == key) {
      if(temp.next == this.head) {
        this.head = null;
      } else {

        //3. if the value store at head is the key and list
        //   contains more than 1 elements, adjust links
        lastNode = this.head.prev;
        this.head = this.head.next;
        lastNode.next = this.head;
        this.head.prev = lastNode;
        nodeToDelete = null; 
      }
    } else {
      
      //4. Else, traverse to the node previous to the 
      //   node with value equal to key, and adjust links 
      while(temp.next != this.head) {
        if(temp.next.data == key) {
          nodeToDelete = temp.next;
          temp.next = temp.next.next;
          temp.next.prev = temp;
          nodeToDelete = null;
          break; 
        }
        temp = temp.next;
      }
    }
  }
}
