using System;

namespace NET._11.GenericsCollections.Task1
{
    /// <summary>
    /// Студент проходящий тест
    /// </summary>
    public class StudentOnTest : IComparable<StudentOnTest>
    {
        /// <summary>
        /// Имя студента
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Название теста
        /// </summary>
        public string TestName { get; set; }
        /// <summary>
        /// Дата теста
        /// </summary>
        public DateTime TestDate { get; set; }
        /// <summary>
        /// Оценка за тест
        /// </summary>
        public byte Assessment { get; set; }
        /// <summary>
        /// Сравнение оценки с другим студентом
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(StudentOnTest other)
        {
            if (other == null) return 1;
            // Сравниваем оценки
            return Assessment.CompareTo(other.Assessment);
        }
        /// <summary>
        /// Переопределяю ToString для печати
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Студент { Name }, на тесте { TestName }, проходившем { TestDate:d}, получил оценку - { Assessment }.";
        }
    }
}
