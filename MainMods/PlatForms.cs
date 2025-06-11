using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

namespace GorillaTagMods.Mods
{
    internal class PlatForms
    {
        private static GameObject Rplat;
        private static GameObject Lplat;

        public static void Platforms()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                if (Rplat == null)
                {
                    Rplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    Rplat.transform.localScale = new Vector3(0.5f, 0.05f, 0.5f);
                    Rplat.GetComponent<Renderer>().material.color = Color.magenta;
                    Rplat.transform.position = GorillaLocomotion.GTPlayer.Instance.rightControllerTransform.position + Vector3.down * 0.1f;
                    Rplat.tag = "Platform";

                    Rigidbody rb = Rplat.GetComponent<Rigidbody>();
                    if (rb == null)
                    {
                        rb = Rplat.AddComponent<Rigidbody>();
                        rb.isKinematic = true;
                    }
                }
            }
            else if (Rplat != null)
            {
                GameObject.Destroy(Rplat);
                Rplat = null;
            }

            if (ControllerInputPoller.instance.leftGrab)
            {
                if (Lplat == null)
                {
                    Lplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    Lplat.transform.localScale = new Vector3(0.5f, 0.05f, 0.5f);
                    Lplat.GetComponent<Renderer>().material.color = Color.magenta;
                    Lplat.transform.position = GorillaLocomotion.GTPlayer.Instance.leftControllerTransform.position + Vector3.down * 0.1f;
                    Lplat.tag = "Platform";

                    Rigidbody rb = Lplat.GetComponent<Rigidbody>();
                    if (rb == null)
                    {
                        rb = Lplat.AddComponent<Rigidbody>();
                        rb.isKinematic = true;
                    }
                }
            }
            else if (Lplat != null)
            {
                GameObject.Destroy(Lplat);
                Lplat = null;
            }
        }
    }
}
