class OutdoorGathering : Event
{
    private string _activity;

    public OutdoorGathering(string title, string description, DateTime date, DateTime time, Address address, string activity) : base(title, description, date, time, address)
    {
        _activity = activity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nActivity: {_activity}";
    }
}