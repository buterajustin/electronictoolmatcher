using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.InputSystem;



public class ActivateTeleportationRay : MonoBehaviour

{

    public GameObject leftTeleportationRay;

    public GameObject rightTeleportationRay;

    public GameObject leftGrab;

    public GameObject rightGrab;

    public InputActionProperty leftSelect;

    public InputActionProperty rightSelect;



    // Start is called before the first frame update

    void Start()

    {



    }



    // Update is called once per frame

    public void Update()

    {

        bool isLeftPressed = leftSelect.action.ReadValue<float>() > 0.1f;

        bool isRightPressed = rightSelect.action.ReadValue<float>() > 0.1f;



        // Handle left teleportation ray

        if (isLeftPressed)

        {

            leftTeleportationRay.SetActive(true);

            leftGrab.SetActive(false);

        }

        else

        {

            leftTeleportationRay.SetActive(false);

            leftGrab.SetActive(true);

        }



        // Handle right teleportation ray

        if (isRightPressed)

        {

            rightTeleportationRay.SetActive(true);

            rightGrab.SetActive(false);

        }

        else

        {

            rightTeleportationRay.SetActive(false);

            rightGrab.SetActive(true);

        }

    }

}
