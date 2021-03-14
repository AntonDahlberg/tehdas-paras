using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPick : MonoBehaviour
{
    public Transform equipPosition;
    public float distance = 10f;
    GameObject currentWeapon;
    public GameObject weapon1;
    public GameObject weapon;
    GameObject wp;
    

    bool canGrab;

    private void Update()
    {
        checkWeapons();
        if (canGrab)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                
                PickUp();
               
            }
        }
        if(currentWeapon != null)
        {
            if (Input.GetKeyDown(KeyCode.Q))
                Drop();
        }
    }
    private void checkWeapons()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance))
        {
            if (hit.transform.tag == "CanGrap")
            {
              
                canGrab = true;
                wp = hit.transform.gameObject;
            }

        }
        else
            canGrab = false;
            
    }
    private void PickUp()
    {
        currentWeapon = wp;
        currentWeapon.transform.position = equipPosition.position;
        currentWeapon.transform.parent = equipPosition;
        currentWeapon.transform.localEulerAngles = new Vector3(0f, 180f, 0f);
        currentWeapon.GetComponent<Rigidbody>().isKinematic = true;
    }
    private void Drop()
    {
        weapon1.gameObject.SetActive(true);
        weapon.gameObject.SetActive(true);
        currentWeapon.transform.parent = null;
        currentWeapon.GetComponent<Rigidbody>().isKinematic = false;
        currentWeapon = null;
        
        



    }

}
