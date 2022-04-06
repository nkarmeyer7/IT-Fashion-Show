using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handle_Controller : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private GameObject handle;
    private bool pickedUp;
    [SerializeField] Transform initPoision;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        pickedUp = false;
    }

    private void FixedUpdate()
    {
        if (pickedUp)
        {
            handle.GetComponent<Rigidbody>().MovePosition(this.transform.position);
        }
    }

    public void PickUp()
    {
        rb.isKinematic = false;
        this.gameObject.layer = 9;
        pickedUp = true;  
    }

    public void Drop()
    {
        pickedUp = false;
        this.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        rb.isKinematic = true;
        StartCoroutine(Cooldown());
    }


    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(1);
        this.transform.position = initPoision.position;
        this.gameObject.layer = 8;
    }

}
