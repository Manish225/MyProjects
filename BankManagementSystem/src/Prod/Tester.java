package Prod ;
import Bus.Validator;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;
import Bus.Customer;
import Bus.transactionType;
public class Tester {
		@SuppressWarnings("unchecked")
		public static void main(String x[]) 
		     throws IOException, FileNotFoundException, ClassNotFoundException,Validator
		
	{	try {
			ArrayList<Customer> myCustomerFromConsole = new ArrayList<Customer>();	
			ArrayList<Customer> myCustomerFromFile = new ArrayList<Customer>();	
			
			//write to binary file
			FileOutputStream   fos = new FileOutputStream("src/data/myCustomers.ser");
			ObjectOutputStream oos = new ObjectOutputStream(fos);
			
			//read from binary file
			FileInputStream fis = new FileInputStream("src/data/myCustomers.ser");
			ObjectInputStream ois = new ObjectInputStream(fis)	;	
			
			  Customer C1 = new Customer(1111111,"Jot","Swag",1234,100,"345678");
			   
			
			   C1.openAnSavingAccount("234567",2345, 2345);
			   C1.getAccounts().get(0).transaction(transactionType.deposit, 100);
			   C1.getAccounts().get(0).transaction(transactionType.deposit, 100);
			   C1.getAccounts().get(0).transaction(transactionType.deposit, 100);
			   C1.getAccounts().get(1).transaction(transactionType.deposit, 112);
			   C1.getAccounts().get(1).transaction(transactionType.deposit, 100);
			   C1.getAccounts().get(1).transaction(transactionType.deposit, 100);
			   C1.getAccounts().get(1).transaction(transactionType.deposit, 100);
			   C1.getAccounts().get(1).transaction(transactionType.deposit, 100);
			   C1.getAccounts().get(1).transaction(transactionType.withdraw,100);
			   Customer C2 = new Customer(6574884,"Gagan","Kaur",1334,113,"546738");
			   
			   C2.openAnSavingAccount("123456",1234,3456);
			   C2.getAccounts().get(0).transaction(transactionType.deposit, 20);
			   C2.getAccounts().get(0).transaction(transactionType.deposit, 120);
			   C2.getAccounts().get(0).transaction(transactionType.withdraw, 100);
			   
			  
			myCustomerFromConsole.add(C1); 
			myCustomerFromConsole.add(C2);
			
			System.out.println("\n Customers From CONSOLE....\n");
			for(Customer aCustomer : myCustomerFromConsole){
				System.out.println(aCustomer);
			}	
			oos.writeObject(myCustomerFromConsole);	
			myCustomerFromFile =    (ArrayList<Customer>) ois.readObject();	

			System.out.println("\n Customers From FILE....\n");
			for(Customer aCustomer : myCustomerFromFile)	{
				System.out.println(aCustomer);
			}
			
			oos.close();
			ois.close();
			

		} catch (Validator e) {
			// TODO Auto-generated catch block
			System.out.println(e.getMessage());
		}
	}
		}
   

