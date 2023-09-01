using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Unity.VisualScripting;
using TMPro;
using UnityEngine.SceneManagement;

public class ArrowController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody _rigidbody;
    [SerializeField]
    private float _speed = 2000f;
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private Transform arrowPosition;
    public static int score = 0;
    public static int lives = 3;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
       
        if (transform.position.z > 25.0f)
        {
            
            transform.position = new Vector3(0.26f, 0f, -0.37f);
            _rigidbody.velocity = Vector3.zero;
            lives -= 1;
            
            if (lives <= 0)
            {
                SceneManager.LoadScene("Game Over");
            }
        }
        
        Vector3 pos = transform.position;
        if(Input.GetKey(KeyCode.UpArrow)){
            pos.y += 0.03f;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            pos.y -= 0.03f;
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            pos.x -= 0.03f;
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            pos.x += 0.03f;
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            _rigidbody.AddForce(transform.forward * _speed);
        }
        transform.position = pos ;
      
    }
    void OnTriggerEnter(Collider collider){
       
        if(collider.gameObject.tag == "target")
        {
            
            score += 1;
        }
        _rigidbody.velocity = Vector3.zero;
        Thread.Sleep(300);
        transform.position = new Vector3(0.26f, 0f, -0.37f);
    }
}
