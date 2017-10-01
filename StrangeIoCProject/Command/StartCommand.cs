using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

//开始命令
public class StartCommand : Command {

    /// <summary>
    /// 当这个命令被执行的时候，默认会调用Excute方法
    /// </summary>
    public override void Execute()
    {
        Debug.Log("start command execute");
    }
}
