using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour
{

    public static MusicPlayer mp = null;

    void Awake()
    {
        if (mp != null)
        {
            Destroy(gameObject);
        }
        else
        {
            mp = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }


	// Use this for initialization
	void Start ()
	{
	    
	}


}
