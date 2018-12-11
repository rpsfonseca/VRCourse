using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorToGo : Interactable
{

    public override void StartInteraction()
    {
        InteractionManager.RemoveCurrentInteractable();
        LevelChanger.FadeToLevel(0);
    }

    public override void Interaction()
    {
    }

    public override void EndInteraction()
    {
    }
}
