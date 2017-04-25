/* Talita Behaviour Script
 * Writer: Rafael Tomaz Prado
 * Current Version: 10.10.2016.1
 * 
 * This script controls the behaviour of Talita.
 * 
 * The transitions among animations is made via the Animator interface on Unity3D engine.
 * This script reads the given commands via txt file and sets the corresponding triggers on the animator.
 * 
 * -Version 10.10.2016.1
 * 		> Removal of enum Phrases (did not work as expected).
 * 		> Update method has been expanded to call an extra animation.
 * 
 * -Version 7.10.2016.1:
 * 		> Implementation of the enum Phrases, containing the hashcodes to the animation triggers.
 * 		> Re-write of Update method. It now uses the Listener class to monitor file updates and only reads the commands if the file
 * 		  has been recently updated.
 *      > The action for each command is selected from a switch-case structure that sets the proper Animator Trigger.
 * 
 * -Version 6.10.2016.1:
 * 		> Opening an external file and collecting instructions;
 * 		> Control of animation via C# script;
 * 	The transition between the 'Idle' animation is managed by the Animator Controller and only occurs 
 * when the trigger parameter 'First' is enabled - this controlled by the Update method below. 
 */

using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;

public class TalitaBehav : MonoBehaviour {

	// Reference to the AnimatorControl
	Animator anim;
	// String that contains the command read from the text file.
	string command;
	// String to hold the trigger to be converted to hash
	string trigger;
	// Contains the text file name.
	string fileName;
	// A listener that monitors the file activities
	Listener mainListener;

	void Start () {
		// Loads the Animator reference
		anim = GetComponent<Animator> ();
		// Sets the correct file path
		fileName = Application.dataPath+"/message.txt";

		// Instantiates the listener using the file path;
		mainListener = new Listener (fileName);
	}

	void Update () {
		// If the file has changed, read the info.
		if (mainListener.Update ()) {
			// Reads the file content and stores it into the 'command' variable
			command = System.IO.File.ReadAllText (fileName);
			// Uses the command to get a corresponding trigger in the Library
			trigger = Library.getTrigger (command);

			// If the command read from the file is valid, sets the proper trigger
			if (trigger == "ERROR")
				System.Console.WriteLine ("ERROR: Invalid command.");
			else {
				anim.SetTrigger (Animator.StringToHash (trigger));
			}
		}
	}// End Update
}