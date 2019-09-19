using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StudentsApi.Models {

    public class Student {

        // Each property is mapped to a key

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string StudentName { get; set; }

        [BsonElement("SAT")]
        public SATScores SATScores { get; set; }

        [BsonElement("Absences")]
        public string[] Absences { get; set; }

        [BsonElement("Living Situation")]
        public string LivingSituation { get; set; }

        [BsonElement("Co-curriculars")]
        public string[] CoCurriculars { get; set; }

        [BsonElement("Grades")]
        public Grades Grades { get; set; }

    }

    public class SATScores {

        [BsonElement("latest")]
        public string latest { get; set; }

        [BsonElement("2019")]
        public string TwoThousand19 { get; set; }

        [BsonElement("2018")]
        public string TwoThousand18 { get; set; }
    }

    public class Grades {

        [BsonElement("2018")]
        public Courses TwoThousand18 { get; set; }

        [BsonElement("2019")]
        public Courses TwoThousand19 { get; set; }

    }

    public class Courses {

        public string Math { get; set; }

        public string Science { get; set; }

        public string English { get; set; }
        
    }
}