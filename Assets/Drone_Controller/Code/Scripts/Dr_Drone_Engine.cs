using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dragneel
{
    [RequireComponent(typeof(BoxCollider))]
    public class Dr_Drone_Engine : MonoBehaviour , IEngine
    {
        #region Variable
        [Header("Engine Properties")]
        [SerializeField]private float maxPower = 4f;
        #endregion


        #region Interface Methods
        public void InitEngine()
        {
            throw new System.NotImplementedException();
        }
        public void UpdateEngine(Rigidbody rb , Dr_Drone_Input input)
        {
           Debug.Log("Running Engine: " + gameObject.name);
           Vector3 engineForce = Vector3.zero;
           engineForce = transform.up * ((rb.mass * Physics.gravity.magnitude) + input.Throttle * maxPower )/ 4f ;

           rb.AddForce(engineForce, ForceMode.Force);
        }


        #endregion
    }
}
