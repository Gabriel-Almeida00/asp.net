﻿using Lanches.Models;

namespace Lanches.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> categorias { get; }
    }
}
