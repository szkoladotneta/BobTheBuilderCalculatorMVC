﻿using BuilderCalculatorMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.Repositories
{
    class RoomRepository :EntityRepositiory<Room>
    {
        public RoomRepository(Context context)
            :base(context)
        {
        }
    }
}
