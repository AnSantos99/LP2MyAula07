using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    interface IObservador
    {
        /// <summary>
        /// Update para receber notificações
        /// </summary>
        /// <param name="sujeito"> recebe o sujeito que publicou a
        /// notificação</param>
        public void Update(ISujeito sujeito);
    }
}
