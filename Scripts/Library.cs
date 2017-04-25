/* AnimationLibrary
 * Writer: Rafael Tomaz Prado
 * Current Version: 28.10.2016.1 [FINAL]
 * 
 * Compile with: csc /target:library /out:AnimationsLib.dll AnimationsLib.cs
 * 
 * The Library is intended to hold a database of animations commands using an effective way
 * to correspond them with their respective trigger names.
 * 
 * The method getTrigger() returns the corresponding trigger name to the argument passed.
*/

using System;
using System.Collections.Generic;

public class Library{
	public struct Animation{
		public string command;
		public string trigger;

		public Animation(string c, string t){
			this.command = c;
			this.trigger = t;
		}
	}

	public static Animation[] Shelf = {
		new Animation ("first", "firstAnimation"),
		new Animation ("second", "secondAnimation"),
		new Animation ("third", "thirdAnimation"),
		new Animation ("fourth", "fourthAnimation"),
		new Animation ("fifth", "fifthAnimation"),
		new Animation ("sixth", "sixthAnimation"),
		new Animation ("seventh", "seventhAnimation"),
		new Animation ("eighth", "eighthAnimation"),
		new Animation ("ninth", "ninthAnimation"),
		new Animation ("tenth", "tenthAnimation"),
		new Animation ("eleventh", "eleventhAnimation"),
		new Animation ("twelfth", "twelfthAnimation"),
		new Animation ("thirteenth", "thirteenthAnimation"),
		new Animation ("fourteenth", "fourteenthAnimation"),
		new Animation ("fifteenth", "fifteenthAnimation"),
		new Animation ("sixteenth", "sixteenthAnimation"),
		new Animation ("seventeenth", "seventeenthAnimation")
	};

	public static string getTrigger(string cmd){
		foreach (Animation anim in Shelf) {
			if (cmd == anim.command)
				return anim.trigger;
		}
		return "ERROR";
	}
}