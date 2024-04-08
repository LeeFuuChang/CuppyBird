using UnityEngine;

public class Jumper : MonoBehaviour

  
{
    Rigidbody rb;

    float _rotate_cur_amount=0f;

    [SerializeField]
    float jump_amount = 0.2f; // 注意这里变量名的命名规范
    [SerializeField]
    float rotate_amount = 1200f;
    [SerializeField]
    float rotate_acc_amount = -15f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (_rotate_cur_amount > 0) _rotate_cur_amount += rotate_acc_amount;
        else _rotate_cur_amount = 0;
        gameObject.transform .Rotate (Vector3.right*rotate_acc_amount*Time.deltaTime);
       
    }

    public void Jump() // 注意方法名的命名规范
    {
        
        rb.velocity = Vector3.up * jump_amount;
        _rotate_cur_amount = rotate_amount;
    }
}
