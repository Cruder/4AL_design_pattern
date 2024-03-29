using System;
using System.Collections.Generic;

namespace Source
{
    public class Expedition : IExpeditionStep
    {
        Queue<IExpeditionStep> steps;

        public Expedition()
        {
            this.steps = new Queue<IExpeditionStep>();
        }

        public void AddStep(IExpeditionStep step)
        {
            this.steps.Enqueue(step);
        }

        public void Turn()
        {
            var currentStep = this.steps.Peek();

            currentStep.Turn();

            if(currentStep.Finished())
            {
                this.steps.Dequeue();
            }
        }

        public bool Finished()
        {
            return this.steps.Count == 0;
        }
    }
}
