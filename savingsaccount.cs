
using System;

class SavingsAccount:BankAccount{

 public override double Balance{
  get{return base. Balance;}
  set{if(value<2500){
    Console.WriteLine("Insufficient balance");
  }
  else{
    base.Balance=value;
  }
  }
}
  public SavingsAccount(): base()
   {} 
  
                                                                    
    
  
  public SavingsAccount(string cname,string caccountnumber, DateTime cdatecreated): base(){

  }
  public void CalculateInterest(){
     Balance = Balance*Math.Pow((1+.05/12),12);
    Console.WriteLine("Added interest and updated balance"+" " +Balance);
  }
  public override void  Withdraw(double amount)
  {
    if(Balance<2500)
    {
      Console.WriteLine("Insufficient balance");
    }
    else{
      base.Withdraw(amount);
    }
  }
  
  
}
  
  




