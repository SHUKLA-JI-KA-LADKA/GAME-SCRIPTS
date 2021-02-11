using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
    {

        public Camera FpsCam;
        public Camera TpsCam;
        bool fpsCam = true;

        void Start()
        {
            FpsCam.enabled = fpsCam;
            TpsCam.enabled = !fpsCam;

        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                fpsCam = !fpsCam;
                FpsCam.enabled = fpsCam;
                TpsCam.enabled = !fpsCam;

            }
        }
    }




