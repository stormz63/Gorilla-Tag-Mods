using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorillaTagMods.Mods.FunMods
{
    internal class UpSideDownHead
    {
        public static void UpSideDownHeadMod()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 180f;
        }
    }
}
