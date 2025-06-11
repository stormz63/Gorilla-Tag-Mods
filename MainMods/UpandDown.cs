using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GorillaTagMods.Mods
{
    internal class UpandDown
    {
        public static void UpandDownMod()
        {
            if (ControllerInputPoller.instance.rightControllerIndexTouch > 1.0f)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position += Vector3.up * Time.deltaTime * 5f;
            }

            if (ControllerInputPoller.instance.leftControllerIndexTouch > 1.0f)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position += Vector3.down * Time.deltaTime * 5f;
            }
        }
    }
}
