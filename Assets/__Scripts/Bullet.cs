using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour{
    public float speed = 5f;
    public float deactivate_Timer = 3f;
    public bool is_EnemyBullet = false;

    
    // Start is called before the first frame update
    void Start()
    {
        if (is_EnemyBullet)

            speed *= -1f;
        Invoke("DeactiveGameObject", deactivate_Timer);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;
        transform.position = temp;
    }
    void OnTriggerEnter(Collider target)
    {
        if(target.tag == "Bullet" || target.tag == "Enemy")
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
