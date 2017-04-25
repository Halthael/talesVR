/* Listener Class
 * Writer: Rafael Tomaz Prado
 * Current Version: 7.10.2016.2 [FINAL]
 * 
 * This class implements the Listener, which is the entity that monitors changes on the text file containing
 * the animation commands. 
 * Its Update method is called every frame by the TalitaBehav class and verifies if the specified file has changed.
*/

using System;
using System.IO;

public class Listener{

	string fileName;
	DateTime lastWrite;
	DateTime currentWrite;

	// Constructor method: receives a string containing the path to the file to be monitored.
	public Listener(string file){
		this.fileName = file;
		// Gets the version  of the file on the moment of instantiation.
		lastWrite = File.GetLastWriteTime (fileName);
	}

	// Checks if the file has been modified and returns true if so, else, returns false.
	public bool Update () {
		currentWrite = File.GetLastWriteTime (fileName);
		if (currentWrite != lastWrite) {
			//System.Console.WriteLine ("File updated!");
			lastWrite = currentWrite;
			return true;
		}
		//System.Console.WriteLine ("File NOT updated!");
		return false;
	} // End Update
}
