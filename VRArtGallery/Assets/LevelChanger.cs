using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public static Animator animator;
    public static int levelToLoad;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    public static void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        Camera.main.transform.parent.position = new Vector3(-1.32f, 4.68f, 1.43f);
        Camera.main.transform.parent.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
        SceneManager.LoadScene(levelToLoad);
    }
}
