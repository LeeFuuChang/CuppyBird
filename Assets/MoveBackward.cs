
using UnityEngine;

public class MoveBackward : MonoBehaviour
{
    // Start is called before the first frame update
    public float move_amount = 0f;
   

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.back * move_amount * Time.deltaTime;
    }
}
