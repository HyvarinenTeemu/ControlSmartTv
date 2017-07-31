using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSmartTv {
    public class RemoteControlLogic {

        TelevisionVolumeControl control = new TelevisionVolumeControl();
        Television tv = new Television();

        //parse userinput to int for boolean comparison as intege  read will give ascii code
        //parsing after getting value is simpler 
        public void ControlLogic(ICollection<KeyValuePair<int, string>> programs) {

            Console.Write("\nValitse no.1 jos haluat nähdä ohjelma listan, no.2 äänenvoimakkuus, no.3 jos haluat sammuttaa television: ");
            string userInput = Console.ReadLine();
            

            switch(Int32.Parse(userInput)) {
                case 1:
                    tv.ChannelList(programs);
                    break;
                case 2:
                    IVolumeControl volume = (IVolumeControl)control;
                    Console.WriteLine("Paina '-' hiljentääksesi ääntä tai '+' koventaaksesi ääntä: ");
                    char volumeUpDown = Console.ReadKey().KeyChar;
                    if(volumeUpDown == '-') {
                        volume.VolumeDown(1);
                    } else {
                        volume.VolumeUp(1);
                    }
                    
                    ControlLogic(programs);

                    break;
                case 3:
                    tv.PowerOff();
                    break;
                default:
                    Console.Write("\nVäärä tieto annettu. ei voida toteuttaa\n");
                    ControlLogic(programs);
                    break;
            }
        }
    }
}
