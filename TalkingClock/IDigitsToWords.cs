using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/************************************************************************************************
 * Name         : Satya Prasad Vanumu
 * Date         : 29/Sep/2021
 * ClassName    : IDigitsToWords
 * Desc         : The IDigitsToWords Interface to declare the method signatures.
 ************************************************************************************************/

namespace TalkingClock
{
    public interface IDigitsToWords
    {
        string ConvertTimeToWords(int H, int M);
    }
}
