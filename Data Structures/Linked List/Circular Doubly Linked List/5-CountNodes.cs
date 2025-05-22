public int countNodes() {
  
  //1. create a temp node pointing to head
  Node temp = new Node();
  temp = this.head;

  //2. create a variable to count nodes
  int i = 0;

  //3. if the temp node is not null increase 
  //   i by 1 and move to the next node, repeat
  //   the process till the temp becomes null
  if (temp != null) {
    i++;
    temp = temp.next;
  }
  while(temp != this.head) {
    i++;
    temp = temp.next;
  }  

  //4. return the count
  return i;  
}  
