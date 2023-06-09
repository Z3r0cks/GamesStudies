using UnityEngine;
using Wave.Native;

public class passThrough : MonoBehaviour
{
   // Start is called before the first frame update
   void Start()
   {
      Interop.WVR_ShowPassthroughUnderlay(true);
      Interop.WVR_SetPassthroughImageQuality(WVR_PassthroughImageQuality.QualityMode);
   }
}
