using System.Collections.Generic;

namespace Source
{
    public class GiantBehaviourManager : IBehaviourManager
    {
        IBehaviour[] behaviours;

        public GiantBehaviourManager(IBehaviour[] behaviours)
        {
            this.behaviours = behaviours;
        }

        public IBehaviour CurrentState(int lives)
        {
            foreach(var behaviour in behaviours)
            {
                if(behaviour.Active(lives))
                {
                    return behaviour;
                }
            }

            return behaviours[behaviours.Length - 1];
        }
    }
}
