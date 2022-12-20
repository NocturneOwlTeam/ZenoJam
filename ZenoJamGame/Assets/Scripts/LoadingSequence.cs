using DG.Tweening;
using Nocturne.GeneralTools;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingSequence : MonoBehaviour
{
    [SerializeField]
    private int selectedIndex;

    [SerializeField]
    private RectTransform loadingIndicator;

    public void StartLoading()
    {
        StartCoroutine(LoadScene());
    }

    private IEnumerator LoadScene()
    {
        loadingIndicator.DOAnchorPos(new Vector2(0, 0), 0.4f).SetEase(Ease.OutQuart);
        yield return Helpers.GetWait(0.4f);
        var loadProgress = SceneManager.LoadSceneAsync(selectedIndex);
        loadProgress.allowSceneActivation = false;
        while (!loadProgress.isDone)
        {
            if (loadProgress.progress >= 0.9f)
            {
                loadingIndicator.DOAnchorPos(new Vector2(0, 1200), 0.4f).SetEase(Ease.OutQuart);
                yield return Helpers.GetWait(0.3f);
                loadProgress.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
