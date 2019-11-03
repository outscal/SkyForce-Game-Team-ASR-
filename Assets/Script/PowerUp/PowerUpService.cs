using SkyForce.Player;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Powerups
{
    public class PowerUpService : MonoSingletonGeneric<PowerUpService>
    {
        public PowerUpScriptableList powerUpModelList;
        PowerUpScriptable powerUpModel;       
        [HideInInspector]
        public PowerUpView powerUpView;

        public void GetPowerUp(PowerUpType powerUpType,Vector3 SpawnPosition)
        {
            PlayerModel Pmodel = getPlayerModel(powerUpType);
            InstantiatePowerUpView(SpawnPosition, Pmodel);
        }

        private PlayerModel getPlayerModel(PowerUpType type)
        {
            powerUpModel = Array.Find(powerUpModelList.PowerUpArray, x => x.PowerUpType.Equals(type));
            return new PlayerModel(powerUpModel);
        }

        private void InstantiatePowerUpView(Vector3 SpawnPosition, PlayerModel Pmodel)
        {
            powerUpView = GameObject.Instantiate<PowerUpView>(powerUpModel.ViewPrefab);
            powerUpView.SetModel(Pmodel);
            powerUpView.transform.position = SpawnPosition;
        }

        
    }
    
}

