
using UnityEngine;

public class RandomY : MonoBehaviour
{
    [SerializeField]
    float max_y = 6;
    [SerializeField]
    float min_y = -6;
   
    void Awake()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(max_y, min_y);
        transform.position = pos;
    }

}
