﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public interface IAttack
    {
       void Fight();
    }

    public interface IStats
    {
         int Health {get; set;}
    }