using UnityEngine;
public class Projectile2D : MonoBehaviour
{
    [SerializeField] Transform shootPoint;
    [SerializeField] GameObject target; //target sprite
    [SerializeField] Rigidbody2D bulletPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //shoot raycast to detect mouse clicked position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 5f, Color.red, 5f);

            //get click point
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            //if hit object with collider
            if (hit.collider != null) 
            {
                target.transform.position = new Vector2(hit.point.x, hit.point.y);
                Debug.Log("hit " + hit.collider.name);
            }
        }
    }
}
