package Bus;

public class Validator extends Exception{
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private static String msg = "There is an Exception";
 Validator()
 {
	 super(msg);
	 
 }
 
 public Validator(String msg)
 {
	 super(msg);
 }
}
