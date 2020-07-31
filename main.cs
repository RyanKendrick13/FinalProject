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

    p1.Balance=3000;
    p1.Withdraw(3500);
    p1.CalculateInterest();

    CheckingAccount p2 = new CheckingAccount();
    p2.Balance=600;
    p2.Withdraw(20);
    SavingsAccount p5 = new SavingsAccount();
    p5.Balance=12000;
    p5.Withdraw(10);
    
  

     
  }
}