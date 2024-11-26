using UnityEngine;

public class CarController : MonoBehaviour
{
    public AudioClip fuelPickupSound; // فایل صوتی افکت
    private AudioSource audioSource; // AudioSource برای پخش صدا

    void Start()
    {
        // AudioSource را دریافت کنید
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        // بررسی برخورد با گیم آبجکت بنزین
        if (other.CompareTag("Fuel"))
        {
            // پخش صدای افکت
            audioSource.PlayOneShot(fuelPickupSound);

            // گیم آبجکت بنزین را حذف کنید
            Destroy(other.gameObject);
        }
    }
}
