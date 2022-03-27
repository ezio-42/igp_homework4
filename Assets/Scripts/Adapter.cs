// Adapter allow us to use legacy code via new interface
class Adapter : NewInterface {
    private readonly LegacyInterface _legacy;

    public Adapter(LegacyInterface legacy) {
        _legacy = legacy;
    }

    public string DoSomething() {
        return $"This is '{this._legacy.DoSomethingUsingLegacyInterface()}'";
    }
}
