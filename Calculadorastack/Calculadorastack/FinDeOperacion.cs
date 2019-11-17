namespace Calculadorastack {
    [System.Serializable]
    public class FinDeOperacion : System.Exception
    {
        public FinDeOperacion() { }
        public FinDeOperacion(string message) : base(message) { }
        public FinDeOperacion(string message, System.Exception inner) : base(message, inner) { }
        protected FinDeOperacion(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}