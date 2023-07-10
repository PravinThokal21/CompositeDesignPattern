using System.Collections;

namespace CompositeDesignPattern
{
    internal class Employee : IEmployee, IEnumerable<IEmployee>
    {
        public int EmpID { get; set; }
        public string Name { get; set; }

        private List<IEmployee> _subordinates = new List<IEmployee>();

        public void AddSubordinate(IEmployee subordinate)
        {
            _subordinates.Add(subordinate);
        }

        public void RemoveSubordinate(IEmployee subordinate)
        {
            _subordinates.Remove(subordinate);
        }

        public IEmployee GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public IEnumerator<IEmployee> GetEnumerator()
        {
            foreach (IEmployee subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
