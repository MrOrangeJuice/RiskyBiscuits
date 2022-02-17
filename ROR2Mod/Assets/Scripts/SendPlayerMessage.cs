using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using UnityEngine;
using BepInEx;
using RoR2;
using RoR2.ConVar;
using RoR2.Networking;
using UnityEngine.Networking;

namespace ROR2RiskyBiscuits
{
    public class SendPlayerMessage : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
        }

        private void OnTriggerEnter(Collider other)
        {
            for (int i = 0; i < CharacterMaster.readOnlyInstancesList.Count; i++)
            {
                //CharacterMaster.readOnlyInstancesList[i] is the player.
                if(other == CharacterMaster.readOnlyInstancesList[i].gameObject.GetComponent<Collider>())
                {
                    Chat.SendBroadcastChat(new Chat.SimpleChatMessage { baseToken = "<color=#e5eefc>{0}</color>", paramTokens = new[] { "SOME_TEXT_STRING" } });
                }
            }
        }
    }
}

