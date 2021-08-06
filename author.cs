using System;
using System.Collections.Generic;
 
 class Author : Person
 {
private List<Book> Books = new List<Book>();

public Author():base(){

}
public void DisplayInfo(){
 Console.WriteLine(FirstName + LastName + Email);
}
public void DisplayBooks(){
   foreach(Book d in Books){
    
d.Display();


  }

}
 public void AddBook(Book b1){
Books.Add(b1);
}
public void RemoveBook(Book b1){
  
  Books.Remove(b1);
  
}

 }