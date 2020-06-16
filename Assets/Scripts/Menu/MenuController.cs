using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
  private AsyncOperation async;
  private bool isTouched = false;
  
  void Awake()
  {

      StartCoroutine(LoadLevel());

  }

  IEnumerator LoadLevel()
  {
      yield return null;
      async = SceneManager.LoadSceneAsync(1);
      async.allowSceneActivation = false;

      while (!async.isDone)
      {
          if (async.progress >= 0.9f)
              if (isTouched)
                  async.allowSceneActivation = true;

          yield return null;

      }
  }

  
  private void OnMouseDown()
  {
      isTouched = true;
  }
}
