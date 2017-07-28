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
        public void ControlLogic(ICollection<KeyValuePair<int, string>> programs, string userinput) {

            switch(Int32.Parse(userinput)) {
                case 1:
                    tv.ChannelList(programs);
                    break;
                case 2:
                    IVolumeControl volume = (IVolumeControl)control;
                    volume.VolumeUp(1);
                    break;
                case 3:
                    tv.PowerOff();
                    break;
                default:
                    Console.Write("Väärä tieto annettu. ei voida toteuttaa");
                    break;
            }
        }
    }
}
