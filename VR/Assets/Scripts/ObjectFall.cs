﻿using UnityEngine;
using System.Collections;

public class ObjectFall : ObjectBase
{
    private Rigidbody rig;

    protected override void Awake()
    {
        base.Awake();                       // 保留 父類別 內的程式內容

        rig = GetComponent<Rigidbody>();
    }

    protected override IEnumerator Action()
    {
        aud.PlayOneShot(sound, volume);
        rig.useGravity = true;                                              // 啟用重力

        yield return new WaitForSeconds(delay);                             // 延遲

        aud.enabled = false;                                                // 喇叭 啟動 = 否
    }
}
