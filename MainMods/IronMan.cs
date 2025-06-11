using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GorillaTagMods.Mods
{
    internal class IronMan
    {
        public static void IronManMod()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position += Vector3.up * 5f;


                Rigidbody rb = GorillaLocomotion.GTPlayer.Instance.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.velocity = Vector3.zero;
                    rb.angularVelocity = Vector3.zero;
                }
            }
        }
    }
}
