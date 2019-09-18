using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StudentsApi.Models {

    public class StudentDatabaseSettings : IStudentsDatabaseSettings {
        public string StudentsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IStudentsDatabaseSettings {
        string StudentsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}