public void deleteEvenNodes() {
  if(this.head != null && this.head.next != this.head) {
  
    //1. if the list has more than one element
    //   create evenNode node - pointing to head
    //   oddNode node - pointing to next of head
    //   temp node - to store last odd node
    Node oddNode = this.head;
    Node evenNode = this.head.next; 
    Node temp = new Node();

    while(true) {
      
      //2. delete even node and update evenNode and 
      //   oddNode to next set of odd-even nodes
      //   update temp node to latest oddNode node
      //   continue the process till any of the node 
      //   reaches head
      temp = oddNode;
      oddNode.next = evenNode.next;
      evenNode = null;
      oddNode = oddNode.next;
      evenNode = oddNode.next;
      if(oddNode == this.head || evenNode == this.head)
        break;
    }
    
    //3. if oddNode reaches head, make next of 
    //   temp as head else make next of oddNode
    //   as head
    if(oddNode == this.head)
      temp.next = this.head;
    else
      oddNode.next = this.head;
  }
}  
