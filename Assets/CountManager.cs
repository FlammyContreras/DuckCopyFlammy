using UnityEngine;
using TMPro;

public class CountManager : MonoBehaviour
{
    public int count;
    public TextMeshProUGUI countText;
    public Animator animator;
    public void AddToCount(){
        count++;
        countText.text = count.ToString();
        animator.SetTrigger("click");
    }
}
