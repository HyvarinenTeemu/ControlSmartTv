using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSmartTv {
    interface IVolumeControl {

        void VolumeUp(int plus);

        void VolumeDown(int minus);
    }
}
