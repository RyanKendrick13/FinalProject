using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    BankAccount ryan = new BankAccount();
    ryan.Balance=10000000;
    ryan.DateCreated=Convert.ToDateTime("01/12/2021");
    ryan.AccountNumber="1234"; 
    ryan.Name="Ryan Kendrick";
    ryan.CalculateInterest();
    ryan.DisplayAccountInfo();
    ryan. Deposit(100);
    ryan.Withdraw(20);

    SavingsAccount p1 = new SavingsAccount();

    p1.Balance=2800;
    p1.Withdraw(50);
    p1.CalculateInterest();
    p1.Deposit(100);


    CheckingAccount p2 = new CheckingAccount();
    p2.Balance=1000;
    p2.Withdraw(20);
    p2.CalculateInterest();
    
  

     
  }
}