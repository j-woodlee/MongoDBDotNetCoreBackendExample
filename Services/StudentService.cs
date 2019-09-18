using StudentsApi.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace StudentsApi.Services
{
    public class StudentService
    {
        private readonly IMongoCollection<Student> _students;

        public StudentService(IStudentsDatabaseSettings settings) {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            this._students = database.GetCollection<Student>(settings.StudentsCollectionName);
        }

        public List<Student> Get() =>
            this._students.Find(student => true).ToList();

        public Student Get(string id) =>
            this._students.Find<Student>(student => student.Id == id).FirstOrDefault();

        public Student Create(Student student) {
            this._students.InsertOne(student);
            return student;
        }

        public void Update(string id, Student studentIn) =>
            this._students.ReplaceOne(student => student.Id == id, studentIn);

        public void Remove(Student studentIn) =>
            this._students.DeleteOne(student => student.Id == studentIn.Id);

        public void Remove(string id) => 
            this._students.DeleteOne(student => student.Id == id);
    }
}