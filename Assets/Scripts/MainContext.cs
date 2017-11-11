using strange.extensions.command.impl;
using UnityEngine;

public class MainContext : SignalContext
{

    public MainContext(MonoBehaviour view) : base(view)
    {

    }
    protected override void mapBindings()
    {
        commandBinder.Bind<AppStartSignal>().InSequence().To<AppStartCommand>().To<TileMapCreateCommand>().Once();
    }
}