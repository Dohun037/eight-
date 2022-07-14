using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transfer_map : MonoBehaviour
{

    public string ~~;           //이동할 맵 이름 입력
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "girl_idle-Sheet_0")
        {
            SceneManager.LoadScene(~~);
        }
    }
}
