using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSmartTv {
    class TelevisionVolumeControl : IVolumeControl {
        void IVolumeControl.VolumeDown(int minus) {

            Console.WriteLine("Ääni nyt tasolla " + minus);
        }

        void IVolumeControl.VolumeUp(int plus) {

            Console.WriteLine("Ääni nyt tasolla " + plus);
        }
    }
}
