package Bus;

public class Date{
	int date;
	int month;
	int year;
	public Date(int date, int month, int year) {
		super();
		this.date = date;
		this.month = month;
		this.year = year;
	}
	public Date() {
		super();
		// TODO Auto-generated constructor stub
	}
	public int getDate() {
		return date;
	}
	public void setDate(int date) {
		this.date = date;
	}
	public int getMonth() {
		return month;
	}
	public void setMonth(int month) {
		this.month = month;
	}
	public int getYear() {
		return year;
	}
	public void setYear(int year) {
		this.year = year;
	}
	@Override
	public String toString() {
		return "Date [date=" + date + ", month=" + month + ", year=" + year + "]";
	}
	

}
