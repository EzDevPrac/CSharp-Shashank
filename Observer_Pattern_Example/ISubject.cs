using System;

namespace Observer_pattern_Example
{
     public interface ISubject
    {
         void RegisterObserver(IObserver observer);
         void RemoveObserver(IObserver observer);
         void NotifyObservers();
    }
}
