using System;
using Library;

public class Tester{

	static string fileName = "message.txt";
	static Listener list = new Listener("./"+fileName);

	static void Main(string[] args){
		System.Console.WriteLine ("Starting test...");

		while (!list.Update ()) {}
		System.Console.WriteLine ("File updated!");
		string command = System.IO.File.ReadAllText (fileName);

		System.Console.WriteLine (Library.getTrigger(command));
	}
}