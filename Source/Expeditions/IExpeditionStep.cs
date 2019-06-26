using System;

namespace Source
{
    public interface IExpeditionStep
    {
        void Turn();
        bool Finished();
    }
}
