using System;

class MainClass {
  public static void Main (string[] args) {

Book b1 = new Book ("123", "diary", "jeff");
Book b2 = new Book ("123", "diary2", "jeff2");
Book b3 = new Book("456", "deo", "patt");

Author a1= new Author();
a1.DisplayBooks();
a1.AddBook(b1);
a1.AddBook(b2);
a1.AddBook(b3);
a1.DisplayBooks();


  }
}
