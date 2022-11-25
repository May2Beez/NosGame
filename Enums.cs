namespace NosGame;

public enum Games
{
    Fishpond = 0,
    Sawmill = 1
}

public enum States
{
    Idle,
    StartingGame,
    StartGame,
    Playing,
    QtEvent,
    Failed,
    GettingReward,
    SelectingLevel,
    Finished,
    ClosingRewardScreen,
    CouponRefill,
}

public enum CouponRefillStates
{
    CloseGame,
    UseCoupon,
    AcceptCoupon,
    Finished
}