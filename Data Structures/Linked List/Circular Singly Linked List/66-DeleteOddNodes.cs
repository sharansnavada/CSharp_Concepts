public void deleteOddNodes() {
  //1. if head is the only element element in 
  //   list make the head as null  
  if(this.head != null && this.head.next == this.head) {
    this.head = null;
  } else if(this.head != null) {

    //2. if the list contains more than one element
    //   delete the head and adjust the link of
    //   last element with the new head       
    Node temp = this.head;
    while(temp.next != this.head) {
      temp = temp.next;
    }
    temp.next = head.next;
    this.head = null;
    this.head = temp.next;

    //3. create evenNode node - pointing to head
    //   oddNode node - pointing to next of head
    //   temp node - to store last even node
    if(this.head != null && this.head.next != this.head) {

      Node evenNode = this.head;
      Node oddNode = this.head.next; 
      while(true) {
        
        //4. delete odd node and update evenNode and 
        //   oddNode to next set of odd-even nodes update
        //   temp node to latest evenNode node continue
        //   the process till any of the node reaches head
        temp = evenNode;
        evenNode.next = oddNode.next;
        oddNode = null;
        evenNode = evenNode.next;
        oddNode = evenNode.next;
        if(evenNode == this.head || oddNode == this.head)
          break;
      }
      
      //5. if evenNode reaches head, make next of temp
      //   as head else make next of evenNode as head
      if(evenNode == this.head)
        temp.next = this.head;
      else
        evenNode.next = this.head;
    }
  } 
}    
