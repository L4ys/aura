public class TestEventScript : GameEventScript
{
	public override void Load()
	{
		SetId("aura_test_event");
		SetName(L("Test Event"));
	}

	public override void AfterLoad()
	{
		ScheduleEvent(Id, DateTime.Parse("2016-11-23 22:23"), DateTime.Parse("2016-11-23 22:24"));
		ScheduleEvent(Id, DateTime.Parse("2016-11-25 13:00"), DateTime.Parse("2016-11-25 13:05"));
	}

	protected override void OnStart()
	{
		Send.Notice(NoticeType.Middle, "test even started");
		AddGlobalBonus(GlobalBonusStat.CombatExp, 2);
	}

	protected override void OnEnd()
	{
		Send.Notice(NoticeType.Middle, "test even stopped");
	}
}
