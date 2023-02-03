using UnityEngine;
using UnityEngine.AI;

public class RayCast : MonoBehaviour
{
    public Camera cam;
    public GameObject blood;
    public GameObject deermodel;
    public GameObject deermain;
    float delay = 1f;
    public AudioSource gunshot;
    public GameObject player;
    public Rigidbody playerrb;
    float countdown;
    float cd;
    float d = 2f;
    public Vector3 prevtrans;
    public float vel;

    void Start()
    {
        countdown = delay;
        playerrb = player.GetComponent<Rigidbody>();
        cd = d;

    }

    void Update()
    {
        
        if (countdown <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                
                if(1==1)
                {
                    Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
                    RaycastHit hit;
                    gunshot.Play();
                    countdown = delay;
                    if (Physics.Raycast(ray, out hit))
                    {

                        if (hit.transform.tag == "Deer")
                        {
                            //Instantiate(blood, hit.transform.position,hit.transform.rotation);


                            NavMeshAgent na = hit.transform.GetComponent<NavMeshAgent>();
                            Instantiate(deermodel, hit.transform.position, new Quaternion(0, 0, 0, 0));
                            float x = (hit.transform.position.x - transform.position.x);
                            float z = (hit.transform.position.z - transform.position.z);
                            float dist = Mathf.Pow((Mathf.Pow(x, 2) + Mathf.Pow(z, 2)), 0.5f);
                            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 1 + (int)(dist / 20));
                            Destroy(hit.transform.parent.gameObject);




                        }

                    }


                }

                
            }
        }

        else
        {
            countdown -= Time.deltaTime;
        }

    }
}