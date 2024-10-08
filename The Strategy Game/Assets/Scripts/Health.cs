using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public UnityEvent OnHeal, OnTakeDamage, OnDie;

    [SerializeField] float max_health = 10;
    private float current_health;

    [SerializeField] MeshRenderer[] healthMeshes; //temp
    [SerializeField] Gradient healthColorGradient;

    private void Start()
    {
        current_health = max_health;
    }

    public void Heal(float amount)
    {
        current_health += amount;
        current_health = Mathf.Ceil(current_health);
        if (current_health > max_health)
            current_health = max_health;
    }

    public void TakeDamage(float amount)
    {
        current_health -= amount;
        current_health = Mathf.Floor(current_health);
        SetHealthColor();
        OnTakeDamage.Invoke();
        if(current_health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        OnDie.Invoke();
        Destroy(gameObject);
    }

    void SetHealthColor()
    {
        foreach (MeshRenderer mr in healthMeshes)
        {
            mr.material.SetColor("_BaseColor", healthColorGradient.Evaluate((max_health - current_health) / max_health));
        }
    }
}
