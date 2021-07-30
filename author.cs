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
     Console.WriteLine(d);
Book b1 = new Book();
b1.Display();
  }

}
 public void AddBook(Book b1){
Books.Add(b1);
}
public void RemoveBook(string ISBN){

}
 }