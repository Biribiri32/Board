using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManager.ClassComponents
{
    public interface IGameClass<T>
    {
        void SetCardData();

        //bool Equals(T gameClass);
    }
}
