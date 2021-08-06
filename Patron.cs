using System;
using System.Collections.Generic;


class Patron : Person{
public string LibraryId{get;set;}
public DateTime StartDate{get;set;}
public DateTime EndDate{get;set;}
public bool IsAccountActive{get;set;}
public double FineAmountDue{get;set;}
List<Rental> Rentals = new List<Rental>();

public Patron(string FirstName, string LastName , string Id) : base(FirstName,LastName){
FineAmountDue = 0;
StartDate = DateTime.Today;
IsAccountActive = true;
LibraryId = Id;
Person p1 = new Person();
FirstName = p1.FirstName;
LastName = p1.LastName;
}
public void Display(){
  Console.WriteLine("Patron id = " + LibraryId + " Name = " + FirstName);
}
public void AddToRentalCart(Book Book){

Rental r1 = new Rental(Book);
Rentals.Add(r1);
Console.WriteLine("added to rental cart " + Book.Title +  " book " + " for " + FirstName + LastName);

}
public void RemoveFromRentalCart(Book Book){

Rental r1 = new Rental(Book);
Rentals.Remove(r1);

Console.WriteLine("Remove from Rental cart " + Book.Title);



}

}