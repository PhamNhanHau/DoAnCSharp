using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnCSharp.Models
{
    public interface DAOInterface<T>
    {
        public int insert(T t);
        public int update(T t);
        public int delete(T t);
        public List<T> selectAll(T t);
        public T selectByID(int ID);
        public List<T> selectByCondition(String condition);

    }
}
