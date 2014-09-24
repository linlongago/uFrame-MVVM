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
using UnityEngine;
using UniRx;


[DiagramInfoAttribute("FPSShooterProject")]
public abstract class FPSDamageableViewBase : ViewBase {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Single _Health;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _DistanceToPlayer;
    
    public override System.Type ViewModelType {
        get {
            return typeof(FPSDamageableViewModel);
        }
    }
    
    public FPSDamageableViewModel FPSDamageable {
        get {
            return ((FPSDamageableViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSDamageableController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        FPSDamageableViewModel fPSDamageable = ((FPSDamageableViewModel)(viewModel));
        fPSDamageable.Health = this._Health;
        fPSDamageable.DistanceToPlayer = this._DistanceToPlayer;
    }
    
    public virtual void ExecuteApplyDamage(Int32 arg) {
        this.ExecuteCommand(FPSDamageable.ApplyDamage, arg);
    }
}

[DiagramInfoAttribute("FPSShooterProject")]
public abstract class FPSEnemyViewBase : FPSDamageableViewBase {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Single _Speed;
    
    public override System.Type ViewModelType {
        get {
            return typeof(FPSEnemyViewModel);
        }
    }
    
    public FPSEnemyViewModel FPSEnemy {
        get {
            return ((FPSEnemyViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSEnemyController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
        FPSEnemyViewModel fPSEnemy = ((FPSEnemyViewModel)(viewModel));
        fPSEnemy.Speed = this._Speed;
    }
}

[DiagramInfoAttribute("FPSShooterProject")]
public abstract class FPSGameViewBase : ViewBase {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public ViewBase _CurrentPlayer;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _Score;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _Kills;
    
    public override string DefaultIdentifier {
        get {
            return "FPSGame";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(FPSGameViewModel);
        }
    }
    
    public FPSGameViewModel FPSGame {
        get {
            return ((FPSGameViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSGameController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        FPSGameViewModel fPSGame = ((FPSGameViewModel)(viewModel));
        fPSGame.CurrentPlayer = this._CurrentPlayer == null ? null : this._CurrentPlayer.ViewModelObject as FPSPlayerViewModel;
        fPSGame.Score = this._Score;
        fPSGame.Kills = this._Kills;
    }
    
    public virtual void ExecuteMainMenu() {
        this.ExecuteCommand(FPSGame.MainMenu);
    }
    
    public virtual void ExecuteQuitGame() {
        this.ExecuteCommand(FPSGame.QuitGame);
    }
}

[DiagramInfoAttribute("FPSShooterProject")]
public abstract class FPSPlayerViewBase : FPSDamageableViewBase {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _CurrentWeaponIndex;
    
    public override string DefaultIdentifier {
        get {
            return "LocalPlayer";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(FPSPlayerViewModel);
        }
    }
    
    public FPSPlayerViewModel FPSPlayer {
        get {
            return ((FPSPlayerViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSPlayerController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
        FPSPlayerViewModel fPSPlayer = ((FPSPlayerViewModel)(viewModel));
        fPSPlayer.CurrentWeaponIndex = this._CurrentWeaponIndex;
    }
    
    public virtual void ExecutePreviousWeapon() {
        this.ExecuteCommand(FPSPlayer.PreviousWeapon);
    }
    
    public virtual void ExecuteNextWeapon() {
        this.ExecuteCommand(FPSPlayer.NextWeapon);
    }
    
    public virtual void ExecutePickupWeapon(FPSWeaponViewModel fPSWeapon) {
        this.ExecuteCommand(FPSPlayer.PickupWeapon, fPSWeapon);
    }
    
    public virtual void ExecuteSelectWeapon(Int32 arg) {
        this.ExecuteCommand(FPSPlayer.SelectWeapon, arg);
    }
}

[DiagramInfoAttribute("FPSShooterProject")]
public abstract class FPSWeaponViewBase : ViewBase {
    
    [UnityEngine.SerializeField()]
    private FPSWeaponFire _FPSWeaponFire;
    
    [UnityEngine.SerializeField()]
    private FPSCrosshair _FPSCrosshair;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _Ammo;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _ZoomIndex;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _MaxZooms;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Single _ReloadTime;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _RoundSize;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _MinSpread;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _BurstSize;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Single _RecoilSpeed;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Single _FireSpeed;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Single _BurstSpeed;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Single _SpreadMultiplier;
    
    public override System.Type ViewModelType {
        get {
            return typeof(FPSWeaponViewModel);
        }
    }
    
    public virtual FPSWeaponFire FPSWeaponFire {
        get {
            return _FPSWeaponFire ?? (_FPSWeaponFire = GetComponent<FPSWeaponFire>());
        }
        set {
            this._FPSWeaponFire = value;
        }
    }
    
    public virtual FPSCrosshair FPSCrosshair {
        get {
            return _FPSCrosshair ?? (_FPSCrosshair = GetComponent<FPSCrosshair>());
        }
        set {
            this._FPSCrosshair = value;
        }
    }
    
    public FPSWeaponViewModel FPSWeapon {
        get {
            return ((FPSWeaponViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSWeaponController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        FPSWeaponViewModel fPSWeapon = ((FPSWeaponViewModel)(viewModel));
        fPSWeapon.Ammo = this._Ammo;
        fPSWeapon.ZoomIndex = this._ZoomIndex;
        fPSWeapon.MaxZooms = this._MaxZooms;
        fPSWeapon.ReloadTime = this._ReloadTime;
        fPSWeapon.RoundSize = this._RoundSize;
        fPSWeapon.MinSpread = this._MinSpread;
        fPSWeapon.BurstSize = this._BurstSize;
        fPSWeapon.RecoilSpeed = this._RecoilSpeed;
        fPSWeapon.FireSpeed = this._FireSpeed;
        fPSWeapon.BurstSpeed = this._BurstSpeed;
        fPSWeapon.SpreadMultiplier = this._SpreadMultiplier;
    }
    
    public virtual void ExecuteBeginFire() {
        this.ExecuteCommand(FPSWeapon.BeginFire);
    }
    
    public virtual void ExecuteNextZoom() {
        this.ExecuteCommand(FPSWeapon.NextZoom);
    }
    
    public virtual void ExecuteReload() {
        this.ExecuteCommand(FPSWeapon.Reload);
    }
    
    public virtual void ExecuteEndFire() {
        this.ExecuteCommand(FPSWeapon.EndFire);
    }
    
    public virtual void ExecuteBulletFired() {
        this.ExecuteCommand(FPSWeapon.BulletFired);
    }
}

[DiagramInfoAttribute("FPSShooterProject")]
public abstract class WavesFPSGameViewBase : FPSGameViewBase {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _KillsToNextWave;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _WaveKills;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _CurrentWave;
    
    public override string DefaultIdentifier {
        get {
            return "FPSGame";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(WavesFPSGameViewModel);
        }
    }
    
    public WavesFPSGameViewModel WavesFPSGame {
        get {
            return ((WavesFPSGameViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<WavesFPSGameController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
        WavesFPSGameViewModel wavesFPSGame = ((WavesFPSGameViewModel)(viewModel));
        wavesFPSGame.KillsToNextWave = this._KillsToNextWave;
        wavesFPSGame.WaveKills = this._WaveKills;
        wavesFPSGame.CurrentWave = this._CurrentWave;
    }
}

[DiagramInfoAttribute("FPSShooterProject")]
public abstract class FPSMenuViewBase : ViewBase {
    
    public override string DefaultIdentifier {
        get {
            return "FPSMenu";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(FPSMenuViewModel);
        }
    }
    
    public FPSMenuViewModel FPSMenu {
        get {
            return ((FPSMenuViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSMenuController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
    }
    
    public virtual void ExecutePlay() {
        this.ExecuteCommand(FPSMenu.Play);
    }
}

[DiagramInfoAttribute("FPSShooterProject")]
public abstract class DeathMatchGameViewBase : FPSGameViewBase {
    
    public override System.Type ViewModelType {
        get {
            return typeof(DeathMatchGameViewModel);
        }
    }
    
    public DeathMatchGameViewModel DeathMatchGame {
        get {
            return ((DeathMatchGameViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<DeathMatchGameController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
    }
}

public class FPSGameViewViewBase : FPSGameViewBase {
    
    [UFToggleGroup("State")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("StateChanged")]
    public bool _BindState = true;
    
    [UFToggleGroup("CurrentPlayer")]
    [UnityEngine.HideInInspector()]
    public bool _BindCurrentPlayer = true;
    
    [UFGroup("CurrentPlayer")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.GameObject _CurrentPlayerPrefab;
    
    [UFToggleGroup("Score")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("ScoreChanged")]
    public bool _BindScore = true;
    
    [UFToggleGroup("Kills")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("KillsChanged")]
    public bool _BindKills = true;
    
    [UFToggleGroup("Enemies")]
    [UnityEngine.HideInInspector()]
    public bool _BindEnemies = true;
    
    [UFGroup("Enemies")]
    [UnityEngine.HideInInspector()]
    public bool _EnemiesSceneFirst;
    
    [UFGroup("Enemies")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Transform _EnemiesContainer;
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSGameController>());
    }
    
    public virtual void StateChanged(FPSGameState value) {
    }
    
    public virtual void CurrentPlayerChanged(FPSPlayerViewModel value) {
        if (value == null && _CurrentPlayer != null && _CurrentPlayer.gameObject != null) {
            Destroy(_CurrentPlayer.gameObject);
        }
        if (_CurrentPlayerPrefab == null ) {
            this._CurrentPlayer = ((FPSPlayerViewBase)(this.InstantiateView(value)));
        }
        else {
            this._CurrentPlayer = ((FPSPlayerViewBase)(this.InstantiateView(this._CurrentPlayerPrefab, value)));
        }
    }
    
    public virtual void ScoreChanged(Int32 value) {
    }
    
    public virtual void KillsChanged(Int32 value) {
    }
    
    public virtual ViewBase CreateEnemiesView(FPSEnemyViewModel item) {
        return this.InstantiateView(item);
    }
    
    public virtual void EnemiesAdded(ViewBase item) {
    }
    
    public virtual void EnemiesRemoved(ViewBase item) {
    }
    
    public virtual void EnemiesAdded(FPSEnemyViewModel item) {
    }
    
    public virtual void EnemiesRemoved(FPSEnemyViewModel item) {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindState) {
            this.BindProperty(FPSGame._StateProperty, this.StateChanged);
        }
        if (this._BindCurrentPlayer) {
            this.BindProperty(FPSGame._CurrentPlayerProperty, this.CurrentPlayerChanged);
        }
        if (this._BindScore) {
            this.BindProperty(FPSGame._ScoreProperty, this.ScoreChanged);
        }
        if (this._BindKills) {
            this.BindProperty(FPSGame._KillsProperty, this.KillsChanged);
        }
        if (this._BindEnemies) {
            this.BindToViewCollection( FPSGame._EnemiesProperty, viewModel=>{ return CreateEnemiesView(viewModel as FPSEnemyViewModel); }, EnemiesAdded, EnemiesRemoved, _EnemiesContainer, _EnemiesSceneFirst);
        }
    }
    
    protected override void Apply() {
        base.Apply();
        if (FPSGame.Dirty) {
        }
    }
}

public partial class FPSGameView : FPSGameViewViewBase {
}

public class FPSWeaponViewViewBase : FPSWeaponViewBase {
    
    [UFToggleGroup("Ammo")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("AmmoChanged")]
    public bool _BindAmmo = true;
    
    [UFToggleGroup("State")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("StateChanged")]
    public bool _BindState = true;
    
    [UFToggleGroup("ZoomIndex")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("ZoomIndexChanged")]
    public bool _BindZoomIndex = true;
    
    [UFToggleGroup("MaxZooms")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("MaxZoomsChanged")]
    public bool _BindMaxZooms = true;
    
    [UFToggleGroup("WeaponType")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("WeaponTypeChanged")]
    public bool _BindWeaponType = true;
    
    [UFToggleGroup("ReloadTime")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("ReloadTimeChanged")]
    public bool _BindReloadTime = true;
    
    [UFToggleGroup("RoundSize")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("RoundSizeChanged")]
    public bool _BindRoundSize = true;
    
    [UFToggleGroup("MinSpread")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("MinSpreadChanged")]
    public bool _BindMinSpread = true;
    
    [UFToggleGroup("BurstSize")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("BurstSizeChanged")]
    public bool _BindBurstSize = true;
    
    [UFToggleGroup("RecoilSpeed")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("RecoilSpeedChanged")]
    public bool _BindRecoilSpeed = true;
    
    [UFToggleGroup("FireSpeed")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("FireSpeedChanged")]
    public bool _BindFireSpeed = true;
    
    [UFToggleGroup("BurstSpeed")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("BurstSpeedChanged")]
    public bool _BindBurstSpeed = true;
    
    [UFToggleGroup("SpreadMultiplier")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("SpreadMultiplierChanged")]
    public bool _BindSpreadMultiplier = true;
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSWeaponController>());
    }
    
    public virtual void AmmoChanged(Int32 value) {
    }
    
    public virtual void StateChanged(FPSWeaponState value) {
    }
    
    public virtual void ZoomIndexChanged(Int32 value) {
    }
    
    public virtual void MaxZoomsChanged(Int32 value) {
    }
    
    public virtual void WeaponTypeChanged(WeaponType value) {
    }
    
    public virtual void ReloadTimeChanged(Single value) {
    }
    
    public virtual void RoundSizeChanged(Int32 value) {
    }
    
    public virtual void MinSpreadChanged(Int32 value) {
    }
    
    public virtual void BurstSizeChanged(Int32 value) {
    }
    
    public virtual void RecoilSpeedChanged(Single value) {
    }
    
    public virtual void FireSpeedChanged(Single value) {
    }
    
    public virtual void BurstSpeedChanged(Single value) {
    }
    
    public virtual void SpreadMultiplierChanged(Single value) {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindAmmo) {
            this.BindProperty(FPSWeapon._AmmoProperty, this.AmmoChanged);
        }
        if (this._BindState) {
            this.BindProperty(FPSWeapon._StateProperty, this.StateChanged);
        }
        if (this._BindZoomIndex) {
            this.BindProperty(FPSWeapon._ZoomIndexProperty, this.ZoomIndexChanged);
        }
        if (this._BindMaxZooms) {
            this.BindProperty(FPSWeapon._MaxZoomsProperty, this.MaxZoomsChanged);
        }
        if (this._BindWeaponType) {
            this.BindProperty(FPSWeapon._WeaponTypeProperty, this.WeaponTypeChanged);
        }
        if (this._BindReloadTime) {
            this.BindProperty(FPSWeapon._ReloadTimeProperty, this.ReloadTimeChanged);
        }
        if (this._BindRoundSize) {
            this.BindProperty(FPSWeapon._RoundSizeProperty, this.RoundSizeChanged);
        }
        if (this._BindMinSpread) {
            this.BindProperty(FPSWeapon._MinSpreadProperty, this.MinSpreadChanged);
        }
        if (this._BindBurstSize) {
            this.BindProperty(FPSWeapon._BurstSizeProperty, this.BurstSizeChanged);
        }
        if (this._BindRecoilSpeed) {
            this.BindProperty(FPSWeapon._RecoilSpeedProperty, this.RecoilSpeedChanged);
        }
        if (this._BindFireSpeed) {
            this.BindProperty(FPSWeapon._FireSpeedProperty, this.FireSpeedChanged);
        }
        if (this._BindBurstSpeed) {
            this.BindProperty(FPSWeapon._BurstSpeedProperty, this.BurstSpeedChanged);
        }
        if (this._BindSpreadMultiplier) {
            this.BindProperty(FPSWeapon._SpreadMultiplierProperty, this.SpreadMultiplierChanged);
        }
    }
    
    protected override void Apply() {
        base.Apply();
        if (FPSWeapon.Dirty) {
        }
    }
}

public partial class FPSWeaponView : FPSWeaponViewViewBase {
}

public class FPSPlayerViewViewBase : DamageableView {
    
    [UFToggleGroup("CurrentWeaponIndex")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("CurrentWeaponIndexChanged")]
    public bool _BindCurrentWeaponIndex = true;
    
    [UFToggleGroup("Weapons")]
    [UnityEngine.HideInInspector()]
    public bool _BindWeapons = true;
    
    [UFGroup("Weapons")]
    [UnityEngine.HideInInspector()]
    public bool _WeaponsSceneFirst;
    
    [UFGroup("Weapons")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Transform _WeaponsContainer;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _CurrentWeaponIndex;
    
    public FPSPlayerViewModel FPSPlayer {
        get {
            return ((FPSPlayerViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(FPSPlayerViewModel);
        }
    }
    
    public override string DefaultIdentifier {
        get {
            return "LocalPlayer";
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSPlayerController>());
    }
    
    public virtual void CurrentWeaponIndexChanged(Int32 value) {
    }
    
    public virtual ViewBase CreateWeaponsView(FPSWeaponViewModel item) {
        return this.InstantiateView(item);
    }
    
    public virtual void WeaponsAdded(ViewBase item) {
    }
    
    public virtual void WeaponsRemoved(ViewBase item) {
    }
    
    public virtual void WeaponsAdded(FPSWeaponViewModel item) {
    }
    
    public virtual void WeaponsRemoved(FPSWeaponViewModel item) {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindCurrentWeaponIndex) {
            this.BindProperty(FPSPlayer._CurrentWeaponIndexProperty, this.CurrentWeaponIndexChanged);
        }
        if (this._BindWeapons) {
            this.BindToViewCollection( FPSPlayer._WeaponsProperty, viewModel=>{ return CreateWeaponsView(viewModel as FPSWeaponViewModel); }, WeaponsAdded, WeaponsRemoved, _WeaponsContainer, _WeaponsSceneFirst);
        }
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
        FPSPlayerViewModel fPSPlayer = ((FPSPlayerViewModel)(viewModel));
        fPSPlayer.CurrentWeaponIndex = this._CurrentWeaponIndex;
    }
    
    public virtual void ExecutePreviousWeapon() {
        this.ExecuteCommand(FPSPlayer.PreviousWeapon);
    }
    
    public virtual void ExecuteNextWeapon() {
        this.ExecuteCommand(FPSPlayer.NextWeapon);
    }
    
    public virtual void ExecutePickupWeapon(FPSWeaponViewModel fPSWeapon) {
        this.ExecuteCommand(FPSPlayer.PickupWeapon, fPSWeapon);
    }
    
    public virtual void ExecuteSelectWeapon(Int32 arg) {
        this.ExecuteCommand(FPSPlayer.SelectWeapon, arg);
    }
    
    protected override void Apply() {
        base.Apply();
        if (FPSPlayer.Dirty) {
        }
    }
}

public partial class FPSPlayerView : FPSPlayerViewViewBase {
}

public class FPSPlayerHUDViewViewBase : FPSPlayerViewBase {
    
    [UFToggleGroup("CurrentWeaponIndex")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("CurrentWeaponIndexChanged")]
    public bool _BindCurrentWeaponIndex = true;
    
    [UFToggleGroup("Weapons")]
    [UnityEngine.HideInInspector()]
    public bool _BindWeapons = true;
    
    [UFGroup("Weapons")]
    [UnityEngine.HideInInspector()]
    public bool _WeaponsSceneFirst;
    
    [UFGroup("Weapons")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Transform _WeaponsContainer;
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSPlayerController>());
    }
    
    public virtual void CurrentWeaponIndexChanged(Int32 value) {
    }
    
    public virtual ViewBase CreateWeaponsView(FPSWeaponViewModel item) {
        return this.InstantiateView(item);
    }
    
    public virtual void WeaponsAdded(ViewBase item) {
    }
    
    public virtual void WeaponsRemoved(ViewBase item) {
    }
    
    public virtual void WeaponsAdded(FPSWeaponViewModel item) {
    }
    
    public virtual void WeaponsRemoved(FPSWeaponViewModel item) {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindCurrentWeaponIndex) {
            this.BindProperty(FPSPlayer._CurrentWeaponIndexProperty, this.CurrentWeaponIndexChanged);
        }
        if (this._BindWeapons) {
            this.BindToViewCollection( FPSPlayer._WeaponsProperty, viewModel=>{ return CreateWeaponsView(viewModel as FPSWeaponViewModel); }, WeaponsAdded, WeaponsRemoved, _WeaponsContainer, _WeaponsSceneFirst);
        }
    }
    
    protected override void Apply() {
        base.Apply();
        if (FPSPlayer.Dirty) {
        }
    }
}

public partial class FPSPlayerHUDView : FPSPlayerHUDViewViewBase {
}

public class FPSWavesHudViewViewBase : WavesFPSGameViewBase {
    
    [UFToggleGroup("KillsToNextWave")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("KillsToNextWaveChanged")]
    public bool _BindKillsToNextWave = true;
    
    [UFToggleGroup("WaveKills")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("WaveKillsChanged")]
    public bool _BindWaveKills = true;
    
    [UFToggleGroup("CurrentWave")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("CurrentWaveChanged")]
    public bool _BindCurrentWave = true;
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<WavesFPSGameController>());
    }
    
    public virtual void KillsToNextWaveChanged(Int32 value) {
    }
    
    public virtual void WaveKillsChanged(Int32 value) {
    }
    
    public virtual void CurrentWaveChanged(Int32 value) {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindKillsToNextWave) {
            this.BindProperty(WavesFPSGame._KillsToNextWaveProperty, this.KillsToNextWaveChanged);
        }
        if (this._BindWaveKills) {
            this.BindProperty(WavesFPSGame._WaveKillsProperty, this.WaveKillsChanged);
        }
        if (this._BindCurrentWave) {
            this.BindProperty(WavesFPSGame._CurrentWaveProperty, this.CurrentWaveChanged);
        }
    }
    
    protected override void Apply() {
        base.Apply();
        if (WavesFPSGame.Dirty) {
        }
    }
}

public partial class FPSWavesHudView : FPSWavesHudViewViewBase {
}

public class FPSHUDViewViewBase : FPSGameViewBase {
    
    [UFToggleGroup("State")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("StateChanged")]
    public bool _BindState = true;
    
    [UFToggleGroup("CurrentPlayer")]
    [UnityEngine.HideInInspector()]
    public bool _BindCurrentPlayer = true;
    
    [UFGroup("CurrentPlayer")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.GameObject _CurrentPlayerPrefab;
    
    [UFToggleGroup("Score")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("ScoreChanged")]
    public bool _BindScore = true;
    
    [UFToggleGroup("Kills")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("KillsChanged")]
    public bool _BindKills = true;
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSGameController>());
    }
    
    public virtual void StateChanged(FPSGameState value) {
    }
    
    public virtual void CurrentPlayerChanged(FPSPlayerViewModel value) {
        if (value == null && _CurrentPlayer != null && _CurrentPlayer.gameObject != null) {
            Destroy(_CurrentPlayer.gameObject);
        }
        if (_CurrentPlayerPrefab == null ) {
            this._CurrentPlayer = ((FPSPlayerViewBase)(this.InstantiateView(value)));
        }
        else {
            this._CurrentPlayer = ((FPSPlayerViewBase)(this.InstantiateView(this._CurrentPlayerPrefab, value)));
        }
    }
    
    public virtual void ScoreChanged(Int32 value) {
    }
    
    public virtual void KillsChanged(Int32 value) {
    }
    
    public virtual ViewBase CreateEnemiesView(FPSEnemyViewModel item) {
        return this.InstantiateView(item);
    }
    
    public virtual void EnemiesAdded(ViewBase item) {
    }
    
    public virtual void EnemiesRemoved(ViewBase item) {
    }
    
    public virtual void EnemiesAdded(FPSEnemyViewModel item) {
    }
    
    public virtual void EnemiesRemoved(FPSEnemyViewModel item) {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindState) {
            this.BindProperty(FPSGame._StateProperty, this.StateChanged);
        }
        if (this._BindCurrentPlayer) {
            this.BindProperty(FPSGame._CurrentPlayerProperty, this.CurrentPlayerChanged);
        }
        if (this._BindScore) {
            this.BindProperty(FPSGame._ScoreProperty, this.ScoreChanged);
        }
        if (this._BindKills) {
            this.BindProperty(FPSGame._KillsProperty, this.KillsChanged);
        }
    }
    
    protected override void Apply() {
        base.Apply();
        if (FPSGame.Dirty) {
        }
    }
}

public partial class FPSHUDView : FPSHUDViewViewBase {
}

public class FPSEnemyViewViewBase : DamageableView {
    
    [UFToggleGroup("Speed")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("SpeedChanged")]
    public bool _BindSpeed = true;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Single _Speed;
    
    public FPSEnemyViewModel FPSEnemy {
        get {
            return ((FPSEnemyViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(FPSEnemyViewModel);
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSEnemyController>());
    }
    
    public virtual void SpeedChanged(Single value) {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindSpeed) {
            this.BindProperty(FPSEnemy._SpeedProperty, this.SpeedChanged);
        }
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
        FPSEnemyViewModel fPSEnemy = ((FPSEnemyViewModel)(viewModel));
        fPSEnemy.Speed = this._Speed;
    }
    
    protected override void Apply() {
        base.Apply();
        if (FPSEnemy.Dirty) {
        }
    }
}

public partial class FPSEnemyView : FPSEnemyViewViewBase {
}

public class FPSMainMenuViewViewBase : FPSMenuViewBase {
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSMenuController>());
    }
    
    public override void Bind() {
        base.Bind();
    }
    
    protected override void Apply() {
        base.Apply();
        if (FPSMenu.Dirty) {
        }
    }
}

public partial class FPSMainMenuView : FPSMainMenuViewViewBase {
}

public class DamageableViewViewBase : FPSDamageableViewBase {
    
    [UFToggleGroup("Health")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("HealthChanged")]
    public bool _BindHealth = true;
    
    [UFToggleGroup("State")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("StateChanged")]
    public bool _BindState = true;
    
    public IObservable<Int32> DistanceToPlayer { get; set; }
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSDamageableController>());
    }
    
    public virtual void HealthChanged(Single value) {
    }
    
    public virtual void StateChanged(FPSPlayerState value) {
    }
    
    protected virtual Int32 GetDistanceToPlayer() {
        return default(Int32);
    }
    
    protected virtual UniRx.IObservable<Int32> GetDistanceToPlayerObservable() {
        return this.UpdateAsObservable().Select(p => GetDistanceToPlayer());
    }
    
    public override void Bind() {
        base.Bind();
        DistanceToPlayer = GetDistanceToPlayerObservable();
        DistanceToPlayer.Subscribe(FPSDamageable._DistanceToPlayerProperty);
        if (this._BindHealth) {
            this.BindProperty(FPSDamageable._HealthProperty, this.HealthChanged);
        }
        if (this._BindState) {
            this.BindProperty(FPSDamageable._StateProperty, this.StateChanged);
        }
    }
    
    protected override void Apply() {
        base.Apply();
        if (FPSDamageable.Dirty) {
        }
    }
}

public abstract partial class DamageableView : DamageableViewViewBase {
}

public class WavesGameViewViewBase : FPSGameView {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _KillsToNextWave;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _WaveKills;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _CurrentWave;
    
    public WavesFPSGameViewModel WavesFPSGame {
        get {
            return ((WavesFPSGameViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(WavesFPSGameViewModel);
        }
    }
    
    public override string DefaultIdentifier {
        get {
            return "FPSGame";
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<WavesFPSGameController>());
    }
    
    public override void Bind() {
        base.Bind();
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
        WavesFPSGameViewModel wavesFPSGame = ((WavesFPSGameViewModel)(viewModel));
        wavesFPSGame.KillsToNextWave = this._KillsToNextWave;
        wavesFPSGame.WaveKills = this._WaveKills;
        wavesFPSGame.CurrentWave = this._CurrentWave;
    }
    
    protected override void Apply() {
        base.Apply();
        if (WavesFPSGame.Dirty) {
        }
    }
}

public partial class WavesGameView : WavesGameViewViewBase {
}

public partial class FPSWeaponFire : ViewComponent {
    
    public virtual FPSWeaponViewModel FPSWeapon {
        get {
            return ((FPSWeaponViewModel)(this.View.ViewModelObject));
        }
    }
    
    public virtual void ExecuteBeginFire() {
        this.View.ExecuteCommand(FPSWeapon.BeginFire);
    }
    
    public virtual void ExecuteNextZoom() {
        this.View.ExecuteCommand(FPSWeapon.NextZoom);
    }
    
    public virtual void ExecuteReload() {
        this.View.ExecuteCommand(FPSWeapon.Reload);
    }
    
    public virtual void ExecuteEndFire() {
        this.View.ExecuteCommand(FPSWeapon.EndFire);
    }
    
    public virtual void ExecuteBulletFired() {
        this.View.ExecuteCommand(FPSWeapon.BulletFired);
    }
}

public partial class FPSCrosshair : ViewComponent {
    
    public virtual FPSWeaponViewModel FPSWeapon {
        get {
            return ((FPSWeaponViewModel)(this.View.ViewModelObject));
        }
    }
    
    public virtual void ExecuteBeginFire() {
        this.View.ExecuteCommand(FPSWeapon.BeginFire);
    }
    
    public virtual void ExecuteNextZoom() {
        this.View.ExecuteCommand(FPSWeapon.NextZoom);
    }
    
    public virtual void ExecuteReload() {
        this.View.ExecuteCommand(FPSWeapon.Reload);
    }
    
    public virtual void ExecuteEndFire() {
        this.View.ExecuteCommand(FPSWeapon.EndFire);
    }
    
    public virtual void ExecuteBulletFired() {
        this.View.ExecuteCommand(FPSWeapon.BulletFired);
    }
}

public partial class RocketLauncher : FPSWeaponFire {
}