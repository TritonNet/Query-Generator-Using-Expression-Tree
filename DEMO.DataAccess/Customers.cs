using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEMO.Entity;
using System.Linq.Expressions;

namespace DEMO.DataAccess
{
    public class Customers : IList<Customer>, IQueryable<Customer>
    {

        public Type ElementType
        {
            get { return typeof(Customer); }
        }

        public System.Linq.Expressions.Expression Expression
        {
            get { return null; }
        }

        public IQueryProvider Provider
        {
            get { throw new NotImplementedException(); }
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(Customer item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, Customer item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public Customer this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Customer item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Customer item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Customer[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(Customer item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<Customer> IEnumerable<Customer>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
