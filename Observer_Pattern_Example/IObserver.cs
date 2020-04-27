using System;
namespace Observer_pattern_Example
{
    public interface IObserver
    {
        void update(string availability);
    }
}