using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorillaTagMods.Mods
{
    internal class SpeedBoost
    {
        public static void SpeedBoostMod()
        {
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 2.4f;
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 5.4f;
        }
    }
}
