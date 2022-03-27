using UnityEngine;

class Main : MonoBehaviour {
    private void Start() {
        LegacyInterface legacy = new Legacy();
        NewInterface newInterfaceImpl = new Adapter(legacy);

        Debug.Log("LegacyInterface interface is incompatible with the client.");
        Debug.Log("But with adapter client can call it's method.");

        Debug.Log(newInterfaceImpl.DoSomething());
    }
}