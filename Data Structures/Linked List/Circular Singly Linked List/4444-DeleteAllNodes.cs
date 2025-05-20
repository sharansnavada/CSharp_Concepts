public void deleteAllNodes() {
  if(this.head != null) {
    
    //1. if head is not null create a temp node
    //   and current node pointed to next of head
    Node temp = new Node();
    Node current = new Node();
    current = this.head.next;
    
    //2. if current node is not equal to head, delete the
    //   current node and move current to next node using temp,
    //   repeat the process till the current reaches the head
    while(current != this.head) {
      temp = current.next;
      current = null;
      current = temp;
    }

    //3. Delete the head
    this.head = null;
  }
  Console.WriteLine("All nodes are deleted successfully."); 
}
