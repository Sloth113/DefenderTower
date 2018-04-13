using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private static GameManager m_instance;
    public GameManager Instance
    {
        get
        {
            if (m_instance == null)
                //Creat instance
                return m_instance = Instantiate<GameObject>(new GameObject()).AddComponent<GameManager>();
            else
                return m_instance;
        }
    }

    [SerializeField] private List<StateInfo> m_states;
    [SerializeField] private Levels m_load;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
