﻿using MODEL.Abstract.Interfaces.AboutFilms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Films
{
    public abstract class BaseArtistEntity : BaseEntity, IArtist
    {
        public string Name { get ; set ; }
        public string? Role { get ; set ; }
        public string? Biography { get ; set ; }
        public DateTime? BirthDate { get ; set ; }
    }
}
