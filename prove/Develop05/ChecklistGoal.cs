class ChecklistGoal : Goal {
    private int total;
    private int count;

    public int Total {
        get { return total; }
        set { total = value; }
    }

    public int Count {
        get { return count; }
        set { count = value; }
    }

    public ChecklistGoal(string name, int value, int total) : base(name, value) {
        this.total = total;
        this.count = 0;
    }

    public override int Complete() {
        count++;
        if (count < total) {
            return Value;
        } else if (count == total) {
            Completed = true;
            return Value + 500;
        }
        return 0;
    }
    public override void RecordEvent()
    {
        Count++;
        if (Count == Total)
        {
            Completed = true;
            TotalPointsEarned += Value; // add the value of the completed goal to the total points earned
        }
    }

    public override string ToString()
    {
        return base.ToString() + $" [Checklist ({Count}/{Total})]";
    }

    public override void Load(string[] fields) {
        base.Load(fields);
        total = Int32.Parse(fields[3]);
        count = Int32.Parse(fields[4]);
    }

    public override void Save(StreamWriter file) {
        base.Save(file);
        file.WriteLine("{0},{1}", total, count);
    }
}