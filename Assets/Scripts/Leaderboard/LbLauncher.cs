using Agate.MVC.Base;
using Agate.MVC.Core;
using Aja.Boot;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LbLauncher : SceneLauncher<LbLauncher, LbView>
{
    public override string SceneName => "Leaderboard";
    protected override IConnector[] GetSceneConnectors()
    {
        return null;
    }

    protected override IController[] GetSceneDependencies()
    {
        return null;
    }

    protected override IEnumerator InitSceneObject()
    {
        yield return null;
    }

    protected override IEnumerator LaunchScene()
    {
        yield return null;
    }
}
