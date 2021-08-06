using System;

class MainClass {
  public static void Main (string[] args) {
    
     Patron f1 = new Patron("samuel", "petteson","1234");
Patron f2 = new Patron("deovyonne", "patteson", "1634");
Patron f3 = new Patron("deo", "patt", "1235");
Patron f4 = new Patron("von", "son", "1238");
Patron f5 = new Patron("none", "tes", "1234");
Patron f6 = new Patron("june", "james", "0123");
Book b1= new Book("0000","Bible","Him");
Book b2 = new Book("5432","Dictonary","schoolastics");
Book b3 = new Book("1234","Diary of a wimpy kid ","jeff kinney");
f1.AddToRentalCart(b1);
f1.RemoveFromRentalCart(b3);
f1.Display();


}
}