public class bankAccount { 

    private double balance = 0;

    public bankAccount(double newBalance){
       if ( newBalance < 0) {
            throw new Exception("No negative Values");
       }       
       balance = newBalance;
    }


public double getBalance() {
    return balance;
}

public double deposit(double amount) {
    balance = balance + amount;
    return balance;
}
public double withdraw(double amount) {
    balance = balance - amount;
    return balance;
}

}

public class checkingAccount : bankAccount {

    public checkingAccount(double initialBalance) : base(initialBalance) {
    }
}

public class savingsAccount : bankAccount {

    public savingsAccount(double initialBalance) : base(initialBalance) {
        this.deposit(100);
    }
}