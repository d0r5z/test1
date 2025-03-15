using UnityEngine;



public class textboxy1 : MonoBehaviour

{

    public GameObject objectToToggle;

    

    private bool objectVisible = false;



    private void Start()

    {

        objectToToggle.SetActive(false); 

    }



    private void Update()

    {

        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {if(collision.gameObject.tag == "Player")

        {

            objectVisible = true;

            objectToToggle.SetActive(true); 
        }}
    
    }








