using DG.Tweening;
using UnityEngine;

public class CellAnimationController : MonoBehaviour
{
    public static CellAnimationController Instanse { get; private set; }

    [SerializeField]
    private CellAnimation animationPref;

    private void Awake()
    {
        if (Instanse == null)
            Instanse = this;

        DOTween.Init();
    }

    public void SmoothTransmition(Cell from, Cell to, bool isMerging)
    {
        Instantiate(animationPref, transform, false).Move(from, to, isMerging);
    }

    public void SmoothAppear(Cell cell)
    {
        Instantiate(animationPref, transform, false).Appear(cell);
    }
}
