using System;

namespace Source
{
    public class Travel : IExpeditionStep
    {
        int duration;

        Travel(int duration)
        {
            this.duration = duration;
        }

        public void Turn()
        {
            duration -= 1;
        }

        public bool Finished()
        {
            return duration <= 0;
        }
    }
}
