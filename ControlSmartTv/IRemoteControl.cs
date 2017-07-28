using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSmartTv {
    interface IRemoteControl {

        int Channel { get; set; } 
        
        void ChangeChannel(ICollection<KeyValuePair<int, string>> programs);
    

        void ChannelList(ICollection<KeyValuePair<int, string>> programs);
        
        void PowerOn();

        void PowerOff();
    }
}
