using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyChase3 : MonoBehaviour {

    public GameObject myEnemy;
	public GameObject myGameObject;		//THIS dog
	public Transform target;
	public Transform secondaryTarget;
	public float moveSpeed = 1;

	public bool folowPrimary = true;

	//public bool isHit = false;			//used when trying to make one dog follow instead of all of them
	public bool isHit = false;		//this works but makes them all follow
	private bool isCount;		//has the score increase been counted?

	private int countDogHit = -1;
	float yPos;






	private Vector3 smoothVelocity = Vector3.zero;

	int count = 0;

	Rigidbody rb;


	//UI
	public Text coinsText;
	[SerializeField]
	public static float coins;


	void OnCollisionEnter (Collision col){
        if(col.gameObject.tag == "bullet" && isCount == false){		//hit by bullet
			//myChaseScript.isHit = true;
			//EnemyChase3.isHit = true;

			countDogHit++;

			Debug.Log("Before hit registration, isCount is " + myGameObject.GetComponent<EnemyChase3>().isCount + " of " + countDogHit);

			myGameObject.GetComponent<EnemyChase3>().isHit = true;				//triggers dog follow
			myGameObject.GetComponent<EnemyChase3>().isCount = true;
			
		

			GameObject e = Instantiate(myEnemy, myEnemy.transform.position, myEnemy.transform.rotation);
			
			PlayerMove playerRef = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();


			target = playerRef.transform;
	
			if (playerRef.dogList.Count > 0)
			{
				secondaryTarget = playerRef.dogList[playerRef.dogList.Count -1].transform;
			}
			else
			{
				secondaryTarget = playerRef.transform;
			}
			//dog should be put into the arrayList here
			playerRef.dogList.Add(this);

			e.GetComponent<EnemyChase3Enemy>().target = transform;		//sets enemy's transform to be the same as target

			

			//isCount = true;

			//Debug.Log("After hit registration, isCount is " + myGameObject.GetComponent<EnemyChase3>().isCount + " of " + countDogHit);
        }
    }

	void OnTriggerEnter (Collider col){
		if(col.gameObject.tag == "collect"){					//collection point
			Debug.Log("OnTrigger triggered");
			addCoins(5);
			Destroy(myGameObject);
		}		
	}

	private void addCoins(int amt){
			coins += amt;
			string str_coins = coins.ToString();
			coinsText.text = str_coins;	
	}

	EnemyChase3(Transform myFollow2, bool myIsHit){	//because the first target it follows will always be the player
		secondaryTarget = myFollow2;
		isHit = myIsHit;
	}

	// Use this for initialization
	void Start () {

		yPos = transform.position.y;
		isCount = false;

		rb.GetComponent<Rigidbody>();

	}

	//
	
	// Update is called once per frame
	void Update () {

		Vector3 pos = transform.position;
		pos.y = yPos;
		transform.position = pos;


		if(isHit == true && ((Vector3.Distance(secondaryTarget.position, transform.position) > 5 && !folowPrimary) || (Vector3.Distance(target.position, transform.position) > 5 && folowPrimary) ) )
		{
			//dogFollow.Add(new EnemyChase3((Transform)dogFollow[count-1],true));
			//count++;
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
		}

				//for linear movement:

	}

	
		//enemychase needs ontriggerenter, then (if collider.tag is equal to bullet, then hit = true)
	
}

