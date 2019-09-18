using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StudentsApi.Models {

    public class Student {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string StudentName { get; set; }

        [BsonElement("SAT")]
        public string SATScores { get; set; }

        [BsonElement("TestObject")]
        public TestObjectInstance TestObject { get; set; }
    }

    public class TestObjectInstance {
        [BsonElement("key")]
        public string key { get; set; }
    }
}