using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "State", menuName = "New Thing/State", order = 0)]
public class StateInfo : ScriptableObject {

    [SerializeField] private States m_state;
    [SerializeField] private GameObject m_UIObject;

    //Things
}
