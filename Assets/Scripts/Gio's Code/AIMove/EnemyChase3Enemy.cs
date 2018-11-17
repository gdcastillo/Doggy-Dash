using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyChase3Enemy : MonoBehaviour {


    public GameObject myEnemy;
	public Transform target;
	public Transform secondaryTarget;
	public float smoothTime = 0.6f;
	public float moveSpeed = 1;

	public bool folowPrimary = true;

	//public bool isHit = false;			//used when trying to make one dog follow instead of all of them
    public bool isHit = false;
	public bool isAte = false;		//this works but makes them all follow

	private Vector3 smoothVelocity = Vector3.zero;
    private GameObject d;

	int count = 0;
    bool wait = false;

	Rigidbody rb;
    PlayerMove playerRef;

    //UI
    [SerializeField]
    public Text coinsText;

	void OnCollisionEnter(Collision col){
		if(col.gameObject.name == "0" || col.gameObject.name == "1" || col.gameObject.name == "2" || col.gameObject.name == "3" || col.gameObject.name == "4" || col.gameObject.name == "5" || col.gameObject.name == "6" || col.gameObject.name == "7" || col.gameObject.name == "8"){
			Destroy(col.gameObject);
            isAte = true;
            transform.Translate(Vector3.forward * Time.deltaTime);
            Destroy(gameObject);

            if(EnemyChase3.coins >= 5)
            {
                EnemyChase3.coins -= 5;

                string str_coins = EnemyChase3.coins.ToString();
			    coinsText.text = str_coins;	
            }
		}
		 //transform.position += transform.forward * Time.deltaTime * 50f;


         if(col.gameObject.tag == "bullet"){
             wait = true;
             StartCoroutine(Wait());
         }
        

        

	}

	// Use this for initialization
	void Start () {

        playerRef = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();


		rb = GetComponent<Rigidbody>();

		//might need to move this to Update
        //target = chaseThis();
        //secondaryTarget = chaseThis();
    
        target = chaseThis();
        secondaryTarget = chaseThis();

        coinsText = GameObject.Find("Coins_Text").GetComponent<Text>();

        isAte = false;

		count++;

	}

	//
	
	// Update is called once per frame
	void Update () {


        //player = myIfs();
        //secondaryTarget = myIfs();
        
        //so if 0 exists, then player and secondarytarget is 0 and so on


        //dogFollow.Add(new EnemyChase3((Transform)dogFollow[count-1],true));
        //count++;
        if(isAte == false && wait == false){
            if (rb != null)
            rb.velocity = Vector3.zero;


            if (Input.GetKeyDown(KeyCode.Space))
            {

                folowPrimary = !folowPrimary;


            }
            if (folowPrimary)
            {

                transform.LookAt(target);
            }
            else
            {

                transform.LookAt(secondaryTarget);			
            }
            //transform.position = Vector3.SmoothDamp(transform.position, player.position, ref smoothVelocity, smoothTime);
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

            //instantiate the bad guy who's immediately following
        

                //for linear movement:
        }
        

	}

    Transform myIfs(){
        if(GameObject.Find("0") != null){
            return GameObject.Find("0").transform;
        }
        else if(GameObject.Find("1") != null){
            return GameObject.Find("1").transform;
        }
        else if(GameObject.Find("2") != null){
            return GameObject.Find("2").transform;
        }
        else if(GameObject.Find("3") != null){
            return GameObject.Find("3").transform;
        }
        else if(GameObject.Find("4") != null){
            return GameObject.Find("4").transform;
        }
        else if(GameObject.Find("5") != null){
            return GameObject.Find("5").transform;
        }
        else if(GameObject.Find("6") != null){
            return GameObject.Find("6").transform;
        }
        else if(GameObject.Find("7") != null){
            return GameObject.Find("7").transform;
        }
        else if(GameObject.Find("8") != null){
            return GameObject.Find("8").transform;
        }else if(GameObject.Find("TDog") != null){
            return GameObject.Find("TDog").transform;
        }
        return null;
    }

    IEnumerator Wait()
    {
        print(Time.time);
        yield return new WaitForSeconds(0.5f);
        print(Time.time);
        wait = false;
    }
    Transform chaseThis(){
        Debug.Log("Chase this");
        return playerRef.dogList[0].transform; 
    }

	
		//enemychase needs ontriggerenter, then (if collider.tag is equal to bullet, then hit = true)
	
}

