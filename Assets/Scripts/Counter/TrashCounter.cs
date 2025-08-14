using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class TrashCounter : BaseCounter {

    public static event EventHandler OnAnyObjectTrashed;
    public override void Interact(Player player) {
        if (player.HasKitchenObject()) {
            player.GetKitchenObject().DestroySelf();

            OnAnyObjectTrashed?.Invoke(this, EventArgs.Empty);
        }
    }
}
