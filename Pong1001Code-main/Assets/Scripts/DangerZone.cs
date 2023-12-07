using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.Impl;

public class DangerZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent liveTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
     

        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.liveTrigger.Invoke(eventData);

        }
    }
}
