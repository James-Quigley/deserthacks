using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour {
	public GameController gc;
	public Vector3 defPos;
	List<char> letters;
	public GameObject keyboard;
	public GameObject gkey;
	List<GameObject> keys;
	public Key keyprefab;
    public Rigidbody player;
    public List<GameObject> pressedKey;
    float timeDelt;

	Dictionary<char, GameObject> dict;
		

	// Use this for initialization
	void Start () {
        timeDelt = 0;
		dict = new Dictionary<char, GameObject>();
		// other
		foreach (Transform row in keyboard.transform) {
			foreach (Transform key in row.transform) {
				dict.Add ((char)key.gameObject.name.ToCharArray () [0], key.gameObject);
			}
		}
		defPos = this.transform.position;
		foreach (KeyValuePair<char, GameObject> pair in dict)
		{
			Debug.Log(pair.Key.ToString ()+ "  -  "  + pair.Value.transform.position);
		}
	}
	
	// Update is called once per frame
	void Update () {
        timeDelt = timeDelt + Time.deltaTime;
        if(timeDelt > .8)
        {
            pressedKey.Add(spawnKey((char)((int)Random.Range(65, 90))));
            timeDelt = 0;
        }
        foreach (char c in Input.inputString)
        {
            foreach (GameObject k in pressedKey) {
                Debug.Log(("" + c).ToUpper());
                Debug.Log(""+k.GetComponent<Key>().getLetter());
                if (string.Compare((""+c).ToUpper(), ""+ k.GetComponent<Key>().getLetter())==0)
                {
                    //  if ((k.transform.position.z == player.transform.position.z))
                    
                Debug.Log("ENTERED");
                    pressedKey.Remove(k);
                    Destroy(k);
                }
            }
        }
            // ((pressedKey.transform.position.z - player.transform.position.z < 0.5) || (pressedKey.transform.position.y - player.transform.position.y < 0.5) || ((pressedKey.transform.position.z - player.transform.position.z < 0.5)))
            //     if ((pressedKey.transform.position - player.transform.position).sqrMagnitude < 0.2)
            //     //if ((pressedKey.transform.position.z == player.transform.position.z))
            //     {
            //         Debug.Log("Direct Hit CLOSE");
            //Destroy (pressedKey);
            //     }
        }
	GameObject spawnKey(char letter){
		Vector3 pos = dict[letter].transform.position;
        //GameObject key = Instantiate (gkey, pos, dict[letter].transform.rotation);
        GameObject pk = Instantiate(gkey, pos, dict[letter].transform.rotation);
        pk.GetComponent<Key>().setLetter(letter);
        return pk;
	}
}
