using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject portal;
    public GameObject ramp;
    public GameObject player;
    public float speed;
    public Text countText;
    public Text winText;
    private Rigidbody rb;
    private int count;
    
    void Start()
    {
        count = 0;
        rb = GetComponent<Rigidbody>();
        SetCountText();
        winText.text = " ";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Teleport"))
        {
            SceneManager.LoadScene(1);
        }

        if (other.gameObject.CompareTag("Pick Up"))
        {

            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

        if (other.gameObject.CompareTag("Ramp"))
        {
           ramp.SetActive(true);
        }
    }

    void SetCountText()
    {
        if (count >= 2)
        {
            winText.text = "You win";
            portal.SetActive(true);
        }
        countText.text = "Count" + count.ToString();
    }
}