public void pop_first(int key) {
  
  //1. if head is not null, create two nodes- temp
  //   and nodeToDelete - to traverse and track 
  //   the node to delete  
  if(this.head != null) {
    Node temp = this.head;
    Node nodeToDelete = this.head;
    
    //2. if the value store at head is the key and head
    //   is the only element in the list, make it null
    if(temp.data == key) {
      if(temp.next == this.head) {
        this.head = null;
      } else {

        //3. if the value store at head is the key and list
        //   contains more than 1 elements, traverse to the
        //   last element of the list and link it to the new head
        while(temp.next != this.head) {
          temp = temp.next;
        }
        this.head = this.head.next;
        temp.next = this.head; 
        nodeToDelete = null; 
      }
    } else {
      
      //4. Else, traverse to the node previous to the 
      //   node with value equal to key, and adjust links 
      while(temp.next != this.head) {
        if(temp.next.data == key) {
          nodeToDelete = temp.next;
          temp.next = temp.next.next;
          nodeToDelete = null;
          break; 
        }
        temp = temp.next;
      }
    }
  }
}
