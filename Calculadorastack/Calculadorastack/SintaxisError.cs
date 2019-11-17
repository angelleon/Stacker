namespace Calculadorastack {
    
    [System.Serializable]
    public class SintaxisError : System.Exception
    {
        public SintaxisError() { }
        public SintaxisError(string message) : base(message) { }
        public SintaxisError(string message, System.Exception inner) : base(message, inner) { }
        protected SintaxisError(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}