using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSmartTv {
    public class Television : IRemoteControl {

        private int currentChannel;
        private int newChannel;

        public int Channel { get; set; }

        public void ChangeChannel() {
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
