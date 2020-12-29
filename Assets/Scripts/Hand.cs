using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public List<GameObject> cards;
    int i = -2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null && hit.collider.CompareTag("card"))
            {
                Debug.Log("Hit a card!!1");
                Debug.Log(hit.collider.gameObject.GetInstanceID());
            }
        }
    }

    public void addCard(GameObject card)
    {
        cards.Add((GameObject) Instantiate(card, new Vector3(i, -3, 0), Quaternion.identity));
        i+=2;
    }
}
