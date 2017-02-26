using System.Collections;using System.Collections.Generic;using UnityEngine;public class KeySpawner : MonoBehaviour {	public GameController gc;	public Vector3 defPos;	List<char> letters;	public GameObject keyboard;	public GameObject gkey;	List<GameObject> keys;	public Key keyprefab;    public Rigidbody player;    public GameObject pressedKey;	public double timeDelt;	Dictionary<char, GameObject> dict;			// Use this for initialization	void Start () {		dict = new Dictionary<char, GameObject>();		// other		foreach (Transform row in keyboard.transform) {			foreach (Transform key in row.transform) {				dict.Add ((char)key.gameObject.name.ToCharArray () [0], key.gameObject);			}		}		defPos = this.transform.position;		foreach (KeyValuePair<char, GameObject> pair in dict)		{			Debug.Log(pair.Key.ToString ()+ "  -  "  + pair.Value.transform.position);		}		timeDelt = 0;	}		// Update is called once per frame	void Update () {		timeDelt += Time.deltaTime;		if (timeDelt > .3) {			Debug.Log ("spawn!");			timeDelt = 0;			spawnKey ((char)Random.Range(65,90));		}		if (Input.GetKeyDown ("a")) {			Debug.Log ("a is pressed");				pressedKey = spawnKey ('A');		}		if (Input.GetKeyDown ("s")) { 			Debug.Log ("s is pressed");
            pressedKey = spawnKey('S');		}		if (Input.GetKeyDown ("d")) {			Debug.Log ("d is presed");
            pressedKey = spawnKey('D');		}		if (Input.GetKeyDown ("f")) {			Debug.Log ("f is pressed");
            pressedKey = spawnKey('F');		}		if (Input.GetKeyDown ("g")) {			Debug.Log ("g is pressed");
            pressedKey = spawnKey('G');		}		if (Input.GetKeyDown ("h")) {			Debug.Log ("g is pressed");
            pressedKey = spawnKey('H');		}		if (Input.GetKeyDown ("j")) {			Debug.Log ("j is pressed");
            pressedKey = spawnKey('G');		}		if (Input.GetKeyDown ("k")) {			Debug.Log ("k is pressed");
            pressedKey = spawnKey('K');		}		if (Input.GetKeyDown ("l")) {			Debug.Log ("l is pressed");
            pressedKey = spawnKey('L');		}		if (Input.GetKeyDown ("z")) {			Debug.Log ("z is pressed");
            pressedKey = spawnKey('Z');		}		if (Input.GetKeyDown ("x")) {			Debug.Log ("x is pressed");            pressedKey = spawnKey('X');
        }		if (Input.GetKeyDown ("c")) {			Debug.Log ("c is pressed");            pressedKey = spawnKey('C');            
        }		if (Input.GetKeyDown ("v")) {			Debug.Log ("v is pressed");            pressedKey = spawnKey('V');
        }		if (Input.GetKeyDown ("b")) {			Debug.Log ("b is pressed");            pressedKey = spawnKey('B');
        }		if (Input.GetKeyDown ("n")) {			Debug.Log ("n is pressed");            pressedKey = spawnKey('N');
        }		if (Input.GetKeyDown ("m")) {			Debug.Log ("m is pressed");            pressedKey = spawnKey('M');
        }		if (Input.GetKeyDown ("q")) {			Debug.Log ("q is pressed");            pressedKey = spawnKey('Q');
        }		if (Input.GetKeyDown ("w")) {			Debug.Log ("w is pressed");            pressedKey = spawnKey('W');
        }		if (Input.GetKeyDown ("e")) {			Debug.Log ("e is pressed");            pressedKey = spawnKey('E');
        }		if (Input.GetKeyDown ("r")) {			Debug.Log ("r is pressed");            pressedKey = spawnKey('R');
        }		if (Input.GetKeyDown ("t")) {			Debug.Log ("t is pressed");            pressedKey = spawnKey('T');
        }		if (Input.GetKeyDown ("y")) {			Debug.Log ("y is pressed");            pressedKey = spawnKey('Y');
        }		if (Input.GetKeyDown ("u")) {			Debug.Log ("u is pressed");            pressedKey = spawnKey('U');
        }		if (Input.GetKeyDown ("i")) {			Debug.Log ("i is pressed");            pressedKey = spawnKey('I');
        }		if (Input.GetKeyDown ("o")) {			Debug.Log ("o is pressed");            pressedKey = spawnKey('O');
        }		if (Input.GetKeyDown ("p")) {			Debug.Log ("p is pressed");            pressedKey = spawnKey('P');
        }        if ((pressedKey.transform.position - player.transform.position).sqrMagnitude < 2*2)
        {
            Debug.Log("Getting close");			Destroy (pressedKey);
        }	}	GameObject spawnKey(char letter){		print ("attempting to spawn letter " + letter);		Debug.Log ("dict[letter] = " + dict[letter]);		Vector3 pos = dict[letter].transform.position;		Debug.Log ("Letter has position " + pos);		GameObject key = Instantiate (gkey, pos, dict[letter].transform.rotation);
        //		key.GetComponent<Key>().setListenKey(letter);
        return key;	}}