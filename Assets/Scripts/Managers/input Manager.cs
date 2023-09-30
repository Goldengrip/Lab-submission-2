using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    private static Gamecontrols _gamecontrols;

    public static void Init(Player myPlayer)
      
    {
        _gamecontrols =new Gamecontrols();

        _gamecontrols.Permanent.Enable();

        _gamecontrols.InGame.Movement.performed += jeff => {

            myPlayer.SetMovementDirection(jeff.ReadValue<Vector3>());
        };
        _gamecontrols.InGame.Jump.performed += bob =>
            {
                myPlayer.Jump();

            };
        _gamecontrols.InGame.Equipgun.performed += hello =>
        {
            myPlayer.EquipGun();
        };
        _gamecontrols.InGame.UnEquipgun.performed += hello =>
        {
            myPlayer.UnEquipGun();
        };

    }
    public static void SetGameControls()
    {
        _gamecontrols.InGame.Enable();
        _gamecontrols.UI.Disable();

    }
    public static  void SetUIControls()
    {
        _gamecontrols.InGame.Disable();
        _gamecontrols.UI.Enable();
    }

}
