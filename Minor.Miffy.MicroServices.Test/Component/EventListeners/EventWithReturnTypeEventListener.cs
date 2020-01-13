using Minor.Miffy.MicroServices.Events;

namespace Minor.Miffy.MicroServices.Test.Component.EventListeners
{
    public class EventWithReturnTypeEventListener
    {
        [EventListener]
        public DummyEvent Handle(DummyEvent ev1)
        {
            return new DummyEvent("test");
        }
    }
}
