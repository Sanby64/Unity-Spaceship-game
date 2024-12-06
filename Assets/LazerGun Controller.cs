using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerGunController : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, t: 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed, Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag != "Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
