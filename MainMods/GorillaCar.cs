using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GorillaTagMods.Mods
{
    internal class GorillaCar
    {
        public static void GorillaCarMod()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position += GorillaLocomotion.GTPlayer.Instance.transform.forward * Time.deltaTime * 15f;
            }

            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position -= GorillaLocomotion.GTPlayer.Instance.transform.forward * Time.deltaTime * 20f;
            }
        }
    }
}
