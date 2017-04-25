import java.io.IOException;

public class Start{
	
	public static Process app;
	
	public static void main (String args[]){
		try{
			app = Runtime.getRuntime().exec("./vrTales.x86_64");
		}catch(IOException a){
			a.printStackTrace();
			System.out.println("Exiting...");
			return;
		}
			SelectButton.createGUI();
			return;
	}
}