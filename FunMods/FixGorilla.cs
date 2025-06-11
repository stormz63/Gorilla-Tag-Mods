using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GorillaTagMods.Mods.FunMods
{
    internal class FixGorilla
    {
        public static void FixGorillaMod()
        {
            var player = GorillaLocomotion.GTPlayer.Instance;
            if (player != null)
            {
                player.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
        }
    }
}
