using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectionProgress : MonoBehaviour
{
    public Animator animator;
    public int stage;
    private void Update()
    {
        stage = PlayerPrefs.GetInt("stage");
        Debug.Log(stage);
        if (stage == 1)
        {
            animator.SetInteger("Level", 1);
        }
        if (stage == 2)
        {
            animator.SetInteger("Level", 2);
        }
        if (stage == 3)
        {
            animator.SetInteger("Level", 3);
        }
        if (stage == 4)
        {
            animator.SetInteger("Level", 4);
        }
        if (stage == 5)
        {
            animator.SetInteger("Level", 5);
        }
    }
}
