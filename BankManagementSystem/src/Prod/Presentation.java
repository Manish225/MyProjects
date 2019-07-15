package Prod;

import java.util.ArrayList;
import java.util.Scanner;

import Bus.Customer;
import Bus.Validator;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import Bus.transactionType;
import Bus.Account;
import Bus.CheckingAccount;
import Bus.SavingAccount;

public class Presentation {
	

	@SuppressWarnings("unchecked")
	public static void main(String x[]) throws Validator, IOException, ClassNotFoundException, InterruptedException {
		FileInputStream fis = new FileInputStream("src/data/myCustomers.ser");
		ObjectInputStream ois = new ObjectInputStream(fis)	;
		ArrayList<Customer> myCustomers =    (ArrayList<Customer>) ois.readObject();
		int i = 0;
		do {
		System.out.println("Choose an option:");
		System.out.println("1.Create a customer");
		System.out.println("2.Edit a Customer");
		System.out.println("3.Save Customers");
		System.out.println("4.Display Customers");
		System.out.println("5.Remove a customer.");
		System.out.println("6.Search a customer.");
		System.out.println("7.Exit.");


		@SuppressWarnings("resource")
		Scanner scan = new Scanner(System.in);
		
		i= scan.nextInt();
		switch(i)
		{
		case 1:
			CheckingAccount a = new CheckingAccount(); ;
			System.out.println("Account number for your defalut account(6 digits)");
	        a.setAccountNo(scan.next());
			System.out.println("Account pin for your defalut account(6 digits)");
			a.setPin(scan.nextInt());
			System.out.println("Account balance for your defalut account(6 digits)");
			a.setAvailableBalance(scan.nextDouble());
			Customer c1 = new Customer(a);
			System.out.println("Id for the customer(7 digits):");
			c1.setIdentificationNo(scan.nextInt());
			System.out.println("First Name:");
			c1.setFirstName(scan.next());
			System.out.println("Last Name:");
			c1.setLastName(scan.next());
			System.out.println(c1.toString());
			myCustomers.add(c1);
			break;
		case 2:
			System.out.println("Customer Id:");
			int id =scan.nextInt();
			Customer c2 = new Customer();
		    c2 = c2.FindaCustomer(id, myCustomers);
		    if(c2!=null) {
			System.out.println("10. Add a Checking Account");
			System.out.println("11. Add a Saving Account");
			System.out.println("12. Find an Account");
			System.out.println("12. Remove an Account");
			int x1 = scan.nextInt();
			switch(x1)
			{
			case 10:
				CheckingAccount b = new CheckingAccount(); 
				System.out.println("Account number(6 digits)");
		        b.setAccountNo(scan.next());
				System.out.println("Account pin (4 digits)");
				b.setPin(scan.nextInt());
				System.out.println("Account balance");
				b.setAvailableBalance(scan.nextDouble());
				c2.getAccounts().add(b);
				break;
			case 11:
				System.out.println("11. Add a Saving Account");
				SavingAccount s = new SavingAccount();
				System.out.println("Account number(6 digits)");
		        s.setAccountNo(scan.next());
				System.out.println("Account pin (4 digits)");
				s.setPin(scan.nextInt());
				System.out.println("Account balance");
				s.setAvailableBalance(scan.nextDouble());
				System.out.println("Account Annual Interest rate5");
				s.setAvailableBalance(scan.nextDouble());
				break;
			case 12:
				System.out.println("Enter Account No you want to Find:");
				Account a1 = new Account();
				Customer c3 = new Customer();
				a1 = c3.FindAnAccount(scan.next());
				System.out.println(a1.toString());
				Thread.sleep(3000);
			case 13:
				System.out.println("Enter Account No you want to Remove:");
				Customer c4 = new Customer();
				c4.RemoveAnAccount(scan.next());
			}}
			break;
		case 3:
			FileOutputStream   fos = new FileOutputStream("src/data/myCustomers.ser");
			ObjectOutputStream oos = new ObjectOutputStream(fos);
			oos.writeObject(myCustomers);
			oos.close();
			break;
		case 4:
			for(Customer aCustomer : myCustomers)	{
				System.out.println(aCustomer);
			}
			Thread.sleep(3000);
			break;
		case 5:
			System.out.println("Enter Customer id you want to remove:");
			Customer c3 = new Customer();
			c3 = c3.FindaCustomer(scan.nextInt(), myCustomers);
			myCustomers.remove(c3);
			break;
		case 6:
			System.out.println("Enter Customer id you want to find:");
			Customer c4 = new Customer();
			c4 = c4.FindaCustomer(scan.nextInt(), myCustomers);
			if(c4!=null)
			{
				System.out.println(c4.toString());
			}
			Thread.sleep(3000);
			break;
		case 7:
			break;
			default:
				System.out.flush();
				System.out.println("Enter a valid Input.");
				break;
				

		}}while(i!=7);
		
		System.out.println("You are out.");
		
		
	}
}
