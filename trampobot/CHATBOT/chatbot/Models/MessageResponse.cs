public class MessageResponse {

    
    public class GenericClass{
        public string response_type { get; set; }
        public string text { get; set; }
    }
    public class IntentClass{
        public string intent { get; set; }
        public double confidence { get; set; }
    }
    public class EntityClass{
        public string entity { get; set; }
        public int[] location {get; set; }
        public string value { get; set; }
    }

    public class OutputClass {
        public GenericClass[] generic {get; set;}
        public IntentClass[] intents {get; set;}
        public EntityClass[] entities {get; set;}
    }

    public OutputClass output {get; set;}
}
