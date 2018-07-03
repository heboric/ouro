﻿// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_SetRunMode2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FE644F5D-682F-4D6E-964D-A0DD77A288F7
// Assembly location: C:\Users\André\Desktop\Assembly-CSharp.dll

using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace SRPG
{
  [EventActionInfo("New/アクター/走りアニメーション変更", "ユニットの走りアニメーションを変更します。", 5592405, 4473992)]
  public class EventAction_SetRunMode2 : EventAction
  {
    [StringIsActorList]
    public string ActorID;
    public string AnimationName;

    public override bool IsPreloadAssets
    {
      get
      {
        return true;
      }
    }

    [DebuggerHidden]
    public override IEnumerator PreloadAssets()
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerator) new EventAction_SetRunMode2.\u003CPreloadAssets\u003Ec__IteratorA2() { \u003C\u003Ef__this = this };
    }

    public override void OnActivate()
    {
      GameObject actor = EventAction.FindActor(this.ActorID);
      if (Object.op_Inequality((Object) actor, (Object) null))
      {
        TacticsUnitController component = (TacticsUnitController) actor.GetComponent<TacticsUnitController>();
        if (Object.op_Inequality((Object) component, (Object) null))
          component.SetRunAnimation(this.AnimationName);
      }
      this.ActivateNext();
    }
  }
}