using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dragneel
{
    public interface IEngine
    {
        void InitEngine();

        void UpdateEngine(Rigidbody rb, Dr_Drone_Input input);

    }
}
