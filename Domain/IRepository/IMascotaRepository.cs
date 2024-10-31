﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public interface IMascotaRepository
    {
        Mascota Add(Mascota mascota);
        void Delete(Mascota mascota);
        List<Mascota> GetAll();
        Mascota? GetById(int id);
        void Update (Mascota mascota);

    }
}