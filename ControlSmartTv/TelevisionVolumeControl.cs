using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSmartTv {
    class TelevisionVolumeControl : IVolumeControl {

        int volume = 1;
        void IVolumeControl.VolumeDown(int minus) {
            volume = volume - minus;

            if(volume > 0) {
                Console.WriteLine("\nÄäni nyt tasolla " + volume);
            } else if(volume == 0) {
                Console.WriteLine("\nÄäni mykistetty");
            } else if(volume < 0) {
                Console.WriteLine("\nÄäni mykistetty jo. ei mahdollisuutta alempaan");
                volume = volume + 1;
            }
            
        }

        void IVolumeControl.VolumeUp(int plus) {
            volume = volume + plus;
            Console.WriteLine("\nÄäni nyt tasolla " + volume);
        }
    }
}
