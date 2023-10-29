using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Application
{
    public interface ILogInsertable<T>
    {
        void LogInsert(T content);
    }
}
