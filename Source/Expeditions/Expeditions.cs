using System;
using System.Collections.Generic;

namespace Source
{
    public class Expeditions
    {
        List<IExpeditionStep> expeditions;

        public Expeditions()
        {
            this.expeditions = new List<IExpeditionStep>();
        }

        public void AddExpedition(IExpeditionStep expedition)
        {
            expeditions.Add(expedition);
        }

        public void Turn()
        {
            expeditions.ForEach(expedition => expedition.Turn());
            expeditions.RemoveAll(expedition => expedition.Finished());
        }
    }
}
