

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace WPF_Mediator
{
    public class ConcreteMediator : IMediator
    {
        private readonly IDictionary<Type, ISubscribersForGivenMessage> _subscribers = new Dictionary<Type, ISubscribersForGivenMessage>();

        #region public methods
        public void Subscribe(object subscriber)
        {
            var messages = GetMessagesSubscribedBySubscriber(subscriber); // our code has to track which message the subscriber
            foreach (var messageType in messages)
            {
                AddToSubscribersList(messageType);

                _subscribers[messageType].Add(subscriber);
            }
        }

        public void Publish(IMessage message)
        {
            for (var messageType = message.GetType(); messageType != null; messageType = messageType.BaseType)
            {
                if (!_subscribers.ContainsKey(messageType)) continue;

                _subscribers[messageType].Publish(message);
            }
        }

       
        #endregion

        #region private methods
        private static IEnumerable<Type> GetAllMessages(Type subscriberType)
        {
            TypeFilter myFilter = new TypeFilter(CanFilterInterface);
            var types = subscriberType.FindInterfaces(myFilter, null);

            var messageTypes = types.Select(type => type.GetGenericArguments()[0]);

            return messageTypes;
        }

        private static bool CanFilterInterface(Type typeObj, Object criteriaObj)
        {
            if (typeObj.IsGenericType && typeObj.GetGenericTypeDefinition() == typeof(ISubscriber<>))
                return true;
            else
                return false;
        }

        private void AddToSubscribersList(Type type)
        {
            if (_subscribers.ContainsKey(type)) return;

            var instanceTypeForeachSubscriber = typeof(SubscribersForGivenMessage<>);
            var genericType = instanceTypeForeachSubscriber.MakeGenericType(type);
            var instanceForSubscriber = (ISubscribersForGivenMessage)Activator.CreateInstance(genericType);
            _subscribers.Add(type, instanceForSubscriber);
        }

        private static IEnumerable<Type> GetMessagesSubscribedBySubscriber(object subscriber)
        {
            var subscriberType = subscriber.GetType();
            return GetAllMessages(subscriberType);
        }

        private interface ISubscribersForGivenMessage
        {
            void Publish(IMessage message);
            void Add(object handler);
        }

        private class SubscribersForGivenMessage<T> : ISubscribersForGivenMessage where T : IMessage
        {
            List<ISubscriber<T>> _subscribers = new List<ISubscriber<T>>();
            public void Publish(IMessage message)
            {
                var handlers = new List<ISubscriber<T>>(_subscribers);
                handlers.ForEach(handler => Publish(handler, message));
            }

            public void Add(object handler)
            {
                _subscribers.Add((ISubscriber<T>)handler);
            }

            private static void Publish(ISubscriber<T> handler, IMessage message)
            {
                handler.Handle((T)message);
            }
        } 
        #endregion
    }
}