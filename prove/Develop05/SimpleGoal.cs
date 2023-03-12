class SimpleGoal : Goal {
    public SimpleGoal(string name, int value) : base(name, value) {
    }

    public override int Complete() {
        if (!Completed) {
            Completed = true;
            return Value;
        }
        return 0;
    }
    public override string ToString()
    {
        return base.ToString() + " [Simple]";
    }
}