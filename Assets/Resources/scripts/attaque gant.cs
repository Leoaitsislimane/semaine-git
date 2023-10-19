using UnityEngine;

public class attaquegant : MonoBehaviour
{
    [SerializeField] private GameObject ballePrefab; 
    [SerializeField] private GameObject lignePrefab; 
    private GameObject currentLigne; 
    private bool isAiming; 
    private Vector2 shootDirection; 
    private float shootVitesse = 30f; 
    private float _tailleBalle = 15.0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isAiming = true;
            currentLigne = Instantiate(lignePrefab);
        }

        if (isAiming)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            shootDirection = (mousePosition - transform.position).normalized;

            if (currentLigne != null)
            {
                currentLigne.transform.position = transform.position;
                currentLigne.transform.right = shootDirection;
            }
        }

        if (Input.GetMouseButtonUp(0) && isAiming)
        {
            isAiming = false;
            Destroy(currentLigne);
            ShootBubble();
        }
    }

    void ShootBubble()
    {
        GameObject balle = Instantiate(ballePrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = balle.GetComponent<Rigidbody2D>();
        balle.transform.localScale = new Vector3(_tailleBalle, _tailleBalle, 1.0f);
        rb.velocity = shootDirection * shootVitesse;
        
    }
}