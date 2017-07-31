using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSmartTv {
    public class Television : IRemoteControl {

        

        public int Channel { get; set; }

        public void ChangeChannel(ICollection<KeyValuePair<int, string>> programs) {
            //use LINQ to get value from programs keyvaluepair collection 
            var selectedProgram = from val in programs where val.Key == Channel select val.Value;

            //get matched program from variable and output to console
            foreach(var match in selectedProgram) {
                Console.WriteLine("\nKatselu aloitettu ohjelmalle: " + match + "\n");
            }
        }

        //get ICollection via parameter generated from main class
        //loop trough key value pairs and output to console
        public void ChannelList(ICollection<KeyValuePair<int, string>> currentPrograms) {
            foreach(KeyValuePair<int, string> programs in currentPrograms) {
                Console.WriteLine("{0}, {1}", programs.Key, programs.Value);
            }
        }

        public void PowerOff() {
        }

        public void PowerOn() {
            Console.WriteLine("\nTelevisio on päällä");
        }

     
    }    
}
