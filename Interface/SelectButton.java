import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.io.File;
import java.io.PrintWriter;
import java.io.IOException;


public class SelectButton extends JPanel implements ActionListener{
	JButton[] menu;
	static JFrame frame;

	public SelectButton(){
		int count = 1;
		String c;
		menu = new JButton[17];
		for(JButton but:menu){
			if(count == 17){
				but = new JButton("Exit");
				but.setVerticalTextPosition(AbstractButton.CENTER);
	        	but.setHorizontalTextPosition(AbstractButton.LEADING);
	        	but.setActionCommand("0");
	        	but.setEnabled(true);
	        	but.addActionListener(this);
	        	add(but);
			}else{
				c = Integer.toString(count);
				but = new JButton(c);
				but.setVerticalTextPosition(AbstractButton.CENTER);
	        	but.setHorizontalTextPosition(AbstractButton.LEADING);
	        	but.setActionCommand(c);
	        	but.setEnabled(true);
	        	but.addActionListener(this);
	        	add(but);
	        	count++;
        	}
		}

	}

	public static void createGUI(){
		frame = new JFrame("Menu");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		SelectButton newMenu = new SelectButton();
		newMenu.setOpaque(true);
		frame.setContentPane(newMenu);
		frame.setSize(120, 305);
		frame.setLocation(670,0);

		frame.setVisible(true);
	}

	public void actionPerformed(ActionEvent e){
		write(e.getActionCommand());
	}

	static void write(String command){
		try{
			File file = new File("./vrTales_Data/message.txt");
			PrintWriter fw;
			if (!file.exists()){
				file.createNewFile();
			}

			switch(command){
				case "1":
					fw = new PrintWriter(file.getAbsoluteFile());
					fw.write("first");
					fw.close();
					break;
				case "2":
					fw = new PrintWriter(file.getAbsoluteFile());
					fw.write("second");
					fw.close();
					break;
				case "3":
					fw = new PrintWriter(file.getAbsoluteFile());
					fw.write("third");
					fw.close();
					break;
				case "4":
					fw = new PrintWriter(file.getAbsoluteFile());
					fw.write("fourth");
					fw.close();
					break;
				case "5":
					fw = new PrintWriter(file.getAbsoluteFile());
					fw.write("fifth");
					fw.close();
					break;
				case "6":
					fw = new PrintWriter(file.getAbsoluteFile());
					fw.write("sixth");
					fw.close();
					break;
				case "7":
					fw = new PrintWriter(file.getAbsoluteFile());
					fw.write("seventh");
					fw.close();
					break;
				case "8":
					fw = new PrintWriter(file.getAbsoluteFile());
					fw.write("eighth");
					fw.close();
					break;
				case "9":
					fw = new PrintWriter(file.getAbsoluteFile());
					fw.write("ninth");
					fw.close();
					break;
				case "10":
					fw = new PrintWriter(file.getAbsoluteFile());
					fw.write("tenth");
					fw.close();
					break;
				case "11":
					fw = new PrintWriter(file.getAbsoluteFile());
					fw.write("eleventh");
					fw.close();
					break;
				case "12":
					fw = new PrintWriter(file.getAbsoluteFile());
					fw.write("twelfth");
					fw.close();
					break;
				case "13":
					fw = new PrintWriter(file.getAbsoluteFile());
					fw.write("thirteenth");
					fw.close();
					break;
				case "14":
					fw = new PrintWriter(file.getAbsoluteFile());
					fw.write("fourteenth");
					fw.close();
					break;
				case "15":
					fw = new PrintWriter(file.getAbsoluteFile());
					fw.write("fifteenth");
					fw.close();
					break;
				case "16":
					fw = new PrintWriter(file.getAbsoluteFile());
					fw.write("sixteenth");
					fw.close();
					break;
				case "0":
					Start.app.destroy();
					frame.dispose();
					return;
				}
		}catch(IOException a){
			a.printStackTrace();
		}
	}
}