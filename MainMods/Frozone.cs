using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GorillaTagMods.Mods
{

    internal class Frozone
    {
        private static readonly Vector3 platformScale = new Vector3(0.5f, 0.05f, 0.5f);
        private static readonly float spawnYOffset = -0.1f;

        public static void FrozeOneMod()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                SpawnCube(GorillaLocomotion.GTPlayer.Instance.rightControllerTransform, Color.blue);
            }
            else
            {
                DestroyCube(GorillaLocomotion.GTPlayer.Instance.rightControllerTransform);
            }

            if (ControllerInputPoller.instance.leftGrab)
            {
                SpawnCube(GorillaLocomotion.GTPlayer.Instance.leftControllerTransform, Color.blue);
            }
            else
            {
                DestroyCube(GorillaLocomotion.GTPlayer.Instance.leftControllerTransform);
            }
        }

        private static void SpawnCube(Transform controller, Color cubeColor)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = controller.position + Vector3.up * spawnYOffset;
            cube.transform.localScale = platformScale;

            cube.GetComponent<Renderer>().material.color = Color.blue;

            cube.tag = "InvisPlat";
        }

        private static void DestroyCube(Transform controller)
        {
            Collider[] colliders = Physics.OverlapSphere(controller.position, 0.5f);
            foreach (Collider collider in colliders)
            {
                if (collider.gameObject.CompareTag("InvisPlat"))
                {
                    UnityEngine.Object.Destroy(collider.gameObject);
                    break;
                }
            }
        }
    }
}
