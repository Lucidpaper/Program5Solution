using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
//using System.Speech.Recognition;


namespace Battleship
{
    class Program
    {

        //mouse input http://blogs.msdn.com/b/toub/archive/2006/05/03/589468.aspx?PageIndex=2#comments
        //voice input http://msdn.microsoft.com/en-us/library/system.speech.recognition.speechrecognizer%28v=vs.110%29.aspx
        static void Main(string[] args)
        {         
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice(); 
            synth.Speak("welcome to battleship");
            Grid grid = new Grid();
            grid.PlayGame();
            Console.ReadKey();
        }
    }
}

