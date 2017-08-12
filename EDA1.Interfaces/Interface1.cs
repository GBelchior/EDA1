using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDA1.Interfaces
{
    public interface IStack
    {
        bool IsFull();
        bool IsEmpty();

        void Push(object item);
        object Pop();
        object Top();
    }
}
