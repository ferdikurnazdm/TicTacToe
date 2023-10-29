using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Application
{
    public interface ILogUpdatable<T>
    {
        void LogUpdatable(T content);
    }
}
