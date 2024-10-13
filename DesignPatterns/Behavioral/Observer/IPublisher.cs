﻿namespace DesignPatterns.Behavioral.Observer
{
    public interface IPublisher
    {
        void Subscribe(ISubscriber subscriber);
        void Unsubscribe(ISubscriber subscriber);
        void Notify();
    }
}
