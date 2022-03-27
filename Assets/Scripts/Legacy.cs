// Legacy interface

public interface LegacyInterface {
    public string DoSomethingUsingLegacyInterface();
}

// Implementation of legacy interface
class Legacy : LegacyInterface {
    public string DoSomethingUsingLegacyInterface() {
        return "DoSomethingUsingLegacyInterface";
    }
}