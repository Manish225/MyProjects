package Bus;

import java.util.ArrayList;
import java.util.UUID;


import java.io.Serializable;
import java.time.LocalDateTime;

public  class Account implements Serializable {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	String accountNo;
	Integer pin;
	AccountType accountType;
	LocalDateTime openedDate;
	double availableBalance;
	ArrayList<Transaction> transactions= new ArrayList<Transaction>();
	public Account(String accountNo, Integer pin, AccountType accountType, LocalDateTime openedDate, double availableBalance) throws Validator {
		super();
		this.setAccountNo(accountNo);
		this.setPin(pin);
		this.accountType = accountType;
		this.openedDate = openedDate;
		this.availableBalance = availableBalance;
		
	}
	
	public Account(String accountNo, Integer pin, LocalDateTime openedDate, double availableBalance) throws Validator {
		super();
		this.setAccountNo(accountNo);
		this.setPin(pin);
		this.openedDate = openedDate;
		this.availableBalance = availableBalance;
		
	}
	public Account() {		
		super();
		// TODO Auto-generated constructor stub
	}
	public String getAccountNo() {
		return accountNo;
	}
	public void setAccountNo(String accountNo)throws Validator {
		if(!accountNo.matches("\\d{6}")) 
		{
			throw new Validator("Invalid AccountNo. Format (xxxxxx)");
		}
		this.accountNo = accountNo;
	}
	public Integer getPin() {
		return pin;
	}
	public void setPin(Integer pin)throws Validator {
		if(!pin.toString().matches("\\d{4}")) 
		{
			throw new Validator("Invalid pin");
		}
		
		this.pin = pin;
	}
	
	public AccountType getAccountType() {
		return accountType;
	}
	public void setAccountType(AccountType accountType) {
		this.accountType = accountType;
	}
	public LocalDateTime getOpenedDate() {
		return openedDate;
	}
	public void setOpenedDate(LocalDateTime openedDate) {
		this.openedDate = openedDate;
	}
	public double getAvailableBalance() {
		return availableBalance;
	}
	public void setAvailableBalance(double availableBalance) {
		this.availableBalance = availableBalance;
	}
	@Override
	public String toString() {
		return "Account [accountNo=" + accountNo + ", pin=" + pin + ", accountType=" + accountType + ", openedDate="
				+ openedDate + ", availableBalance=" + availableBalance + "]";
	}
	public void transaction(transactionType type,double anAmount)
	{
		
		Transaction aTransaction =new Transaction(UUID.randomUUID().toString().substring(2, 8),"an transaction",LocalDateTime.now().toString(),anAmount,type);
		
		transactions.add(aTransaction);
		
		if(transactions.size() > 4)
		{
			availableBalance -= 5; 
		}
	    if(aTransaction.Type == transactionType.withdraw)
		{
			this.withdrawl(anAmount);
		}
		else if(aTransaction.Type == transactionType.deposit)
		{
			this.deposit(anAmount);
		}
	
		
	}
	public void withdrawl(double anAmount) {
		this.availableBalance-=anAmount;
		
		
	}
	
	public void deposit(double anAmount) {
		this.availableBalance+=anAmount;
		
	}
}


