package Bus;

import java.io.Serializable;
import java.time.LocalDateTime;

@SuppressWarnings("serial")
public class SavingAccount extends Account implements Serializable{
	double annualInterestRate = 0.02;
	double annualGain;
	
	
	public SavingAccount() {
		super();
		
	}
	public SavingAccount(String accountNo, int pin,LocalDateTime openedDate, double availableBalance,double annualInterestRate, double annualGain) throws Validator {
		super(accountNo,pin,openedDate,availableBalance);
		this.annualInterestRate = annualInterestRate;
		this.annualGain = annualGain;
	}
	public double getAnnualInterestRate() {
		return annualInterestRate;
	}
	public void setAnnualInterestRate(double annualInterestRate) {
		this.annualInterestRate = annualInterestRate;
	}
	public double getAnnualGain() {
		return annualGain;
	}
	public void setAnnualGain(double annualGain) {
		this.annualGain = annualGain;
		
	}
	public double calculBalance()//Customer will gain amount
	{ 
		if(super.transactions.size() >= 4)
		{
		//interestRate = 0.02;
		annualGain = super.getAvailableBalance() * annualInterestRate;
		this.availableBalance+=annualGain;
		return this.availableBalance;
		}
		else 
		{
			return super.getAvailableBalance();
		}
	}
	@Override
	public String toString() {
		return "Saving [accountNumber="
				+ super.getAccountNo() + ", pin=" + super.getPin() + ", type=" + super.getAccountType()
				+ ", noOfTransactions=" + super.transactions.size()+ ", openedDate="
				+ super.getOpenedDate() + ",balance=" + super.getAvailableBalance() + "interestRate=" + annualInterestRate + ", annualGain="
				+ annualGain + ", Your Balance= "+ calculBalance() + "]";
	}
	

}
