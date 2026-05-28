using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Part2OfPoe
{
    public class chatbot_voice
    {
        // speech synthesizer object to convert text to speech
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        // This method takes a string input (chatbot_response) and uses the SpeechSynthesizer to convert the text to speech.
        public void speak(string chatbot_response)
        {
           
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);
            synthesizer.Rate = 2;
            synthesizer.Volume = 100;
            synthesizer.SpeakAsync(chatbot_response);
        }
       

    }
}
