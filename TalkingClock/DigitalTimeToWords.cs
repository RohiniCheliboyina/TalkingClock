using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkingClock
{

/***************************************************************************************************************************
* Name		: Satya Prasad Vanumu
* Date		: 29/Sep/2021
* ClassName : DigitalTimeToWords
* Desc		: The DigitalTimeToWords Class inherited from IDigitsToWords to define the methods.
****************************************************************************************************************************/
	
	//Class to convert the given digital time to words.
	public class DigitalTimeToWords : IDigitsToWords
	{
		public string sTalkWord = string.Empty;

		// ConvertTimeToWords Static method to convert and print word format.
		public string ConvertTimeToWords(int iHr, int iMn)
		{

			if (iMn == 0)
				sTalkWord = TalkingClock.TimeConstants.sNumbers[iHr] + TalkingClock.TimeConstants.OC;
			else if (iMn == 1)
				sTalkWord = TalkingClock.TimeConstants.OMP + TalkingClock.TimeConstants.sNumbers[iHr];
			else if (iMn == 15)
				sTalkWord = TalkingClock.TimeConstants.QP + TalkingClock.TimeConstants.sNumbers[iHr];
			else if (iMn == 30)
				sTalkWord = TalkingClock.TimeConstants.HP + TalkingClock.TimeConstants.sNumbers[iHr];
			else if (iMn == 45)
				sTalkWord = TalkingClock.TimeConstants.QT + TalkingClock.TimeConstants.sNumbers[(iHr % 12) + 1];
			else if (iMn == 59)
				sTalkWord = TalkingClock.TimeConstants.OMT + TalkingClock.TimeConstants.sNumbers[(iHr % 12) + 1];
			else if (iMn <= 30)
				sTalkWord = TalkingClock.TimeConstants.sNumbers[iMn] + TalkingClock.TimeConstants.MP + TalkingClock.TimeConstants.sNumbers[iHr];
			else if (iMn > 30)				
				sTalkWord = TalkingClock.TimeConstants.sNumbers[60 - iMn] + TalkingClock.TimeConstants.MT + TalkingClock.TimeConstants.sNumbers[(iHr % 12) + 1];
		
			return sTalkWord;
		}

	}
}