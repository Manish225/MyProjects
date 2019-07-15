package Bus;

import java.util.ArrayList;
import java.util.UUID;

import java.io.Serializable;
import java.time.LocalDateTime;
public class Customer implements Serializable {
	
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	Integer identificationNo;
	String firstName;
	String lastName;
	ArrayList<Account> accounts = new ArrayList<Account>(); //Default Checking Account
	
	public ArrayList<Account> getAccounts() {
		return accounts;
	}

	public void setAccounts(ArrayList<Account> accounts) {
		this.accounts = accounts;
	}
	public Customer()
	{
		
	}

	public Customer(Integer identificationNo, String firstName, String lastName,int pin,double avail,String accountno) throws Validator {
		super();
		
		this.setIdentificationNo(identificationNo);
		this.setFirstName(firstName);
		this.setLastName(lastName);
		accounts.add(new CheckingAccount (accountno,pin ,LocalDateTime.now(),avail));//Default Checking Account
		
	}

	public Customer(CheckingAccount a) throws Validator {
		super();
		accounts = new ArrayList<Account>();
		// TODO Auto-generated constructor stub
		accounts.add(a);
	}

	public Integer getIdentificationNo() {
		return identificationNo;
	}

	public void setIdentificationNo(Integer identificationNo) throws Validator {
		if(!identificationNo.toString().matches("\\d{7}"))
		{
			throw new Validator("Invalid id"); 	
		}
		this.identificationNo = identificationNo;
	}

	public String getFirstName() {
		return firstName;
	}

	public void setFirstName(String firstName) throws Validator{
		if(!firstName.matches("[a-zA-Z]{1,}"))
		{
			throw new Validator("Invlaid First Name. Please characters only");
		}
		this.firstName = firstName;
	}

	public String getLastName() {
		return lastName;
	}

	public void setLastName(String lastName)throws Validator {
		if(!lastName.matches("[a-zA-Z]{1,}\\s{0,}[a-zA-Z]{0,}"))
		{
			throw new Validator("Invlaid Last Name. Please characters only");
		}
		this.lastName = lastName;
	}

	public String listacc()
	{
		String info = null;
		for(Account anAccount : accounts)
		{
			//info =  "AccountNo =  " +  anAccount.getAccountNo()+ "\n" + "Opened Date = " + anAccount.getOpenedDate().toString()+"\n" + "Account Type = "  + anAccount.getAccountType()+ "\n"+ "Available Balance = " + (anAccount.getAvailableBalance()) + "\n";
			info += anAccount.toString() + "\n";		
		}
		return info;
	}
	@Override
	public String toString() {
		return "Customer [identificationNo=" + identificationNo + "\n"+  ", firstName=" + firstName + "\n"+ ", lastName=" + lastName
				+"\n"+ ", accounts=" + listacc() + "]";
	}
public void openAnCheeckingAccount(String accountno,int pin,double balance) throws Validator
{
		accounts.add(new CheckingAccount(accountno,pin ,LocalDateTime.now(),balance));
}
public void openAnSavingAccount(String accountno,int pin,double balance) throws Validator {

	
		accounts.add(new SavingAccount (accountno,pin,LocalDateTime.now(),balance,0.26,100));
	
}
public Customer FindaCustomer(int id,ArrayList<Customer> custlist)
{
	for(Customer c:custlist)
	{
		if(c.identificationNo==id)
		{
			return c;
		}
	}
	System.out.println("No such Customer");
	return null;
	}
public Account FindAnAccount(String id)
{
	for(Account a:this.accounts)
	{
		if(a.accountNo==id)
		{
			return a;
		}
	}
	System.out.println("No such Customer");
	return null;
	}

public void RemoveAnAccount(String id)
{
	for(Account a:this.accounts)
	{
		if(a.accountNo==id)
		{
			this.accounts.remove(a);
		}
	}
	System.out.println("No such Account");
	
	}
}


	
