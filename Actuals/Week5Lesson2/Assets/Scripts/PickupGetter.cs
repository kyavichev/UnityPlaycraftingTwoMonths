﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class PickupGetter : MonoBehaviour
{
    private List<PickupType> pickups;

    public void Awake()
    {
        pickups = new List<PickupType>();
    }

    public void PickUp( PickupType pickupType )
    {
        pickups.Add( pickupType );

        if ( pickupType == PickupType.JumpBonus )
        {
            if( GetComponent<ThirdPersonCharacter>() != null )
            {
                GetComponent<ThirdPersonCharacter>().ApplyJumpBonus();
            }
        }
    }

    public int GetPickupCount( PickupType pickupType )
    {
        int count = 0;

        for ( int i = 0; i < pickups.Count; i++ )
        {
            if( pickups[i] == pickupType )
            {
                count++;
            }
        }

        return count;
    }
}
