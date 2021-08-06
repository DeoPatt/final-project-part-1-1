using System;
using System.Collections.Generic;
class Rental {
public Book Book;
public DateTime DateRented;
public DateTime DateDue;
 List<Rental > RentalCart = new List<Rental>();
public Rental(Book Book ){
DateRented = DateTime.Today;
DateDue = DateTime.Today;



}

public Rental(Book book, DateTime DueDate,DateTime DateRented){
Book =book;
DueDate = DateDue;

}



}
