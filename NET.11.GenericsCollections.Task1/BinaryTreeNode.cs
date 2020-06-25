using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET._11.GenericsCollections.Task1
{
    /// <summary>
    /// Расположения узла относительно родителя
    /// </summary>
    public enum Side
    {
        Left,
        Right
    }

    /// <summary>
    /// Узел бинарного дерева
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryTreeNode<T> where T : IComparable<T>
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="data">Данные</param>
        public BinaryTreeNode(T data)
        {
            Data = data;
        }

        /// <summary>
        /// Данные которые хранятся в узле
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Левая ветка
        /// </summary>
        public BinaryTreeNode<T> LeftNode { get; set; }

        /// <summary>
        /// Правая ветка
        /// </summary>
        public BinaryTreeNode<T> RightNode { get; set; }

        /// <summary>
        /// Родитель
        /// </summary>
        public BinaryTreeNode<T> ParentNode { get; set; }

        /// <summary>
        /// Расположение узла относительно его родителя
        /// </summary>
        public Side? NodeSide =>
            ParentNode == null
            ? (Side?)null
            : ParentNode.LeftNode == this
                ? Side.Left
                : Side.Right;

        /// <summary>
        /// Преобразование экземпляра класса в строку
        /// </summary>
        /// <returns>Данные узла дерева</returns>
        public override string ToString() => Data.ToString();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(BinaryTreeNode<T> other)
        {
            if (other == null) return 1;
            // Сравниваем оценки
            return Data.CompareTo(other.Data);
        }
    }
}
