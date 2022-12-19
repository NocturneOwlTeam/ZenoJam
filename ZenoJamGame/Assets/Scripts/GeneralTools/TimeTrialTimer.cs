using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Nocturne.GeneralTools
{
    public class TimeTrialTimer : MonoBehaviour
    {
        // This is a standard delay for any purpose.

        [SerializeField]
        private float timerFrecuency = 1f;

        [SerializeField]
        private TextMeshProUGUI timerText;

        private float counterTime;

        [SerializeField]
        private UnityEvent OnTimerEnded;

        private IEnumerator timeBehaviour;

        // Start is called before the first frame update
        private void Start()
        {
            ResetTimer();
            ShowTimeFormatted();
        }

        //PD: I love Lambda <3
        public void ResetTimer() => counterTime = 0;

        public void StartTimer() => StartCoroutine(timeBehaviour);

        //For seconds.
        private void ShowTime() => timerText.text = $"{counterTime}";

        //For the MM:SS format.
        private void ShowTimeFormatted()
        {
            int seconds = (int)(counterTime % 60);
            int minutes = (int)(counterTime / 60);
            timerText.text = $"{minutes}:{seconds.ToString("D2")}";
        }

        private IEnumerator TimerBehaviour()
        {
            yield return Helpers.GetWait(timerFrecuency);
            counterTime += timerFrecuency;
            ShowTimeFormatted();
        }

        public void IncreaseTimer(float extraTime) => counterTime += extraTime;

        public void DecreaseTimer(float removedTime) => counterTime = Mathf.Max(counterTime - removedTime, 0);

        public void StopTimer()
        {
            StopCoroutine(timeBehaviour);
            OnTimerEnded.Invoke();
        }
    }
}