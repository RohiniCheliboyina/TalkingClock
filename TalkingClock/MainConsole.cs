using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************************************************************************************
 * Name			: Satya Prasad Vanumu
 * Date			: 29/Sep/2021
 * ClassName	: MainConsole
 * Desc			: The MainConsole Class of a Talking Clock, to convert and display current time in a 
 *				: more "Human Friendly" way with Words.
 **************************************************************************************************************/
class MainConsole
{		
	// The Main Function Code for given Objectives
	static void Main()
	{
		int iHours;
		int iMins;
		string sTalkWord;

		TalkingClock.DigitalTimeToWords oDigitToWord = new TalkingClock.DigitalTimeToWords();

		//Objective 1 Part of the Solution Starts Here.

		var currdate = DateTime.Now;
		Console.WriteLine("The Current Time is : " + currdate.ToString("HH:mm"));

		iHours = currdate.Hour;
		iMins = currdate.Minute;

		sTalkWord = oDigitToWord.ConvertTimeToWords(iHours, iMins);
		Console.WriteLine(sTalkWord);
		Console.WriteLine();

		//Objective 1 Part of the Solution Ends Here.	


		//Objective 2 Part of the Solution Starts Here
		bool bktop = true;
		string option;
			while (bktop)
			{

				Console.WriteLine("Enter the time in hours,minutes in HH:mm format: ");
				string sConsoleString = Console.ReadLine();
				//If pressed enter here without a  value or data string, stop the  program here without
				//further execution??
				if (string.IsNullOrWhiteSpace(sConsoleString))
					return;
				else if (sConsoleString.Length > 0)
				{
					if (sConsoleString.Contains(":"))
					{ 
						string[] sSplit = sConsoleString.ToString().Split(':');
						iHours = Convert.ToInt32(sSplit[0]);
						iMins = Convert.ToInt32(sSplit[1]);

						if (iHours > 24)
						{ 
							Console.WriteLine("Enter the correct value for hours field.");
							Main();
						}

						if (iMins > 60)
						{
							Console.WriteLine("Enter the correct value for minutes field.");
							Main();
						}
						sTalkWord = oDigitToWord.ConvertTimeToWords(iHours, iMins);
						Console.WriteLine(sTalkWord);
						Console.WriteLine();
				}
					else
					{
						Console.WriteLine("Wrong time format entered.");
						Main();
					}
			}

				Console.WriteLine("Do you want to continue? Enter 'Y' for continue, 'N' or any other key to exit.");
				option = Console.ReadLine();
				if (option.ToUpper() == "Y")
				{
					bktop = false;
					Main();
				}
				else
				{					
					Environment.Exit(-1);
				}
				Console.ReadLine();
			}
		//Objective 2 Part of the Solution Ends Here
	}
}

