using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GorillaTagMods.Mods.FunMods
{
    internal class FlipGorilla
    {
        public static void FlipGorillaMod()
        {
            var player = GorillaLocomotion.GTPlayer.Instance;
            if (player != null)
            {
                player.transform.rotation = Quaternion.Euler(180f, 180f, 180f);
            }
        }
    }
}
