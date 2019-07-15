package Bus;

import java.io.Serializable;
import java.time.LocalDateTime;

public class CheckingAccount extends Account implements Serializable{
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	double extraFees;
	double withdrawAmount;
	
	
	public CheckingAccount(String accountNo,int pin, LocalDateTime openedDate, double availableBalance) throws Validator {
		super(accountNo,pin,openedDate,availableBalance);
		this.accountType = AccountType.Checking;
	}
	
	public CheckingAccount() {
		super();
		this.openedDate = LocalDateTime.now();
		// TODO Auto-generated constructor stub
	}
	

	public double getExtraFees() {
		return extraFees;
	}
	public void setExtraFees(double extraFees) {
		this.extraFees = extraFees;
	}
	public double getWithdrawAmount() {
		return withdrawAmount;
	}
	public void setWithdrawAmount(double withdrawAmount) {
		this.withdrawAmount = withdrawAmount;
	}

	
	
	@Override
	public String toString() {
		return "CheckingAccount [accountNumber="
				+ super.getAccountNo() + ", pin=" + super.getPin() + ", type=" + super.getAccountType()
				+ ", noOfTransactions=" + transactions.size() + ", openedDate="
				+ super.getOpenedDate() + ",balance=" + super.getAvailableBalance() + ",extraFees=" + extraFees + 
				",amountWithdraw=" + withdrawAmount+"]";
	}

	

}
