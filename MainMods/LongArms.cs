using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorillaTagMods.Mods
{
    internal class LongArms
    {
        public static void LongArmsMod()
        {
            GorillaLocomotion.GTPlayer.Instance.transform.localScale = new UnityEngine.Vector3(1.2f, 1.2f, 1.2f);
        }
    }
}
