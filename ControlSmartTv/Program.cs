using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSmartTv {
    public class Program {
        static void Main(string[] args) {

            Television tv = new Television();
            RemoteControlLogic logic = new RemoteControlLogic();

            //create and populate ICollection for programs
            ICollection<KeyValuePair<int, String>> currentPrograms = new Dictionary<int, String>(); 
            currentPrograms.Add(new KeyValuePair<int, string>(1, "How i met your mother"));
            currentPrograms.Add(new KeyValuePair<int, string>(2, "The big bang theory"));
            currentPrograms.Add(new KeyValuePair<int, string>(3, "Surffing"));
            currentPrograms.Add(new KeyValuePair<int, string>(4, "motosport"));
            currentPrograms.Add(new KeyValuePair<int, string>(5, "Terminator"));

            
            string userInput = "";

            Console.Write("Haluatko katsoa televisiota? Paina mitä tahansa numeroa laittaaksesi television päälle: ");
            userInput = Console.ReadLine();

            tv.Channel = Int32.Parse(userInput);
            tv.PowerOn();

            Console.Write("Valitse no.1 jos haluat nähdä ohjelma listan, no.2 äänenvoimakkuus, no.3 jos haluat sammuttaa television: ");
            userInput = Console.ReadLine();
            logic.ControlLogic(currentPrograms, userInput);

            Console.WriteLine("\nValitse ohjelma mitä haluat katsoa: ");
            userInput = Console.ReadLine();

            //modify else statement that it doesn't crash if value is something else than 1 - 5
            if(Int32.Parse(userInput) > 0) {
                tv.Channel = Int32.Parse(userInput);
                tv.ChangeChannel(currentPrograms);
            } else {
                Environment.Exit(0);
            }
        }  
    }
}
 