class EternalGoal : Goal {
    private int count;
    

    public int Count {
        get { return count; }
        set { count = value; }
    }

    public EternalGoal(string name, int value) : base(name, value) {
        count = 0;
    }

    public override int Complete() {
        Completed = true;
        count++;
        return Value;
    }
    public override void RecordEvent()
    {
        Count++;
        TotalPointsEarned += Value; // add the value of the completed goal to the total points earned
    }

    public override string ToString()
    {
        return base.ToString() + $" [Eternal ({Count} events)]";
    }

    public override void Load(string[] fields) {
        base.Load(fields);
        count = Int32.Parse(fields[3]);
    }

    public override void Save(StreamWriter file) {
        base.Save(file);
        file.WriteLine("{0}", count);
    }
}