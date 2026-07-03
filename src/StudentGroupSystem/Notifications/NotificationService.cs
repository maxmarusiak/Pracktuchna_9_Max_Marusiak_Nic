using System;

namespace StudentGroupSystem.Notifications
{
    public class NotificationService
    {
        public event Action<Student> LowGradeDetected;

        public void CheckStudent(Student student)
        {
            if (student.GetAverageGrade() < 60)
            {
                LowGradeDetected?.Invoke(student);
            }
        }
    }
}
