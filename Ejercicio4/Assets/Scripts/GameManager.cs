using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject A, B, C, D, W, portal;
    TextAsset tmp;
    string[] words;
    Dictionary<string, GameObject> prefabs;

    private void Awake()
    {
        prefabs = new Dictionary<string, GameObject>()
        {
            {"A", A },
            {"B", B },
            {"C", C },
            {"D", D },
            {"W", W }
        };
    }

    void Start()
    {
        tmp = Resources.Load<TextAsset>("Map2");
        string newTxt = tmp.text.Replace('\n', ',');
        words = newTxt.Split(',');


        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i].Trim();
            if (word != "")
            {
                float x = i % 100;
                float y = i / 100;

                if(x == 89 && y == 10)
                {
                    Instantiate(portal, new Vector3(x, y), Quaternion.identity);
                }
                else
                {
                    Instantiate(prefabs[word], new Vector3(x, y), Quaternion.identity);
                }
            }
        }
    }
}
