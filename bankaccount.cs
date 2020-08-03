using System;

class BankAccount{

public string accountnumber;
public string name;
public double balance;
DateTime datecreated;
 

public string AccountNumber{

  get{return accountnumber;}
  set{if (value.Length<=6)
  {
     accountnumber=value;
  }
     
  else{
    Console.WriteLine("Invalid accountnumber. AccountNumber has to be 6 characters long");
  }
  }
}
    public virtual double Balance{
    get{return balance;}
    set{if(value<=0){
      Console.WriteLine("Your balance is zero.");

    }
    else{
      balance = value;
    
    }
    }



  }       
  public string Name{get;set;}

  public DateTime DateCreated{
  get{return datecreated; }  
  set{if (value < DateTime.Today.AddDays(1)){
      datecreated=value;
  }
    else
    Console.WriteLine("Error");
  }
  }

  
  public BankAccount(){
     DateCreated= DateTime.Today;

  }
   public BankAccount(string cName,string cAccountNumber,DateTime cDateCreated){
    cName=Name;
    cAccountNumber=AccountNumber;
    cDateCreated=DateCreated;
    DateCreated=DateTime.Today;

}
public void DisplayAccountInfo(){
 Console.WriteLine(Name +" "+AccountNumber+" "+ Balance );
}
public void Deposit(double amount){
   Balance = Balance+amount;
  Console.WriteLine(Balance);
}
public virtual void Withdraw(double amount){
  if(Balance > amount){
    Balance=Balance-amount;
    
  }
  else{
    Console.WriteLine("Error");
  }
  Console.WriteLine(Balance);
 


}
public void CalculateInterest(){

  Console.WriteLine("This method will calculate Interest");

}
}

  
 














