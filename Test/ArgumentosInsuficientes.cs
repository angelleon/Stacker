[System.Serializable]
public class ArgumentosInsuficientes : System.Exception
{
    public ArgumentosInsuficientes() { }
    public ArgumentosInsuficientes(string message) : base(message) { }
    public ArgumentosInsuficientes(string message, System.Exception inner) : base(message, inner) { }
    protected ArgumentosInsuficientes(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}