using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        control();
    }

    void control()
    {
        float hori = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float verti = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector3 pos = this.transform.position;
        Vector3 newPos = new Vector3(pos.x + hori, pos.y + verti, pos.z);
        this.transform.position = newPos;
    }
}
