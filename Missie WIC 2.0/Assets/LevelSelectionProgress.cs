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
        if (stage == 1)
        {
            animator.SetBool("SecondLevelUnlocked", true);
        }
        if (stage == 2)
        {
            animator.SetBool("ThirdLevelUnlocked", true);
        }
        if (stage == 3)
        {
            animator.SetBool("FourthLevelUnlocked", true);
        }
        if (stage == 4)
        {
            animator.SetBool("FifthLevelUnlocked", true);
        }
        if (stage == 5)
        {
            animator.SetBool("AllLevelsUnlocked", true);
        }
    }
}
