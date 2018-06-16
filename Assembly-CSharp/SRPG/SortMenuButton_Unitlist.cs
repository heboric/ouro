﻿// Decompiled with JetBrains decompiler
// Type: SRPG.SortMenuButton_Unitlist
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FE644F5D-682F-4D6E-964D-A0DD77A288F7
// Assembly location: C:\Users\André\Desktop\Assembly-CSharp.dll

using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

namespace SRPG
{
  public class SortMenuButton_Unitlist : SortMenuButton
  {
    public Image FilterButton;
    public Sprite Active;
    public Sprite NonActive;
    public Text Msg;
    private Coroutine mCoroutine;
    private bool mRequest;
    private bool mFlag;

    protected override void Start()
    {
      base.Start();
    }

    protected override void OnEnable()
    {
    }

    protected override void UpdateFilterState(bool active)
    {
      this.mFlag = active;
      this.mRequest = true;
    }

    private void Update()
    {
      if (!this.mRequest || this.mCoroutine != null)
        return;
      this.mCoroutine = ((MonoBehaviour) this).StartCoroutine(this.UpdateState(this.mFlag));
      this.mRequest = false;
    }

    [DebuggerHidden]
    private IEnumerator UpdateState(bool active)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerator) new SortMenuButton_Unitlist.\u003CUpdateState\u003Ec__Iterator116() { active = active, \u003C\u0024\u003Eactive = active, \u003C\u003Ef__this = this };
    }
  }
}