using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
