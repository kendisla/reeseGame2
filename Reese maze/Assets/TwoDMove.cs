using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDMove : MonoBehaviour
{
    public float speed = 1f;
    public int coins = 0; /* we always start this variable at zero, when we start the game you haven’t picked up any coins! */
    float speedChange;  // Start is called before the first frame update
    Animator animatorVariable;
    bool walkV; /*this one checks if you’re moving vertically */
    bool walkH; /*this one checks if you’re moving horizontally */
    SpriteRenderer sr;

    void Start()
    {
      speedChange = 2f;
      animatorVariable = GetComponent<Animator>();
      sr = GetComponent<SpriteRenderer>();
      walkV = false;
      walkH = false;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            animatorVariable.SetBool("walking v", true);
            animatorVariable.SetBool("walking h", false);
            walkV = true;

            if (!sr.flipY)
            {
                sr.flipY = true;
            }

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            animatorVariable.SetBool("walking v", true);
            animatorVariable.SetBool("walking h", false);

            walkV = true;

if (sr.flipY)
            {
                sr.flipY = false;
            }


        }
        else if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            animatorVariable.SetBool("walking h", true);
            animatorVariable.SetBool("walking v", false);

            walkH = true;

            if (!sr.flipX)
            {
                sr.flipX = true;
            }
if (sr.flipY)
            {
                    sr.flipY = false;
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            animatorVariable.SetBool("walking h", true);
            animatorVariable.SetBool("walking v", false);

            walkH = true;
	if (sr.flipX)
            {
                sr.flipX = false;
            }
if (sr.flipY)
            {
                    sr.flipY = false;
            }

        }
        else
        {
            animatorVariable.SetBool("walking v", false);
            animatorVariable.SetBool("walking h", false);
        }

    }
    void OnTriggerEnter2D(Collider2D other) {
      if(other.gameObject.tag.Equals("coin")) {
      coins = coins + 1; /* now that we’ve run into another coin, we’ll increase our count of how many we have! */
      Destroy(other.gameObject);
      }
      else if(other.gameObject.tag.Equals("speed")) {
      	speed = speed * speedChange;
        animatorVariable.SetBool("fast", true);
        Destroy(other.gameObject);
        StartCoroutine(SpeedUpCoroutine());
      }else if(other.gameObject.tag.Equals("slow")) {
      	speed = speed / speedChange;
        animatorVariable.SetBool("slow", true);
        Destroy(other.gameObject);
        StartCoroutine(SlowDownCoroutine());
      } /* note the divide vs. the multiply */

    }

    IEnumerator SpeedUpCoroutine() {
        yield return new WaitForSeconds(3f); /* replace the 5 with however long you want the boost to last */
        speed = speed / speedChange; /* note this is a reversal of how we sped up, this brings our speed back to normal */
        animatorVariable.SetBool("fast", false);
      }
      IEnumerator SlowDownCoroutine() {
        yield return new WaitForSeconds(3f); /* replace the 5 with however long you want the boost to last */
        speed = speed * speedChange; /* note this is a reversal of how we sped up, this brings our speed back to normal */
        animatorVariable.SetBool("slow", false);
      }
}
