using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewPlayer : PhysicsObject
{
    [SerializeField] private float maxSpeed = 1;
    [SerializeField] private float jumpPower = 10;
    public int coinsCollected;

    public Text coinsText;
    
    // Start is called before the first frame update
    void Start()
    {
        coinsText = GameObject.Find("Coins").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        targetVelocity = new Vector2(Input.GetAxis("Horizontal") * maxSpeed, 0);

        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y = jumpPower;
        }
    }
    //update ui elements
    public void UpdateUI()
    {
        //coinsText updated in collectables
        coinsText.text = coinsCollected.ToString();
    }
}
