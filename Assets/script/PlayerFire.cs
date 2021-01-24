using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFire : MonoBehaviour
{

    public Rigidbody projectile;
    public Text ammodisplay;
    public float speed;
    public Animator Aim;
    public Animator animator;
    public float firerate;
    private float nextFire;
    

    public int maxAmmo = 10;
    public int currentAmmo;
    public float reloadTime = 1f;
    private bool isReloading = false;

    
    public AudioClip otherClip;
    private AudioSource playerAudio;


    // Use this for initialization
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();

        currentAmmo = maxAmmo;
            
        
        
    }
    

    // Update is called once per frame
    void Update()
    {
        ammodisplay.text = currentAmmo.ToString();
        if (isReloading)
            return;
        if(currentAmmo <= 0)
        {
            StartCoroutine(reload());
            return;
        }
        
        
        

            if (Input.GetButton("Fire1") && Time.time >= nextFire)
            {
                firerate = 1;
                nextFire = Time.time + 1f / firerate;
                Fire();
               

            }
        if (Input.GetButton("Fire2") && Time.time >= nextFire)
        {
            firerate = 10;
            nextFire = Time.time + 1f / firerate;
            Fire();


        }
        void Fire()
            {
            Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;

            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            playerAudio.PlayOneShot(otherClip, 1.0f);
            currentAmmo--;
            

            }
            
            IEnumerator reload()
            {
                isReloading = true;
                Debug.Log("Reloading...");
                animator.SetBool("Reloading", true);

                yield return new WaitForSeconds(reloadTime - .25f);
                animator.SetBool("Reloading", false);
                yield return new WaitForSeconds(.25f);

            currentAmmo = maxAmmo;
                isReloading = false;
                
            }
        
        


    }
}

