using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorillaTagMods.Mods.FunMods
{
    internal class SideWaysHead
    {
        public static void SideWaysHeadMod()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.y = 90f;
        }
    }
}
