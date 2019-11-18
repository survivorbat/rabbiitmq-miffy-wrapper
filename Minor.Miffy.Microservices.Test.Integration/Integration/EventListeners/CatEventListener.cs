using Minor.Miffy.MicroServices;
using Minor.Miffy.MicroServices.Events;
using Minor.Miffy.Microservices.Test.Integration.Integration.Events;

namespace Minor.Miffy.Microservices.Test.Integration.Integration.EventListeners
{
    [EventListener("PeopleApp.Cats")]
    public class CatEventListener
    {
        /// <summary>
        /// Reset the static variable
        /// </summary>
        public CatEventListener() => ResultEvent = null;
        
        /// <summary>
        /// Static variable to keep track of the event
        /// </summary>
        internal static CatAddedEvent ResultEvent { get; set; }
        
        /// <summary>
        /// Listener for the event
        /// </summary>
        [Topic("PeopleApp.Cats.New")]
        public void Handles(CatAddedEvent addedEvent) => ResultEvent = addedEvent;
    }
}