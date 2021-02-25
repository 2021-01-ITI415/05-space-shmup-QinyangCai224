using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    public float speed = 5f;
    public float deactivate_Timer = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DeactiveGameObject", deactivate_Timer);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 temp = Transform.position;
        temp.y += speed * Time.deltaTime;
        transform.position = temp;
    }
}
