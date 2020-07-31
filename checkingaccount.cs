using System;


class CheckingAccount:BankAccount{

 public override double Balance{
  get{return base. Balance;}
  set{if(value<500){
    Console.WriteLine("Insufficient balance");
  }
  else{
    base.Balance=value;
  }
  }
 }
 public CheckingAccount(): base()
   {}
  public CheckingAccount(string cname,string caccountnumber, DateTime cdatecreated): base()
  {}
  
  public void CalculateInterest(){
     Balance = Balance*Math.Pow((1+.0075/12),12);
    Console.WriteLine("Added intrest and updated balance"+" " +Balance);
  }
   public override void Withdraw(double amount){
  
    if(Balance<500)
    {
      Console.WriteLine("Insufficient balance");
    }
    else
    {
      base.Withdraw(amount);
    }
  }
}













