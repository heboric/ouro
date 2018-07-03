﻿// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_DisableQuit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 85BFDF7F-5712-4D45-9CD6-3465C703DFDF
// Assembly location: S:\Desktop\Assembly-CSharp.dll

using UnityEngine;

namespace SRPG
{
  [EventActionInfo("強制終了/禁止", "スクリプトの強制終了を無効にします。", 5592405, 4473992)]
  public class EventAction_DisableQuit : EventAction
  {
    public override void OnActivate()
    {
      EventQuit eventQuit = EventQuit.Find();
      if (Object.op_Equality((Object) null, (Object) eventQuit))
      {
        this.ActivateNext();
      }
      else
      {
        ((Component) eventQuit).get_gameObject().SetActive(false);
        this.ActivateNext();
      }
    }
  }
}