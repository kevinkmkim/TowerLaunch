using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject launchButton;
    [SerializeField]
    GameObject tower;

    private bool launched = false;
    private float speed = 0f;
    private float maxSpeed = 10f;
    private float acceleration = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (launched)
        {
            Debug.Log(speed);
            if (speed < maxSpeed)
            {
                speed += acceleration * Time.deltaTime;
            }
            tower.transform.position += new Vector3(0f,0f,speed * Time.deltaTime);
        }
    }

    public void Launch()
    {
        Destroy(launchButton);
        launched = true;
    }
}
