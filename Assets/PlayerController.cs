using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Jumper jumper;

    void Awake()
    {
        jumper = GetComponent<Jumper>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetMouseButtonDown(0)) { jumper.Jump(); }
            }

    

}