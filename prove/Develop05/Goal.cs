class Goal {
    private string _name;
    private int _value;
    private bool _completed;

    public int TotalPointsEarned { get; set; } // new property to store total points earned

    public virtual void RecordEvent()
    {
        Completed = true;
        TotalPointsEarned += Value; // add the value of the completed goal to the total points earned
    }

    public override string ToString()
    {
        return $"{(Completed ? "[X]" : "[ ]")} {Name} ({Value} points)";
    }

    public string Name {
        get { return _name; }
        set { _name = value; }
    }

    public int Value {
        get { return _value; }
        set { this._value = value; }
    }

    public bool Completed {
        get { return _completed; }
        set { _completed = value; }
    }

    public Goal(string name, int value) {
        _name = name;
        _value = value;
        _completed = false;
    }

    public virtual int Complete() {
        _completed = true;
        return _value;
    }

    public virtual void Load(string[] fields) {
        _name = fields[0];
        _value = Int32.Parse(fields[1]);
        _completed = Boolean.Parse(fields[2]);
    }

    public virtual void Save(StreamWriter file) {
        file.WriteLine("{0},{1},{2}", _name, _value, _completed);
    }
}