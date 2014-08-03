// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public abstract class FPSDamageableControllerBase : Controller {
    
    public abstract void InitializeFPSDamageable(FPSDamageableViewModel fPSDamageable);
    
    public virtual FPSDamageableViewModel CreateFPSDamageable() {
        return ((FPSDamageableViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeFPSDamageable(((FPSDamageableViewModel)(viewModel)));
    }
    
    public virtual void ApplyDamage(FPSDamageableViewModel fPSDamageable, int arg) {
    }
}

public abstract class FPSEnemyControllerBase : FPSDamageableController {
    
    [Inject] public FPSGameController FPSGameController {get;set;}
    public abstract void InitializeFPSEnemy(FPSEnemyViewModel fPSEnemy);
    
    public override ViewModel CreateEmpty() {
        return new FPSEnemyViewModel();
    }
    
    public virtual FPSEnemyViewModel CreateFPSEnemy() {
        return ((FPSEnemyViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeFPSEnemy(((FPSEnemyViewModel)(viewModel)));
    }
}

public abstract class FPSGameControllerBase : Controller {
    
    [Inject] public FPSPlayerController FPSPlayerController {get;set;}
    [Inject] public FPSEnemyController FPSEnemyController {get;set;}
    public virtual FPSGameViewModel FPSGame {
        get {
            return Container.Resolve<FPSGameViewModel>();
        }
    }
    
    public abstract void InitializeFPSGame(FPSGameViewModel fPSGame);
    
    public override ViewModel CreateEmpty() {
        return new FPSGameViewModel();
    }
    
    public virtual FPSGameViewModel CreateFPSGame() {
        return ((FPSGameViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeFPSGame(((FPSGameViewModel)(viewModel)));
    }
    
    public virtual void MainMenu() {
        this.GameEvent("MainMenu");
    }
    
    public virtual void QuitGame() {
        this.GameEvent("QuitGame");
    }
}

public abstract class FPSPlayerControllerBase : FPSDamageableController {
    
    [Inject] public FPSGameController FPSGameController {get;set;}
    [Inject] public FPSWeaponController FPSWeaponController {get;set;}
    public abstract void InitializeFPSPlayer(FPSPlayerViewModel fPSPlayer);
    
    public override ViewModel CreateEmpty() {
        return new FPSPlayerViewModel();
    }
    
    public virtual FPSPlayerViewModel CreateFPSPlayer() {
        return ((FPSPlayerViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeFPSPlayer(((FPSPlayerViewModel)(viewModel)));
    }
    
    public virtual void PreviousWeapon(FPSPlayerViewModel fPSPlayer) {
    }
    
    public virtual void NextWeapon(FPSPlayerViewModel fPSPlayer) {
    }
    
    public virtual void PickupWeapon(FPSPlayerViewModel fPSPlayer, FPSWeaponViewModel arg) {
    }
    
    public virtual void SelectWeapon(FPSPlayerViewModel fPSPlayer, int arg) {
    }
}

public abstract class FPSWeaponControllerBase : Controller {
    
    [Inject] public FPSPlayerController FPSPlayerController {get;set;}
    public abstract void InitializeFPSWeapon(FPSWeaponViewModel fPSWeapon);
    
    public override ViewModel CreateEmpty() {
        return new FPSWeaponViewModel();
    }
    
    public virtual FPSWeaponViewModel CreateFPSWeapon() {
        return ((FPSWeaponViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeFPSWeapon(((FPSWeaponViewModel)(viewModel)));
    }
    
    public virtual void BeginFire(FPSWeaponViewModel fPSWeapon) {
    }
    
    public virtual void NextZoom(FPSWeaponViewModel fPSWeapon) {
    }
    
    public virtual System.Collections.IEnumerator Reload(FPSWeaponViewModel fPSWeapon) {
        yield break;
    }
    
    public virtual void EndFire(FPSWeaponViewModel fPSWeapon) {
    }
    
    public virtual void BulletFired(FPSWeaponViewModel fPSWeapon) {
    }
}

public abstract class WavesFPSGameControllerBase : FPSGameController {
    
    public virtual WavesFPSGameViewModel WavesFPSGame {
        get {
            return Container.Resolve<WavesFPSGameViewModel>();
        }
    }
    
    public abstract void InitializeWavesFPSGame(WavesFPSGameViewModel wavesFPSGame);
    
    public override ViewModel CreateEmpty() {
        return new WavesFPSGameViewModel();
    }
    
    public virtual WavesFPSGameViewModel CreateWavesFPSGame() {
        return ((WavesFPSGameViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeWavesFPSGame(((WavesFPSGameViewModel)(viewModel)));
    }
}

public abstract class FPSMenuControllerBase : Controller {
    
    public virtual FPSMenuViewModel FPSMenu {
        get {
            return Container.Resolve<FPSMenuViewModel>();
        }
    }
    
    public abstract void InitializeFPSMenu(FPSMenuViewModel fPSMenu);
    
    public override ViewModel CreateEmpty() {
        return new FPSMenuViewModel();
    }
    
    public virtual FPSMenuViewModel CreateFPSMenu() {
        return ((FPSMenuViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeFPSMenu(((FPSMenuViewModel)(viewModel)));
    }
    
    public virtual void Play() {
        this.GameEvent("Play");
    }
}

public abstract class DeathMatchGameControllerBase : FPSGameController {
    
    public virtual DeathMatchGameViewModel DeathMatchGame {
        get {
            return Container.Resolve<DeathMatchGameViewModel>();
        }
    }
    
    public abstract void InitializeDeathMatchGame(DeathMatchGameViewModel deathMatchGame);
    
    public override ViewModel CreateEmpty() {
        return new DeathMatchGameViewModel();
    }
    
    public virtual DeathMatchGameViewModel CreateDeathMatchGame() {
        return ((DeathMatchGameViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeDeathMatchGame(((DeathMatchGameViewModel)(viewModel)));
    }
}

[System.SerializableAttribute()]
public sealed partial class FPSMainMenuManagerSettings {
    
    public string[] _Scenes;
}

public class FPSMainMenuManagerBase : SceneManager {
    
    public WavesFPSGameManagerSettings _PlayTransition = new WavesFPSGameManagerSettings();
    
    public FPSMainMenuManagerSettings _FPSMainMenuManagerSettings = new FPSMainMenuManagerSettings();
    
    public FPSMenuController FPSMenuController { get; set; }
    public override void Setup() {
        base.Setup();
        this.FPSMenuController = new FPSMenuController() { Container = Container, Context = Context };
        this.Container.RegisterInstance(this.FPSMenuController, false);
        this.Container.InjectAll();
        Container.RegisterInstance<FPSMenuViewModel>(SetupViewModel<FPSMenuViewModel>(FPSMenuController, "FPSMenu"));
    }
    
    public virtual void Play() {
        GameManager.TransitionLevel<WavesFPSGameManager>((container) =>{container._WavesFPSGameManagerSettings = _PlayTransition; }, this._PlayTransition._Scenes);
    }
}

public enum WavesFPSGameManagerFPSGameTypes {
    
    FPSGame,
    
    WavesFPSGame,
    
    DeathMatchGame,
}

[System.SerializableAttribute()]
public sealed partial class WavesFPSGameManagerSettings {
    
    public string[] _Scenes;
    
    public WavesFPSGameManagerFPSGameTypes FPSGameTypes;
}

public class WavesFPSGameManagerBase : SceneManager {
    
    public FPSMainMenuManagerSettings _MainMenuTransition = new FPSMainMenuManagerSettings();
    
    public FPSMainMenuManagerSettings _QuitGameTransition = new FPSMainMenuManagerSettings();
    
    public WavesFPSGameManagerSettings _WavesFPSGameManagerSettings = new WavesFPSGameManagerSettings();
    
    public WavesFPSGameController WavesFPSGameController { get; set; }
    public DeathMatchGameController DeathMatchGameController { get; set; }
    public FPSEnemyController FPSEnemyController { get; set; }
    public FPSGameController FPSGameController { get; set; }
    public FPSPlayerController FPSPlayerController { get; set; }
    public FPSWeaponController FPSWeaponController { get; set; }
    public override void Setup() {
        base.Setup();
        this.WavesFPSGameController = new WavesFPSGameController() { Container = Container, Context = Context };
        this.Container.RegisterInstance(this.WavesFPSGameController, false);
        this.DeathMatchGameController = new DeathMatchGameController() { Container = Container, Context = Context };
        this.Container.RegisterInstance(this.DeathMatchGameController, false);
        this.FPSEnemyController = new FPSEnemyController() { Container = Container, Context = Context };
        this.Container.RegisterInstance(this.FPSEnemyController, false);
        this.FPSGameController = new FPSGameController() { Container = Container, Context = Context };
        this.Container.RegisterInstance(this.FPSGameController, false);
        this.FPSPlayerController = new FPSPlayerController() { Container = Container, Context = Context };
        this.Container.RegisterInstance(this.FPSPlayerController, false);
        this.FPSWeaponController = new FPSWeaponController() { Container = Container, Context = Context };
        this.Container.RegisterInstance(this.FPSWeaponController, false);
        this.Container.InjectAll();
        if ((this._WavesFPSGameManagerSettings.FPSGameTypes == WavesFPSGameManagerFPSGameTypes.WavesFPSGame)) {
            WavesFPSGameViewModel wavesFPSGame = SetupViewModel<WavesFPSGameViewModel>(WavesFPSGameController,"FPSGame");
            Container.RegisterInstance<WavesFPSGameViewModel>(wavesFPSGame, false);
            Container.RegisterInstance<FPSGameViewModel>(wavesFPSGame, false);
            Container.RegisterInstance<FPSGameController>(WavesFPSGameController, false);
        }
        if ((this._WavesFPSGameManagerSettings.FPSGameTypes == WavesFPSGameManagerFPSGameTypes.DeathMatchGame)) {
            DeathMatchGameViewModel deathMatchGame = SetupViewModel<DeathMatchGameViewModel>(DeathMatchGameController,"FPSGame");
            Container.RegisterInstance<DeathMatchGameViewModel>(deathMatchGame, false);
            Container.RegisterInstance<FPSGameViewModel>(deathMatchGame, false);
            Container.RegisterInstance<FPSGameController>(DeathMatchGameController, false);
        }
        if ((this._WavesFPSGameManagerSettings.FPSGameTypes == WavesFPSGameManagerFPSGameTypes.FPSGame)) {
            FPSGameViewModel fPSGame = SetupViewModel<FPSGameViewModel>(FPSGameController,"FPSGame");
            Container.RegisterInstance<FPSGameViewModel>(fPSGame, false);
        }
    }
    
    public virtual void MainMenu() {
        GameManager.TransitionLevel<FPSMainMenuManager>((container) =>{container._FPSMainMenuManagerSettings = _MainMenuTransition; }, this._MainMenuTransition._Scenes);
    }
    
    public virtual void QuitGame() {
        GameManager.TransitionLevel<FPSMainMenuManager>((container) =>{container._FPSMainMenuManagerSettings = _QuitGameTransition; }, this._QuitGameTransition._Scenes);
    }
}
