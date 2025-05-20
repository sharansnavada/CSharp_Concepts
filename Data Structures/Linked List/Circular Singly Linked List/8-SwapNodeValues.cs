public void swapNodeValues(int node1, int node2) {
  
  //1. count the number of nodes in the list
  Node temp = new Node();
  temp = this.head;
  int N = 0;
  if (temp != null) {
    N++;
    temp = temp.next;
  }
  while(temp != this.head) {
    N++;
    temp = temp.next;
  } 

  //2. check if the swap positions are valid entries
  if(node1 < 1 || node1 > N || node2 < 1 || node2 > N)
    return;

  //3. traverse to the nodes where values to be swapped
  Node pos1 = this.head;
  Node pos2 = this.head;
  for(int i = 1; i < node1; i++) {
    pos1 = pos1.next;
  }
  for(int i = 1; i < node2; i++) {
    pos2 = pos2.next;
  }

  //4. swap the values of two nodes
  int val = pos1.data;
  pos1.data = pos2.data;
  pos2.data = val; 
}   
