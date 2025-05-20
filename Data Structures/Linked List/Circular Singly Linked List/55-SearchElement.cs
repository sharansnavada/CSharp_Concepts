public void SearchElement(int searchValue) {
  
  //1. create a temp node pointing to head
  Node temp = new Node();
  temp = this.head;

  //2. create two variables: found - to track
  //   search, idx - to track current index
  int found = 0;
  int i = 0;

  //3. if the temp node is not null check the
  //   node value with searchValue, if found 
  //   update variables and break the loop, else
  //   continue searching till temp node is not head 
  if(temp != null) {
    while(true) {
      i++;
      if(temp.data == searchValue) {
        found++;
        break;
      }
      temp = temp.next;
      if(temp == this.head) {break;}
    }
    if (found == 1) {
      Console.WriteLine(searchValue + " is found at index = " + i +".");
    } else {
      Console.WriteLine(searchValue + " is not found in the list.");
    }
  } else {
    
    //4. If the temp node is null at the start, 
    //   the list is empty
    Console.WriteLine("The list is empty.");
  }
}  
