using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dragneel 
{
    [RequireComponent(typeof(Rigidbody))]

    public class Dr_Base_Rigidbody : MonoBehaviour
    {
        #region Variables
        [Header("Regidbody Properties")]
        [SerializeField] private float weightInLbs = 1f;

        const float lbstoKg = 0.454f; 
        
        protected Rigidbody rb;
        protected float startDrag;
        protected float startAngularDrag;
        #endregion

        #region Main Methods
        // Start is called before the first frame update
        void awake()
        {
            rb = GetComponent<Rigidbody>();
            if (rb)
            {
                rb.mass = weightInLbs * lbstoKg;
                startDrag = rb.drag;
                startAngularDrag = rb.angularDrag;
            }
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (!rb)
            {
                return;
            }

            HandlePhysics();
        }
        #endregion

        #region Custom Methods
        protected virtual void HandlePhysics() { }
        #endregion
    }
}