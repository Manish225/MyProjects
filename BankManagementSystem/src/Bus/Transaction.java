package Bus;

import java.io.Serializable;

@SuppressWarnings("serial")
public class Transaction implements Serializable {
	@Override
	public String toString() {
		return "Transaction [transactionNo=" + transactionNo + ", description=" + description + ", transactionDate="
				+ transactionDate + ", amount=" + amount + ", Type=" + Type + "]";
	}
	String transactionNo;
	public String getTransactionNo() {
		return transactionNo;
	}
	public void setTransactionNo(String transactionNo) {
		this.transactionNo = transactionNo;
	}
	String description;
	String transactionDate;
	double amount;
	transactionType Type;
	
	
	public String getDescription() {
		return description;
	}
	public void setDescription(String description) {
		this.description = description;
	}

	public double getAmount() {
		return amount;
	}
	public void setAmount(double amount) {
		this.amount = amount;
	}
	public transactionType getType() {
		return Type;
	}
	public void setType(transactionType type) {
		Type = type;
	}
	public Transaction(  String transactionNo, String description, String transactionDate, double amount,
			transactionType type) {
		super();
		this.transactionNo =transactionNo;
		this.description = description;
		this.transactionDate = transactionDate;
		this.amount = amount;
		Type = type;
	}
	public String getTransactionDate() {
		return transactionDate;
	}
	public void setTransactionDate(String transactionDate) {
		this.transactionDate = transactionDate;
	}
	
	
	

}
