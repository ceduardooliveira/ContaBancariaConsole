using System;
using System.Collections.Generic;

// Padrão Observer: Permite que objetos sejam notificados automaticamente quando o estado de outro objeto é alterado.
public interface IObservador
{
    void Atualizar(ContaBancaria conta);
}