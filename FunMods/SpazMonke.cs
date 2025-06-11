using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GorillaTagMods.Mods.FunMods
{
    internal class SpazMonke
    {
        public static void SpazMonkeMod()
        {
            GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3(UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360));
            GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3(UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360));
            GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3(UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360));
            GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3(UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 180), UnityEngine.Random.Range(0, 180));
            GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3(UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 180), UnityEngine.Random.Range(0, 180));
            GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3(UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 180), UnityEngine.Random.Range(0, 180));
        }
    }
}
